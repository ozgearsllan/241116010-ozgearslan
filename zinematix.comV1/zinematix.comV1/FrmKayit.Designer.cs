namespace zinematix.comV1
{
    partial class FrmKayit
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
            groupBox1 = new GroupBox();
            btnekle = new Button();
            cbkoltuksy = new ComboBox();
            label8 = new Label();
            label3 = new Label();
            txtsalonad = new TextBox();
            groupBox2 = new GroupBox();
            panelsalon = new FlowLayoutPanel();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            panel1.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.DarkRed;
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
            label1.Size = new Size(165, 31);
            label1.TabIndex = 1;
            label1.Text = " SALON KAYIT ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Snow;
            groupBox1.Controls.Add(btnekle);
            groupBox1.Controls.Add(cbkoltuksy);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtsalonad);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(0, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(569, 127);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // btnekle
            // 
            btnekle.BackColor = Color.DarkRed;
            btnekle.Cursor = Cursors.Hand;
            btnekle.FlatAppearance.BorderSize = 0;
            btnekle.FlatStyle = FlatStyle.Flat;
            btnekle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnekle.ForeColor = Color.Snow;
            btnekle.Location = new Point(380, 44);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(180, 48);
            btnekle.TabIndex = 17;
            btnekle.Text = "EKLE";
            btnekle.UseVisualStyleBackColor = false;
            btnekle.Click += btnekle_Click;
            btnekle.MouseLeave += ayrill;
            btnekle.MouseMove += gell;
            // 
            // cbkoltuksy
            // 
            cbkoltuksy.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cbkoltuksy.ForeColor = Color.OrangeRed;
            cbkoltuksy.FormattingEnabled = true;
            cbkoltuksy.Location = new Point(242, 59);
            cbkoltuksy.Name = "cbkoltuksy";
            cbkoltuksy.Size = new Size(58, 31);
            cbkoltuksy.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Snow;
            label8.ForeColor = Color.DarkRed;
            label8.Location = new Point(6, 30);
            label8.Name = "label8";
            label8.Size = new Size(120, 28);
            label8.TabIndex = 15;
            label8.Text = " SALON ADI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Snow;
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(211, 30);
            label3.Name = "label3";
            label3.Size = new Size(147, 28);
            label3.TabIndex = 2;
            label3.Text = "KOLTUK SAYISI";
            // 
            // txtsalonad
            // 
            txtsalonad.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtsalonad.ForeColor = Color.OrangeRed;
            txtsalonad.Location = new Point(6, 61);
            txtsalonad.Multiline = true;
            txtsalonad.Name = "txtsalonad";
            txtsalonad.Size = new Size(193, 31);
            txtsalonad.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Snow;
            groupBox2.Controls.Add(panelsalon);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(3, 172);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(566, 453);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // panelsalon
            // 
            panelsalon.AutoScroll = true;
            panelsalon.Dock = DockStyle.Fill;
            panelsalon.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            panelsalon.Location = new Point(3, 30);
            panelsalon.Name = "panelsalon";
            panelsalon.Size = new Size(560, 420);
            panelsalon.TabIndex = 11;
            // 
            // FrmKayit
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(569, 637);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(700, 140);
            Margin = new Padding(5);
            Name = "FrmKayit";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmKayit";
            Load += FrmKayit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cbkoltuksy;
        private Label label8;
        private Label label3;
        private TextBox txtsalonad;
        private Button btnekle;
        private GroupBox groupBox2;
        private FlowLayoutPanel panelsalon;
    }
}