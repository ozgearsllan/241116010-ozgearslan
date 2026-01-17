namespace zinematix.comV1
{
    partial class FrmYonetmenListesi
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
            txtarama = new TextBox();
            label2 = new Label();
            listepaneli = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.Size = new Size(569, 40);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Maroon;
            button1.Location = new Point(529, 0);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
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
            label1.Size = new Size(301, 31);
            label1.TabIndex = 1;
            label1.Text = "[YÖNETMEN LİSTE EKRANI]";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MistyRose;
            panel2.Controls.Add(txtarama);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(569, 44);
            panel2.TabIndex = 4;
            // 
            // txtarama
            // 
            txtarama.BackColor = Color.Snow;
            txtarama.BorderStyle = BorderStyle.None;
            txtarama.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtarama.ForeColor = Color.DarkRed;
            txtarama.Location = new Point(150, 8);
            txtarama.Name = "txtarama";
            txtarama.Size = new Size(205, 23);
            txtarama.TabIndex = 1;
            txtarama.TextChanged += txtarama_TextChanged;
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
            label2.Click += label2_Click;
            // 
            // listepaneli
            // 
            listepaneli.AutoScroll = true;
            listepaneli.BackColor = Color.DarkRed;
            listepaneli.Dock = DockStyle.Fill;
            listepaneli.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            listepaneli.Location = new Point(0, 84);
            listepaneli.Name = "listepaneli";
            listepaneli.Size = new Size(569, 553);
            listepaneli.TabIndex = 0;
            listepaneli.Paint += listepaneli_Paint;
            // 
            // FrmYonetmenListesi
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(569, 637);
            Controls.Add(listepaneli);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(700, 140);
            Margin = new Padding(5);
            Name = "FrmYonetmenListesi";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmYonetmenListesi";
            Load += FrmYonetmenListesi_Load;
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
        private FlowLayoutPanel listepaneli;
        private Label label2;
        private TextBox txtarama;
    }
}