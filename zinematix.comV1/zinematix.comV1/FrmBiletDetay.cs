using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace zinematix.comV1
{
    public partial class FrmBiletDetay : Form
    {
        public FrmBiletDetay()
        {
            InitializeComponent();
        }
        public string biletno = "";
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=sinematix.db; Integrated Security=True;Encrypt=False;TrustServerCertificate=True;");
        private void FrmBiletDetay_Load(object sender, EventArgs e)
        {
            lblblt.Text = biletno;
            lblBiletNo2.Text = biletno;
            barkotNolustur();
            BilgiGetir();
        }
        void BilgiGetir()
        {
            string sorgu = "select * from tbl_Biletler where BKOD=@kod";
            baglanti.Open();
            SqlCommand getir = new SqlCommand(sorgu, baglanti);
            getir.Parameters.AddWithValue("@kod", biletno);
            SqlDataReader oku = getir.ExecuteReader();
            if (oku.Read())
            {
                lblfilmadi.Text = oku["FILMADI"].ToString();
                lblfilmadi2.Text = oku["FILMADI"].ToString();
                lbltelno.Text = oku["TELNO"].ToString();
                lbladsoyad.Text = oku["ADSOYAD"].ToString();
                lblbilettur.Text = oku["TUR"].ToString();
                lblsalonadi.Text = oku["SALON"].ToString();
                lblsalon.Text = oku["SALON"].ToString();
                lblbltrh.Text = oku["TARIH"].ToString() + " " + oku["SAAT"].ToString();
                lbltarih.Text = oku["TARIH"].ToString() + " " + oku["SAAT"].ToString();
                lblbgn.Text = oku["ISLEMSAATI"].ToString();
                lblkoltuk.Text = oku["KOLTUKNO"].ToString();
                lblkoltuk2.Text = oku["KOLTUKNO"].ToString();
            }

            baglanti.Close();
        }
        void barkotNolustur()
        {
            Random rnd = new Random();
            string karakterler = "01234567898761234567898765432123456789876543212345678987654321234567898765432543210";
            string kod = "";
            for (int i = 0; i < 11; i++)

            {
                kod += karakterler[rnd.Next(karakterler.Length)];
            }
            lblbarkod.Text = kod.ToString();

            lblbarkod1.Text = kod.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
