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
    public partial class FrmFilmListe : Form
    {
        public FrmFilmListe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=sinematix.db; Integrated Security=True;Encrypt=False;TrustServerCertificate=True;");
        private void FrmFilmListe_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from tbl_Filmler ORDER BY ADI ASC";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                filmListesi arac = new filmListesi();
                arac.lblfilm.Text = oku["ADI"].ToString();
                arac.pbresim.ImageLocation = oku["AFIS"].ToString();
                arac.lblıd.Text = oku["ID"].ToString();
                flistepaneli.Controls.Add(arac);
            }
            baglanti.Close();
        }

        private void txtaramafilm_TextChanged(object sender, EventArgs e)
        {

            flistepaneli.Controls.Clear();
            baglanti.Open();
            string sorgu = "SELECT * FROM tbl_Filmler WHERE ADI collate Turkish_CI_AS LIKE @arama ORDER BY ADI ASC";
            SqlCommand ara = new SqlCommand(sorgu, baglanti);
            ara.Parameters.AddWithValue("@arama", "%" + txtaramafilm.Text + "%" );
            // SqlCommand ara = new SqlCommand("select * from tb_yonetmenler WHERE AD_SOYAD LİKE '%"+txtarama.Text+"%'", baglanti);
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {

                filmListesi arac = new filmListesi();
                arac.lblfilm.Text = oku["ADI"].ToString();
                arac.pbresim.ImageLocation = oku["AFIS"].ToString();
                arac.lblıd.Text = oku["ID"].ToString();
                flistepaneli.Controls.Add(arac);
            }
            baglanti.Close();
        }
    }
}
