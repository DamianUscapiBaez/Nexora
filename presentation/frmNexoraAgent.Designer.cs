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
            pnlMain = new Panel();
            pnlComputerSummary = new Panel();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            lbOnTime = new Label();
            lbSumaryOnTime = new Label();
            lbUser = new Label();
            lbSumaryUser = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            lbArquitecture = new Label();
            lbSumaryArquitecture = new Label();
            lbVersion = new Label();
            lbSystem = new Label();
            lbSumaryVersion = new Label();
            lbSumarySystem = new Label();
            pbVersion = new PictureBox();
            pbSystem = new PictureBox();
            lbModel = new Label();
            lbHostname = new Label();
            pbDeviceType = new PictureBox();
            label1 = new Label();
            lbTitle = new Label();
            pnlTitleBar = new Panel();
            pbClose = new PictureBox();
            pbMinimize = new PictureBox();
            pnlMain.SuspendLayout();
            pnlComputerSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVersion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSystem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDeviceType).BeginInit();
            pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMinimize).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.Black;
            pnlMain.Controls.Add(pnlComputerSummary);
            pnlMain.Controls.Add(label1);
            pnlMain.Controls.Add(lbTitle);
            pnlMain.Controls.Add(pnlTitleBar);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1147, 715);
            pnlMain.TabIndex = 1;
            pnlMain.Paint += pnlMain_Paint;
            // 
            // pnlComputerSummary
            // 
            pnlComputerSummary.BackColor = Color.FromArgb(26, 26, 26);
            pnlComputerSummary.Controls.Add(label2);
            pnlComputerSummary.Controls.Add(pictureBox4);
            pnlComputerSummary.Controls.Add(lbOnTime);
            pnlComputerSummary.Controls.Add(lbSumaryOnTime);
            pnlComputerSummary.Controls.Add(lbUser);
            pnlComputerSummary.Controls.Add(lbSumaryUser);
            pnlComputerSummary.Controls.Add(pictureBox2);
            pnlComputerSummary.Controls.Add(pictureBox3);
            pnlComputerSummary.Controls.Add(pictureBox1);
            pnlComputerSummary.Controls.Add(lbArquitecture);
            pnlComputerSummary.Controls.Add(lbSumaryArquitecture);
            pnlComputerSummary.Controls.Add(lbVersion);
            pnlComputerSummary.Controls.Add(lbSystem);
            pnlComputerSummary.Controls.Add(lbSumaryVersion);
            pnlComputerSummary.Controls.Add(lbSumarySystem);
            pnlComputerSummary.Controls.Add(pbVersion);
            pnlComputerSummary.Controls.Add(pbSystem);
            pnlComputerSummary.Controls.Add(lbModel);
            pnlComputerSummary.Controls.Add(lbHostname);
            pnlComputerSummary.Controls.Add(pbDeviceType);
            pnlComputerSummary.Location = new Point(25, 124);
            pnlComputerSummary.Name = "pnlComputerSummary";
            pnlComputerSummary.Size = new Size(1094, 217);
            pnlComputerSummary.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft YaHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(888, 168);
            label2.Name = "label2";
            label2.Size = new Size(184, 36);
            label2.TabIndex = 19;
            label2.Text = "Windows 11";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.fondo_system;
            pictureBox4.Location = new Point(706, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(448, 264);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // lbOnTime
            // 
            lbOnTime.AutoSize = true;
            lbOnTime.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            lbOnTime.ForeColor = Color.White;
            lbOnTime.Location = new Point(249, 186);
            lbOnTime.Name = "lbOnTime";
            lbOnTime.Size = new Size(111, 13);
            lbOnTime.TabIndex = 17;
            lbOnTime.Text = "Tiempo encendido";
            // 
            // lbSumaryOnTime
            // 
            lbSumaryOnTime.AutoSize = true;
            lbSumaryOnTime.Font = new Font("SansSerif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 2);
            lbSumaryOnTime.ForeColor = Color.White;
            lbSumaryOnTime.Location = new Point(372, 185);
            lbSumaryOnTime.Name = "lbSumaryOnTime";
            lbSumaryOnTime.Size = new Size(153, 14);
            lbSumaryOnTime.TabIndex = 16;
            lbSumaryOnTime.Text = "1 dias, 4 horas, 20 minutos";
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            lbUser.ForeColor = Color.White;
            lbUser.Location = new Point(249, 159);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(89, 13);
            lbUser.TabIndex = 15;
            lbUser.Text = "Usuario actual";
            // 
            // lbSumaryUser
            // 
            lbSumaryUser.AutoSize = true;
            lbSumaryUser.Font = new Font("SansSerif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 2);
            lbSumaryUser.ForeColor = Color.White;
            lbSumaryUser.Location = new Point(372, 158);
            lbSumaryUser.Name = "lbSumaryUser";
            lbSumaryUser.Size = new Size(50, 14);
            lbSumaryUser.TabIndex = 14;
            lbSumaryUser.Text = "Usuario";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Cross;
            pictureBox2.Image = Properties.Resources.icon_arquitecture;
            pictureBox2.Location = new Point(208, 180);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Cross;
            pictureBox3.Image = Properties.Resources.icon_tag;
            pictureBox3.Location = new Point(208, 153);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(19, 19);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Cross;
            pictureBox1.Image = Properties.Resources.icon_arquitecture;
            pictureBox1.Location = new Point(209, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(19, 19);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // lbArquitecture
            // 
            lbArquitecture.AutoSize = true;
            lbArquitecture.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            lbArquitecture.ForeColor = Color.White;
            lbArquitecture.Location = new Point(249, 128);
            lbArquitecture.Name = "lbArquitecture";
            lbArquitecture.Size = new Size(76, 13);
            lbArquitecture.TabIndex = 10;
            lbArquitecture.Text = "Arquitectura";
            // 
            // lbSumaryArquitecture
            // 
            lbSumaryArquitecture.AutoSize = true;
            lbSumaryArquitecture.Font = new Font("SansSerif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 2);
            lbSumaryArquitecture.ForeColor = Color.White;
            lbSumaryArquitecture.Location = new Point(372, 128);
            lbSumaryArquitecture.Name = "lbSumaryArquitecture";
            lbSumaryArquitecture.Size = new Size(73, 14);
            lbSumaryArquitecture.TabIndex = 9;
            lbSumaryArquitecture.Text = "Arquitecture";
            // 
            // lbVersion
            // 
            lbVersion.AutoSize = true;
            lbVersion.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            lbVersion.ForeColor = Color.White;
            lbVersion.Location = new Point(249, 98);
            lbVersion.Name = "lbVersion";
            lbVersion.Size = new Size(49, 13);
            lbVersion.TabIndex = 8;
            lbVersion.Text = "Versión";
            // 
            // lbSystem
            // 
            lbSystem.AutoSize = true;
            lbSystem.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            lbSystem.ForeColor = Color.White;
            lbSystem.Location = new Point(249, 67);
            lbSystem.Name = "lbSystem";
            lbSystem.Size = new Size(108, 13);
            lbSystem.TabIndex = 7;
            lbSystem.Text = "Sistema operativo";
            // 
            // lbSumaryVersion
            // 
            lbSumaryVersion.AutoSize = true;
            lbSumaryVersion.Font = new Font("SansSerif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 2);
            lbSumaryVersion.ForeColor = Color.White;
            lbSumaryVersion.Location = new Point(372, 98);
            lbSumaryVersion.Name = "lbSumaryVersion";
            lbSumaryVersion.Size = new Size(49, 14);
            lbSumaryVersion.TabIndex = 6;
            lbSumaryVersion.Text = "Version";
            // 
            // lbSumarySystem
            // 
            lbSumarySystem.AutoSize = true;
            lbSumarySystem.Font = new Font("SansSerif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 2);
            lbSumarySystem.ForeColor = Color.White;
            lbSumarySystem.Location = new Point(372, 67);
            lbSumarySystem.Name = "lbSumarySystem";
            lbSumarySystem.Size = new Size(80, 14);
            lbSumarySystem.TabIndex = 5;
            lbSumarySystem.Text = "NameSystem";
            // 
            // pbVersion
            // 
            pbVersion.Cursor = Cursors.Cross;
            pbVersion.Image = Properties.Resources.icon_tag;
            pbVersion.Location = new Point(209, 93);
            pbVersion.Name = "pbVersion";
            pbVersion.Size = new Size(19, 19);
            pbVersion.SizeMode = PictureBoxSizeMode.Zoom;
            pbVersion.TabIndex = 4;
            pbVersion.TabStop = false;
            // 
            // pbSystem
            // 
            pbSystem.Image = Properties.Resources.icon_windows;
            pbSystem.Location = new Point(209, 67);
            pbSystem.Name = "pbSystem";
            pbSystem.Size = new Size(19, 19);
            pbSystem.SizeMode = PictureBoxSizeMode.Zoom;
            pbSystem.TabIndex = 3;
            pbSystem.TabStop = false;
            // 
            // lbModel
            // 
            lbModel.AutoSize = true;
            lbModel.Font = new Font("SansSerif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 2);
            lbModel.ForeColor = Color.White;
            lbModel.Location = new Point(204, 45);
            lbModel.Name = "lbModel";
            lbModel.Size = new Size(101, 14);
            lbModel.TabIndex = 2;
            lbModel.Text = "Brand and Model";
            // 
            // lbHostname
            // 
            lbHostname.AutoSize = true;
            lbHostname.BackColor = Color.Transparent;
            lbHostname.Font = new Font("SansSerif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 2);
            lbHostname.ForeColor = Color.White;
            lbHostname.Location = new Point(202, 16);
            lbHostname.Name = "lbHostname";
            lbHostname.Size = new Size(96, 19);
            lbHostname.TabIndex = 1;
            lbHostname.Text = "Hostaname";
            // 
            // pbDeviceType
            // 
            pbDeviceType.Location = new Point(14, 16);
            pbDeviceType.Name = "pbDeviceType";
            pbDeviceType.Size = new Size(167, 183);
            pbDeviceType.SizeMode = PictureBoxSizeMode.Zoom;
            pbDeviceType.TabIndex = 0;
            pbDeviceType.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("LT Internet", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 89);
            label1.Name = "label1";
            label1.Size = new Size(200, 18);
            label1.TabIndex = 2;
            label1.Text = "Informacion general del equipo";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("LT Internet", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.White;
            lbTitle.Location = new Point(25, 47);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(228, 30);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Resumen del sistema";
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.White;
            pnlTitleBar.Controls.Add(pbClose);
            pnlTitleBar.Controls.Add(pbMinimize);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(1147, 34);
            pnlTitleBar.TabIndex = 0;
            // 
            // pbClose
            // 
            pbClose.Image = Properties.Resources.window_close;
            pbClose.Location = new Point(1117, 7);
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
            pbMinimize.Location = new Point(1087, 7);
            pbMinimize.Name = "pbMinimize";
            pbMinimize.Size = new Size(22, 22);
            pbMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            pbMinimize.TabIndex = 0;
            pbMinimize.TabStop = false;
            pbMinimize.MouseEnter += pbMinimize_MouseEnter;
            pbMinimize.MouseLeave += pbMinimize_MouseLeave;
            // 
            // frmNexoraAgent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 715);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNexoraAgent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nexora Agente";
            Load += frmNexoraAgent_Load;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlComputerSummary.ResumeLayout(false);
            pnlComputerSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVersion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSystem).EndInit();
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
        private Label lbHostname;
        private Label lbModel;
        private Label lbSumaryVersion;
        private Label lbSumarySystem;
        private PictureBox pbVersion;
        private PictureBox pbSystem;
        private Label lbVersion;
        private Label lbSystem;
        private PictureBox pictureBox1;
        private Label lbArquitecture;
        private Label lbOnTime;
        private Label lbSumaryOnTime;
        private Label lbUser;
        private Label lbSumaryUser;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label2;
        private Label lbSumaryArquitecture;
    }
}
