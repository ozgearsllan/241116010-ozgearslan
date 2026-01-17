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
    public partial class oyuncuListe : UserControl
    {
        public oyuncuListe()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=sinematix.db; Integrated Security=True;Encrypt=False;TrustServerCertificate=True;");

        private void oyuncuListe_Load(object sender, EventArgs e)
        {


            baglanti.Open();

            string sorgu = "select * from tbl_oyuncular WHERE ID=@p1";

            SqlCommand komut = new SqlCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("@p1", lbId.Text);

            SqlDataReader oku = komut.ExecuteReader();

            baglanti.Close();



        }

        private void btnyukle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from tbl_oyuncular WHERE ID=@p1";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@p1", lbId.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("BİYOGRAFİ : " + oku["BIYOGRAFI"].ToString(), oku["ADSOYAD"].ToString());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete  from tb_yonetmenler where ID=@p1 ", baglanti);
            sil.Parameters.AddWithValue("@p1", lbId.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show(lbladsoyad.Text + " KİŞİSİNE AİT KAYIT BAŞARILI BİR ŞEKİLDE SİLİNMİŞTİR");
            this.Hide();
        }
    }
}
