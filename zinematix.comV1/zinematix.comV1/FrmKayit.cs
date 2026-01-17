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
    public partial class FrmKayit : Form
    {
        public FrmKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=sinematix.db; Integrated Security=True;Encrypt=False;TrustServerCertificate=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (txtsalonad.Text != "" && cbkoltuksy.Text != "")
            {
                baglanti.Open();
                SqlCommand kaydet = new SqlCommand("insert into tbl_salonlar (SALONADI,KOLTUKSAYISI) Values (@p1,@p2)", baglanti);
                kaydet.Parameters.AddWithValue("@p1", txtsalonad.Text.ToUpper());
                kaydet.Parameters.AddWithValue("@p2", cbkoltuksy.Text);
                kaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("KAYDETME İŞLEMİNİZ GERÇEKLEŞTERİLİRDİ");
            }
            else
            {
                MessageBox.Show("LÜTFEN DEĞER GİRİNİZ");

            }

            txtsalonad.Text = "";
            cbkoltuksy.Text = "";
            txtsalonad.Focus();
            listeGetir();

        }

        private void FrmKayit_Load(object sender, EventArgs e)
        {
            listeGetir();
            kOLustur();
        }
        void kOLustur()
        {
            for (int i = 1; i <= 200; i++)
            {
                cbkoltuksy.Items.Add(i);
            }
        }
        void listeGetir()
        {
            panelsalon.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_salonlar ORDER BY SALONADI ASC", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                salonListesi arac = new salonListesi();
                arac.lblsalonad.Text = oku["SALONADI"].ToString();
                arac.lblkoltuk.Text = oku["KOLTUKSAYISI"].ToString();
                panelsalon.Controls.Add(arac);
            }
            baglanti.Close();


        }

        private void gell(object sender, MouseEventArgs e)
        {
            btnekle.BackColor = Color.DarkRed;
        }

        private void ayrill(object sender, EventArgs e)
        {
            btnekle.BackColor = Color.DarkSalmon;
        }

    }
}
