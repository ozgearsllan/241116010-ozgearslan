namespace zinematix.comV1
{
    partial class liste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(liste));
            pbaa = new PictureBox();
            lblad = new Label();
            ((System.ComponentModel.ISupportInitialize)pbaa).BeginInit();
            SuspendLayout();
            // 
            // pbaa
            // 
            pbaa.Image = (Image)resources.GetObject("pbaa.Image");
            pbaa.Location = new Point(0, 0);
            pbaa.Name = "pbaa";
            pbaa.Size = new Size(30, 33);
            pbaa.SizeMode = PictureBoxSizeMode.Zoom;
            pbaa.TabIndex = 0;
            pbaa.TabStop = false;
            // 
            // lblad
            // 
            lblad.AutoSize = true;
            lblad.Cursor = Cursors.Hand;
            lblad.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblad.ForeColor = Color.DarkRed;
            lblad.Location = new Point(36, 6);
            lblad.Name = "lblad";
            lblad.Size = new Size(57, 21);
            lblad.TabIndex = 1;
            lblad.Text = "label1";
            lblad.Click += lblad_Click;
            lblad.MouseLeave += lblad_MouseLeave_1;
            lblad.MouseMove += lblad_MouseMove_1;
            // 
            // liste
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblad);
            Controls.Add(pbaa);
            Name = "liste";
            Size = new Size(177, 36);
            Load += liste_Load;
            ((System.ComponentModel.ISupportInitialize)pbaa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbaa;
        internal Label lblad;
    }
}
