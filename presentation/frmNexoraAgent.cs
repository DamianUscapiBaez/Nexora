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
            pnlComputerSummary.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlComputerSummary.Width, pnlComputerSummary.Height, 20, 20));
            //pnlComputerInformation.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlComputerInformation.Width, pnlComputerInformation.Height, 20, 20));
        }

        private void frmNexoraAgent_Load(object sender, EventArgs e)
        {
            LoadInformation();
            tmrRealTime.Start(); // Arranca el temporizador
        }

        private void LoadInformation()
        {
            var _computerInfoCache = ComputerInfoService.GetComputerInfo();


            if (_computerInfoCache == null) return;

            var hardwareObj = _computerInfoCache.Hardware;

            if (_computerInfoCache.OperatingSystem != null)
            {
                lbSumaryHostname.Text = _computerInfoCache.OperatingSystem.HostName;
                lbSumaryTypeDevice.Text = _computerInfoCache.ComputerType.ToString();
                lbSumaryModelAndBrand.Text = _computerInfoCache.Model;
                lbSumaryNumberSerie.Text = _computerInfoCache.SerialNumber;
                //lbSumarySystem.Text = _computerInfoCache.OperatingSystem.OperatingSystem;
            }

            lbSumaryModelAndBrand.Text = $"{_computerInfoCache.Manufacturer} {_computerInfoCache.Model}";

            if (hardwareObj != null)
            {
                // Mapeos corregidos usando las nuevas propiedades en inglés de HardwareInfo
                //lbSumaryMicroprocessor.Text = hardwareObj.CpuName; // .Cpu -> .CpuName
                //lbSumaryGpu.Text = hardwareObj.GpuName; // .Gpu -> .GpuName
                //lbSumaryRam.Text = $"{hardwareObj.TotalRam} GB {hardwareObj.RamType} {hardwareObj.RamSpeedMhz} Mhz";

                // === LOGIC DETECCIÓN Y RESUMEN DE DISCOS ===
                // Nota: Asegúrate de que tu modelo 'ComputerInfo' tenga asignada la propiedad correcta de capacidad si usas TotalGBDisk externamente,
                // de lo contrario, si calculas por la lista de discos, puedes dejar el formateador.
                //string formattedTotalSize = HardwareInfoService.FormatStorageSize(hardwareObj.to);

                var uniqueMediaTypes = new List<string>();
                if (hardwareObj.Disks != null)
                {
                    foreach (var disk in hardwareObj.Disks)
                    {
                        if (!uniqueMediaTypes.Contains(disk.MediaType))
                        {
                            uniqueMediaTypes.Add(disk.MediaType);
                        }
                    }
                }

                string diskTypesCombination = string.Join(" + ", uniqueMediaTypes);
                //lbSumaryDisk.Text = $"{formattedTotalSize} ({diskTypesCombination})";

                // GUARDAR EL TIEMPO INICIAL EN MEMORIA (Evita llamar a WMI en el Timer)
                _initialUptime = hardwareObj.Uptime;
                _loadTime = DateTime.Now;
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

            UpdateRealTimeMetrics();
        }

        // Evento Tick del temporizador en inglés
        private void TmrRealTime_Tick(object sender, EventArgs e)
        {
            UpdateRealTimeMetrics();
        }

        // Método encargado del refresco, ahora totalmente en inglés
        private void UpdateRealTimeMetrics()
        {
            // En lugar de ir a buscar a WMI, calculamos la diferencia usando el reloj interno
            TimeSpan timePassedSinceLoad = DateTime.Now - _loadTime;
            TimeSpan currentUptime = _initialUptime + timePassedSinceLoad;

            // Muestra el tiempo actualizado de inmediato
            //lbSumaryOnTime.Text = $"{currentUptime.Days}d {currentUptime.Hours:00}h {currentUptime.Minutes:00}m {currentUptime.Seconds:00}s";
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
    }
}