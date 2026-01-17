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
    public partial class FrmBiletSorgulama : Form
    {
        public FrmBiletSorgulama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=sinematix.db; Integrated Security=True;Encrypt=False;TrustServerCertificate=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtbiletno.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from tbl_Biletler where BKOD=@p1 ", baglanti);
                komut.Parameters.AddWithValue("@p1", txtbiletno.Text.ToString());
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    FrmBiletDetay frm = new FrmBiletDetay();
                    frm.biletno = txtbiletno.Text.ToString();
                    txtbiletno.Text = "";
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("KAYITLI BİLET BULUNAMADI ");
                    baglanti.Close();
                }
                baglanti.Close();



            }
            else
            {
                    MessageBox.Show("LÜTFEN BİLET NUMARASI GİRİNİZ");
            }

            
        }
    }
}
