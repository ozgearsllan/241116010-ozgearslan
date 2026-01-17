namespace zinematix.comV1
{
    partial class oyuncuListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oyuncuListe));
            btnsil = new Button();
            lblcnsiyt = new Label();
            btnyukle = new Button();
            pbresimdetay = new PictureBox();
            lbId = new Label();
            lbladsoyad = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbresimdetay).BeginInit();
            SuspendLayout();
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.DarkSlateGray;
            btnsil.Cursor = Cursors.Hand;
            btnsil.FlatAppearance.BorderSize = 0;
            btnsil.FlatStyle = FlatStyle.Flat;
            btnsil.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnsil.ForeColor = Color.Snow;
            btnsil.Location = new Point(466, 35);
            btnsil.Margin = new Padding(5);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(61, 45);
            btnsil.TabIndex = 16;
            btnsil.Text = "SİL";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += button1_Click;
            // 
            // lblcnsiyt
            // 
            lblcnsiyt.AutoSize = true;
            lblcnsiyt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblcnsiyt.ForeColor = Color.DarkRed;
            lblcnsiyt.Location = new Point(341, 71);
            lblcnsiyt.Margin = new Padding(5, 0, 5, 0);
            lblcnsiyt.Name = "lblcnsiyt";
            lblcnsiyt.Size = new Size(0, 31);
            lblcnsiyt.TabIndex = 15;
            lblcnsiyt.Visible = false;
            // 
            // btnyukle
            // 
            btnyukle.BackColor = Color.Firebrick;
            btnyukle.Cursor = Cursors.Hand;
            btnyukle.FlatAppearance.BorderSize = 0;
            btnyukle.FlatStyle = FlatStyle.Flat;
            btnyukle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnyukle.ForeColor = Color.Snow;
            btnyukle.Location = new Point(351, 35);
            btnyukle.Margin = new Padding(5);
            btnyukle.Name = "btnyukle";
            btnyukle.Size = new Size(105, 45);
            btnyukle.TabIndex = 13;
            btnyukle.Text = "DETAY";
            btnyukle.UseVisualStyleBackColor = false;
            btnyukle.Click += btnyukle_Click;
            // 
            // pbresimdetay
            // 
            pbresimdetay.Image = (Image)resources.GetObject("pbresimdetay.Image");
            pbresimdetay.Location = new Point(18, 5);
            pbresimdetay.Margin = new Padding(5);
            pbresimdetay.Name = "pbresimdetay";
            pbresimdetay.Size = new Size(79, 75);
            pbresimdetay.SizeMode = PictureBoxSizeMode.StretchImage;
            pbresimdetay.TabIndex = 12;
            pbresimdetay.TabStop = false;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbId.ForeColor = Color.DarkRed;
            lbId.Location = new Point(304, 49);
            lbId.Margin = new Padding(5, 0, 5, 0);
            lbId.Name = "lbId";
            lbId.Size = new Size(27, 31);
            lbId.TabIndex = 11;
            lbId.Text = "0";
            lbId.Visible = false;
            // 
            // lbladsoyad
            // 
            lbladsoyad.AutoSize = true;
            lbladsoyad.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbladsoyad.ForeColor = Color.Firebrick;
            lbladsoyad.Location = new Point(107, 5);
            lbladsoyad.Margin = new Padding(5, 0, 5, 0);
            lbladsoyad.Name = "lbladsoyad";
            lbladsoyad.Size = new Size(73, 31);
            lbladsoyad.TabIndex = 9;
            lbladsoyad.Text = "label1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(8, 87);
            panel1.TabIndex = 10;
            // 
            // oyuncuListe
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            Controls.Add(btnsil);
            Controls.Add(lblcnsiyt);
            Controls.Add(btnyukle);
            Controls.Add(pbresimdetay);
            Controls.Add(lbId);
            Controls.Add(lbladsoyad);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(5);
            Name = "oyuncuListe";
            Size = new Size(535, 87);
            Load += oyuncuListe_Load;
            ((System.ComponentModel.ISupportInitialize)pbresimdetay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsil;
        public Label lblcnsiyt;
        private Button btnyukle;
        public PictureBox pbresimdetay;
        public Label lbId;
        public Label lbladsoyad;
        private Panel panel1;
    }
}
