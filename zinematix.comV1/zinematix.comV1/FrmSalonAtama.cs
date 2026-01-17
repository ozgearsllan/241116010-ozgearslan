using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace zinematix.comV1
{
    public partial class FrmSalonAtama : Form
    {
        public FrmSalonAtama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=sinematix.db; Integrated Security=True;Encrypt=False;TrustServerCertificate=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSalonAtama_Load(object sender, EventArgs e)
        {
            bugunTarihi();
            filmAdiGetir();
            SalonlarGetir();
        }
        void SalonlarGetir()
        {
            string sorgu = "select * from tbl_salonlar ORDER BY SALONADI ASC";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cbsalon.Items.Add(oku["SALONADI"].ToString());
            }

            baglanti.Close();
        }
        void filmAdiGetir()
        {
            cbfilm.Items.Clear();
            string sorgu = "select DISTINCT ADI, TARIH from tbl_Filmler ORDER BY ADI ASC";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                string gelentarih = oku["TARIH"].ToString();
                DateTime fTarih = Convert.ToDateTime(gelentarih);
                DateTime bugun = DateTime.Today;

                TimeSpan timeSpan = fTarih - bugun;
                if (timeSpan.TotalDays >= 0)
                {
                    cbfilm.Items.Add(oku["ADI"].ToString());
                }

                //cbfilm.Items.Add(oku["ADI"].ToString());

            }

            baglanti.Close();
        }

        void bugunTarihi()
        {
            ngun.Value = DateTime.Today.Day;
            nay.Value = DateTime.Today.Month;
            nyil.Value = DateTime.Today.Year;


        }

        private void btnbiletal_Click(object sender, EventArgs e)
        {
            if (btnbiletal.Text == "TAMAMLA")
            {
                string sorgu = "SELECT DISTINCT  SAAT FROM tbl_Control WHERE TARIH=@tarih AND SALONADI=@salonadi";
                // string tarih= ngun.Value+"-"+nay.Value+"-"+nyil.Value;
                string tarih = ngun.Value.ToString("00") + "-" + nay.Value.ToString("00") + "-" + nyil.Value.ToString();
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@tarih", tarih);
                komut.Parameters.AddWithValue("@salonadi", cbsalon.Text.ToString());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    cbdolusaat.Items.Add(oku["SAAT"].ToString());
                }
                baglanti.Close();
                SeansControl();

                btnbiletal.Text = "OLUŞTUR";
                btnbiletal.BackColor = Color.DarkSalmon;


            }
            else
            {
                kaydet();
                temizleme();
                btnbiletal.Text = "TAMAMLA";
                btnbiletal.BackColor = Color.DarkRed;
            }
        }
        void kaydet()
        {


            string sorgu = "insert into tbl_Control (FILMADI,TARIH,SAAT,SALONADI)  VALUES (@filmadi,@tarih,@saat,@salonadi)";
            string tarih = ngun.Value.ToString("00") + "-" + nay.Value.ToString("00") + "-" + nyil.Value.ToString();
            baglanti.Open();
            SqlCommand ekle = new SqlCommand(sorgu, baglanti);
            ekle.Parameters.AddWithValue("@filmadi", cbfilm.Text);
            ekle.Parameters.AddWithValue("@tarih", tarih);
            ekle.Parameters.AddWithValue("@saat", lblsecilen.Text);
            ekle.Parameters.AddWithValue("@salonadi", cbsalon.Text);
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("SALON BİLGİLERİ BAŞARILI BİR ŞEKİLDE KAYDEDİLMİŞTİR");
        }
        private void SeansSaatler(object sender, EventArgs e)
        {
            foreach (RadioButton item in fpsaat.Controls)
            {
                if (item.Checked)
                {
                    lblsecilen.Text = item.Text.ToString();
                }
            }
        }
        private void btntemizle_Click(object sender, EventArgs e)
        {

            temizleme();
        }
        void temizleme()
        {

            cbfilm.Items.Clear();
            cbsalon.Items.Clear();
            cbdolusaat.Items.Clear();
            lblsecilen.Text = "";
            bugunTarihi();
            filmAdiGetir();
            SalonlarGetir();
            fpsaat.Controls.Clear();
            btnbiletal.Text = "TAMAMLA";

        }
        void SeansControl()
        {

            fpsaat.Controls.Clear();
            for (int i = 10; i <= 22; i++)
            {
                for (int j = 0; j <= 30; j += 30)
                {
                    RadioButton rnd = new RadioButton();
                    rnd.Width = 115;
                    rnd.CheckedChanged += new EventHandler(SeansSaatler);
                    rnd.Text = i.ToString("00") + ":" + j.ToString("00");
                    if (cbdolusaat.Items.Contains(rnd.Text))
                    {
                        rnd.Visible = false;
                        // rnd.ForeColor = Color.DarkBlue;
                    }
                    fpsaat.Controls.Add(rnd);
                }

            }
        }

        private void cbfilm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
