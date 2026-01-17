
namespace zinematix.comV1
{
    partial class formAcilis
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            kllnciadi = new TextBox();
            label3 = new Label();
            btngiris = new Button();
            sifre = new TextBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            lblhesapolustur = new Label();
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
            panel1.Size = new Size(426, 40);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.DarkRed;
            button1.Location = new Point(386, 0);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.LavenderBlush;
            label1.Location = new Point(12, 0);
            label1.Name = "label1";
            label1.Size = new Size(170, 31);
            label1.TabIndex = 1;
            label1.Text = "SinematiX.com";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(0, 59);
            label2.Name = "label2";
            label2.Size = new Size(138, 31);
            label2.TabIndex = 2;
            label2.Text = "YETKİLİ KİŞİ";
            // 
            // kllnciadi
            // 
            kllnciadi.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kllnciadi.ForeColor = Color.DarkRed;
            kllnciadi.Location = new Point(144, 61);
            kllnciadi.Multiline = true;
            kllnciadi.Name = "kllnciadi";
            kllnciadi.Size = new Size(176, 31);
            kllnciadi.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(66, 109);
            label3.Name = "label3";
            label3.Size = new Size(72, 31);
            label3.TabIndex = 4;
            label3.Text = "ŞİFRE";
            // 
            // btngiris
            // 
            btngiris.BackColor = Color.IndianRed;
            btngiris.Cursor = Cursors.Hand;
            btngiris.FlatAppearance.BorderSize = 0;
            btngiris.FlatStyle = FlatStyle.Flat;
            btngiris.ForeColor = Color.LavenderBlush;
            btngiris.Location = new Point(144, 155);
            btngiris.Name = "btngiris";
            btngiris.Size = new Size(176, 43);
            btngiris.TabIndex = 6;
            btngiris.Text = "GİRİŞ YAP";
            btngiris.UseVisualStyleBackColor = false;
            btngiris.Click += btngiris_Click;
            // 
            // sifre
            // 
            sifre.ForeColor = Color.DarkRed;
            sifre.Location = new Point(144, 109);
            sifre.Name = "sifre";
            sifre.Size = new Size(176, 38);
            sifre.TabIndex = 3;
            sifre.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.acikgoz;
            pictureBox1.Location = new Point(283, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(144, 201);
            label4.Name = "label4";
            label4.Size = new Size(176, 30);
            label4.TabIndex = 8;
            label4.Text = "HESABIN YOK MU ?";
            // 
            // lblhesapolustur
            // 
            lblhesapolustur.Cursor = Cursors.Hand;
            lblhesapolustur.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblhesapolustur.ForeColor = Color.DarkSalmon;
            lblhesapolustur.Location = new Point(154, 231);
            lblhesapolustur.Name = "lblhesapolustur";
            lblhesapolustur.Size = new Size(147, 25);
            lblhesapolustur.TabIndex = 9;
            lblhesapolustur.Text = " HESAP OLUŞTUR";
            lblhesapolustur.Click += lblhesapolustur_Click;
            lblhesapolustur.MouseEnter += lblhesapolustur_MouseEnter;
            lblhesapolustur.MouseLeave += lblhesapolustur_MouseLeave;
            // 
            // formAcilis
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(426, 281);
            Controls.Add(lblhesapolustur);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(sifre);
            Controls.Add(btngiris);
            Controls.Add(label3);
            Controls.Add(kllnciadi);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "formAcilis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += formAcilis_Load;
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
        private Label label2;
        private TextBox kllnciadi;
        private Label label3;
        private Button btngiris;
        private TextBox sifre;
        private PictureBox pictureBox1;
        private Label label4;
        private Label lblhesapolustur;
    }
}
