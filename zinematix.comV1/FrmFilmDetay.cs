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
    public partial class FrmFilmDetay : Form
    {
        public FrmFilmDetay()
        {
            InitializeComponent();

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=sinematix.db; Integrated Security=True;Encrypt=False;TrustServerCertificate=True;");
        public string idno = "";
        private void FrmFilmDetay_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from tbl_Filmler WHERE ID=@p1";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@p1", idno);

            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                pbresim.ImageLocation = oku["AFIS"].ToString();
                lblfilmadi.Text = oku["ADI"].ToString();
                lblbic.Text = oku["BICIMI"].ToString();
                lbloz.Text = oku["OZELLIKLERI"].ToString();
                lbltur.Text = oku["TURU"].ToString();
                lbloyn.Text = oku["OYUNCU"].ToString();
                lblynt.Text = oku["YONETMEN"].ToString();
                lbldur.Text = oku["DURUM"].ToString();
                lblviz.Text = oku["TARIH"].ToString();
                lblpuan.Text = oku["PUAN"].ToString();
                lbldetay.Text = oku["DETAY"].ToString();
            }
            baglanti.Close();

            if(lbldur.Text == "0")
            {
                lbldur.Text = "FİLM VİZYONDA";
            }
            else
            {
                lbldur.Text = "FİLM VİZYONDA DEĞİL";
            }

               

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void lbldur_Click(object sender, EventArgs e)
        {

        }
    }
}
