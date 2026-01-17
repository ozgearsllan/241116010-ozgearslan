namespace zinematix.comV1
{
    partial class salonListesi
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salonListesi));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblsalonad = new Label();
            lblkoltuk = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(7, 70);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseLeave += ayril;
            pictureBox1.MouseMove += gel;
            // 
            // lblsalonad
            // 
            lblsalonad.AutoSize = true;
            lblsalonad.BackColor = Color.Transparent;
            lblsalonad.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblsalonad.ForeColor = Color.Snow;
            lblsalonad.Location = new Point(91, 4);
            lblsalonad.Name = "lblsalonad";
            lblsalonad.Size = new Size(76, 32);
            lblsalonad.TabIndex = 1;
            lblsalonad.Text = "label1";
            lblsalonad.MouseLeave += ayril;
            lblsalonad.MouseMove += gel;
            // 
            // lblkoltuk
            // 
            lblkoltuk.AutoSize = true;
            lblkoltuk.BackColor = Color.Transparent;
            lblkoltuk.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblkoltuk.ForeColor = Color.Snow;
            lblkoltuk.Location = new Point(91, 34);
            lblkoltuk.Name = "lblkoltuk";
            lblkoltuk.Size = new Size(84, 35);
            lblkoltuk.TabIndex = 2;
            lblkoltuk.Text = "label2";
            lblkoltuk.Click += lblkoltuk_Click;
            lblkoltuk.MouseLeave += ayril;
            lblkoltuk.MouseMove += gel;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(70, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.MouseLeave += ayril;
            pictureBox2.MouseMove += gel;
            // 
            // salonListesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            Controls.Add(pictureBox2);
            Controls.Add(lblkoltuk);
            Controls.Add(lblsalonad);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "salonListesi";
            Size = new Size(178, 70);
            Load += salonListesi_Load;
            MouseLeave += ayril;
            MouseMove += gel;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        public Label lblsalonad;
        public Label lblkoltuk;
        private PictureBox pictureBox2;
    }
}
