namespace zinematix.comV1
{
    partial class filmListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(filmListesi));
            groupBox9 = new GroupBox();
            lblıd = new Label();
            btnyuklee = new Button();
            lblfilm = new Label();
            pbresim = new PictureBox();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbresim).BeginInit();
            SuspendLayout();
            // 
            // groupBox9
            // 
            groupBox9.BackColor = Color.Snow;
            groupBox9.Controls.Add(lblıd);
            groupBox9.Controls.Add(btnyuklee);
            groupBox9.Controls.Add(lblfilm);
            groupBox9.Controls.Add(pbresim);
            groupBox9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox9.ForeColor = Color.DarkRed;
            groupBox9.Location = new Point(1, 3);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(10, 3, 3, 3);
            groupBox9.Size = new Size(163, 228);
            groupBox9.TabIndex = 12;
            groupBox9.TabStop = false;
            groupBox9.Enter += groupBox9_Enter;
            // 
            // lblıd
            // 
            lblıd.AutoSize = true;
            lblıd.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblıd.Location = new Point(15, 147);
            lblıd.Name = "lblıd";
            lblıd.Size = new Size(45, 19);
            lblıd.TabIndex = 6;
            lblıd.Text = "label1";
            lblıd.Visible = false;
            // 
            // btnyuklee
            // 
            btnyuklee.BackColor = Color.Moccasin;
            btnyuklee.Cursor = Cursors.Hand;
            btnyuklee.FlatAppearance.BorderSize = 0;
            btnyuklee.FlatStyle = FlatStyle.Flat;
            btnyuklee.ForeColor = Color.DarkRed;
            btnyuklee.Location = new Point(15, 169);
            btnyuklee.Name = "btnyuklee";
            btnyuklee.Size = new Size(142, 40);
            btnyuklee.TabIndex = 5;
            btnyuklee.Text = "DETAY";
            btnyuklee.UseVisualStyleBackColor = false;
            btnyuklee.Click += btnyuklee_Click;
            // 
            // lblfilm
            // 
            lblfilm.AutoSize = true;
            lblfilm.Location = new Point(13, 0);
            lblfilm.Name = "lblfilm";
            lblfilm.Size = new Size(63, 28);
            lblfilm.TabIndex = 0;
            lblfilm.Text = "label1";
            // 
            // pbresim
            // 
            pbresim.BackColor = Color.Snow;
            pbresim.Image = (Image)resources.GetObject("pbresim.Image");
            pbresim.Location = new Point(21, 33);
            pbresim.Name = "pbresim";
            pbresim.Size = new Size(127, 130);
            pbresim.SizeMode = PictureBoxSizeMode.StretchImage;
            pbresim.TabIndex = 3;
            pbresim.TabStop = false;
            // 
            // filmListesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            Controls.Add(groupBox9);
            Name = "filmListesi";
            Size = new Size(178, 234);
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbresim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox9;
        private Button btnyuklee;
        public Label lblfilm;
        public PictureBox pbresim;
        public Label lblıd;
    }
}
