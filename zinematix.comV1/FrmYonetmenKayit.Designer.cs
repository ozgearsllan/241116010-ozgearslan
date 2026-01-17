namespace zinematix.comV1
{
    partial class FrmYonetmenKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYonetmenKayit));
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            rbkdn = new RadioButton();
            rberkk = new RadioButton();
            label5 = new Label();
            nyil = new NumericUpDown();
            ngun = new NumericUpDown();
            label4 = new Label();
            nay = new NumericUpDown();
            txtsoyad = new TextBox();
            label3 = new Label();
            txtad = new TextBox();
            groupBox2 = new GroupBox();
            btnyukle = new Button();
            pbresim = new PictureBox();
            label6 = new Label();
            groupBox3 = new GroupBox();
            lblkrktr = new Label();
            label2 = new Label();
            txtbygrfi = new TextBox();
            label10 = new Label();
            btnkayitet = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nyil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ngun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nay).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbresim).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 40);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.DarkRed;
            button1.Location = new Point(529, 0);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
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
            label1.Size = new Size(305, 31);
            label1.TabIndex = 1;
            label1.Text = "[YÖNETMEN KAYIT EKRANI]";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(rbkdn);
            groupBox1.Controls.Add(rberkk);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(nyil);
            groupBox1.Controls.Add(ngun);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(nay);
            groupBox1.Controls.Add(txtsoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtad);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(12, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(268, 283);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DarkRed;
            label8.ForeColor = Color.Snow;
            label8.Location = new Point(4, 17);
            label8.Name = "label8";
            label8.Size = new Size(39, 28);
            label8.TabIndex = 15;
            label8.Text = "AD";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(95, 233);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(218, 233);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // rbkdn
            // 
            rbkdn.AutoSize = true;
            rbkdn.FlatStyle = FlatStyle.Flat;
            rbkdn.ForeColor = Color.Snow;
            rbkdn.Location = new Point(132, 233);
            rbkdn.Name = "rbkdn";
            rbkdn.Size = new Size(92, 32);
            rbkdn.TabIndex = 12;
            rbkdn.Text = "KADIN";
            rbkdn.UseVisualStyleBackColor = true;
            rbkdn.CheckedChanged += rbkdn_CheckedChanged;
            // 
            // rberkk
            // 
            rberkk.AutoSize = true;
            rberkk.Checked = true;
            rberkk.FlatStyle = FlatStyle.Flat;
            rberkk.ForeColor = Color.Snow;
            rberkk.Location = new Point(12, 233);
            rberkk.Name = "rberkk";
            rberkk.Size = new Size(88, 32);
            rberkk.TabIndex = 11;
            rberkk.TabStop = true;
            rberkk.Text = "ERKEK";
            rberkk.UseVisualStyleBackColor = true;
            rberkk.CheckedChanged += rberkk_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(6, 202);
            label5.Name = "label5";
            label5.Size = new Size(95, 28);
            label5.TabIndex = 9;
            label5.Text = "CİNSİYET";
            // 
            // nyil
            // 
            nyil.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            nyil.ForeColor = Color.DarkRed;
            nyil.Location = new Point(171, 169);
            nyil.Maximum = new decimal(new int[] { 2300, 0, 0, 0 });
            nyil.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            nyil.Name = "nyil";
            nyil.RightToLeft = RightToLeft.No;
            nyil.Size = new Size(64, 30);
            nyil.TabIndex = 8;
            nyil.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // ngun
            // 
            ngun.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            ngun.ForeColor = Color.DarkRed;
            ngun.Location = new Point(31, 169);
            ngun.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            ngun.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ngun.Name = "ngun";
            ngun.RightToLeft = RightToLeft.No;
            ngun.Size = new Size(64, 30);
            ngun.TabIndex = 6;
            ngun.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(6, 138);
            label4.Name = "label4";
            label4.Size = new Size(155, 28);
            label4.TabIndex = 4;
            label4.Text = "DOĞUM TARİHİ";
            // 
            // nay
            // 
            nay.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            nay.ForeColor = Color.DarkRed;
            nay.Location = new Point(101, 169);
            nay.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nay.Name = "nay";
            nay.RightToLeft = RightToLeft.No;
            nay.Size = new Size(64, 30);
            nay.TabIndex = 7;
            nay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtsoyad
            // 
            txtsoyad.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtsoyad.ForeColor = Color.DarkRed;
            txtsoyad.Location = new Point(31, 105);
            txtsoyad.Multiline = true;
            txtsoyad.Name = "txtsoyad";
            txtsoyad.Size = new Size(204, 30);
            txtsoyad.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkRed;
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(6, 74);
            label3.Name = "label3";
            label3.Size = new Size(75, 28);
            label3.TabIndex = 2;
            label3.Text = "SOYAD";
            // 
            // txtad
            // 
            txtad.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtad.ForeColor = Color.DarkRed;
            txtad.Location = new Point(31, 48);
            txtad.Multiline = true;
            txtad.Name = "txtad";
            txtad.Size = new Size(204, 27);
            txtad.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnyukle);
            groupBox2.Controls.Add(pbresim);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(286, 46);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(254, 283);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // btnyukle
            // 
            btnyukle.BackColor = Color.Snow;
            btnyukle.Cursor = Cursors.Hand;
            btnyukle.FlatAppearance.BorderSize = 0;
            btnyukle.FlatStyle = FlatStyle.Flat;
            btnyukle.ForeColor = Color.DarkRed;
            btnyukle.Location = new Point(0, 233);
            btnyukle.Name = "btnyukle";
            btnyukle.Size = new Size(248, 44);
            btnyukle.TabIndex = 4;
            btnyukle.Text = "YÜKLE";
            btnyukle.UseVisualStyleBackColor = false;
            btnyukle.Click += btnyukle_Click;
            // 
            // pbresim
            // 
            pbresim.BackColor = Color.Snow;
            pbresim.Image = (Image)resources.GetObject("pbresim.Image");
            pbresim.Location = new Point(0, 48);
            pbresim.Name = "pbresim";
            pbresim.Size = new Size(248, 182);
            pbresim.SizeMode = PictureBoxSizeMode.StretchImage;
            pbresim.TabIndex = 2;
            pbresim.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Snow;
            label6.Location = new Point(6, 17);
            label6.Name = "label6";
            label6.Size = new Size(69, 28);
            label6.TabIndex = 1;
            label6.Text = "RESİM";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblkrktr);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtbygrfi);
            groupBox3.Controls.Add(label10);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.Location = new Point(13, 335);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(521, 229);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            // 
            // lblkrktr
            // 
            lblkrktr.BackColor = Color.Snow;
            lblkrktr.ForeColor = Color.DarkRed;
            lblkrktr.Location = new Point(467, 189);
            lblkrktr.Name = "lblkrktr";
            lblkrktr.RightToLeft = RightToLeft.Yes;
            lblkrktr.Size = new Size(45, 28);
            lblkrktr.TabIndex = 3;
            lblkrktr.Text = "300";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(369, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 23);
            label2.TabIndex = 2;
            label2.Text = "max 300 karakter";
            // 
            // txtbygrfi
            // 
            txtbygrfi.Dock = DockStyle.Bottom;
            txtbygrfi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtbygrfi.ForeColor = Color.DarkRed;
            txtbygrfi.Location = new Point(3, 36);
            txtbygrfi.MaxLength = 300;
            txtbygrfi.Multiline = true;
            txtbygrfi.Name = "txtbygrfi";
            txtbygrfi.Size = new Size(515, 190);
            txtbygrfi.TabIndex = 1;
            txtbygrfi.TextChanged += txtbygrfi_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Snow;
            label10.Location = new Point(11, 0);
            label10.Name = "label10";
            label10.Size = new Size(112, 28);
            label10.TabIndex = 0;
            label10.Text = "BİYOGRAFİ";
            // 
            // btnkayitet
            // 
            btnkayitet.BackColor = Color.Snow;
            btnkayitet.Cursor = Cursors.Hand;
            btnkayitet.FlatAppearance.BorderSize = 0;
            btnkayitet.FlatStyle = FlatStyle.Flat;
            btnkayitet.ForeColor = Color.DarkRed;
            btnkayitet.Location = new Point(13, 581);
            btnkayitet.Name = "btnkayitet";
            btnkayitet.Size = new Size(518, 44);
            btnkayitet.TabIndex = 5;
            btnkayitet.Text = "KAYIT EKLE";
            btnkayitet.UseVisualStyleBackColor = false;
            btnkayitet.Click += btnkayitet_Click;
            // 
            // FrmYonetmenKayit
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(569, 637);
            Controls.Add(btnkayitet);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ForeColor = Color.LavenderBlush;
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(700, 140);
            Margin = new Padding(5);
            Name = "FrmYonetmenKayit";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmYonetmenKayit";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nyil).EndInit();
            ((System.ComponentModel.ISupportInitialize)ngun).EndInit();
            ((System.ComponentModel.ISupportInitialize)nay).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbresim).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtad;
        private GroupBox groupBox2;
        private TextBox txtsoyad;
        private Label label3;
        private Label label4;
        private NumericUpDown ngun;
        private RadioButton rberkk;
        private Label label5;
        private NumericUpDown nyil;
        private NumericUpDown nay;
        private PictureBox pictureBox1;
        private RadioButton rbkdn;
        private PictureBox pictureBox2;
        private Label label6;
        private PictureBox pbresim;
        private Button btnyukle;
        private GroupBox groupBox3;
        private TextBox txtbygrfi;
        private Label label10;
        private Label label2;
        private Label lblkrktr;
        private Button btnkayitet;
        private Label label8;
    }
}