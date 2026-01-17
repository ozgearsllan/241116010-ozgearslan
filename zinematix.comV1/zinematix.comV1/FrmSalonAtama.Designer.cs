namespace zinematix.comV1
{
    partial class FrmSalonAtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalonAtama));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            groupBox8 = new GroupBox();
            cbsalon = new ComboBox();
            lblsecilen = new Label();
            groupBox6 = new GroupBox();
            pictureBox1 = new PictureBox();
            fpsaat = new FlowLayoutPanel();
            groupBox5 = new GroupBox();
            pictureBox4 = new PictureBox();
            nyil = new NumericUpDown();
            ngun = new NumericUpDown();
            nay = new NumericUpDown();
            lbltarih = new Label();
            groupBox3 = new GroupBox();
            pictureBox2 = new PictureBox();
            cbfilm = new ComboBox();
            btntemizle = new Button();
            btnbiletal = new Button();
            groupBox1 = new GroupBox();
            cbdolusaat = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox8.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nyil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ngun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nay).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 40);
            panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.DarkRed;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(211, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 29;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.DarkRed;
            button1.Location = new Point(637, 0);
            button1.Name = "button1";
            button1.Size = new Size(47, 40);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.LavenderBlush;
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(207, 31);
            label1.TabIndex = 1;
            label1.Text = "SALON İŞLEMLERİ";
            // 
            // groupBox8
            // 
            groupBox8.BackColor = Color.Snow;
            groupBox8.Controls.Add(cbsalon);
            groupBox8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox8.ForeColor = Color.DarkRed;
            groupBox8.Location = new Point(9, 121);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(10, 3, 3, 3);
            groupBox8.Size = new Size(281, 69);
            groupBox8.TabIndex = 16;
            groupBox8.TabStop = false;
            groupBox8.Text = "SALON ADI";
            // 
            // cbsalon
            // 
            cbsalon.Dock = DockStyle.Bottom;
            cbsalon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbsalon.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cbsalon.ForeColor = Color.DarkRed;
            cbsalon.FormattingEnabled = true;
            cbsalon.Location = new Point(10, 35);
            cbsalon.Name = "cbsalon";
            cbsalon.Size = new Size(268, 31);
            cbsalon.TabIndex = 0;
            // 
            // lblsecilen
            // 
            lblsecilen.AutoSize = true;
            lblsecilen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblsecilen.ForeColor = Color.Orange;
            lblsecilen.Location = new Point(336, 441);
            lblsecilen.Name = "lblsecilen";
            lblsecilen.Size = new Size(87, 28);
            lblsecilen.TabIndex = 17;
            lblsecilen.Text = "salonadı";
            lblsecilen.Visible = false;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.Snow;
            groupBox6.Controls.Add(pictureBox1);
            groupBox6.Controls.Add(fpsaat);
            groupBox6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox6.ForeColor = Color.DarkRed;
            groupBox6.Location = new Point(299, 46);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(10, 3, 3, 3);
            groupBox6.Size = new Size(385, 363);
            groupBox6.TabIndex = 15;
            groupBox6.TabStop = false;
            groupBox6.Text = "SAAT";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(70, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // fpsaat
            // 
            fpsaat.AutoScroll = true;
            fpsaat.FlowDirection = FlowDirection.TopDown;
            fpsaat.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            fpsaat.ForeColor = Color.DarkRed;
            fpsaat.Location = new Point(10, 37);
            fpsaat.Name = "fpsaat";
            fpsaat.Size = new Size(369, 310);
            fpsaat.TabIndex = 15;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Snow;
            groupBox5.Controls.Add(pictureBox4);
            groupBox5.Controls.Add(nyil);
            groupBox5.Controls.Add(ngun);
            groupBox5.Controls.Add(nay);
            groupBox5.Controls.Add(lbltarih);
            groupBox5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox5.ForeColor = Color.DarkRed;
            groupBox5.Location = new Point(9, 196);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(10, 3, 3, 3);
            groupBox5.Size = new Size(281, 66);
            groupBox5.TabIndex = 14;
            groupBox5.TabStop = false;
            groupBox5.Text = "TARİH";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(68, 1);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(43, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 30;
            pictureBox4.TabStop = false;
            // 
            // nyil
            // 
            nyil.BorderStyle = BorderStyle.None;
            nyil.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            nyil.ForeColor = Color.DarkRed;
            nyil.Location = new Point(186, 31);
            nyil.Maximum = new decimal(new int[] { 2300, 0, 0, 0 });
            nyil.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            nyil.Name = "nyil";
            nyil.RightToLeft = RightToLeft.No;
            nyil.Size = new Size(88, 26);
            nyil.TabIndex = 18;
            nyil.TextAlign = HorizontalAlignment.Center;
            nyil.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // ngun
            // 
            ngun.BorderStyle = BorderStyle.None;
            ngun.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            ngun.ForeColor = Color.DarkRed;
            ngun.Location = new Point(12, 31);
            ngun.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            ngun.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ngun.Name = "ngun";
            ngun.RightToLeft = RightToLeft.No;
            ngun.Size = new Size(80, 26);
            ngun.TabIndex = 16;
            ngun.TextAlign = HorizontalAlignment.Center;
            ngun.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nay
            // 
            nay.BorderStyle = BorderStyle.None;
            nay.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            nay.ForeColor = Color.DarkRed;
            nay.Location = new Point(95, 31);
            nay.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nay.Name = "nay";
            nay.RightToLeft = RightToLeft.No;
            nay.Size = new Size(88, 26);
            nay.TabIndex = 17;
            nay.TextAlign = HorizontalAlignment.Center;
            nay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbltarih
            // 
            lbltarih.AutoSize = true;
            lbltarih.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbltarih.ForeColor = Color.Orange;
            lbltarih.Location = new Point(201, 0);
            lbltarih.Name = "lbltarih";
            lbltarih.Size = new Size(79, 19);
            lbltarih.TabIndex = 15;
            lbltarih.Text = "gg/aa/yyyy";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Snow;
            groupBox3.Controls.Add(pictureBox2);
            groupBox3.Controls.Add(cbfilm);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.ForeColor = Color.DarkRed;
            groupBox3.Location = new Point(9, 56);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(10, 3, 3, 3);
            groupBox3.Size = new Size(284, 59);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "FİLM ADI";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(105, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // cbfilm
            // 
            cbfilm.Dock = DockStyle.Bottom;
            cbfilm.DropDownStyle = ComboBoxStyle.DropDownList;
            cbfilm.FlatStyle = FlatStyle.Flat;
            cbfilm.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cbfilm.ForeColor = Color.DarkRed;
            cbfilm.FormattingEnabled = true;
            cbfilm.Location = new Point(10, 25);
            cbfilm.Name = "cbfilm";
            cbfilm.Size = new Size(271, 31);
            cbfilm.TabIndex = 0;
            cbfilm.SelectedIndexChanged += cbfilm_SelectedIndexChanged;
            // 
            // btntemizle
            // 
            btntemizle.BackColor = Color.DarkRed;
            btntemizle.Cursor = Cursors.Hand;
            btntemizle.FlatAppearance.BorderSize = 0;
            btntemizle.FlatStyle = FlatStyle.Flat;
            btntemizle.ForeColor = Color.Snow;
            btntemizle.Location = new Point(11, 347);
            btntemizle.Name = "btntemizle";
            btntemizle.Size = new Size(281, 62);
            btntemizle.TabIndex = 27;
            btntemizle.Text = "TEMİZLE";
            btntemizle.UseVisualStyleBackColor = false;
            btntemizle.Click += btntemizle_Click;
            // 
            // btnbiletal
            // 
            btnbiletal.BackColor = Color.DarkRed;
            btnbiletal.Cursor = Cursors.Hand;
            btnbiletal.FlatAppearance.BorderSize = 0;
            btnbiletal.FlatStyle = FlatStyle.Flat;
            btnbiletal.ForeColor = Color.Snow;
            btnbiletal.Location = new Point(12, 283);
            btnbiletal.Name = "btnbiletal";
            btnbiletal.Size = new Size(282, 58);
            btnbiletal.TabIndex = 26;
            btnbiletal.Text = "TAMAMLA";
            btnbiletal.UseVisualStyleBackColor = false;
            btnbiletal.Click += btnbiletal_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Snow;
            groupBox1.Controls.Add(cbdolusaat);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.DarkRed;
            groupBox1.Location = new Point(11, 417);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10, 3, 3, 3);
            groupBox1.Size = new Size(281, 69);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "DOLU OLAN SAATLER";
            groupBox1.Visible = false;
            // 
            // cbdolusaat
            // 
            cbdolusaat.Dock = DockStyle.Bottom;
            cbdolusaat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbdolusaat.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cbdolusaat.ForeColor = Color.DarkRed;
            cbdolusaat.FormattingEnabled = true;
            cbdolusaat.Location = new Point(10, 35);
            cbdolusaat.Name = "cbdolusaat";
            cbdolusaat.Size = new Size(268, 31);
            cbdolusaat.TabIndex = 0;
            // 
            // FrmSalonAtama
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(684, 418);
            Controls.Add(lblsecilen);
            Controls.Add(groupBox1);
            Controls.Add(btntemizle);
            Controls.Add(btnbiletal);
            Controls.Add(groupBox8);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ForeColor = Color.DarkRed;
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(500, 210);
            Margin = new Padding(5);
            Name = "FrmSalonAtama";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmSalonAtama";
            Load += FrmSalonAtama_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox8.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)nyil).EndInit();
            ((System.ComponentModel.ISupportInitialize)ngun).EndInit();
            ((System.ComponentModel.ISupportInitialize)nay).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private GroupBox groupBox8;
        private Label lblsecilen;
        private ComboBox cbsalon;
        private GroupBox groupBox6;
        private FlowLayoutPanel fpsaat;
        private GroupBox groupBox5;
        private Label lbltarih;
        private GroupBox groupBox3;
        private ComboBox cbfilm;
        private Button btntemizle;
        private Button btnbiletal;
        private NumericUpDown nyil;
        private NumericUpDown ngun;
        private NumericUpDown nay;
        private GroupBox groupBox1;
        private ComboBox cbdolusaat;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}