namespace zinematix.comV1
{
    partial class yListearacı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yListearacı));
            pba = new PictureBox();
            lblAdi = new Label();
            ((System.ComponentModel.ISupportInitialize)pba).BeginInit();
            SuspendLayout();
            // 
            // pba
            // 
            pba.Image = (Image)resources.GetObject("pba.Image");
            pba.Location = new Point(0, 0);
            pba.Name = "pba";
            pba.Size = new Size(30, 33);
            pba.SizeMode = PictureBoxSizeMode.Zoom;
            pba.TabIndex = 0;
            pba.TabStop = false;
            // 
            // lblAdi
            // 
            lblAdi.AutoSize = true;
            lblAdi.Cursor = Cursors.Hand;
            lblAdi.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAdi.ForeColor = Color.DarkRed;
            lblAdi.Location = new Point(36, 6);
            lblAdi.Name = "lblAdi";
            lblAdi.Size = new Size(57, 21);
            lblAdi.TabIndex = 1;
            lblAdi.Text = "label1";
            lblAdi.Click += lblAdi_Click;
            lblAdi.MouseLeave += lblAdi_MouseLeave;
            lblAdi.MouseMove += lblAdi_MouseMove;
            // 
            // yListearacı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            Controls.Add(lblAdi);
            Controls.Add(pba);
            Name = "yListearacı";
            Size = new Size(173, 36);
            Load += yListearacı_Load;
            ((System.ComponentModel.ISupportInitialize)pba).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pba;
        public Label lblAdi;
    }
}
