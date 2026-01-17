namespace zinematix.comV1
{
    partial class FrmKullancıOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullancıOlustur));
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            txtSifre = new TextBox();
            btngiris = new Button();
            txtAdsoyad = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtKullaniciAdi = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.Size = new Size(556, 40);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.DarkRed;
            button1.Location = new Point(507, 0);
            button1.Name = "button1";
            button1.Size = new Size(49, 40);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.LavenderBlush;
            label1.Location = new Point(10, 3);
            label1.Name = "label1";
            label1.Size = new Size(172, 32);
            label1.TabIndex = 1;
            label1.Text = "SinematiX.com";
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtSifre.ForeColor = Color.DarkRed;
            txtSifre.Location = new Point(231, 201);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(192, 34);
            txtSifre.TabIndex = 7;
            // 
            // btngiris
            // 
            btngiris.BackColor = Color.IndianRed;
            btngiris.Cursor = Cursors.Hand;
            btngiris.FlatAppearance.BorderSize = 0;
            btngiris.FlatStyle = FlatStyle.Flat;
            btngiris.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btngiris.ForeColor = Color.Snow;
            btngiris.Location = new Point(146, 259);
            btngiris.Name = "btngiris";
            btngiris.Size = new Size(219, 55);
            btngiris.TabIndex = 9;
            btngiris.Text = "OLUŞTUR";
            btngiris.UseVisualStyleBackColor = false;
            btngiris.Click += btngiris_Click;
            // 
            // txtAdsoyad
            // 
            txtAdsoyad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtAdsoyad.ForeColor = Color.DarkRed;
            txtAdsoyad.Location = new Point(230, 88);
            txtAdsoyad.Multiline = true;
            txtAdsoyad.Name = "txtAdsoyad";
            txtAdsoyad.Size = new Size(198, 35);
            txtAdsoyad.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkRed;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(146, 201);
            label3.Name = "label3";
            label3.Size = new Size(84, 31);
            label3.TabIndex = 11;
            label3.Text = "ŞİFRE :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkRed;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(48, 145);
            label2.Name = "label2";
            label2.Size = new Size(185, 31);
            label2.TabIndex = 10;
            label2.Text = "KULLANICI ADI :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkRed;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(87, 92);
            label4.Name = "label4";
            label4.Size = new Size(137, 31);
            label4.TabIndex = 12;
            label4.Text = "AD SOYAD :";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtKullaniciAdi.ForeColor = Color.DarkRed;
            txtKullaniciAdi.Location = new Point(230, 147);
            txtKullaniciAdi.Multiline = true;
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(198, 35);
            txtKullaniciAdi.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(553, 360);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // FrmKullancıOlustur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(556, 396);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSifre);
            Controls.Add(btngiris);
            Controls.Add(txtAdsoyad);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmKullancıOlustur";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmKullancıOlustur";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private TextBox txtSifre;
        private Button btngiris;
        private TextBox txtAdsoyad;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox txtKullaniciAdi;
        private PictureBox pictureBox1;
    }
}