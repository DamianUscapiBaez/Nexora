namespace presentation
{
    partial class frmNexoraAgent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tmrRealTime = new System.Windows.Forms.Timer(components);
            pfhTitleBar = new ReaLTaiizor.Controls.ParrotFormHandle();
            pnlTitleBar = new Panel();
            pbClose = new PictureBox();
            pbMinimize = new PictureBox();
            lbTitle = new Label();
            lbSubTitle = new Label();
            mcrdComputerSummary = new ReaLTaiizor.Controls.MaterialCard();
            pbDeviceType = new PictureBox();
            lbOnTime = new Label();
            lbSumaryOnTime = new Label();
            lbNumerSerie = new Label();
            lbSumaryNumberSerie = new Label();
            lbBrandAndModel = new Label();
            lbSumaryTypeDevice = new Label();
            lbTypeDevice = new Label();
            lbSumaryCurrentUser = new Label();
            lbCurrentUser = new Label();
            lbHostname = new Label();
            lbSumaryModelAndBrand = new Label();
            lbSumaryHostname = new Label();
            pnlMain = new Panel();
            mcrdRed = new ReaLTaiizor.Controls.MaterialCard();
            flowReds = new FlowLayoutPanel();
            lbCardRed = new Label();
            pbSumaryRed = new PictureBox();
            mcrdMonitor = new ReaLTaiizor.Controls.MaterialCard();
            flowMonitors = new FlowLayoutPanel();
            lbCardMonitor = new Label();
            pbSumaryMonitor = new PictureBox();
            mcrdDisk = new ReaLTaiizor.Controls.MaterialCard();
            flowDisks = new FlowLayoutPanel();
            lbCardDisk = new Label();
            pbSumaryDisk = new PictureBox();
            mcrdGpu = new ReaLTaiizor.Controls.MaterialCard();
            lbGpuMemory = new Label();
            lbSumaryManufacter = new Label();
            lbSumaryMemory = new Label();
            lbSumaryGpuName = new Label();
            lbManufacturer = new Label();
            lbGpuName = new Label();
            lbCardGpu = new Label();
            pbSumaryGpu = new PictureBox();
            mcrdRam = new ReaLTaiizor.Controls.MaterialCard();
            lbSumaryRamSlots = new Label();
            lbSumaryRamSeed = new Label();
            lbSumaryRamType = new Label();
            lbSumaryCapacity = new Label();
            lbRamSlots = new Label();
            lbRamSeed = new Label();
            lbRamType = new Label();
            lbCapacity = new Label();
            lbCardRam = new Label();
            pbRam = new PictureBox();
            mcrdMicroprocessor = new ReaLTaiizor.Controls.MaterialCard();
            lbSumaryMaximumSeed = new Label();
            lbMaxmumSeed = new Label();
            lbSumaryBaseSpeed = new Label();
            lbSumaryThreads = new Label();
            lbSumaryCores = new Label();
            lbSumaryNameMicroprocessor = new Label();
            lbBaseSpeed = new Label();
            lbThreads = new Label();
            lbCores = new Label();
            lnNameMicroprocessor = new Label();
            lbCardMicroprocessor = new Label();
            pbMicroProcessor = new PictureBox();
            mcrdSystem = new ReaLTaiizor.Controls.MaterialCard();
            pbSumarySystem = new PictureBox();
            lbSumaryInstallationDate = new Label();
            lbInstallationDate = new Label();
            lbSumaryArchitecture = new Label();
            lbSumaryCompilation = new Label();
            lbSumaryVersion = new Label();
            lbSumaryEdition = new Label();
            lbArchitecture = new Label();
            lbCompilation = new Label();
            lbVersion = new Label();
            lbEdition = new Label();
            lbCardSystem = new Label();
            pbSystem = new PictureBox();
            pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMinimize).BeginInit();
            mcrdComputerSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDeviceType).BeginInit();
            pnlMain.SuspendLayout();
            mcrdRed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSumaryRed).BeginInit();
            mcrdMonitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSumaryMonitor).BeginInit();
            mcrdDisk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSumaryDisk).BeginInit();
            mcrdGpu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSumaryGpu).BeginInit();
            mcrdRam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbRam).BeginInit();
            mcrdMicroprocessor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMicroProcessor).BeginInit();
            mcrdSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSumarySystem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSystem).BeginInit();
            SuspendLayout();
            // 
            // tmrRealTime
            // 
            tmrRealTime.Tick += TmrRealTime_Tick;
            // 
            // pfhTitleBar
            // 
            pfhTitleBar.DockAtTop = true;
            pfhTitleBar.HandleControl = pnlTitleBar;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.White;
            pnlTitleBar.Controls.Add(pbClose);
            pnlTitleBar.Controls.Add(pbMinimize);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(1276, 34);
            pnlTitleBar.TabIndex = 0;
            // 
            // pbClose
            // 
            pbClose.Image = Properties.Resources.window_close;
            pbClose.Location = new Point(1236, 7);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(22, 22);
            pbClose.SizeMode = PictureBoxSizeMode.Zoom;
            pbClose.TabIndex = 1;
            pbClose.TabStop = false;
            pbClose.MouseEnter += pbClose_MouseEnter;
            pbClose.MouseLeave += pbClose_MouseLeave;
            // 
            // pbMinimize
            // 
            pbMinimize.Image = Properties.Resources.window_minimize;
            pbMinimize.Location = new Point(1206, 7);
            pbMinimize.Name = "pbMinimize";
            pbMinimize.Size = new Size(22, 22);
            pbMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            pbMinimize.TabIndex = 0;
            pbMinimize.TabStop = false;
            pbMinimize.MouseEnter += pbMinimize_MouseEnter;
            pbMinimize.MouseLeave += pbMinimize_MouseLeave;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.Black;
            lbTitle.Location = new Point(265, 46);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(209, 25);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Resumen del equipo";
            // 
            // lbSubTitle
            // 
            lbSubTitle.AutoSize = true;
            lbSubTitle.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSubTitle.ForeColor = Color.Black;
            lbSubTitle.Location = new Point(265, 79);
            lbSubTitle.Name = "lbSubTitle";
            lbSubTitle.Size = new Size(266, 16);
            lbSubTitle.TabIndex = 2;
            lbSubTitle.Text = "información general de hardware y software";
            // 
            // mcrdComputerSummary
            // 
            mcrdComputerSummary.BackColor = Color.FromArgb(255, 255, 255);
            mcrdComputerSummary.Controls.Add(pbDeviceType);
            mcrdComputerSummary.Controls.Add(lbOnTime);
            mcrdComputerSummary.Controls.Add(lbSumaryOnTime);
            mcrdComputerSummary.Controls.Add(lbNumerSerie);
            mcrdComputerSummary.Controls.Add(lbSumaryNumberSerie);
            mcrdComputerSummary.Controls.Add(lbBrandAndModel);
            mcrdComputerSummary.Controls.Add(lbSumaryTypeDevice);
            mcrdComputerSummary.Controls.Add(lbTypeDevice);
            mcrdComputerSummary.Controls.Add(lbSumaryCurrentUser);
            mcrdComputerSummary.Controls.Add(lbCurrentUser);
            mcrdComputerSummary.Controls.Add(lbHostname);
            mcrdComputerSummary.Controls.Add(lbSumaryModelAndBrand);
            mcrdComputerSummary.Controls.Add(lbSumaryHostname);
            mcrdComputerSummary.Depth = 0;
            mcrdComputerSummary.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcrdComputerSummary.Location = new Point(265, 107);
            mcrdComputerSummary.Margin = new Padding(14);
            mcrdComputerSummary.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mcrdComputerSummary.Name = "mcrdComputerSummary";
            mcrdComputerSummary.Padding = new Padding(14);
            mcrdComputerSummary.Size = new Size(993, 150);
            mcrdComputerSummary.TabIndex = 4;
            // 
            // pbDeviceType
            // 
            pbDeviceType.Location = new Point(0, 0);
            pbDeviceType.Name = "pbDeviceType";
            pbDeviceType.Size = new Size(190, 150);
            pbDeviceType.SizeMode = PictureBoxSizeMode.Zoom;
            pbDeviceType.TabIndex = 44;
            pbDeviceType.TabStop = false;
            // 
            // lbOnTime
            // 
            lbOnTime.AutoSize = true;
            lbOnTime.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbOnTime.ForeColor = Color.Black;
            lbOnTime.Location = new Point(454, 106);
            lbOnTime.Name = "lbOnTime";
            lbOnTime.Size = new Size(116, 13);
            lbOnTime.TabIndex = 43;
            lbOnTime.Text = "Tiempo activo (Uptime)";
            // 
            // lbSumaryOnTime
            // 
            lbSumaryOnTime.AutoSize = true;
            lbSumaryOnTime.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbSumaryOnTime.ForeColor = Color.DarkViolet;
            lbSumaryOnTime.Location = new Point(609, 106);
            lbSumaryOnTime.Name = "lbSumaryOnTime";
            lbSumaryOnTime.Size = new Size(96, 13);
            lbSumaryOnTime.TabIndex = 42;
            lbSumaryOnTime.Text = "PF4XXXXXXXXXX";
            // 
            // lbNumerSerie
            // 
            lbNumerSerie.AutoSize = true;
            lbNumerSerie.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbNumerSerie.ForeColor = Color.Black;
            lbNumerSerie.Location = new Point(454, 65);
            lbNumerSerie.Name = "lbNumerSerie";
            lbNumerSerie.Size = new Size(84, 13);
            lbNumerSerie.TabIndex = 41;
            lbNumerSerie.Text = "Número de serie";
            // 
            // lbSumaryNumberSerie
            // 
            lbSumaryNumberSerie.AutoSize = true;
            lbSumaryNumberSerie.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbSumaryNumberSerie.ForeColor = Color.DarkViolet;
            lbSumaryNumberSerie.Location = new Point(609, 65);
            lbSumaryNumberSerie.Name = "lbSumaryNumberSerie";
            lbSumaryNumberSerie.Size = new Size(96, 13);
            lbSumaryNumberSerie.TabIndex = 40;
            lbSumaryNumberSerie.Text = "PF4XXXXXXXXXX";
            // 
            // lbBrandAndModel
            // 
            lbBrandAndModel.AutoSize = true;
            lbBrandAndModel.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbBrandAndModel.ForeColor = Color.Black;
            lbBrandAndModel.Location = new Point(454, 24);
            lbBrandAndModel.Name = "lbBrandAndModel";
            lbBrandAndModel.Size = new Size(103, 13);
            lbBrandAndModel.TabIndex = 39;
            lbBrandAndModel.Text = "Fabricante / Modelo";
            // 
            // lbSumaryTypeDevice
            // 
            lbSumaryTypeDevice.AutoSize = true;
            lbSumaryTypeDevice.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbSumaryTypeDevice.ForeColor = Color.DarkViolet;
            lbSumaryTypeDevice.Location = new Point(327, 106);
            lbSumaryTypeDevice.Name = "lbSumaryTypeDevice";
            lbSumaryTypeDevice.Size = new Size(47, 13);
            lbSumaryTypeDevice.TabIndex = 38;
            lbSumaryTypeDevice.Text = "Desktop";
            // 
            // lbTypeDevice
            // 
            lbTypeDevice.AutoSize = true;
            lbTypeDevice.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbTypeDevice.ForeColor = Color.Black;
            lbTypeDevice.Location = new Point(206, 106);
            lbTypeDevice.Name = "lbTypeDevice";
            lbTypeDevice.Size = new Size(78, 13);
            lbTypeDevice.TabIndex = 37;
            lbTypeDevice.Text = "Tipo de equipo";
            // 
            // lbSumaryCurrentUser
            // 
            lbSumaryCurrentUser.AutoSize = true;
            lbSumaryCurrentUser.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbSumaryCurrentUser.ForeColor = Color.DarkViolet;
            lbSumaryCurrentUser.Location = new Point(327, 65);
            lbSumaryCurrentUser.Name = "lbSumaryCurrentUser";
            lbSumaryCurrentUser.Size = new Size(43, 13);
            lbSumaryCurrentUser.TabIndex = 36;
            lbSumaryCurrentUser.Text = "Damian";
            // 
            // lbCurrentUser
            // 
            lbCurrentUser.AutoSize = true;
            lbCurrentUser.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbCurrentUser.ForeColor = Color.Black;
            lbCurrentUser.Location = new Point(206, 65);
            lbCurrentUser.Name = "lbCurrentUser";
            lbCurrentUser.Size = new Size(75, 13);
            lbCurrentUser.TabIndex = 35;
            lbCurrentUser.Text = "Usuario actual";
            // 
            // lbHostname
            // 
            lbHostname.AutoSize = true;
            lbHostname.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbHostname.ForeColor = Color.Black;
            lbHostname.Location = new Point(206, 24);
            lbHostname.Name = "lbHostname";
            lbHostname.Size = new Size(55, 13);
            lbHostname.TabIndex = 34;
            lbHostname.Text = "Hostname";
            // 
            // lbSumaryModelAndBrand
            // 
            lbSumaryModelAndBrand.AutoSize = true;
            lbSumaryModelAndBrand.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbSumaryModelAndBrand.ForeColor = Color.DarkViolet;
            lbSumaryModelAndBrand.Location = new Point(609, 24);
            lbSumaryModelAndBrand.Name = "lbSumaryModelAndBrand";
            lbSumaryModelAndBrand.Size = new Size(114, 13);
            lbSumaryModelAndBrand.TabIndex = 33;
            lbSumaryModelAndBrand.Text = "Lenovo / ThinkStation";
            // 
            // lbSumaryHostname
            // 
            lbSumaryHostname.AutoSize = true;
            lbSumaryHostname.BackColor = Color.Transparent;
            lbSumaryHostname.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbSumaryHostname.ForeColor = Color.DarkViolet;
            lbSumaryHostname.Location = new Point(327, 24);
            lbSumaryHostname.Name = "lbSumaryHostname";
            lbSumaryHostname.Size = new Size(66, 13);
            lbSumaryHostname.TabIndex = 32;
            lbSumaryHostname.Text = "PC-DAMIAN";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(250, 251, 253);
            pnlMain.Controls.Add(mcrdRed);
            pnlMain.Controls.Add(mcrdMonitor);
            pnlMain.Controls.Add(mcrdDisk);
            pnlMain.Controls.Add(mcrdGpu);
            pnlMain.Controls.Add(mcrdRam);
            pnlMain.Controls.Add(mcrdMicroprocessor);
            pnlMain.Controls.Add(mcrdSystem);
            pnlMain.Controls.Add(mcrdComputerSummary);
            pnlMain.Controls.Add(lbSubTitle);
            pnlMain.Controls.Add(lbTitle);
            pnlMain.Controls.Add(pnlTitleBar);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            pnlMain.ForeColor = Color.Black;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1276, 865);
            pnlMain.TabIndex = 1;
            pnlMain.Paint += pnlMain_Paint;
            // 
            // mcrdRed
            // 
            mcrdRed.BackColor = Color.FromArgb(255, 255, 255);
            mcrdRed.Controls.Add(flowReds);
            mcrdRed.Controls.Add(lbCardRed);
            mcrdRed.Controls.Add(pbSumaryRed);
            mcrdRed.Depth = 0;
            mcrdRed.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mcrdRed.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcrdRed.Location = new Point(938, 470);
            mcrdRed.Margin = new Padding(14);
            mcrdRed.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mcrdRed.Name = "mcrdRed";
            mcrdRed.Padding = new Padding(14);
            mcrdRed.Size = new Size(320, 376);
            mcrdRed.TabIndex = 12;
            // 
            // flowReds
            // 
            flowReds.AutoScroll = true;
            flowReds.Location = new Point(17, 56);
            flowReds.Name = "flowReds";
            flowReds.Size = new Size(286, 298);
            flowReds.TabIndex = 25;
            // 
            // lbCardRed
            // 
            lbCardRed.AutoSize = true;
            lbCardRed.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCardRed.Location = new Point(55, 19);
            lbCardRed.Name = "lbCardRed";
            lbCardRed.Size = new Size(36, 16);
            lbCardRed.TabIndex = 1;
            lbCardRed.Text = "Red";
            // 
            // pbSumaryRed
            // 
            pbSumaryRed.Image = Properties.Resources.icon_ethernet;
            pbSumaryRed.Location = new Point(17, 15);
            pbSumaryRed.Name = "pbSumaryRed";
            pbSumaryRed.Size = new Size(25, 25);
            pbSumaryRed.SizeMode = PictureBoxSizeMode.Zoom;
            pbSumaryRed.TabIndex = 0;
            pbSumaryRed.TabStop = false;
            // 
            // mcrdMonitor
            // 
            mcrdMonitor.BackColor = Color.FromArgb(255, 255, 255);
            mcrdMonitor.Controls.Add(flowMonitors);
            mcrdMonitor.Controls.Add(lbCardMonitor);
            mcrdMonitor.Controls.Add(pbSumaryMonitor);
            mcrdMonitor.Depth = 0;
            mcrdMonitor.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcrdMonitor.Location = new Point(601, 470);
            mcrdMonitor.Margin = new Padding(14);
            mcrdMonitor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mcrdMonitor.Name = "mcrdMonitor";
            mcrdMonitor.Padding = new Padding(14);
            mcrdMonitor.Size = new Size(320, 180);
            mcrdMonitor.TabIndex = 9;
            // 
            // flowMonitors
            // 
            flowMonitors.AutoScroll = true;
            flowMonitors.Location = new Point(17, 56);
            flowMonitors.Name = "flowMonitors";
            flowMonitors.Size = new Size(283, 107);
            flowMonitors.TabIndex = 24;
            // 
            // lbCardMonitor
            // 
            lbCardMonitor.AutoSize = true;
            lbCardMonitor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCardMonitor.Location = new Point(57, 19);
            lbCardMonitor.Name = "lbCardMonitor";
            lbCardMonitor.Size = new Size(58, 16);
            lbCardMonitor.TabIndex = 23;
            lbCardMonitor.Text = "Monitor";
            // 
            // pbSumaryMonitor
            // 
            pbSumaryMonitor.Image = Properties.Resources.icon_monitor;
            pbSumaryMonitor.Location = new Point(17, 15);
            pbSumaryMonitor.Name = "pbSumaryMonitor";
            pbSumaryMonitor.Size = new Size(25, 25);
            pbSumaryMonitor.SizeMode = PictureBoxSizeMode.Zoom;
            pbSumaryMonitor.TabIndex = 22;
            pbSumaryMonitor.TabStop = false;
            // 
            // mcrdDisk
            // 
            mcrdDisk.BackColor = Color.FromArgb(255, 255, 255);
            mcrdDisk.Controls.Add(flowDisks);
            mcrdDisk.Controls.Add(lbCardDisk);
            mcrdDisk.Controls.Add(pbSumaryDisk);
            mcrdDisk.Depth = 0;
            mcrdDisk.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcrdDisk.Location = new Point(265, 470);
            mcrdDisk.Margin = new Padding(14);
            mcrdDisk.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mcrdDisk.Name = "mcrdDisk";
            mcrdDisk.Padding = new Padding(14);
            mcrdDisk.Size = new Size(320, 180);
            mcrdDisk.TabIndex = 8;
            // 
            // flowDisks
            // 
            flowDisks.AutoScroll = true;
            flowDisks.FlowDirection = FlowDirection.TopDown;
            flowDisks.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowDisks.Location = new Point(14, 43);
            flowDisks.Margin = new Padding(0);
            flowDisks.Name = "flowDisks";
            flowDisks.Size = new Size(292, 123);
            flowDisks.TabIndex = 12;
            flowDisks.WrapContents = false;
            // 
            // lbCardDisk
            // 
            lbCardDisk.AutoSize = true;
            lbCardDisk.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCardDisk.Location = new Point(55, 19);
            lbCardDisk.Name = "lbCardDisk";
            lbCardDisk.Size = new Size(55, 16);
            lbCardDisk.TabIndex = 11;
            lbCardDisk.Text = "Discos";
            // 
            // pbSumaryDisk
            // 
            pbSumaryDisk.Image = Properties.Resources.icon_disk;
            pbSumaryDisk.Location = new Point(17, 15);
            pbSumaryDisk.Name = "pbSumaryDisk";
            pbSumaryDisk.Size = new Size(25, 25);
            pbSumaryDisk.SizeMode = PictureBoxSizeMode.Zoom;
            pbSumaryDisk.TabIndex = 10;
            pbSumaryDisk.TabStop = false;
            pbSumaryDisk.Click += pictureBox2_Click;
            // 
            // mcrdGpu
            // 
            mcrdGpu.BackColor = Color.FromArgb(255, 255, 255);
            mcrdGpu.Controls.Add(lbGpuMemory);
            mcrdGpu.Controls.Add(lbSumaryManufacter);
            mcrdGpu.Controls.Add(lbSumaryMemory);
            mcrdGpu.Controls.Add(lbSumaryGpuName);
            mcrdGpu.Controls.Add(lbManufacturer);
            mcrdGpu.Controls.Add(lbGpuName);
            mcrdGpu.Controls.Add(lbCardGpu);
            mcrdGpu.Controls.Add(pbSumaryGpu);
            mcrdGpu.Depth = 0;
            mcrdGpu.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mcrdGpu.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcrdGpu.Location = new Point(938, 274);
            mcrdGpu.Margin = new Padding(14);
            mcrdGpu.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mcrdGpu.Name = "mcrdGpu";
            mcrdGpu.Padding = new Padding(14);
            mcrdGpu.Size = new Size(320, 180);
            mcrdGpu.TabIndex = 7;
            // 
            // lbGpuMemory
            // 
            lbGpuMemory.AutoSize = true;
            lbGpuMemory.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbGpuMemory.Location = new Point(17, 73);
            lbGpuMemory.Name = "lbGpuMemory";
            lbGpuMemory.Size = new Size(94, 13);
            lbGpuMemory.TabIndex = 9;
            lbGpuMemory.Text = "Memoria dedicada";
            // 
            // lbSumaryManufacter
            // 
            lbSumaryManufacter.AutoSize = true;
            lbSumaryManufacter.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbSumaryManufacter.Location = new Point(132, 97);
            lbSumaryManufacter.Name = "lbSumaryManufacter";
            lbSumaryManufacter.Size = new Size(37, 13);
            lbSumaryManufacter.TabIndex = 8;
            lbSumaryManufacter.Text = "Nvidia";
            // 
            // lbSumaryMemory
            // 
            lbSumaryMemory.AutoSize = true;
            lbSumaryMemory.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbSumaryMemory.Location = new Point(132, 73);
            lbSumaryMemory.Name = "lbSumaryMemory";
            lbSumaryMemory.Size = new Size(27, 13);
            lbSumaryMemory.TabIndex = 7;
            lbSumaryMemory.Text = "6Gb";
            // 
            // lbSumaryGpuName
            // 
            lbSumaryGpuName.AutoSize = true;
            lbSumaryGpuName.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbSumaryGpuName.Location = new Point(132, 49);
            lbSumaryGpuName.Name = "lbSumaryGpuName";
            lbSumaryGpuName.Size = new Size(37, 13);
            lbSumaryGpuName.TabIndex = 6;
            lbSumaryGpuName.Text = "Nvidia";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbManufacturer.Location = new Point(17, 97);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(57, 13);
            lbManufacturer.TabIndex = 4;
            lbManufacturer.Text = "Fabricante";
            // 
            // lbGpuName
            // 
            lbGpuName.AutoSize = true;
            lbGpuName.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbGpuName.Location = new Point(17, 49);
            lbGpuName.Name = "lbGpuName";
            lbGpuName.Size = new Size(44, 13);
            lbGpuName.TabIndex = 2;
            lbGpuName.Text = "Nombre";
            // 
            // lbCardGpu
            // 
            lbCardGpu.AutoSize = true;
            lbCardGpu.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCardGpu.Location = new Point(55, 19);
            lbCardGpu.Name = "lbCardGpu";
            lbCardGpu.Size = new Size(111, 16);
            lbCardGpu.TabIndex = 1;
            lbCardGpu.Text = "Tarjeta Gráfica";
            // 
            // pbSumaryGpu
            // 
            pbSumaryGpu.Image = Properties.Resources.icon_gpu;
            pbSumaryGpu.Location = new Point(17, 15);
            pbSumaryGpu.Name = "pbSumaryGpu";
            pbSumaryGpu.Size = new Size(25, 25);
            pbSumaryGpu.SizeMode = PictureBoxSizeMode.Zoom;
            pbSumaryGpu.TabIndex = 0;
            pbSumaryGpu.TabStop = false;
            // 
            // mcrdRam
            // 
            mcrdRam.BackColor = Color.FromArgb(255, 255, 255);
            mcrdRam.Controls.Add(lbSumaryRamSlots);
            mcrdRam.Controls.Add(lbSumaryRamSeed);
            mcrdRam.Controls.Add(lbSumaryRamType);
            mcrdRam.Controls.Add(lbSumaryCapacity);
            mcrdRam.Controls.Add(lbRamSlots);
            mcrdRam.Controls.Add(lbRamSeed);
            mcrdRam.Controls.Add(lbRamType);
            mcrdRam.Controls.Add(lbCapacity);
            mcrdRam.Controls.Add(lbCardRam);
            mcrdRam.Controls.Add(pbRam);
            mcrdRam.Depth = 0;
            mcrdRam.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcrdRam.Location = new Point(601, 274);
            mcrdRam.Margin = new Padding(14);
            mcrdRam.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mcrdRam.Name = "mcrdRam";
            mcrdRam.Padding = new Padding(14);
            mcrdRam.Size = new Size(320, 180);
            mcrdRam.TabIndex = 6;
            // 
            // lbSumaryRamSlots
            // 
            lbSumaryRamSlots.AutoSize = true;
            lbSumaryRamSlots.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbSumaryRamSlots.Location = new Point(140, 126);
            lbSumaryRamSlots.Name = "lbSumaryRamSlots";
            lbSumaryRamSlots.Size = new Size(37, 13);
            lbSumaryRamSlots.TabIndex = 31;
            lbSumaryRamSlots.Text = "2 de 4";
            // 
            // lbSumaryRamSeed
            // 
            lbSumaryRamSeed.AutoSize = true;
            lbSumaryRamSeed.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbSumaryRamSeed.Location = new Point(140, 100);
            lbSumaryRamSeed.Name = "lbSumaryRamSeed";
            lbSumaryRamSeed.Size = new Size(56, 13);
            lbSumaryRamSeed.TabIndex = 30;
            lbSumaryRamSeed.Text = "5600 MHz";
            // 
            // lbSumaryRamType
            // 
            lbSumaryRamType.AutoSize = true;
            lbSumaryRamType.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbSumaryRamType.Location = new Point(140, 74);
            lbSumaryRamType.Name = "lbSumaryRamType";
            lbSumaryRamType.Size = new Size(37, 13);
            lbSumaryRamType.TabIndex = 29;
            lbSumaryRamType.Text = "DDR5";
            // 
            // lbSumaryCapacity
            // 
            lbSumaryCapacity.AutoSize = true;
            lbSumaryCapacity.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbSumaryCapacity.Location = new Point(140, 48);
            lbSumaryCapacity.Name = "lbSumaryCapacity";
            lbSumaryCapacity.Size = new Size(37, 13);
            lbSumaryCapacity.TabIndex = 28;
            lbSumaryCapacity.Text = "32 GB";
            // 
            // lbRamSlots
            // 
            lbRamSlots.AutoSize = true;
            lbRamSlots.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbRamSlots.Location = new Point(23, 126);
            lbRamSlots.Name = "lbRamSlots";
            lbRamSlots.Size = new Size(67, 13);
            lbRamSlots.TabIndex = 27;
            lbRamSlots.Text = "Slots usados";
            // 
            // lbRamSeed
            // 
            lbRamSeed.AutoSize = true;
            lbRamSeed.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbRamSeed.Location = new Point(23, 100);
            lbRamSeed.Name = "lbRamSeed";
            lbRamSeed.Size = new Size(54, 13);
            lbRamSeed.TabIndex = 26;
            lbRamSeed.Text = "Velocidad";
            // 
            // lbRamType
            // 
            lbRamType.AutoSize = true;
            lbRamType.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbRamType.Location = new Point(23, 74);
            lbRamType.Name = "lbRamType";
            lbRamType.Size = new Size(28, 13);
            lbRamType.TabIndex = 25;
            lbRamType.Text = "Tipo";
            // 
            // lbCapacity
            // 
            lbCapacity.AutoSize = true;
            lbCapacity.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbCapacity.Location = new Point(23, 48);
            lbCapacity.Name = "lbCapacity";
            lbCapacity.Size = new Size(103, 13);
            lbCapacity.TabIndex = 24;
            lbCapacity.Text = "Capacidad instalada";
            // 
            // lbCardRam
            // 
            lbCardRam.AutoSize = true;
            lbCardRam.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCardRam.Location = new Point(57, 19);
            lbCardRam.Name = "lbCardRam";
            lbCardRam.Size = new Size(104, 16);
            lbCardRam.TabIndex = 23;
            lbCardRam.Text = "Memoria RAM";
            // 
            // pbRam
            // 
            pbRam.Image = Properties.Resources.icon_ram;
            pbRam.Location = new Point(17, 15);
            pbRam.Name = "pbRam";
            pbRam.Size = new Size(25, 25);
            pbRam.SizeMode = PictureBoxSizeMode.Zoom;
            pbRam.TabIndex = 22;
            pbRam.TabStop = false;
            // 
            // mcrdMicroprocessor
            // 
            mcrdMicroprocessor.BackColor = Color.FromArgb(255, 255, 255);
            mcrdMicroprocessor.Controls.Add(lbSumaryMaximumSeed);
            mcrdMicroprocessor.Controls.Add(lbMaxmumSeed);
            mcrdMicroprocessor.Controls.Add(lbSumaryBaseSpeed);
            mcrdMicroprocessor.Controls.Add(lbSumaryThreads);
            mcrdMicroprocessor.Controls.Add(lbSumaryCores);
            mcrdMicroprocessor.Controls.Add(lbSumaryNameMicroprocessor);
            mcrdMicroprocessor.Controls.Add(lbBaseSpeed);
            mcrdMicroprocessor.Controls.Add(lbThreads);
            mcrdMicroprocessor.Controls.Add(lbCores);
            mcrdMicroprocessor.Controls.Add(lnNameMicroprocessor);
            mcrdMicroprocessor.Controls.Add(lbCardMicroprocessor);
            mcrdMicroprocessor.Controls.Add(pbMicroProcessor);
            mcrdMicroprocessor.Depth = 0;
            mcrdMicroprocessor.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcrdMicroprocessor.Location = new Point(265, 274);
            mcrdMicroprocessor.Margin = new Padding(14);
            mcrdMicroprocessor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mcrdMicroprocessor.Name = "mcrdMicroprocessor";
            mcrdMicroprocessor.Padding = new Padding(14);
            mcrdMicroprocessor.Size = new Size(320, 180);
            mcrdMicroprocessor.TabIndex = 6;
            // 
            // lbSumaryMaximumSeed
            // 
            lbSumaryMaximumSeed.AutoSize = true;
            lbSumaryMaximumSeed.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbSumaryMaximumSeed.Location = new Point(131, 145);
            lbSumaryMaximumSeed.Name = "lbSumaryMaximumSeed";
            lbSumaryMaximumSeed.Size = new Size(52, 13);
            lbSumaryMaximumSeed.TabIndex = 21;
            lbSumaryMaximumSeed.Text = "5.40 GHz";
            // 
            // lbMaxmumSeed
            // 
            lbMaxmumSeed.AutoSize = true;
            lbMaxmumSeed.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbMaxmumSeed.Location = new Point(20, 145);
            lbMaxmumSeed.Name = "lbMaxmumSeed";
            lbMaxmumSeed.Size = new Size(92, 13);
            lbMaxmumSeed.TabIndex = 20;
            lbMaxmumSeed.Text = "Velocidad maxima";
            // 
            // lbSumaryBaseSpeed
            // 
            lbSumaryBaseSpeed.AutoSize = true;
            lbSumaryBaseSpeed.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbSumaryBaseSpeed.Location = new Point(131, 121);
            lbSumaryBaseSpeed.Name = "lbSumaryBaseSpeed";
            lbSumaryBaseSpeed.Size = new Size(52, 13);
            lbSumaryBaseSpeed.TabIndex = 19;
            lbSumaryBaseSpeed.Text = "3.40 GHz";
            // 
            // lbSumaryThreads
            // 
            lbSumaryThreads.AutoSize = true;
            lbSumaryThreads.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbSumaryThreads.Location = new Point(131, 97);
            lbSumaryThreads.Name = "lbSumaryThreads";
            lbSumaryThreads.Size = new Size(19, 13);
            lbSumaryThreads.TabIndex = 18;
            lbSumaryThreads.Text = "24";
            // 
            // lbSumaryCores
            // 
            lbSumaryCores.AutoSize = true;
            lbSumaryCores.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbSumaryCores.Location = new Point(131, 73);
            lbSumaryCores.Name = "lbSumaryCores";
            lbSumaryCores.Size = new Size(19, 13);
            lbSumaryCores.TabIndex = 17;
            lbSumaryCores.Text = "12";
            // 
            // lbSumaryNameMicroprocessor
            // 
            lbSumaryNameMicroprocessor.AutoSize = true;
            lbSumaryNameMicroprocessor.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbSumaryNameMicroprocessor.Location = new Point(131, 49);
            lbSumaryNameMicroprocessor.Name = "lbSumaryNameMicroprocessor";
            lbSumaryNameMicroprocessor.Size = new Size(105, 13);
            lbSumaryNameMicroprocessor.TabIndex = 16;
            lbSumaryNameMicroprocessor.Text = "Interl Core i7-13700k";
            // 
            // lbBaseSpeed
            // 
            lbBaseSpeed.AutoSize = true;
            lbBaseSpeed.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbBaseSpeed.Location = new Point(20, 121);
            lbBaseSpeed.Name = "lbBaseSpeed";
            lbBaseSpeed.Size = new Size(80, 13);
            lbBaseSpeed.TabIndex = 15;
            lbBaseSpeed.Text = "Velocidad base";
            // 
            // lbThreads
            // 
            lbThreads.AutoSize = true;
            lbThreads.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbThreads.Location = new Point(20, 97);
            lbThreads.Name = "lbThreads";
            lbThreads.Size = new Size(30, 13);
            lbThreads.TabIndex = 14;
            lbThreads.Text = "Hilos";
            // 
            // lbCores
            // 
            lbCores.AutoSize = true;
            lbCores.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbCores.Location = new Point(20, 73);
            lbCores.Name = "lbCores";
            lbCores.Size = new Size(80, 13);
            lbCores.TabIndex = 13;
            lbCores.Text = "Núcleos físicos";
            // 
            // lnNameMicroprocessor
            // 
            lnNameMicroprocessor.AutoSize = true;
            lnNameMicroprocessor.Font = new Font("Microsoft Sans Serif", 8.25F);
            lnNameMicroprocessor.Location = new Point(20, 49);
            lnNameMicroprocessor.Name = "lnNameMicroprocessor";
            lnNameMicroprocessor.Size = new Size(44, 13);
            lnNameMicroprocessor.TabIndex = 12;
            lnNameMicroprocessor.Text = "Nombre";
            // 
            // lbCardMicroprocessor
            // 
            lbCardMicroprocessor.AutoSize = true;
            lbCardMicroprocessor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCardMicroprocessor.Location = new Point(55, 19);
            lbCardMicroprocessor.Name = "lbCardMicroprocessor";
            lbCardMicroprocessor.Size = new Size(88, 16);
            lbCardMicroprocessor.TabIndex = 11;
            lbCardMicroprocessor.Text = "Procesador";
            // 
            // pbMicroProcessor
            // 
            pbMicroProcessor.Image = Properties.Resources.icon_microprocessor;
            pbMicroProcessor.Location = new Point(17, 15);
            pbMicroProcessor.Name = "pbMicroProcessor";
            pbMicroProcessor.Size = new Size(25, 25);
            pbMicroProcessor.SizeMode = PictureBoxSizeMode.Zoom;
            pbMicroProcessor.TabIndex = 10;
            pbMicroProcessor.TabStop = false;
            // 
            // mcrdSystem
            // 
            mcrdSystem.BackColor = Color.FromArgb(255, 255, 255);
            mcrdSystem.Controls.Add(pbSumarySystem);
            mcrdSystem.Controls.Add(lbSumaryInstallationDate);
            mcrdSystem.Controls.Add(lbInstallationDate);
            mcrdSystem.Controls.Add(lbSumaryArchitecture);
            mcrdSystem.Controls.Add(lbSumaryCompilation);
            mcrdSystem.Controls.Add(lbSumaryVersion);
            mcrdSystem.Controls.Add(lbSumaryEdition);
            mcrdSystem.Controls.Add(lbArchitecture);
            mcrdSystem.Controls.Add(lbCompilation);
            mcrdSystem.Controls.Add(lbVersion);
            mcrdSystem.Controls.Add(lbEdition);
            mcrdSystem.Controls.Add(lbCardSystem);
            mcrdSystem.Controls.Add(pbSystem);
            mcrdSystem.Depth = 0;
            mcrdSystem.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mcrdSystem.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcrdSystem.Location = new Point(265, 666);
            mcrdSystem.Margin = new Padding(14);
            mcrdSystem.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mcrdSystem.Name = "mcrdSystem";
            mcrdSystem.Padding = new Padding(14);
            mcrdSystem.Size = new Size(656, 180);
            mcrdSystem.TabIndex = 5;
            // 
            // pbSumarySystem
            // 
            pbSumarySystem.Image = Properties.Resources.fondo_system;
            pbSumarySystem.Location = new Point(385, 0);
            pbSumarySystem.Name = "pbSumarySystem";
            pbSumarySystem.Size = new Size(271, 180);
            pbSumarySystem.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSumarySystem.TabIndex = 45;
            pbSumarySystem.TabStop = false;
            // 
            // lbSumaryInstallationDate
            // 
            lbSumaryInstallationDate.AutoSize = true;
            lbSumaryInstallationDate.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbSumaryInstallationDate.Location = new Point(132, 145);
            lbSumaryInstallationDate.Name = "lbSumaryInstallationDate";
            lbSumaryInstallationDate.Size = new Size(65, 13);
            lbSumaryInstallationDate.TabIndex = 11;
            lbSumaryInstallationDate.Text = "26/06/2026";
            // 
            // lbInstallationDate
            // 
            lbInstallationDate.AutoSize = true;
            lbInstallationDate.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbInstallationDate.Location = new Point(17, 145);
            lbInstallationDate.Name = "lbInstallationDate";
            lbInstallationDate.Size = new Size(105, 13);
            lbInstallationDate.TabIndex = 10;
            lbInstallationDate.Text = "Fecha de instalación";
            // 
            // lbSumaryArchitecture
            // 
            lbSumaryArchitecture.AutoSize = true;
            lbSumaryArchitecture.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbSumaryArchitecture.Location = new Point(132, 121);
            lbSumaryArchitecture.Name = "lbSumaryArchitecture";
            lbSumaryArchitecture.Size = new Size(38, 13);
            lbSumaryArchitecture.TabIndex = 9;
            lbSumaryArchitecture.Text = "64 bits";
            // 
            // lbSumaryCompilation
            // 
            lbSumaryCompilation.AutoSize = true;
            lbSumaryCompilation.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbSumaryCompilation.Location = new Point(132, 97);
            lbSumaryCompilation.Name = "lbSumaryCompilation";
            lbSumaryCompilation.Size = new Size(64, 13);
            lbSumaryCompilation.TabIndex = 8;
            lbSumaryCompilation.Text = "26100.1742";
            // 
            // lbSumaryVersion
            // 
            lbSumaryVersion.AutoSize = true;
            lbSumaryVersion.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbSumaryVersion.Location = new Point(132, 73);
            lbSumaryVersion.Name = "lbSumaryVersion";
            lbSumaryVersion.Size = new Size(33, 13);
            lbSumaryVersion.TabIndex = 7;
            lbSumaryVersion.Text = "24H2";
            // 
            // lbSumaryEdition
            // 
            lbSumaryEdition.AutoSize = true;
            lbSumaryEdition.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbSumaryEdition.Location = new Point(132, 49);
            lbSumaryEdition.Name = "lbSumaryEdition";
            lbSumaryEdition.Size = new Size(84, 13);
            lbSumaryEdition.TabIndex = 6;
            lbSumaryEdition.Text = "Windows 11 pro";
            // 
            // lbArchitecture
            // 
            lbArchitecture.AutoSize = true;
            lbArchitecture.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbArchitecture.Location = new Point(17, 121);
            lbArchitecture.Name = "lbArchitecture";
            lbArchitecture.Size = new Size(64, 13);
            lbArchitecture.TabIndex = 5;
            lbArchitecture.Text = "Arquitectura";
            // 
            // lbCompilation
            // 
            lbCompilation.AutoSize = true;
            lbCompilation.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbCompilation.Location = new Point(17, 97);
            lbCompilation.Name = "lbCompilation";
            lbCompilation.Size = new Size(96, 13);
            lbCompilation.TabIndex = 4;
            lbCompilation.Text = "Compilación (Build)";
            // 
            // lbVersion
            // 
            lbVersion.AutoSize = true;
            lbVersion.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbVersion.Location = new Point(17, 73);
            lbVersion.Name = "lbVersion";
            lbVersion.Size = new Size(42, 13);
            lbVersion.TabIndex = 3;
            lbVersion.Text = "Versión";
            // 
            // lbEdition
            // 
            lbEdition.AutoSize = true;
            lbEdition.Font = new Font("Microsoft Sans Serif", 8.25F);
            lbEdition.Location = new Point(17, 49);
            lbEdition.Name = "lbEdition";
            lbEdition.Size = new Size(42, 13);
            lbEdition.TabIndex = 2;
            lbEdition.Text = "Edición";
            // 
            // lbCardSystem
            // 
            lbCardSystem.AutoSize = true;
            lbCardSystem.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCardSystem.Location = new Point(55, 19);
            lbCardSystem.Name = "lbCardSystem";
            lbCardSystem.Size = new Size(135, 16);
            lbCardSystem.TabIndex = 1;
            lbCardSystem.Text = "Sistema Operativo";
            // 
            // pbSystem
            // 
            pbSystem.Image = Properties.Resources.icon_system;
            pbSystem.Location = new Point(17, 15);
            pbSystem.Name = "pbSystem";
            pbSystem.Size = new Size(25, 25);
            pbSystem.SizeMode = PictureBoxSizeMode.Zoom;
            pbSystem.TabIndex = 0;
            pbSystem.TabStop = false;
            // 
            // frmNexoraAgent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 865);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1032);
            MinimumSize = new Size(190, 40);
            Name = "frmNexoraAgent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nexora Agente";
            TransparencyKey = Color.Fuchsia;
            Load += frmNexoraAgent_Load;
            pnlTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMinimize).EndInit();
            mcrdComputerSummary.ResumeLayout(false);
            mcrdComputerSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbDeviceType).EndInit();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            mcrdRed.ResumeLayout(false);
            mcrdRed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSumaryRed).EndInit();
            mcrdMonitor.ResumeLayout(false);
            mcrdMonitor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSumaryMonitor).EndInit();
            mcrdDisk.ResumeLayout(false);
            mcrdDisk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSumaryDisk).EndInit();
            mcrdGpu.ResumeLayout(false);
            mcrdGpu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSumaryGpu).EndInit();
            mcrdRam.ResumeLayout(false);
            mcrdRam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbRam).EndInit();
            mcrdMicroprocessor.ResumeLayout(false);
            mcrdMicroprocessor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbMicroProcessor).EndInit();
            mcrdSystem.ResumeLayout(false);
            mcrdSystem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSumarySystem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSystem).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer tmrRealTime;
        private ReaLTaiizor.Controls.ParrotFormHandle pfhTitleBar;
        private Panel pnlTitleBar;
        private PictureBox pbClose;
        private PictureBox pbMinimize;
        private Label lbTitle;
        private Label lbSubTitle;
        private ReaLTaiizor.Controls.MaterialCard mcrdComputerSummary;
        private PictureBox pbDeviceType;
        private Label lbOnTime;
        private Label lbSumaryOnTime;
        private Label lbNumerSerie;
        private Label lbSumaryNumberSerie;
        private Label lbBrandAndModel;
        private Label lbSumaryTypeDevice;
        private Label lbTypeDevice;
        private Label lbSumaryCurrentUser;
        private Label lbCurrentUser;
        private Label lbHostname;
        private Label lbSumaryModelAndBrand;
        private Label lbSumaryHostname;
        private Panel pnlMain;
        private ReaLTaiizor.Controls.MaterialCard mcrdRam;
        private ReaLTaiizor.Controls.MaterialCard mcrdMicroprocessor;
        private ReaLTaiizor.Controls.MaterialCard mcrdSystem;
        private PictureBox pbSystem;
        private Label lbCardSystem;
        private Label lbSumaryArchitecture;
        private Label lbSumaryCompilation;
        private Label lbSumaryVersion;
        private Label lbSumaryEdition;
        private Label lbArchitecture;
        private Label lbCompilation;
        private Label lbVersion;
        private Label lbEdition;
        private Label lbSumaryBaseSpeed;
        private Label lbSumaryThreads;
        private Label lbSumaryCores;
        private Label lbSumaryNameMicroprocessor;
        private Label lbBaseSpeed;
        private Label lbThreads;
        private Label lbCores;
        private Label lnNameMicroprocessor;
        private Label lbCardMicroprocessor;
        private PictureBox pbMicroProcessor;
        private Label lbSumaryInstallationDate;
        private Label lbInstallationDate;
        private Label lbSumaryMaximumSeed;
        private Label lbMaxmumSeed;
        private Label lbSumaryRamSlots;
        private Label lbSumaryRamSeed;
        private Label lbSumaryRamType;
        private Label lbSumaryCapacity;
        private Label lbRamSlots;
        private Label lbRamSeed;
        private Label lbRamType;
        private Label lbCapacity;
        private Label lbCardRam;
        private PictureBox pbRam;
        private ReaLTaiizor.Controls.MaterialCard mcrdMonitor;
        private Label lbCardMonitor;
        private PictureBox pbSumaryMonitor;
        private ReaLTaiizor.Controls.MaterialCard mcrdDisk;
        private Label lbCardDisk;
        private PictureBox pbSumaryDisk;
        private ReaLTaiizor.Controls.MaterialCard mcrdGpu;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label lbSumaryManufacter;
        private Label lbSumaryMemory;
        private Label lbSumaryGpuName;
        private Label label29;
        private Label lbManufacturer;
        private Label label31;
        private Label lbGpuName;
        private Label lbCardGpu;
        private PictureBox pbSumaryGpu;
        private ReaLTaiizor.Controls.MaterialCard mcrdRed;
        private Label lbCardRed;
        private PictureBox pbSumaryRed;
        private PictureBox pbSumarySystem;
        private Label lbGpuMemory;
        private FlowLayoutPanel flowReds;
        private FlowLayoutPanel flowDisks;
        private FlowLayoutPanel flowMonitors;
    }
}
