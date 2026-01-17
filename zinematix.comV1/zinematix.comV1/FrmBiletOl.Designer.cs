namespace zinematix.comV1
{
    partial class FrmBiletOl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBiletOl));
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtisim = new TextBox();
            groupBox2 = new GroupBox();
            bltno = new TextBox();
            groupBox3 = new GroupBox();
            cbfilm = new ComboBox();
            groupBox4 = new GroupBox();
            txttelno = new TextBox();
            groupBox5 = new GroupBox();
            lbltarih = new Label();
            cbtarih = new ComboBox();
            groupBox6 = new GroupBox();
            fpsaat = new FlowLayoutPanel();
            lblsaat = new Label();
            groupBox7 = new GroupBox();
            txtkoltuklar = new TextBox();
            groupBox8 = new GroupBox();
            lblssad = new Label();
            cbsalon = new ComboBox();
            groupBox9 = new GroupBox();
            cbblttur = new ComboBox();
            btnbiletal = new Button();
            pictureBox1 = new PictureBox();
            fkoltukpnali = new FlowLayoutPanel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            lblkrm = new Label();
            lblsari = new Label();
            lblbos = new Label();
            lblgelenko = new Label();
            listegelen = new ListBox();
            lbsecilen = new ListBox();
            btntemizle = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(970, 54);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.DarkRed;
            button1.Location = new Point(905, 0);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(65, 54);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.LavenderBlush;
            label1.Location = new Point(5, 8);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(217, 31);
            label1.TabIndex = 1;
            label1.Text = "FİLM KAYIT EKRANI";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Snow;
            groupBox1.Controls.Add(txtisim);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.DarkRed;
            groupBox1.Location = new Point(9, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10, 3, 3, 3);
            groupBox1.Size = new Size(279, 57);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "AD SOYAD";
            // 
            // txtisim
            // 
            txtisim.BorderStyle = BorderStyle.None;
            txtisim.Dock = DockStyle.Bottom;
            txtisim.ForeColor = Color.DarkRed;
            txtisim.Location = new Point(10, 27);
            txtisim.Name = "txtisim";
            txtisim.Size = new Size(266, 27);
            txtisim.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Snow;
            groupBox2.Controls.Add(bltno);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.DarkRed;
            groupBox2.Location = new Point(12, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10, 3, 3, 3);
            groupBox2.Size = new Size(279, 57);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "BİLET NUMARASI";
            // 
            // bltno
            // 
            bltno.BorderStyle = BorderStyle.None;
            bltno.Dock = DockStyle.Bottom;
            bltno.ForeColor = Color.DarkRed;
            bltno.Location = new Point(10, 27);
            bltno.Name = "bltno";
            bltno.Size = new Size(266, 27);
            bltno.TabIndex = 4;
            bltno.TextChanged += bltno_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Snow;
            groupBox3.Controls.Add(cbfilm);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.ForeColor = Color.DarkRed;
            groupBox3.Location = new Point(9, 251);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(10, 3, 3, 3);
            groupBox3.Size = new Size(279, 69);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "FİLM ADI";
            // 
            // cbfilm
            // 
            cbfilm.Dock = DockStyle.Bottom;
            cbfilm.DropDownStyle = ComboBoxStyle.DropDownList;
            cbfilm.FlatStyle = FlatStyle.Flat;
            cbfilm.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cbfilm.ForeColor = Color.DarkRed;
            cbfilm.FormattingEnabled = true;
            cbfilm.Location = new Point(10, 35);
            cbfilm.Name = "cbfilm";
            cbfilm.Size = new Size(266, 31);
            cbfilm.TabIndex = 0;
            cbfilm.SelectedIndexChanged += cbfilm_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Snow;
            groupBox4.Controls.Add(txttelno);
            groupBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox4.ForeColor = Color.DarkRed;
            groupBox4.Location = new Point(9, 188);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(10, 3, 3, 3);
            groupBox4.Size = new Size(279, 57);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "TELEFON NUMARASI ";
            // 
            // txttelno
            // 
            txttelno.BorderStyle = BorderStyle.None;
            txttelno.Dock = DockStyle.Bottom;
            txttelno.ForeColor = Color.DarkRed;
            txttelno.Location = new Point(10, 27);
            txttelno.Name = "txttelno";
            txttelno.Size = new Size(266, 27);
            txttelno.TabIndex = 4;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Snow;
            groupBox5.Controls.Add(lbltarih);
            groupBox5.Controls.Add(cbtarih);
            groupBox5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox5.ForeColor = Color.DarkRed;
            groupBox5.Location = new Point(9, 326);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(10, 3, 3, 3);
            groupBox5.Size = new Size(279, 66);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "TARİH";
            // 
            // lbltarih
            // 
            lbltarih.AutoSize = true;
            lbltarih.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbltarih.ForeColor = Color.Orange;
            lbltarih.Location = new Point(194, 0);
            lbltarih.Name = "lbltarih";
            lbltarih.Size = new Size(79, 19);
            lbltarih.TabIndex = 15;
            lbltarih.Text = "gg/aa/yyyy";
            // 
            // cbtarih
            // 
            cbtarih.Dock = DockStyle.Bottom;
            cbtarih.DropDownStyle = ComboBoxStyle.DropDownList;
            cbtarih.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cbtarih.FormattingEnabled = true;
            cbtarih.Location = new Point(10, 32);
            cbtarih.Name = "cbtarih";
            cbtarih.Size = new Size(266, 31);
            cbtarih.TabIndex = 0;
            cbtarih.SelectedIndexChanged += cbtarih_SelectedIndexChanged;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.Snow;
            groupBox6.Controls.Add(fpsaat);
            groupBox6.Controls.Add(lblsaat);
            groupBox6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox6.ForeColor = Color.DarkRed;
            groupBox6.Location = new Point(9, 398);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(10, 3, 3, 3);
            groupBox6.Size = new Size(276, 93);
            groupBox6.TabIndex = 10;
            groupBox6.TabStop = false;
            groupBox6.Text = "SAAT";
            // 
            // fpsaat
            // 
            fpsaat.AutoScroll = true;
            fpsaat.FlowDirection = FlowDirection.TopDown;
            fpsaat.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            fpsaat.Location = new Point(10, 37);
            fpsaat.Name = "fpsaat";
            fpsaat.Size = new Size(263, 48);
            fpsaat.TabIndex = 15;
            fpsaat.WrapContents = false;
            // 
            // lblsaat
            // 
            lblsaat.AutoSize = true;
            lblsaat.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblsaat.ForeColor = Color.Orange;
            lblsaat.Location = new Point(227, 0);
            lblsaat.Name = "lblsaat";
            lblsaat.Size = new Size(43, 19);
            lblsaat.TabIndex = 16;
            lblsaat.Text = "seans";
            lblsaat.Visible = false;
            // 
            // groupBox7
            // 
            groupBox7.BackColor = Color.Snow;
            groupBox7.Controls.Add(txtkoltuklar);
            groupBox7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox7.ForeColor = Color.DarkRed;
            groupBox7.Location = new Point(5, 628);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(10, 3, 3, 3);
            groupBox7.Size = new Size(283, 62);
            groupBox7.TabIndex = 11;
            groupBox7.TabStop = false;
            groupBox7.Text = "SEÇİLEN KOLTUK";
            // 
            // txtkoltuklar
            // 
            txtkoltuklar.Dock = DockStyle.Bottom;
            txtkoltuklar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtkoltuklar.ForeColor = Color.DarkRed;
            txtkoltuklar.Location = new Point(10, 29);
            txtkoltuklar.Name = "txtkoltuklar";
            txtkoltuklar.Size = new Size(270, 30);
            txtkoltuklar.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.BackColor = Color.Snow;
            groupBox8.Controls.Add(lblssad);
            groupBox8.Controls.Add(cbsalon);
            groupBox8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox8.ForeColor = Color.DarkRed;
            groupBox8.Location = new Point(9, 497);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(10, 3, 3, 3);
            groupBox8.Size = new Size(279, 60);
            groupBox8.TabIndex = 12;
            groupBox8.TabStop = false;
            groupBox8.Text = "SALON ADI";
            // 
            // lblssad
            // 
            lblssad.AutoSize = true;
            lblssad.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblssad.ForeColor = Color.Orange;
            lblssad.Location = new Point(213, 0);
            lblssad.Name = "lblssad";
            lblssad.Size = new Size(61, 19);
            lblssad.TabIndex = 17;
            lblssad.Text = "salonadı";
            lblssad.Visible = false;
            // 
            // cbsalon
            // 
            cbsalon.Dock = DockStyle.Bottom;
            cbsalon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbsalon.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cbsalon.ForeColor = Color.DarkRed;
            cbsalon.FormattingEnabled = true;
            cbsalon.Location = new Point(10, 26);
            cbsalon.Name = "cbsalon";
            cbsalon.Size = new Size(266, 31);
            cbsalon.TabIndex = 0;
            cbsalon.SelectedIndexChanged += cbsalon_SelectedIndexChanged;
            // 
            // groupBox9
            // 
            groupBox9.BackColor = Color.Snow;
            groupBox9.Controls.Add(cbblttur);
            groupBox9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox9.ForeColor = Color.DarkRed;
            groupBox9.Location = new Point(5, 563);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(10, 3, 3, 3);
            groupBox9.Size = new Size(283, 59);
            groupBox9.TabIndex = 13;
            groupBox9.TabStop = false;
            groupBox9.Text = "BİLET TÜRÜ";
            // 
            // cbblttur
            // 
            cbblttur.Dock = DockStyle.Bottom;
            cbblttur.DropDownStyle = ComboBoxStyle.DropDownList;
            cbblttur.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cbblttur.ForeColor = Color.DarkRed;
            cbblttur.FormattingEnabled = true;
            cbblttur.Items.AddRange(new object[] { "YETİŞKİN", "ÖĞRENCİ", "ÇOCUK(3-12)" });
            cbblttur.Location = new Point(10, 25);
            cbblttur.Name = "cbblttur";
            cbblttur.Size = new Size(270, 31);
            cbblttur.TabIndex = 0;
            // 
            // btnbiletal
            // 
            btnbiletal.BackColor = Color.DarkRed;
            btnbiletal.Cursor = Cursors.Hand;
            btnbiletal.FlatAppearance.BorderSize = 0;
            btnbiletal.FlatStyle = FlatStyle.Flat;
            btnbiletal.ForeColor = Color.Snow;
            btnbiletal.Location = new Point(9, 701);
            btnbiletal.Name = "btnbiletal";
            btnbiletal.Size = new Size(276, 46);
            btnbiletal.TabIndex = 14;
            btnbiletal.Text = "BİLET AL";
            btnbiletal.UseVisualStyleBackColor = false;
            btnbiletal.Click += btnbiletal_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(329, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(641, 62);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // fkoltukpnali
            // 
            fkoltukpnali.AutoScroll = true;
            fkoltukpnali.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            fkoltukpnali.ForeColor = Color.DarkRed;
            fkoltukpnali.Location = new Point(327, 125);
            fkoltukpnali.Name = "fkoltukpnali";
            fkoltukpnali.Size = new Size(643, 562);
            fkoltukpnali.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(596, 85);
            label2.Name = "label2";
            label2.Size = new Size(87, 31);
            label2.TabIndex = 20;
            label2.Text = "perde  ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.krm;
            pictureBox2.Location = new Point(748, 705);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.bos;
            pictureBox3.Location = new Point(814, 705);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.sari;
            pictureBox4.Location = new Point(875, 705);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // lblkrm
            // 
            lblkrm.AutoSize = true;
            lblkrm.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblkrm.ForeColor = Color.Red;
            lblkrm.Location = new Point(753, 767);
            lblkrm.Name = "lblkrm";
            lblkrm.Size = new Size(47, 19);
            lblkrm.TabIndex = 21;
            lblkrm.Text = "DOLU";
            // 
            // lblsari
            // 
            lblsari.AutoSize = true;
            lblsari.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblsari.ForeColor = Color.Yellow;
            lblsari.Location = new Point(877, 770);
            lblsari.Name = "lblsari";
            lblsari.Size = new Size(58, 19);
            lblsari.TabIndex = 22;
            lblsari.Text = "SEÇİLDİ";
            // 
            // lblbos
            // 
            lblbos.AutoSize = true;
            lblbos.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblbos.ForeColor = Color.Black;
            lblbos.Location = new Point(823, 770);
            lblbos.Name = "lblbos";
            lblbos.Size = new Size(36, 19);
            lblbos.TabIndex = 23;
            lblbos.Text = "BOŞ";
            // 
            // lblgelenko
            // 
            lblgelenko.AutoSize = true;
            lblgelenko.Location = new Point(644, 716);
            lblgelenko.Name = "lblgelenko";
            lblgelenko.Size = new Size(0, 31);
            lblgelenko.TabIndex = 16;
            lblgelenko.Visible = false;
            // 
            // listegelen
            // 
            listegelen.FormattingEnabled = true;
            listegelen.ItemHeight = 31;
            listegelen.Location = new Point(474, 705);
            listegelen.Name = "listegelen";
            listegelen.Size = new Size(112, 66);
            listegelen.TabIndex = 0;
            listegelen.Visible = false;
            // 
            // lbsecilen
            // 
            lbsecilen.FormattingEnabled = true;
            lbsecilen.ItemHeight = 31;
            lbsecilen.Location = new Point(342, 705);
            lbsecilen.Name = "lbsecilen";
            lbsecilen.Size = new Size(126, 66);
            lbsecilen.TabIndex = 24;
            lbsecilen.Visible = false;
            // 
            // btntemizle
            // 
            btntemizle.BackColor = Color.DarkRed;
            btntemizle.Cursor = Cursors.Hand;
            btntemizle.FlatAppearance.BorderSize = 0;
            btntemizle.FlatStyle = FlatStyle.Flat;
            btntemizle.ForeColor = Color.Snow;
            btntemizle.Location = new Point(9, 751);
            btntemizle.Name = "btntemizle";
            btntemizle.Size = new Size(276, 46);
            btntemizle.TabIndex = 25;
            btntemizle.Text = "TEMİZLE";
            btntemizle.UseVisualStyleBackColor = false;
            btntemizle.Click += btntemizle_Click;
            // 
            // FrmBiletOl
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(970, 798);
            Controls.Add(btntemizle);
            Controls.Add(lbsecilen);
            Controls.Add(listegelen);
            Controls.Add(lblgelenko);
            Controls.Add(lblbos);
            Controls.Add(lblsari);
            Controls.Add(lblkrm);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(fkoltukpnali);
            Controls.Add(pictureBox1);
            Controls.Add(btnbiletal);
            Controls.Add(groupBox9);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(600, 140);
            Margin = new Padding(5);
            Name = "FrmBiletOl";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmBiletOl";
            Load += FrmBiletOl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private GroupBox groupBox1;
        private PictureBox pictureBox13;
        private TextBox txtisim;
        private GroupBox groupBox2;
        private TextBox bltno;
        private GroupBox groupBox3;
        private ComboBox cbfilm;
        private GroupBox groupBox4;
        private TextBox txttelno;
        private GroupBox groupBox5;
        private ComboBox cbtarih;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private GroupBox groupBox8;
        private GroupBox groupBox9;
        private ComboBox cbblttur;
        private ComboBox cbsalon;
        private TextBox txtkoltuklar;
        private Button btnbiletal;
        private Label lbltarih;
        private Label lblsaat;
        private FlowLayoutPanel fpsaat;
        private Label lblssad;
        private PictureBox pictureBox1;
        private FlowLayoutPanel fkoltukpnali;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label lblkrm;
        private Label lblsari;
        private Label lblbos;
        private Label lblgelenko;
        private ListBox listegelen;
        private ListBox lbsecilen;
        private Button btntemizle;
    }
}