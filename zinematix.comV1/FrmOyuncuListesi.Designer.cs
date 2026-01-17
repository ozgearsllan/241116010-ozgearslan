namespace zinematix.comV1
{
    partial class FrmOyuncuListesi
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
            panel1 = new Panel();
            oylis = new Button();
            label1 = new Label();
            panel2 = new Panel();
            txtaramaa = new TextBox();
            label2 = new Label();
            listepaneli = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(oylis);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 40);
            panel1.TabIndex = 7;
            // 
            // oylis
            // 
            oylis.BackColor = Color.Snow;
            oylis.Cursor = Cursors.Hand;
            oylis.Dock = DockStyle.Right;
            oylis.FlatAppearance.BorderSize = 0;
            oylis.FlatStyle = FlatStyle.Flat;
            oylis.ForeColor = Color.Maroon;
            oylis.Location = new Point(529, 0);
            oylis.Name = "oylis";
            oylis.Size = new Size(40, 40);
            oylis.TabIndex = 1;
            oylis.Text = "X";
            oylis.UseVisualStyleBackColor = false;
            oylis.Click += oylis_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.LavenderBlush;
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(272, 31);
            label1.TabIndex = 1;
            label1.Text = "[OYUNCU LİSTE EKRANI]";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MistyRose;
            panel2.Controls.Add(txtaramaa);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(569, 44);
            panel2.TabIndex = 8;
            // 
            // txtaramaa
            // 
            txtaramaa.BackColor = Color.Snow;
            txtaramaa.BorderStyle = BorderStyle.None;
            txtaramaa.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtaramaa.ForeColor = Color.DarkRed;
            txtaramaa.Location = new Point(150, 8);
            txtaramaa.Name = "txtaramaa";
            txtaramaa.Size = new Size(205, 23);
            txtaramaa.TabIndex = 1;
            txtaramaa.TextChanged += txtarama_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(0, 4);
            label2.Name = "label2";
            label2.Size = new Size(143, 28);
            label2.TabIndex = 0;
            label2.Text = "AD VE SOYAD ";
            // 
            // listepaneli
            // 
            listepaneli.AutoScroll = true;
            listepaneli.Dock = DockStyle.Fill;
            listepaneli.Location = new Point(0, 84);
            listepaneli.Name = "listepaneli";
            listepaneli.Size = new Size(569, 469);
            listepaneli.TabIndex = 9;
            // 
            // FrmOyuncuListesi
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.DarkRed;
            ClientSize = new Size(569, 553);
            Controls.Add(listepaneli);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(700, 140);
            Margin = new Padding(5);
            Name = "FrmOyuncuListesi";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmOyuncuListesi";
            Load += FrmOyuncuListesi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button oylis;
        private Label label1;
        private Panel panel2;
        private TextBox txtaramaa;
        private Label label2;
        private FlowLayoutPanel listepaneli;
    }
}