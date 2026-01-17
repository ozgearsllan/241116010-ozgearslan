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
    public partial class FrmOyuncuListesi : Form
    {
        public FrmOyuncuListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=sinematix.db; Integrated Security=True;Encrypt=False;TrustServerCertificate=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmOyuncuListesi_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from tbl_oyuncular ORDER BY ADSOYAD ASC";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                oyuncuListe arac = new oyuncuListe();


                listepaneli.Controls.Add(arac);
                arac.lbId.Text = oku["ID"].ToString();
                arac.lbladsoyad.Text = oku["ADSOYAD"].ToString();
                arac.pbresimdetay.ImageLocation = oku["RESIM"].ToString();
                listepaneli.Controls.Add(arac);



            }
            baglanti.Close();
        }

        private void txtarama_TextChanged(object sender, EventArgs e)
        {

            listepaneli.Controls.Clear();
            baglanti.Open();
            string sorgu = "SELECT * FROM tbl_oyuncular WHERE ADSOYAD collate Turkish_CI_AS LIKE @arama ORDER BY ADSOYAD ASC";
            SqlCommand ara = new SqlCommand(sorgu, baglanti);
            ara.Parameters.AddWithValue("@arama", "%" + txtaramaa.Text + "%");

            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {
                oyuncuListe arac = new oyuncuListe();


                listepaneli.Controls.Add(arac);
                arac.lbId.Text = oku["ID"].ToString();
                arac.lbladsoyad.Text = oku["ADSOYAD"].ToString();
                arac.pbresimdetay.ImageLocation = oku["RESIM"].ToString();


            }
            baglanti.Close();
        }

        private void oylis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
