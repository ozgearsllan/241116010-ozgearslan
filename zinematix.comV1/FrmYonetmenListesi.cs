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
    public partial class FrmYonetmenListesi : Form
    {
        public FrmYonetmenListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=sinematix.db; Integrated Security=True;Encrypt=False;TrustServerCertificate=True;");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmYonetmenListesi_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            string sorgu = "select * from tb_yonetmenler ORDER BY AD_SOYAD ASC";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                YonetmenListesi arac = new YonetmenListesi();


                listepaneli.Controls.Add(arac);
                arac.lbId.Text = oku["ID"].ToString();
                arac.lbladsoyad.Text = oku["AD_SOYAD"].ToString();
                arac.pbresimdetay.ImageLocation = oku["RESIM"].ToString();
                listepaneli.Controls.Add(arac);



            }
            baglanti.Close();
        }

        private void listepaneli_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtarama_TextChanged(object sender, EventArgs e)
        {
            listepaneli.Controls.Clear();
            baglanti.Open();
            string sorgu = "SELECT * FROM tb_yonetmenler WHERE AD_SOYAD LIKE @arama ORDER BY AD_SOYAD ASC";
            SqlCommand ara = new SqlCommand(sorgu, baglanti);
            ara.Parameters.AddWithValue("@arama", "%" + txtarama.Text + "%");
            // SqlCommand ara = new SqlCommand("select * from tb_yonetmenler WHERE AD_SOYAD LİKE '%"+txtarama.Text+"%'", baglanti);
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {
                YonetmenListesi arac = new YonetmenListesi();


                listepaneli.Controls.Add(arac);
                arac.lbId.Text = oku["ID"].ToString();
                arac.lbladsoyad.Text = oku["AD_SOYAD"].ToString();
                arac.pbresimdetay.ImageLocation = oku["RESIM"].ToString();


            }
            baglanti.Close();
        }
    }
}
