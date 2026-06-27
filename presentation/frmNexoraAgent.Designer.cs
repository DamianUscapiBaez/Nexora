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
            pnlComputerInformation = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label3 = new Label();
            pnlComputerSummary = new Panel();
            lbSumaryDisk = new Label();
            pbUsageTime = new PictureBox();
            pictureBox4 = new PictureBox();
            lbSumaryOnTime = new Label();
            lbSumaryRam = new Label();
            pbDisk = new PictureBox();
            pbRam = new PictureBox();
            pbGpu = new PictureBox();
            lbSumaryGpu = new Label();
            lbSumaryMicroprocessor = new Label();
            lbSumarySystem = new Label();
            pbMicroprocessor = new PictureBox();
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
            pnlComputerInformation.SuspendLayout();
            pnlComputerSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUsageTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDisk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGpu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMicroprocessor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSystem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDeviceType).BeginInit();
            pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMinimize).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(3, 9, 23);
            pnlMain.Controls.Add(pnlComputerInformation);
            pnlMain.Controls.Add(pnlComputerSummary);
            pnlMain.Controls.Add(label1);
            pnlMain.Controls.Add(lbTitle);
            pnlMain.Controls.Add(pnlTitleBar);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            pnlMain.ForeColor = Color.White;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1076, 715);
            pnlMain.TabIndex = 1;
            pnlMain.Paint += pnlMain_Paint;
            // 
            // pnlComputerInformation
            // 
            pnlComputerInformation.BackColor = Color.FromArgb(26, 26, 26);
            pnlComputerInformation.Controls.Add(label4);
            pnlComputerInformation.Controls.Add(label5);
            pnlComputerInformation.Controls.Add(label6);
            pnlComputerInformation.Controls.Add(label7);
            pnlComputerInformation.Controls.Add(label8);
            pnlComputerInformation.Controls.Add(label9);
            pnlComputerInformation.Controls.Add(label10);
            pnlComputerInformation.Controls.Add(label11);
            pnlComputerInformation.Controls.Add(label12);
            pnlComputerInformation.Controls.Add(label13);
            pnlComputerInformation.Controls.Add(label3);
            pnlComputerInformation.Location = new Point(25, 362);
            pnlComputerInformation.Name = "pnlComputerInformation";
            pnlComputerInformation.Size = new Size(315, 324);
            pnlComputerInformation.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(26, 188);
            label4.Name = "label4";
            label4.Size = new Size(111, 13);
            label4.TabIndex = 39;
            label4.Text = "Tiempo encendido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SansSerif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 2);
            label5.ForeColor = Color.White;
            label5.Location = new Point(149, 187);
            label5.Name = "label5";
            label5.Size = new Size(153, 14);
            label5.TabIndex = 38;
            label5.Text = "1 dias, 4 horas, 20 minutos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(26, 161);
            label6.Name = "label6";
            label6.Size = new Size(89, 13);
            label6.TabIndex = 37;
            label6.Text = "Usuario actual";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("SansSerif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 2);
            label7.ForeColor = Color.White;
            label7.Location = new Point(149, 160);
            label7.Name = "label7";
            label7.Size = new Size(50, 14);
            label7.TabIndex = 36;
            label7.Text = "Usuario";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(26, 130);
            label8.Name = "label8";
            label8.Size = new Size(76, 13);
            label8.TabIndex = 35;
            label8.Text = "Arquitectura";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("SansSerif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 2);
            label9.ForeColor = Color.White;
            label9.Location = new Point(149, 130);
            label9.Name = "label9";
            label9.Size = new Size(73, 14);
            label9.TabIndex = 34;
            label9.Text = "Arquitecture";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(26, 100);
            label10.Name = "label10";
            label10.Size = new Size(48, 13);
            label10.TabIndex = 33;
            label10.Text = "Modelo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(26, 69);
            label11.Name = "label11";
            label11.Size = new Size(67, 13);
            label11.TabIndex = 32;
            label11.Text = "Fabricante";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("SansSerif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 2);
            label12.ForeColor = Color.White;
            label12.Location = new Point(149, 100);
            label12.Name = "label12";
            label12.Size = new Size(49, 14);
            label12.TabIndex = 31;
            label12.Text = "Version";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("SansSerif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 2);
            label13.ForeColor = Color.White;
            label13.Location = new Point(149, 69);
            label13.Name = "label13";
            label13.Size = new Size(80, 14);
            label13.TabIndex = 30;
            label13.Text = "NameSystem";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("LT Internet", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(26, 23);
            label3.Name = "label3";
            label3.Size = new Size(155, 18);
            label3.TabIndex = 6;
            label3.Text = "Informacion del sistema";
            // 
            // pnlComputerSummary
            // 
            pnlComputerSummary.BackColor = Color.FromArgb(7, 18, 30);
            pnlComputerSummary.Controls.Add(lbSumaryDisk);
            pnlComputerSummary.Controls.Add(pbUsageTime);
            pnlComputerSummary.Controls.Add(pictureBox4);
            pnlComputerSummary.Controls.Add(lbSumaryOnTime);
            pnlComputerSummary.Controls.Add(lbSumaryRam);
            pnlComputerSummary.Controls.Add(pbDisk);
            pnlComputerSummary.Controls.Add(pbRam);
            pnlComputerSummary.Controls.Add(pbGpu);
            pnlComputerSummary.Controls.Add(lbSumaryGpu);
            pnlComputerSummary.Controls.Add(lbSumaryMicroprocessor);
            pnlComputerSummary.Controls.Add(lbSumarySystem);
            pnlComputerSummary.Controls.Add(pbMicroprocessor);
            pnlComputerSummary.Controls.Add(pbSystem);
            pnlComputerSummary.Controls.Add(lbModel);
            pnlComputerSummary.Controls.Add(lbHostname);
            pnlComputerSummary.Controls.Add(pbDeviceType);
            pnlComputerSummary.Location = new Point(25, 111);
            pnlComputerSummary.Name = "pnlComputerSummary";
            pnlComputerSummary.Size = new Size(1024, 178);
            pnlComputerSummary.TabIndex = 3;
            // 
            // lbSumaryDisk
            // 
            lbSumaryDisk.AutoSize = true;
            lbSumaryDisk.Font = new Font("SansSerif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 2);
            lbSumaryDisk.ForeColor = Color.White;
            lbSumaryDisk.Location = new Point(513, 98);
            lbSumaryDisk.Name = "lbSumaryDisk";
            lbSumaryDisk.Size = new Size(166, 14);
            lbSumaryDisk.TabIndex = 21;
            lbSumaryDisk.Text = "1.86 TB (SSD NVMe + SATA)";
            // 
            // pbUsageTime
            // 
            pbUsageTime.Cursor = Cursors.Cross;
            pbUsageTime.Image = Properties.Resources.icon_timer;
            pbUsageTime.Location = new Point(470, 122);
            pbUsageTime.Name = "pbUsageTime";
            pbUsageTime.Size = new Size(19, 19);
            pbUsageTime.SizeMode = PictureBoxSizeMode.Zoom;
            pbUsageTime.TabIndex = 20;
            pbUsageTime.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.fondo_system;
            pictureBox4.Location = new Point(730, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(305, 181);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // lbSumaryOnTime
            // 
            lbSumaryOnTime.AutoSize = true;
            lbSumaryOnTime.Font = new Font("SansSerif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 2);
            lbSumaryOnTime.ForeColor = Color.White;
            lbSumaryOnTime.Location = new Point(513, 127);
            lbSumaryOnTime.Name = "lbSumaryOnTime";
            lbSumaryOnTime.Size = new Size(153, 14);
            lbSumaryOnTime.TabIndex = 16;
            lbSumaryOnTime.Text = "1 dias, 4 horas, 20 minutos";
            // 
            // lbSumaryRam
            // 
            lbSumaryRam.AutoSize = true;
            lbSumaryRam.Font = new Font("SansSerif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 2);
            lbSumaryRam.ForeColor = Color.White;
            lbSumaryRam.Location = new Point(513, 72);
            lbSumaryRam.Name = "lbSumaryRam";
            lbSumaryRam.Size = new Size(106, 14);
            lbSumaryRam.TabIndex = 14;
            lbSumaryRam.Text = "32 GB DRR5 MHz";
            // 
            // pbDisk
            // 
            pbDisk.Cursor = Cursors.Cross;
            pbDisk.Image = Properties.Resources.icon_disk;
            pbDisk.Location = new Point(470, 93);
            pbDisk.Name = "pbDisk";
            pbDisk.Size = new Size(19, 19);
            pbDisk.SizeMode = PictureBoxSizeMode.Zoom;
            pbDisk.TabIndex = 13;
            pbDisk.TabStop = false;
            // 
            // pbRam
            // 
            pbRam.Cursor = Cursors.Cross;
            pbRam.Image = Properties.Resources.icon_ram;
            pbRam.Location = new Point(470, 67);
            pbRam.Name = "pbRam";
            pbRam.Size = new Size(19, 19);
            pbRam.SizeMode = PictureBoxSizeMode.Zoom;
            pbRam.TabIndex = 12;
            pbRam.TabStop = false;
            // 
            // pbGpu
            // 
            pbGpu.Cursor = Cursors.Cross;
            pbGpu.Image = Properties.Resources.icon_gpu;
            pbGpu.Location = new Point(209, 122);
            pbGpu.Name = "pbGpu";
            pbGpu.Size = new Size(19, 19);
            pbGpu.SizeMode = PictureBoxSizeMode.Zoom;
            pbGpu.TabIndex = 11;
            pbGpu.TabStop = false;
            // 
            // lbSumaryGpu
            // 
            lbSumaryGpu.AutoSize = true;
            lbSumaryGpu.Font = new Font("SansSerif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 2);
            lbSumaryGpu.ForeColor = Color.White;
            lbSumaryGpu.Location = new Point(247, 127);
            lbSumaryGpu.Name = "lbSumaryGpu";
            lbSumaryGpu.Size = new Size(155, 14);
            lbSumaryGpu.TabIndex = 9;
            lbSumaryGpu.Text = "NVIDIA GeForce RTX 4070";
            // 
            // lbSumaryMicroprocessor
            // 
            lbSumaryMicroprocessor.AutoSize = true;
            lbSumaryMicroprocessor.Font = new Font("SansSerif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 2);
            lbSumaryMicroprocessor.ForeColor = Color.White;
            lbSumaryMicroprocessor.Location = new Point(247, 98);
            lbSumaryMicroprocessor.Name = "lbSumaryMicroprocessor";
            lbSumaryMicroprocessor.Size = new Size(118, 14);
            lbSumaryMicroprocessor.TabIndex = 6;
            lbSumaryMicroprocessor.Text = "Intel Core i7-13700k";
            // 
            // lbSumarySystem
            // 
            lbSumarySystem.AutoSize = true;
            lbSumarySystem.Font = new Font("SansSerif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 2);
            lbSumarySystem.ForeColor = Color.White;
            lbSumarySystem.Location = new Point(247, 72);
            lbSumarySystem.Name = "lbSumarySystem";
            lbSumarySystem.Size = new Size(80, 14);
            lbSumarySystem.TabIndex = 5;
            lbSumarySystem.Text = "NameSystem";
            // 
            // pbMicroprocessor
            // 
            pbMicroprocessor.Cursor = Cursors.Cross;
            pbMicroprocessor.Image = Properties.Resources.icon_microprocessor;
            pbMicroprocessor.Location = new Point(209, 93);
            pbMicroprocessor.Name = "pbMicroprocessor";
            pbMicroprocessor.Size = new Size(19, 19);
            pbMicroprocessor.SizeMode = PictureBoxSizeMode.Zoom;
            pbMicroprocessor.TabIndex = 4;
            pbMicroprocessor.TabStop = false;
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
            lbHostname.Size = new Size(87, 19);
            lbHostname.TabIndex = 1;
            lbHostname.Text = "Hostname";
            // 
            // pbDeviceType
            // 
            pbDeviceType.Location = new Point(14, 16);
            pbDeviceType.Name = "pbDeviceType";
            pbDeviceType.Size = new Size(167, 142);
            pbDeviceType.SizeMode = PictureBoxSizeMode.Zoom;
            pbDeviceType.TabIndex = 0;
            pbDeviceType.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("LT Internet", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 79);
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
            lbTitle.Location = new Point(22, 49);
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
            pnlTitleBar.Size = new Size(1076, 34);
            pnlTitleBar.TabIndex = 0;
            // 
            // pbClose
            // 
            pbClose.Image = Properties.Resources.window_close;
            pbClose.Location = new Point(1045, 6);
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
            pbMinimize.Location = new Point(1015, 6);
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
            ClientSize = new Size(1076, 715);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNexoraAgent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nexora Agente";
            Load += frmNexoraAgent_Load;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlComputerInformation.ResumeLayout(false);
            pnlComputerInformation.PerformLayout();
            pnlComputerSummary.ResumeLayout(false);
            pnlComputerSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbUsageTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDisk).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRam).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGpu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMicroprocessor).EndInit();
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
        private Label lbSumaryMicroprocessor;
        private Label lbSumarySystem;
        private PictureBox pbMicroprocessor;
        private PictureBox pbSystem;
        private PictureBox pbGpu;
        private Label lbSumaryOnTime;
        private Label lbSumaryRam;
        private PictureBox pbDisk;
        private PictureBox pbRam;
        private PictureBox pictureBox4;
        private Label lbSumaryGpu;
        private Panel pnlComputerInformation;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label3;
        private Label lbSumaryDisk;
        private PictureBox pbUsageTime;
    }
}
