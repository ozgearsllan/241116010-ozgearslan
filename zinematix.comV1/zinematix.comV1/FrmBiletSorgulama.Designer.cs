namespace zinematix.comV1
{
    partial class FrmBiletSorgulama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBiletSorgulama));
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtbiletno = new TextBox();
            button2 = new Button();
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
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(510, 40);
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
            button1.Location = new Point(455, 0);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(55, 40);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(5, 8);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 31);
            label1.TabIndex = 1;
            label1.Text = "BİLET SORGULAMA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSalmon;
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(25, 91);
            label2.Name = "label2";
            label2.Size = new Size(196, 31);
            label2.TabIndex = 3;
            label2.Text = "BİLET NUMARASI";
            // 
            // txtbiletno
            // 
            txtbiletno.BorderStyle = BorderStyle.FixedSingle;
            txtbiletno.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtbiletno.ForeColor = Color.DarkRed;
            txtbiletno.Location = new Point(241, 90);
            txtbiletno.Name = "txtbiletno";
            txtbiletno.Size = new Size(248, 32);
            txtbiletno.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.Snow;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.DarkRed;
            button2.Location = new Point(241, 130);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(248, 43);
            button2.TabIndex = 5;
            button2.Text = "SORGULA";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkSalmon;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(510, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FrmBiletSorgulama
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(510, 218);
            Controls.Add(button2);
            Controls.Add(txtbiletno);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ForeColor = Color.Snow;
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(600, 250);
            Margin = new Padding(5);
            Name = "FrmBiletSorgulama";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmBiletSorgulama";
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
        private TextBox txtbiletno;
        private Button button2;
        private PictureBox pictureBox1;
    }
}