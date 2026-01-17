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
    public partial class FrmKullancıOlustur : Form
    {
        public FrmKullancıOlustur()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=sinematix.db; Integrated Security=True;Encrypt=False;TrustServerCertificate=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO tb_kullanicilar (AD_Soyad, KULLANIcı_ADI, KULLANI_SIFRE) VALUES (@adsoyad,@kadi,@sifre)";

            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@adsoyad", txtAdsoyad.Text);
            komut.Parameters.AddWithValue("@kadi", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@sifre", txtSifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("HESAP BAŞARIYLA OLUŞTURULDU");

            formAcilis frm = new formAcilis();
            frm.Show();
            this.Close();
        }
    }
}
