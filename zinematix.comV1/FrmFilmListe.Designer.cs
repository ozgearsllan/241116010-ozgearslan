namespace zinematix.comV1
{
    partial class FrmFilmListe
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
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            txtaramafilm = new TextBox();
            label2 = new Label();
            flistepaneli = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 47);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Maroon;
            button1.Location = new Point(534, 0);
            button1.Name = "button1";
            button1.Size = new Size(40, 47);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.LavenderBlush;
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(147, 31);
            label1.TabIndex = 1;
            label1.Text = "FİLM LİSTESİ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MistyRose;
            panel2.Controls.Add(txtaramafilm);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(577, 44);
            panel2.TabIndex = 5;
            // 
            // txtaramafilm
            // 
            txtaramafilm.BackColor = Color.Snow;
            txtaramafilm.BorderStyle = BorderStyle.None;
            txtaramafilm.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtaramafilm.ForeColor = Color.DarkRed;
            txtaramafilm.Location = new Point(150, 8);
            txtaramafilm.Name = "txtaramafilm";
            txtaramafilm.Size = new Size(205, 23);
            txtaramafilm.TabIndex = 1;
            txtaramafilm.TextChanged += txtaramafilm_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(7, 8);
            label2.Name = "label2";
            label2.Size = new Size(143, 28);
            label2.TabIndex = 0;
            label2.Text = "AD VE SOYAD ";
            // 
            // flistepaneli
            // 
            flistepaneli.AutoScroll = true;
            flistepaneli.Location = new Point(0, 84);
            flistepaneli.Name = "flistepaneli";
            flistepaneli.Size = new Size(577, 488);
            flistepaneli.TabIndex = 3;
            // 
            // FrmFilmListe
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(577, 572);
            Controls.Add(panel2);
            Controls.Add(flistepaneli);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ForeColor = Color.Snow;
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(700, 140);
            Margin = new Padding(5);
            Name = "FrmFilmListe";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmFilmListe";
            Load += FrmFilmListe_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Panel panel2;
        private TextBox txtaramafilm;
        private Label label2;
        private FlowLayoutPanel flistepaneli;
    }
}