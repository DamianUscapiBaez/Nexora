using entities;
using presentation.Properties;
using System.Runtime.InteropServices;
using System.Text;

namespace presentation
{
    public partial class frmNexoraAgent : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int left, int top, int right, int bottom, int widthEllipse, int heightEllipse);
        public frmNexoraAgent()
        {
            InitializeComponent();

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            pnlComputerSummary.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlComputerSummary.Width, pnlComputerSummary.Height, 20, 20));
            pnlComputerInformation.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlComputerInformation.Width, pnlComputerInformation.Height, 20, 20));
        }

        private void frmNexoraAgent_Load(object sender, EventArgs e)
        {
            LoadInformation();
        }

        private void LoadInformation()
        {
            var computerInfo = business.ComputerInfoService.GetComputerInfo();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Manufacturer: {computerInfo.Manufacturer}");
            sb.AppendLine($"Model: {computerInfo.Model}");
            sb.AppendLine($"Serial Number: {computerInfo.SerialNumber}");
            sb.AppendLine($"Computer Type: {computerInfo.ComputerType}");

            if (computerInfo.OperatingSystem != null)
            {
                sb.AppendLine();
                sb.AppendLine("=== OPERATING SYSTEM ===");
                sb.AppendLine($"OS: {computerInfo.OperatingSystem.OperatingSystem}");
                sb.AppendLine($"Version: {computerInfo.OperatingSystem.OSVersion}");
                sb.AppendLine($"Build: {computerInfo.OperatingSystem.OSBuild}");
                sb.AppendLine($"Architecture: {computerInfo.OperatingSystem.OSArchitecture}");
            }

            if (computerInfo.Hardware != null)
            {
                sb.AppendLine();
                sb.AppendLine("=== HARDWARE ===");
                sb.AppendLine($"CPU: {computerInfo.Hardware.Cpu}");
                sb.AppendLine($"RAM: {computerInfo.Hardware.Ram}");

                if (computerInfo.Hardware.Disks != null)
                {
                    sb.AppendLine();
                    sb.AppendLine("Disks:");

                    foreach (var disk in computerInfo.Hardware.Disks)
                    {
                        sb.AppendLine($"• {disk.Model} - {disk.CapacityGB}");
                    }
                }

                if (computerInfo.Hardware.Monitors != null)
                {
                    sb.AppendLine();
                    sb.AppendLine("Monitors:");

                    foreach (var monitor in computerInfo.Hardware.Monitors)
                    {
                        sb.AppendLine(
                            $"• Manufacturer: {monitor.Manufacturer}" +
                            $"\n  Model: {monitor.Model}" +
                            $"\n  Serial: {monitor.SerialNumber}");
                    }
                }
            }

            switch (computerInfo.ComputerType)
            {
                // Evaluamos directamente utilizando el Enum
                case ComputerType.Desktop:
                    pbDeviceType.Image = Properties.Resources.device_desktop;
                    break;

                case ComputerType.AllInOne:
                    pbDeviceType.Image = Properties.Resources.device_AllInOne;
                    break;

                case ComputerType.Laptop:
                    pbDeviceType.Image = Properties.Resources.device_laptop;
                    break;

                case ComputerType.Unknown:
                default:
                    pbDeviceType.Image = Properties.Resources.device_desktop;
                    break;
            }
            lbHostname.Text = computerInfo.OperatingSystem.HostName;
            lbModel.Text = computerInfo.Manufacturer + " " + computerInfo.Model;
            lbSumarySystem.Text = computerInfo.OperatingSystem.OperatingSystem;
            lbSumaryVersion.Text = $"{computerInfo.OperatingSystem.OSVersion} (Compilación {computerInfo.OperatingSystem.OSBuild})";
            lbSumaryArquitecture.Text = computerInfo.OperatingSystem.OSArchitecture;

            // MessageBox.Show(
            //    sb.ToString(),
            //    "+/9+785858585858584517069*9+9*8/9*08/*-06+85587+879+Computer Information",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Information);
        }

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
    }
}
