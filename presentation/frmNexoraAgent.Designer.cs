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
            pictureBox4 = new PictureBox();
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
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            materialCard2 = new ReaLTaiizor.Controls.MaterialCard();
            materialCard3 = new ReaLTaiizor.Controls.MaterialCard();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDeviceType).BeginInit();
            pnlMain.SuspendLayout();
            mcrdRam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbRam).BeginInit();
            mcrdMicroprocessor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMicroProcessor).BeginInit();
            mcrdSystem.SuspendLayout();
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
            pnlTitleBar.Size = new Size(1500, 34);
            pnlTitleBar.TabIndex = 0;
            // 
            // pbClose
            // 
            pbClose.Image = Properties.Resources.window_close;
            pbClose.Location = new Point(1468, 6);
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
            pbMinimize.Location = new Point(1438, 6);
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
            lbTitle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.Black;
            lbTitle.Location = new Point(265, 45);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(261, 31);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Resumen del equipo";
            // 
            // lbSubTitle
            // 
            lbSubTitle.AutoSize = true;
            lbSubTitle.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSubTitle.ForeColor = Color.Black;
            lbSubTitle.Location = new Point(265, 89);
            lbSubTitle.Name = "lbSubTitle";
            lbSubTitle.Size = new Size(316, 20);
            lbSubTitle.TabIndex = 2;
            lbSubTitle.Text = "información general de hardware y software";
            // 
            // mcrdComputerSummary
            // 
            mcrdComputerSummary.BackColor = Color.FromArgb(255, 255, 255);
            mcrdComputerSummary.Controls.Add(pictureBox4);
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
            mcrdComputerSummary.Location = new Point(265, 123);
            mcrdComputerSummary.Margin = new Padding(14);
            mcrdComputerSummary.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mcrdComputerSummary.Name = "mcrdComputerSummary";
            mcrdComputerSummary.Padding = new Padding(14);
            mcrdComputerSummary.Size = new Size(1214, 199);
            mcrdComputerSummary.TabIndex = 4;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.fondo_system;
            pictureBox4.Location = new Point(1014, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(199, 199);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 45;
            pictureBox4.TabStop = false;
            // 
            // pbDeviceType
            // 
            pbDeviceType.Location = new Point(10, 9);
            pbDeviceType.Name = "pbDeviceType";
            pbDeviceType.Size = new Size(180, 180);
            pbDeviceType.SizeMode = PictureBoxSizeMode.Zoom;
            pbDeviceType.TabIndex = 44;
            pbDeviceType.TabStop = false;
            // 
            // lbOnTime
            // 
            lbOnTime.AutoSize = true;
            lbOnTime.Font = new Font("Microsoft Sans Serif", 9.749999F);
            lbOnTime.ForeColor = Color.Black;
            lbOnTime.Location = new Point(564, 137);
            lbOnTime.Name = "lbOnTime";
            lbOnTime.Size = new Size(147, 16);
            lbOnTime.TabIndex = 43;
            lbOnTime.Text = "Tiempo activo (Uptime)";
            // 
            // lbSumaryOnTime
            // 
            lbSumaryOnTime.AutoSize = true;
            lbSumaryOnTime.Font = new Font("Microsoft Sans Serif", 9.749999F);
            lbSumaryOnTime.ForeColor = Color.DarkViolet;
            lbSumaryOnTime.Location = new Point(730, 137);
            lbSumaryOnTime.Name = "lbSumaryOnTime";
            lbSumaryOnTime.Size = new Size(111, 16);
            lbSumaryOnTime.TabIndex = 42;
            lbSumaryOnTime.Text = "PF4XXXXXXXXXX";
            // 
            // lbNumerSerie
            // 
            lbNumerSerie.AutoSize = true;
            lbNumerSerie.Font = new Font("Microsoft Sans Serif", 9.749999F);
            lbNumerSerie.ForeColor = Color.Black;
            lbNumerSerie.Location = new Point(564, 91);
            lbNumerSerie.Name = "lbNumerSerie";
            lbNumerSerie.Size = new Size(107, 16);
            lbNumerSerie.TabIndex = 41;
            lbNumerSerie.Text = "Número de serie";
            // 
            // lbSumaryNumberSerie
            // 
            lbSumaryNumberSerie.AutoSize = true;
            lbSumaryNumberSerie.Font = new Font("Microsoft Sans Serif", 9.749999F);
            lbSumaryNumberSerie.ForeColor = Color.DarkViolet;
            lbSumaryNumberSerie.Location = new Point(730, 91);
            lbSumaryNumberSerie.Name = "lbSumaryNumberSerie";
            lbSumaryNumberSerie.Size = new Size(111, 16);
            lbSumaryNumberSerie.TabIndex = 40;
            lbSumaryNumberSerie.Text = "PF4XXXXXXXXXX";
            // 
            // lbBrandAndModel
            // 
            lbBrandAndModel.AutoSize = true;
            lbBrandAndModel.Font = new Font("Microsoft Sans Serif", 9.749999F);
            lbBrandAndModel.ForeColor = Color.Black;
            lbBrandAndModel.Location = new Point(564, 45);
            lbBrandAndModel.Name = "lbBrandAndModel";
            lbBrandAndModel.Size = new Size(127, 16);
            lbBrandAndModel.TabIndex = 39;
            lbBrandAndModel.Text = "Fabricante / Modelo";
            // 
            // lbSumaryTypeDevice
            // 
            lbSumaryTypeDevice.AutoSize = true;
            lbSumaryTypeDevice.Font = new Font("Microsoft Sans Serif", 9.749999F);
            lbSumaryTypeDevice.ForeColor = Color.DarkViolet;
            lbSumaryTypeDevice.Location = new Point(353, 136);
            lbSumaryTypeDevice.Name = "lbSumaryTypeDevice";
            lbSumaryTypeDevice.Size = new Size(58, 16);
            lbSumaryTypeDevice.TabIndex = 38;
            lbSumaryTypeDevice.Text = "Desktop";
            // 
            // lbTypeDevice
            // 
            lbTypeDevice.AutoSize = true;
            lbTypeDevice.Font = new Font("Microsoft Sans Serif", 9.749999F);
            lbTypeDevice.ForeColor = Color.Black;
            lbTypeDevice.Location = new Point(232, 137);
            lbTypeDevice.Name = "lbTypeDevice";
            lbTypeDevice.Size = new Size(99, 16);
            lbTypeDevice.TabIndex = 37;
            lbTypeDevice.Text = "Tipo de equipo";
            // 
            // lbSumaryCurrentUser
            // 
            lbSumaryCurrentUser.AutoSize = true;
            lbSumaryCurrentUser.Font = new Font("Microsoft Sans Serif", 9.749999F);
            lbSumaryCurrentUser.ForeColor = Color.DarkViolet;
            lbSumaryCurrentUser.Location = new Point(353, 91);
            lbSumaryCurrentUser.Name = "lbSumaryCurrentUser";
            lbSumaryCurrentUser.Size = new Size(54, 16);
            lbSumaryCurrentUser.TabIndex = 36;
            lbSumaryCurrentUser.Text = "Damian";
            // 
            // lbCurrentUser
            // 
            lbCurrentUser.AutoSize = true;
            lbCurrentUser.Font = new Font("Microsoft Sans Serif", 9.749999F);
            lbCurrentUser.ForeColor = Color.Black;
            lbCurrentUser.Location = new Point(232, 92);
            lbCurrentUser.Name = "lbCurrentUser";
            lbCurrentUser.Size = new Size(93, 16);
            lbCurrentUser.TabIndex = 35;
            lbCurrentUser.Text = "Usuario actual";
            // 
            // lbHostname
            // 
            lbHostname.AutoSize = true;
            lbHostname.Font = new Font("Microsoft Sans Serif", 9.749999F);
            lbHostname.ForeColor = Color.Black;
            lbHostname.Location = new Point(232, 47);
            lbHostname.Name = "lbHostname";
            lbHostname.Size = new Size(69, 16);
            lbHostname.TabIndex = 34;
            lbHostname.Text = "Hostname";
            // 
            // lbSumaryModelAndBrand
            // 
            lbSumaryModelAndBrand.AutoSize = true;
            lbSumaryModelAndBrand.Font = new Font("Microsoft Sans Serif", 9.749999F);
            lbSumaryModelAndBrand.ForeColor = Color.DarkViolet;
            lbSumaryModelAndBrand.Location = new Point(730, 45);
            lbSumaryModelAndBrand.Name = "lbSumaryModelAndBrand";
            lbSumaryModelAndBrand.Size = new Size(136, 16);
            lbSumaryModelAndBrand.TabIndex = 33;
            lbSumaryModelAndBrand.Text = "Lenovo / ThinkStation";
            // 
            // lbSumaryHostname
            // 
            lbSumaryHostname.AutoSize = true;
            lbSumaryHostname.BackColor = Color.Transparent;
            lbSumaryHostname.Font = new Font("Microsoft Sans Serif", 9.749999F);
            lbSumaryHostname.ForeColor = Color.DarkViolet;
            lbSumaryHostname.Location = new Point(353, 46);
            lbSumaryHostname.Name = "lbSumaryHostname";
            lbSumaryHostname.Size = new Size(81, 16);
            lbSumaryHostname.TabIndex = 32;
            lbSumaryHostname.Text = "PC-DAMIAN";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(250, 251, 253);
            pnlMain.Controls.Add(materialCard1);
            pnlMain.Controls.Add(materialCard2);
            pnlMain.Controls.Add(materialCard3);
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
            pnlMain.Size = new Size(1500, 900);
            pnlMain.TabIndex = 1;
            pnlMain.Paint += pnlMain_Paint;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(1070, 774);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(390, 230);
            materialCard1.TabIndex = 9;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(677, 595);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(390, 230);
            materialCard2.TabIndex = 8;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(275, 595);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(390, 230);
            materialCard3.TabIndex = 7;
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
            mcrdRam.Location = new Point(1089, 337);
            mcrdRam.Margin = new Padding(14);
            mcrdRam.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mcrdRam.Name = "mcrdRam";
            mcrdRam.Padding = new Padding(14);
            mcrdRam.Size = new Size(390, 230);
            mcrdRam.TabIndex = 6;
            // 
            // lbSumaryRamSlots
            // 
            lbSumaryRamSlots.AutoSize = true;
            lbSumaryRamSlots.Font = new Font("Microsoft Sans Serif", 9.75F);
            lbSumaryRamSlots.Location = new Point(170, 163);
            lbSumaryRamSlots.Name = "lbSumaryRamSlots";
            lbSumaryRamSlots.Size = new Size(43, 16);
            lbSumaryRamSlots.TabIndex = 31;
            lbSumaryRamSlots.Text = "2 de 4";
            // 
            // lbSumaryRamSeed
            // 
            lbSumaryRamSeed.AutoSize = true;
            lbSumaryRamSeed.Font = new Font("Microsoft Sans Serif", 9.75F);
            lbSumaryRamSeed.Location = new Point(170, 127);
            lbSumaryRamSeed.Name = "lbSumaryRamSeed";
            lbSumaryRamSeed.Size = new Size(65, 16);
            lbSumaryRamSeed.TabIndex = 30;
            lbSumaryRamSeed.Text = "5600 MHz";
            // 
            // lbSumaryRamType
            // 
            lbSumaryRamType.AutoSize = true;
            lbSumaryRamType.Font = new Font("Microsoft Sans Serif", 9.75F);
            lbSumaryRamType.Location = new Point(170, 91);
            lbSumaryRamType.Name = "lbSumaryRamType";
            lbSumaryRamType.Size = new Size(44, 16);
            lbSumaryRamType.TabIndex = 29;
            lbSumaryRamType.Text = "DDR5";
            // 
            // lbSumaryCapacity
            // 
            lbSumaryCapacity.AutoSize = true;
            lbSumaryCapacity.Font = new Font("Microsoft Sans Serif", 9.75F);
            lbSumaryCapacity.Location = new Point(170, 55);
            lbSumaryCapacity.Name = "lbSumaryCapacity";
            lbSumaryCapacity.Size = new Size(43, 16);
            lbSumaryCapacity.TabIndex = 28;
            lbSumaryCapacity.Text = "32 GB";
            // 
            // lbRamSlots
            // 
            lbRamSlots.AutoSize = true;
            lbRamSlots.Font = new Font("Microsoft Sans Serif", 9.75F);
            lbRamSlots.Location = new Point(17, 163);
            lbRamSlots.Name = "lbRamSlots";
            lbRamSlots.Size = new Size(85, 16);
            lbRamSlots.TabIndex = 27;
            lbRamSlots.Text = "Slots usados";
            // 
            // lbRamSeed
            // 
            lbRamSeed.AutoSize = true;
            lbRamSeed.Font = new Font("Microsoft Sans Serif", 9.75F);
            lbRamSeed.Location = new Point(17, 127);
            lbRamSeed.Name = "lbRamSeed";
            lbRamSeed.Size = new Size(69, 16);
            lbRamSeed.TabIndex = 26;
            lbRamSeed.Text = "Velocidad";
            // 
            // lbRamType
            // 
            lbRamType.AutoSize = true;
            lbRamType.Font = new Font("Microsoft Sans Serif", 9.75F);
            lbRamType.Location = new Point(17, 91);
            lbRamType.Name = "lbRamType";
            lbRamType.Size = new Size(35, 16);
            lbRamType.TabIndex = 25;
            lbRamType.Text = "Tipo";
            // 
            // lbCapacity
            // 
            lbCapacity.AutoSize = true;
            lbCapacity.Font = new Font("Microsoft Sans Serif", 9.75F);
            lbCapacity.Location = new Point(17, 55);
            lbCapacity.Name = "lbCapacity";
            lbCapacity.Size = new Size(132, 16);
            lbCapacity.TabIndex = 24;
            lbCapacity.Text = "Capacidad instalada";
            // 
            // lbCardRam
            // 
            lbCardRam.AutoSize = true;
            lbCardRam.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCardRam.Location = new Point(71, 22);
            lbCardRam.Name = "lbCardRam";
            lbCardRam.Size = new Size(115, 18);
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
            mcrdMicroprocessor.Location = new Point(677, 337);
            mcrdMicroprocessor.Margin = new Padding(14);
            mcrdMicroprocessor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mcrdMicroprocessor.Name = "mcrdMicroprocessor";
            mcrdMicroprocessor.Padding = new Padding(14);
            mcrdMicroprocessor.Size = new Size(390, 230);
            mcrdMicroprocessor.TabIndex = 6;
            // 
            // lbSumaryMaximumSeed
            // 
            lbSumaryMaximumSeed.AutoSize = true;
            lbSumaryMaximumSeed.Font = new Font("Microsoft Sans Serif", 9.75F);
            lbSumaryMaximumSeed.Location = new Point(159, 199);
            lbSumaryMaximumSeed.Name = "lbSumaryMaximumSeed";
            lbSumaryMaximumSeed.Size = new Size(60, 16);
            lbSumaryMaximumSeed.TabIndex = 21;
            lbSumaryMaximumSeed.Text = "5.40 GHz";
            // 
            // lbMaxmumSeed
            // 
            lbMaxmumSeed.AutoSize = true;
            lbMaxmumSeed.Font = new Font("Microsoft Sans Serif", 9.75F);
            lbMaxmumSeed.Location = new Point(17, 199);
            lbMaxmumSeed.Name = "lbMaxmumSeed";
            lbMaxmumSeed.Size = new Size(119, 16);
            lbMaxmumSeed.TabIndex = 20;
            lbMaxmumSeed.Text = "Velocidad maxima";
            // 
            // lbSumaryBaseSpeed
            // 
            lbSumaryBaseSpeed.AutoSize = true;
            lbSumaryBaseSpeed.Font = new Font("Microsoft Sans Serif", 9.75F);
            lbSumaryBaseSpeed.Location = new Point(159, 163);
            lbSumaryBaseSpeed.Name = "lbSumaryBaseSpeed";
            lbSumaryBaseSpeed.Size = new Size(60, 16);
            lbSumaryBaseSpeed.TabIndex = 19;
            lbSumaryBaseSpeed.Text = "3.40 GHz";
            // 
            // lbSumaryThreads
            // 
            lbSumaryThreads.AutoSize = true;
            lbSumaryThreads.Font = new Font("Microsoft Sans Serif", 9.75F);
            lbSumaryThreads.Location = new Point(159, 127);
            lbSumaryThreads.Name = "lbSumaryThreads";
            lbSumaryThreads.Size = new Size(21, 16);
            lbSumaryThreads.TabIndex = 18;
            lbSumaryThreads.Text = "24";
            // 
            // lbSumaryCores
            // 
            lbSumaryCores.AutoSize = true;
            lbSumaryCores.Font = new Font("Microsoft Sans Serif", 9.75F);
            lbSumaryCores.Location = new Point(159, 91);
            lbSumaryCores.Name = "lbSumaryCores";
            lbSumaryCores.Size = new Size(21, 16);
            lbSumaryCores.TabIndex = 17;
            lbSumaryCores.Text = "12";
            // 
            // lbSumaryNameMicroprocessor
            // 
            lbSumaryNameMicroprocessor.AutoSize = true;
            lbSumaryNameMicroprocessor.Font = new Font("Microsoft Sans Serif", 9.75F);
            lbSumaryNameMicroprocessor.Location = new Point(159, 55);
            lbSumaryNameMicroprocessor.Name = "lbSumaryNameMicroprocessor";
            lbSumaryNameMicroprocessor.Size = new Size(126, 16);
            lbSumaryNameMicroprocessor.TabIndex = 16;
            lbSumaryNameMicroprocessor.Text = "Interl Core i7-13700k";
            // 
            // lbBaseSpeed
            // 
            lbBaseSpeed.AutoSize = true;
            lbBaseSpeed.Font = new Font("Microsoft Sans Serif", 9.75F);
            lbBaseSpeed.Location = new Point(17, 163);
            lbBaseSpeed.Name = "lbBaseSpeed";
            lbBaseSpeed.Size = new Size(103, 16);
            lbBaseSpeed.TabIndex = 15;
            lbBaseSpeed.Text = "Velocidad base";
            // 
            // lbThreads
            // 
            lbThreads.AutoSize = true;
            lbThreads.Font = new Font("Microsoft Sans Serif", 9.75F);
            lbThreads.Location = new Point(17, 127);
            lbThreads.Name = "lbThreads";
            lbThreads.Size = new Size(38, 16);
            lbThreads.TabIndex = 14;
            lbThreads.Text = "Hilos";
            // 
            // lbCores
            // 
            lbCores.AutoSize = true;
            lbCores.Font = new Font("Microsoft Sans Serif", 9.75F);
            lbCores.Location = new Point(17, 91);
            lbCores.Name = "lbCores";
            lbCores.Size = new Size(98, 16);
            lbCores.TabIndex = 13;
            lbCores.Text = "Núcleos físicos";
            // 
            // lnNameMicroprocessor
            // 
            lnNameMicroprocessor.AutoSize = true;
            lnNameMicroprocessor.Font = new Font("Microsoft Sans Serif", 9.75F);
            lnNameMicroprocessor.Location = new Point(17, 55);
            lnNameMicroprocessor.Name = "lnNameMicroprocessor";
            lnNameMicroprocessor.Size = new Size(56, 16);
            lnNameMicroprocessor.TabIndex = 12;
            lnNameMicroprocessor.Text = "Nombre";
            // 
            // lbCardMicroprocessor
            // 
            lbCardMicroprocessor.AutoSize = true;
            lbCardMicroprocessor.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCardMicroprocessor.Location = new Point(66, 22);
            lbCardMicroprocessor.Name = "lbCardMicroprocessor";
            lbCardMicroprocessor.Size = new Size(96, 18);
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
            mcrdSystem.Location = new Point(265, 337);
            mcrdSystem.Margin = new Padding(14);
            mcrdSystem.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mcrdSystem.Name = "mcrdSystem";
            mcrdSystem.Padding = new Padding(14);
            mcrdSystem.Size = new Size(390, 230);
            mcrdSystem.TabIndex = 5;
            // 
            // lbSumaryInstallationDate
            // 
            lbSumaryInstallationDate.AutoSize = true;
            lbSumaryInstallationDate.Location = new Point(163, 199);
            lbSumaryInstallationDate.Name = "lbSumaryInstallationDate";
            lbSumaryInstallationDate.Size = new Size(71, 16);
            lbSumaryInstallationDate.TabIndex = 11;
            lbSumaryInstallationDate.Text = "26/06/2026";
            // 
            // lbInstallationDate
            // 
            lbInstallationDate.AutoSize = true;
            lbInstallationDate.Location = new Point(17, 199);
            lbInstallationDate.Name = "lbInstallationDate";
            lbInstallationDate.Size = new Size(131, 16);
            lbInstallationDate.TabIndex = 10;
            lbInstallationDate.Text = "Fecha de instalación";
            // 
            // lbSumaryArchitecture
            // 
            lbSumaryArchitecture.AutoSize = true;
            lbSumaryArchitecture.Location = new Point(163, 163);
            lbSumaryArchitecture.Name = "lbSumaryArchitecture";
            lbSumaryArchitecture.Size = new Size(45, 16);
            lbSumaryArchitecture.TabIndex = 9;
            lbSumaryArchitecture.Text = "64 bits";
            // 
            // lbSumaryCompilation
            // 
            lbSumaryCompilation.AutoSize = true;
            lbSumaryCompilation.Location = new Point(163, 127);
            lbSumaryCompilation.Name = "lbSumaryCompilation";
            lbSumaryCompilation.Size = new Size(73, 16);
            lbSumaryCompilation.TabIndex = 8;
            lbSumaryCompilation.Text = "26100.1742";
            // 
            // lbSumaryVersion
            // 
            lbSumaryVersion.AutoSize = true;
            lbSumaryVersion.Location = new Point(163, 91);
            lbSumaryVersion.Name = "lbSumaryVersion";
            lbSumaryVersion.Size = new Size(38, 16);
            lbSumaryVersion.TabIndex = 7;
            lbSumaryVersion.Text = "24H2";
            // 
            // lbSumaryEdition
            // 
            lbSumaryEdition.AutoSize = true;
            lbSumaryEdition.Location = new Point(163, 55);
            lbSumaryEdition.Name = "lbSumaryEdition";
            lbSumaryEdition.Size = new Size(102, 16);
            lbSumaryEdition.TabIndex = 6;
            lbSumaryEdition.Text = "Windows 11 pro";
            // 
            // lbArchitecture
            // 
            lbArchitecture.AutoSize = true;
            lbArchitecture.Location = new Point(17, 163);
            lbArchitecture.Name = "lbArchitecture";
            lbArchitecture.Size = new Size(78, 16);
            lbArchitecture.TabIndex = 5;
            lbArchitecture.Text = "Arquitectura";
            // 
            // lbCompilation
            // 
            lbCompilation.AutoSize = true;
            lbCompilation.Location = new Point(17, 127);
            lbCompilation.Name = "lbCompilation";
            lbCompilation.Size = new Size(123, 16);
            lbCompilation.TabIndex = 4;
            lbCompilation.Text = "Compilación (Build)";
            // 
            // lbVersion
            // 
            lbVersion.AutoSize = true;
            lbVersion.Location = new Point(17, 91);
            lbVersion.Name = "lbVersion";
            lbVersion.Size = new Size(53, 16);
            lbVersion.TabIndex = 3;
            lbVersion.Text = "Versión";
            // 
            // lbEdition
            // 
            lbEdition.AutoSize = true;
            lbEdition.Location = new Point(17, 55);
            lbEdition.Name = "lbEdition";
            lbEdition.Size = new Size(52, 16);
            lbEdition.TabIndex = 2;
            lbEdition.Text = "Edición";
            // 
            // lbCardSystem
            // 
            lbCardSystem.AutoSize = true;
            lbCardSystem.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCardSystem.Location = new Point(69, 22);
            lbCardSystem.Name = "lbCardSystem";
            lbCardSystem.Size = new Size(147, 18);
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
            ClientSize = new Size(1500, 900);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDeviceType).EndInit();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            mcrdRam.ResumeLayout(false);
            mcrdRam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbRam).EndInit();
            mcrdMicroprocessor.ResumeLayout(false);
            mcrdMicroprocessor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbMicroProcessor).EndInit();
            mcrdSystem.ResumeLayout(false);
            mcrdSystem.PerformLayout();
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
        private PictureBox pictureBox4;
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
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.MaterialCard materialCard2;
        private ReaLTaiizor.Controls.MaterialCard materialCard3;
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
        private Label label2;
        private Label label3;
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
    }
}
