



using Microsoft.Data.SqlClient;

namespace zinematix.comV1
{
    public partial class formAcilis : Form
    {
        public formAcilis()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=sinematix.db; Integrated Security=True;Encrypt=False;TrustServerCertificate=True;");


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkSalmon;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkRed;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (sifre.UseSystemPasswordChar)
            {
                sifre.UseSystemPasswordChar = false;
                pictureBox1.Image = Properties.Resources.acikgoz;
            }
            else
            {
                sifre.UseSystemPasswordChar = true;
                pictureBox1.Image = Properties.Resources.eye_closed_icon_11550225620ajweggaqlk;
            }



        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sorgula = new SqlCommand("select * from tb_kullanicilar where KULLANICI_ADI=@username and KULLANI_SIFRE=@password", baglanti);
            sorgula.Parameters.AddWithValue("@username", kllnciadi.Text);
            sorgula.Parameters.AddWithValue("password", sifre.Text);
            SqlDataReader oku = sorgula.ExecuteReader();
            if (oku.Read())
            {
                // MessageBox.Show("kullanýcý var");
                Formanaform frm = new Formanaform();
                frm.kisiAdiSoyadi = oku["AD_SOYAD"].ToString();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("KULLANICI KAYDI BULUNAMADI LÜTFEN BÝLGÝLERÝ KONTROL EDÝNÝZ");
            }

            baglanti.Close();
            kllnciadi.Text = "";
            sifre.Text = "";
            kllnciadi.Focus();
        }

        private void formAcilis_Load(object sender, EventArgs e)
        {

        }

        private void lblhesapolustur_Click(object sender, EventArgs e)
        {
            FrmKullancýOlustur frm = new FrmKullancýOlustur();
            frm.Show();
            this.Hide();
        }

        private void lblhesapolustur_MouseEnter(object sender, EventArgs e)
        {
            lblhesapolustur.ForeColor = Color.DarkBlue;
            lblhesapolustur.Font = new Font(lblhesapolustur.Font, FontStyle.Underline);
        }

        private void lblhesapolustur_MouseLeave(object sender, EventArgs e)
        {
            lblhesapolustur.ForeColor = Color.DarkRed;
            lblhesapolustur.Font = new Font(lblhesapolustur.Font, FontStyle.Regular);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}

