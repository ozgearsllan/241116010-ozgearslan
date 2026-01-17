namespace zinematix.comV1
{
    partial class YonetmenListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YonetmenListesi));
            panel1 = new Panel();
            lbladsoyad = new Label();
            lbId = new Label();
            pbresimdetay = new PictureBox();
            btnyukle = new Button();
            pbcnsiyt = new PictureBox();
            lblcnsiyt = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbresimdetay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbcnsiyt).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 86);
            panel1.TabIndex = 0;
            // 
            // lbladsoyad
            // 
            lbladsoyad.AutoSize = true;
            lbladsoyad.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbladsoyad.ForeColor = Color.DarkRed;
            lbladsoyad.Location = new Point(122, 8);
            lbladsoyad.Name = "lbladsoyad";
            lbladsoyad.Size = new Size(73, 31);
            lbladsoyad.TabIndex = 0;
            lbladsoyad.Text = "label1";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbId.ForeColor = Color.DarkRed;
            lbId.Location = new Point(122, 46);
            lbId.Name = "lbId";
            lbId.Size = new Size(27, 31);
            lbId.TabIndex = 2;
            lbId.Text = "0";
            lbId.Visible = false;
            // 
            // pbresimdetay
            // 
            pbresimdetay.Image = (Image)resources.GetObject("pbresimdetay.Image");
            pbresimdetay.Location = new Point(11, 0);
            pbresimdetay.Name = "pbresimdetay";
            pbresimdetay.Size = new Size(76, 79);
            pbresimdetay.SizeMode = PictureBoxSizeMode.StretchImage;
            pbresimdetay.TabIndex = 3;
            pbresimdetay.TabStop = false;
            // 
            // btnyukle
            // 
            btnyukle.BackColor = Color.DarkRed;
            btnyukle.Cursor = Cursors.Hand;
            btnyukle.FlatAppearance.BorderSize = 0;
            btnyukle.FlatStyle = FlatStyle.Flat;
            btnyukle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnyukle.ForeColor = Color.Snow;
            btnyukle.Location = new Point(355, 32);
            btnyukle.Name = "btnyukle";
            btnyukle.Size = new Size(105, 45);
            btnyukle.TabIndex = 5;
            btnyukle.Text = "DETAY";
            btnyukle.UseVisualStyleBackColor = false;
            btnyukle.Click += btnyukle_Click;
            // 
            // pbcnsiyt
            // 
            pbcnsiyt.Image = (Image)resources.GetObject("pbcnsiyt.Image");
            pbcnsiyt.Location = new Point(93, 8);
            pbcnsiyt.Name = "pbcnsiyt";
            pbcnsiyt.Size = new Size(10, 31);
            pbcnsiyt.SizeMode = PictureBoxSizeMode.StretchImage;
            pbcnsiyt.TabIndex = 6;
            pbcnsiyt.TabStop = false;
            pbcnsiyt.Visible = false;
            // 
            // lblcnsiyt
            // 
            lblcnsiyt.AutoSize = true;
            lblcnsiyt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblcnsiyt.ForeColor = Color.DarkRed;
            lblcnsiyt.Location = new Point(246, 46);
            lblcnsiyt.Name = "lblcnsiyt";
            lblcnsiyt.Size = new Size(0, 31);
            lblcnsiyt.TabIndex = 7;
            lblcnsiyt.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGoldenrod;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(466, 32);
            button1.Name = "button1";
            button1.Size = new Size(61, 45);
            button1.TabIndex = 8;
            button1.Text = "SİL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // YonetmenListesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            Controls.Add(button1);
            Controls.Add(lblcnsiyt);
            Controls.Add(pbcnsiyt);
            Controls.Add(btnyukle);
            Controls.Add(pbresimdetay);
            Controls.Add(lbId);
            Controls.Add(lbladsoyad);
            Controls.Add(panel1);
            Name = "YonetmenListesi";
            Size = new Size(536, 86);
            Load += YonetmenListesi_Load;
            ((System.ComponentModel.ISupportInitialize)pbresimdetay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbcnsiyt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        public Label lbladsoyad;
        public Label lbId;
        public PictureBox pbresimdetay;
        private PictureBox pbcnsiyt;
        private Button btnyukle;
        public Label lblcnsiyt;
        private Button button1;
    }
}
