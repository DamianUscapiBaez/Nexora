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
            pnlMain = new Panel();
            pnlComputerSummary = new Panel();
            lbOnTime = new Label();
            lbSumaryOnTime = new Label();
            pictureBox4 = new PictureBox();
            lbNumerSerie = new Label();
            lbSumaryNumberSerie = new Label();
            label2 = new Label();
            lbSumaryTypeDevice = new Label();
            lbTypeDevice = new Label();
            lbSumaryCurrentUser = new Label();
            lbCurrentUser = new Label();
            lbHostname = new Label();
            lbSumaryModelAndBrand = new Label();
            lbSumaryHostname = new Label();
            pbDeviceType = new PictureBox();
            label1 = new Label();
            lbTitle = new Label();
            pnlTitleBar = new Panel();
            pbClose = new PictureBox();
            pbMinimize = new PictureBox();
            tmrRealTime = new System.Windows.Forms.Timer(components);
            parrotFormHandle1 = new ReaLTaiizor.Controls.ParrotFormHandle();
            pnlMain.SuspendLayout();
            pnlComputerSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDeviceType).BeginInit();
            pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMinimize).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(250, 251, 253);
            pnlMain.Controls.Add(pnlComputerSummary);
            pnlMain.Controls.Add(label1);
            pnlMain.Controls.Add(lbTitle);
            pnlMain.Controls.Add(pnlTitleBar);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            pnlMain.ForeColor = Color.Black;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1300, 715);
            pnlMain.TabIndex = 1;
            pnlMain.Paint += pnlMain_Paint;
            // 
            // pnlComputerSummary
            // 
            pnlComputerSummary.BackColor = Color.White;
            pnlComputerSummary.Controls.Add(lbOnTime);
            pnlComputerSummary.Controls.Add(lbSumaryOnTime);
            pnlComputerSummary.Controls.Add(pictureBox4);
            pnlComputerSummary.Controls.Add(lbNumerSerie);
            pnlComputerSummary.Controls.Add(lbSumaryNumberSerie);
            pnlComputerSummary.Controls.Add(label2);
            pnlComputerSummary.Controls.Add(lbSumaryTypeDevice);
            pnlComputerSummary.Controls.Add(lbTypeDevice);
            pnlComputerSummary.Controls.Add(lbSumaryCurrentUser);
            pnlComputerSummary.Controls.Add(lbCurrentUser);
            pnlComputerSummary.Controls.Add(lbHostname);
            pnlComputerSummary.Controls.Add(lbSumaryModelAndBrand);
            pnlComputerSummary.Controls.Add(lbSumaryHostname);
            pnlComputerSummary.Controls.Add(pbDeviceType);
            pnlComputerSummary.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlComputerSummary.ForeColor = Color.Black;
            pnlComputerSummary.Location = new Point(198, 112);
            pnlComputerSummary.Name = "pnlComputerSummary";
            pnlComputerSummary.Size = new Size(1079, 199);
            pnlComputerSummary.TabIndex = 3;
            pnlComputerSummary.Paint += pnlComputerSummary_Paint;
            // 
            // lbOnTime
            // 
            lbOnTime.AutoSize = true;
            lbOnTime.Font = new Font("SansSerif", 9.749999F);
            lbOnTime.ForeColor = Color.Black;
            lbOnTime.Location = new Point(493, 138);
            lbOnTime.Name = "lbOnTime";
            lbOnTime.Size = new Size(142, 15);
            lbOnTime.TabIndex = 31;
            lbOnTime.Text = "Tiempo activo (Uptime)";
            // 
            // lbSumaryOnTime
            // 
            lbSumaryOnTime.AutoSize = true;
            lbSumaryOnTime.Font = new Font("SansSerif", 9.749999F);
            lbSumaryOnTime.ForeColor = Color.DarkViolet;
            lbSumaryOnTime.Location = new Point(659, 138);
            lbSumaryOnTime.Name = "lbSumaryOnTime";
            lbSumaryOnTime.Size = new Size(121, 15);
            lbSumaryOnTime.TabIndex = 30;
            lbSumaryOnTime.Text = "PF4XXXXXXXXXX";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.fondo_system;
            pictureBox4.Location = new Point(879, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(199, 199);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // lbNumerSerie
            // 
            lbNumerSerie.AutoSize = true;
            lbNumerSerie.Font = new Font("SansSerif", 9.749999F);
            lbNumerSerie.ForeColor = Color.Black;
            lbNumerSerie.Location = new Point(493, 92);
            lbNumerSerie.Name = "lbNumerSerie";
            lbNumerSerie.Size = new Size(102, 15);
            lbNumerSerie.TabIndex = 29;
            lbNumerSerie.Text = "Número de serie";
            // 
            // lbSumaryNumberSerie
            // 
            lbSumaryNumberSerie.AutoSize = true;
            lbSumaryNumberSerie.Font = new Font("SansSerif", 9.749999F);
            lbSumaryNumberSerie.ForeColor = Color.DarkViolet;
            lbSumaryNumberSerie.Location = new Point(659, 92);
            lbSumaryNumberSerie.Name = "lbSumaryNumberSerie";
            lbSumaryNumberSerie.Size = new Size(121, 15);
            lbSumaryNumberSerie.TabIndex = 28;
            lbSumaryNumberSerie.Text = "PF4XXXXXXXXXX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SansSerif", 9.749999F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(493, 46);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 27;
            label2.Text = "Fabricante / Modelo";
            // 
            // lbSumaryTypeDevice
            // 
            lbSumaryTypeDevice.AutoSize = true;
            lbSumaryTypeDevice.Font = new Font("SansSerif", 9.749999F);
            lbSumaryTypeDevice.ForeColor = Color.DarkViolet;
            lbSumaryTypeDevice.Location = new Point(344, 137);
            lbSumaryTypeDevice.Name = "lbSumaryTypeDevice";
            lbSumaryTypeDevice.Size = new Size(62, 15);
            lbSumaryTypeDevice.TabIndex = 26;
            lbSumaryTypeDevice.Text = "Desktopp";
            // 
            // lbTypeDevice
            // 
            lbTypeDevice.AutoSize = true;
            lbTypeDevice.Font = new Font("SansSerif", 9.749999F);
            lbTypeDevice.ForeColor = Color.Black;
            lbTypeDevice.Location = new Point(223, 138);
            lbTypeDevice.Name = "lbTypeDevice";
            lbTypeDevice.Size = new Size(92, 15);
            lbTypeDevice.TabIndex = 25;
            lbTypeDevice.Text = "Tipo de equipo";
            // 
            // lbSumaryCurrentUser
            // 
            lbSumaryCurrentUser.AutoSize = true;
            lbSumaryCurrentUser.Font = new Font("SansSerif", 9.749999F);
            lbSumaryCurrentUser.ForeColor = Color.DarkViolet;
            lbSumaryCurrentUser.Location = new Point(344, 91);
            lbSumaryCurrentUser.Name = "lbSumaryCurrentUser";
            lbSumaryCurrentUser.Size = new Size(51, 15);
            lbSumaryCurrentUser.TabIndex = 24;
            lbSumaryCurrentUser.Text = "Damian";
            // 
            // lbCurrentUser
            // 
            lbCurrentUser.AutoSize = true;
            lbCurrentUser.Font = new Font("SansSerif", 9.749999F);
            lbCurrentUser.ForeColor = Color.Black;
            lbCurrentUser.Location = new Point(223, 92);
            lbCurrentUser.Name = "lbCurrentUser";
            lbCurrentUser.Size = new Size(90, 15);
            lbCurrentUser.TabIndex = 23;
            lbCurrentUser.Text = "Usuario actual";
            // 
            // lbHostname
            // 
            lbHostname.AutoSize = true;
            lbHostname.Font = new Font("SansSerif", 9.749999F);
            lbHostname.ForeColor = Color.Black;
            lbHostname.Location = new Point(223, 47);
            lbHostname.Name = "lbHostname";
            lbHostname.Size = new Size(66, 15);
            lbHostname.TabIndex = 22;
            lbHostname.Text = "Hostname";
            // 
            // lbSumaryModelAndBrand
            // 
            lbSumaryModelAndBrand.AutoSize = true;
            lbSumaryModelAndBrand.Font = new Font("SansSerif", 9.749999F);
            lbSumaryModelAndBrand.ForeColor = Color.DarkViolet;
            lbSumaryModelAndBrand.Location = new Point(659, 46);
            lbSumaryModelAndBrand.Name = "lbSumaryModelAndBrand";
            lbSumaryModelAndBrand.Size = new Size(134, 15);
            lbSumaryModelAndBrand.TabIndex = 2;
            lbSumaryModelAndBrand.Text = "Lenovo / ThinkStation";
            // 
            // lbSumaryHostname
            // 
            lbSumaryHostname.AutoSize = true;
            lbSumaryHostname.BackColor = Color.Transparent;
            lbSumaryHostname.Font = new Font("SansSerif", 9.749999F);
            lbSumaryHostname.ForeColor = Color.DarkViolet;
            lbSumaryHostname.Location = new Point(344, 46);
            lbSumaryHostname.Name = "lbSumaryHostname";
            lbSumaryHostname.Size = new Size(80, 15);
            lbSumaryHostname.TabIndex = 1;
            lbSumaryHostname.Text = "PC-DAMIAN";
            // 
            // pbDeviceType
            // 
            pbDeviceType.Location = new Point(-3, 0);
            pbDeviceType.Name = "pbDeviceType";
            pbDeviceType.Size = new Size(199, 199);
            pbDeviceType.SizeMode = PictureBoxSizeMode.Zoom;
            pbDeviceType.TabIndex = 0;
            pbDeviceType.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("LT Internet", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(198, 80);
            label1.Name = "label1";
            label1.Size = new Size(283, 18);
            label1.TabIndex = 2;
            label1.Text = "información general de hardware y software";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("LT Internet", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.Black;
            lbTitle.Location = new Point(195, 50);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(219, 30);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Resumen del equipo";
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.White;
            pnlTitleBar.Controls.Add(pbClose);
            pnlTitleBar.Controls.Add(pbMinimize);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(1300, 34);
            pnlTitleBar.TabIndex = 0;
            // 
            // pbClose
            // 
            pbClose.Image = Properties.Resources.window_close;
            pbClose.Location = new Point(1266, 6);
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
            pbMinimize.Location = new Point(1236, 6);
            pbMinimize.Name = "pbMinimize";
            pbMinimize.Size = new Size(22, 22);
            pbMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            pbMinimize.TabIndex = 0;
            pbMinimize.TabStop = false;
            pbMinimize.MouseEnter += pbMinimize_MouseEnter;
            pbMinimize.MouseLeave += pbMinimize_MouseLeave;
            // 
            // tmrRealTime
            // 
            tmrRealTime.Tick += TmrRealTime_Tick;
            // 
            // parrotFormHandle1
            // 
            parrotFormHandle1.DockAtTop = true;
            parrotFormHandle1.HandleControl = pnlTitleBar;
            // 
            // frmNexoraAgent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 715);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1032);
            MinimumSize = new Size(190, 40);
            Name = "frmNexoraAgent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nexora Agente";
            TransparencyKey = Color.Fuchsia;
            Load += frmNexoraAgent_Load;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlComputerSummary.ResumeLayout(false);
            pnlComputerSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDeviceType).EndInit();
            pnlTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMinimize).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlMain;
        private Panel pnlTitleBar;
        private PictureBox pbClose;
        private PictureBox pbMinimize;
        private Label lbTitle;
        private Panel pnlComputerSummary;
        private Label label1;
        private PictureBox pbDeviceType;
        private Label lbSumaryHostname;
        private Label lbSumaryModelAndBrand;
        private System.Windows.Forms.Timer tmrRealTime;
        private ReaLTaiizor.Controls.ParrotFormHandle parrotFormHandle1;
        private Label lbCurrentUser;
        private Label lbHostname;
        private Label lbSumaryTypeDevice;
        private Label lbTypeDevice;
        private Label lbSumaryCurrentUser;
        private Label label2;
        private Label lbNumerSerie;
        private Label lbSumaryNumberSerie;
        private PictureBox pictureBox4;
        private Label lbOnTime;
        private Label lbSumaryOnTime;
    }
}
