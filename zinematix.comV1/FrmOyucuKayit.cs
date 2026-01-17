using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace zinematix.comV1
{
    public partial class FrmOyucuKayit : Form
    {
        public FrmOyucuKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=sinematix.db; Integrated Security=True;Encrypt=False;TrustServerCertificate=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string resimYolu = "";
        private void btnyukle_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESİM SEÇME EKRANI";
            ofd.Filter = "PNG | *.png |JPG - JPEG|*.jpg;*.jpeg | All FİLES | *.*";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbresim.Image = new Bitmap(ofd.FileName);
                resimYolu = ofd.FileName.ToString();

            }
        }

        private void rberkk_CheckedChanged(object sender, EventArgs e)
        {

            cinsiyet = "0";


        }

        private void rbkdn_CheckedChanged(object sender, EventArgs e)
        {

            cinsiyet = "1";


        }
        public string cinsiyet = "0";


        private void btnkayitet_Click(object sender, EventArgs e)
        {
            yasHesaplama();
            if (txtad.Text != "" && txtsoyad.Text != "" && txtbygrfi.Text != "" && resimYolu != "")
            {
                string adSoyad = txtad.Text.ToString().ToUpper() + " " + txtsoyad.Text.ToString().ToUpper();

                baglanti.Open();
                SqlCommand kayit = new SqlCommand("insert into tbl_oyuncular (ADSOYAD,CINSIYET,YAS,BIYOGRAFI,RESIM) VALUES(@p1,@p2,@p3,@p4,@p5) ", baglanti);
                kayit.Parameters.AddWithValue("@p1", adSoyad);
                kayit.Parameters.AddWithValue("@p2", cinsiyet);
                kayit.Parameters.AddWithValue("@p3", bYas);
                kayit.Parameters.AddWithValue("@p4", txtbygrfi.Text.ToString());
                kayit.Parameters.AddWithValue("@p5", resimYolu);
                kayit.ExecuteNonQuery();
                MessageBox.Show(" KAYIT İŞLEMİ BAŞARILI ");
                baglanti.Close();
                aracTemizle();
            }
            else
            {
                MessageBox.Show("ALANLAR BOŞ BIRAKILMAZ");
            }

            void aracTemizle()
            {
                txtad.Text = "";
                txtsoyad.Text = "";
                txtbygrfi.Text = "";
                ngun.Value = 1;
                nay.Value = 1;
                nyil.Value = 2023;
                rberkk.Checked = true;
                rberkk.Checked = false;
                lblkrktr.Text = "300";
                cinsiyet = "0";
                bYas = "00";
                txtad.Focus();
                pbresim.ImageLocation = @" C:\Users\arsla\OneDrive\Masaüstü\indir.png";
            }
        }

        public string bYas = "00";
        void yasHesaplama()
        {
            string dogum = ngun.Value.ToString() + "-" + nay.Value.ToString() + "-" + nyil.Value.ToString();
            DateTime dogumTarihi = Convert.ToDateTime(dogum);
            DateTime bugun = DateTime.Today;
            int yas = bugun.Year - dogumTarihi.Year;



            bYas = yas.ToString();

        }

        private void txtbygrfi_TextChanged(object sender, EventArgs e)
        {
            int karaktersayisi = txtbygrfi.Text.Length;
            int geri = 300 - karaktersayisi;
            lblkrktr.Text = geri.ToString();
            if (geri < 11)
            {
                lblkrktr.ForeColor = Color.Red;
            }
            else
            {
                lblkrktr.ForeColor = Color.DarkRed;
            }

        }

        private void FrmOyucuKayit_Load(object sender, EventArgs e)
        {

        }
    }
}

