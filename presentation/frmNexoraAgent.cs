using business;
using Business;
using entities;
using Microsoft.VisualBasic.Devices;
using presentation.Properties;
using System.CodeDom.Compiler;
using System.Runtime.InteropServices;

namespace presentation
{
    public partial class frmNexoraAgent : Form
    {
        // Variable para guardar el momento exacto en que se encendió la PC
        private TimeSpan _initialUptime;
        private DateTime _loadTime;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int left, int top, int right, int bottom, int widthEllipse, int heightEllipse);

        public frmNexoraAgent()
        {
            InitializeComponent();

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void frmNexoraAgent_Load(object sender, EventArgs e)
        {
            var info = ComputerInfoService.GetComputerInfo();
            _initialUptime = info.Hardware.Uptime;
            _loadTime = DateTime.Now;

            LoadInformation();
            tmrRealTime.Start();
            ShowFullSystemReport();
        }

        private void LoadInformation()
        {
            var _computerInfoCache = ComputerInfoService.GetComputerInfo();


            if (_computerInfoCache == null) return;

            var hardwareObj = _computerInfoCache.Hardware;

            // Card equipo
            if (_computerInfoCache != null)
            {
                lbSumaryHostname.Text = _computerInfoCache.HostName;
                lbSumaryTypeDevice.Text = _computerInfoCache.ComputerType.ToString();
                lbSumaryModelAndBrand.Text = $"{_computerInfoCache.Manufacturer} / {_computerInfoCache.Model}";
                lbSumaryNumberSerie.Text = _computerInfoCache.SerialNumber;
                lbSumaryCurrentUser.Text = _computerInfoCache.CurrentUser;
                UpdateRealTimeMetrics();
            }
            // Card Operating System
            if (_computerInfoCache.SystemInfo != null)
            {
                lbSumaryEdition.Text = _computerInfoCache.SystemInfo.OperatingSystem;
                lbSumaryVersion.Text = _computerInfoCache.SystemInfo.OSVersion;
                lbSumaryCompilation.Text = _computerInfoCache.SystemInfo.OSBuild;
                lbSumaryArchitecture.Text = _computerInfoCache.SystemInfo.OSArchitecture;
                lbSumaryInstallationDate.Text = _computerInfoCache.SystemInfo.InstalledDate.ToString();
            }
            if (_computerInfoCache.Hardware != null)
            {
                // Card Micro Processor
                lbSumaryNameMicroprocessor.Text = _computerInfoCache.Hardware.CpuName;
                lbSumaryCores.Text = _computerInfoCache.Hardware.CpuCores.ToString();
                lbSumaryThreads.Text = _computerInfoCache.Hardware.CpuThreads.ToString();
                lbSumaryBaseSpeed.Text = $"{_computerInfoCache.Hardware.CpuBaseSpeed.ToString()} GHz";
                lbSumaryMaximumSeed.Text = $"{_computerInfoCache.Hardware.CpuMaximumSpeed.ToString()} GHz";

                // Card Memory RAM
                lbSumaryCapacity.Text = $"{_computerInfoCache.Hardware.TotalRam.ToString()} GB";
                lbSumaryRamType.Text = _computerInfoCache.Hardware.RamType;
                lbSumaryRamSeed.Text = $"{_computerInfoCache.Hardware.RamSpeedMhz.ToString()} MHz";
                lbSumaryRamSlots.Text = $"{_computerInfoCache.Hardware.RamUsedSlots.ToString()} de {_computerInfoCache.Hardware.RamTotalSlots.ToString()}";

            }
            switch (_computerInfoCache.ComputerType)
            {
                case ComputerType.Desktop:
                    pbDeviceType.Image = Resources.device_desktop;
                    break;
                case ComputerType.AllInOne:
                    pbDeviceType.Image = Resources.device_AllInOne;
                    break;
                case ComputerType.Laptop:
                    pbDeviceType.Image = Resources.device_laptop;
                    break;
                default:
                    pbDeviceType.Image = Resources.device_desktop;
                    break;
            }

           
        }

        // Evento Tick del temporizador en inglés
        private void TmrRealTime_Tick(object sender, EventArgs e)
        {
            UpdateRealTimeMetrics();
        }

        // Método encargado del refresco, ahora totalmente en inglés
        private void UpdateRealTimeMetrics()
        {
            TimeSpan timePassedSinceLoad = DateTime.Now - _loadTime;
            TimeSpan totalUptime = _initialUptime + timePassedSinceLoad;

            lbSumaryOnTime.Text = $"{totalUptime.Days}d {totalUptime.Hours:00}h {totalUptime.Minutes:00}m {totalUptime.Seconds:00}s";
        }

        #region UI Events
        private void pbMinimize_MouseEnter(object sender, EventArgs e)
        {
            pbMinimize.Image = Resources.window_minimize_hover;
        }

        private void pbMinimize_MouseLeave(object sender, EventArgs e)
        {
            pbMinimize.Image = Resources.window_minimize;
        }

        private void pbClose_MouseEnter(object sender, EventArgs e)
        {
            pbClose.Image = Resources.window_close_hover;
        }

        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.Image = Resources.window_close;
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
        }
        #endregion

        private void pnlComputerSummary_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowFullSystemReport()
        {
            var info = ComputerInfoService.GetComputerInfo();
            if (info == null) return;

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.AppendLine("=== SYSTEM REPORT ===");
            sb.AppendLine($"Hostname: {info.HostName}");
            sb.AppendLine($"User: {info.CurrentUser}");
            sb.AppendLine($"Type: {info.ComputerType}");
            sb.AppendLine($"Manufacturer: {info.Manufacturer}");
            sb.AppendLine($"Model: {info.Model}");
            sb.AppendLine($"Serial: {info.SerialNumber}");

            sb.AppendLine("\n--- OPERATING SYSTEM ---");
            sb.AppendLine($"OS: {info.SystemInfo.OperatingSystem}");
            sb.AppendLine($"Version: {info.SystemInfo.OSVersion}");
            sb.AppendLine($"Build: {info.SystemInfo.OSBuild}");
            sb.AppendLine($"Arch: {info.SystemInfo.OSArchitecture}");
            sb.AppendLine($"Install Date: {info.SystemInfo.InstalledDate}");

            sb.AppendLine("\n--- HARDWARE ---");
            sb.AppendLine($"CPU: {info.Hardware.CpuName}");
            sb.AppendLine($"Cores/Threads: {info.Hardware.CpuCores}/{info.Hardware.CpuThreads}");
            sb.AppendLine($"Speed: {info.Hardware.CpuBaseSpeed} GHz (Max: {info.Hardware.CpuMaximumSpeed} GHz)");
            sb.AppendLine($"RAM: {info.Hardware.TotalRam} GB {info.Hardware.RamType} @ {info.Hardware.RamSpeedMhz} MHz");
            sb.AppendLine($"Slots: {info.Hardware.RamUsedSlots}/{info.Hardware.RamTotalSlots}");
            sb.AppendLine($"GPU: {info.Hardware.GpuName} ({info.Hardware.VramTotalGB} GB VRAM)");

            sb.AppendLine("\n--- DISKS ---");
            foreach (var disk in info.Hardware.Disks)
            {
                sb.AppendLine($"- {disk.Model} [{disk.MediaType}] - {disk.CapacityGB}");
            }

            sb.AppendLine("\n--- MONITORS ---");
            foreach (var mon in info.Hardware.Monitors)
            {
                sb.AppendLine($"- {mon.Manufacturer} {mon.Model}");
            }

            // Mostrar en MessageBox
            MessageBox.Show(sb.ToString(), "Nexora Agent - Full System Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}