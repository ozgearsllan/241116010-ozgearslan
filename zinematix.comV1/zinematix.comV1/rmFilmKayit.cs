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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace zinematix.comV1
{
    public partial class rmFilmKayit : Form
    {
        public rmFilmKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=sinematix.db; Integrated Security=True;Encrypt=False;TrustServerCertificate=True;");


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            verileriSil();
            
        }
        void verileriSil()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from tbl_secilenler", baglanti);

            komut.ExecuteNonQuery();
            baglanti.Close();

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int karaktersayisi = txtbiygrafi.Text.Length;
            int geri = 1000 - karaktersayisi;
            lblkarakter.Text = geri.ToString();
            if (geri < 11)
            {
                lblkarakter.ForeColor = Color.Red;
            }
            else
            {
                lblkarakter.ForeColor = Color.DarkRed;
            }
        }


        string resimYolu = "";
        private void btnyuklee_Click(object sender, EventArgs e)
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






        private void rmFilmKayit_Load(object sender, EventArgs e)
        {
            yListesiGetir();
            oListesiGetir();
            bugunTarihi();

        }
        void bugunTarihi()
        {
            ngun.Value = DateTime.Today.Day;
            nay.Value = DateTime.Today.Month;
            nyil.Value = DateTime.Today.Year;


        }
        void yListesiGetir()
        {
            string sorgu = "select * from tb_yonetmenler ORDER BY AD_SOYAD ASC";
            fyonpanel.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                yListearacı arac = new yListearacı();
                arac.lblAdi.Text = oku["AD_SOYAD"].ToString();
                fyonpanel.Controls.Add(arac);



            }
            baglanti.Close();


        }
        void oListesiGetir()
        {
            string sorgu = "select * from tbl_oyuncular ORDER BY ADSOYAD ASC";
            foynpnl.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                liste arac = new liste();
                arac.lblad.Text = oku["ADSOYAD"].ToString();
                foynpnl.Controls.Add(arac);



            }
            baglanti.Close();

        }

        private void textBox3_MouseMove(object sender, MouseEventArgs e)
        {
            lbloyuncuara.Visible = true;
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            lbloyuncuara.Visible = false;
        }

        private void textBox2_MouseMove(object sender, MouseEventArgs e)
        {
            lblyntm.Visible = true;
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            lblyntm.Visible = false;
        }

        private void txtyntara_TextChanged(object sender, EventArgs e)
        {
            yonetmenAra();
        }
        void yonetmenAra()
        {
            string sorgu = "SELECT * FROM tb_yonetmenler WHERE AD_SOYAD LIKE '%" + txtyntara.Text + "%'  collate Turkish_CI_AS ORDER BY AD_SOYAD ASC";
            fyonpanel.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                yListearacı arac = new yListearacı();
                arac.lblAdi.Text = oku["AD_SOYAD"].ToString();
                fyonpanel.Controls.Add(arac);
            }
            baglanti.Close();
        }

        private void txtoyuncuara_TextChanged_1(object sender, EventArgs e)

        {
            oyuncuAra();
        }
        void oyuncuAra()
        {

            string sorgu = "SELECT * FROM tbl_oyuncular WHERE ADSOYAD LIKE '%" + txtoyuncuara.Text + "%' collate Turkish_CI_AS  ORDER BY ADSOYAD ASC";
            foynpnl.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                liste arac = new liste();
                arac.lblad.Text = oku["ADSOYAD"].ToString();
                foynpnl.Controls.Add(arac);
            }
            baglanti.Close();
        }

        private void lblaksiyon_Click(object sender, EventArgs e)
        {
            if (lblaksiyon.ForeColor == Color.DarkRed)
            {
                lblaksiyon.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblaksiyon.ForeColor = Color.DarkRed;
            }
        }

        private void lblask_Click(object sender, EventArgs e)
        {
            if (lblask.ForeColor == Color.DarkRed)
            {
                lblask.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblask.ForeColor = Color.DarkRed;
            }
        }

        private void lblbilim_Click(object sender, EventArgs e)
        {
            if (lblbilim.ForeColor == Color.DarkRed)
            {
                lblbilim.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblbilim.ForeColor = Color.DarkRed;
            }
        }

        private void lblgerilim_Click(object sender, EventArgs e)
        {
            if (lblgerilim.ForeColor == Color.DarkRed)
            {
                lblgerilim.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblgerilim.ForeColor = Color.DarkRed;
            }
        }

        private void lblkorku_Click(object sender, EventArgs e)
        {
            if (lblkorku.ForeColor == Color.DarkRed)
            {
                lblkorku.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblkorku.ForeColor = Color.DarkRed;
            }
        }

        private void lbldram_Click(object sender, EventArgs e)
        {
            if (lblkomedi.ForeColor == Color.DarkRed)
            {
                lblkomedi.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblkomedi.ForeColor = Color.DarkRed;
            }
        }



        private void lblturkce_Click(object sender, EventArgs e)
        {
            if (lblturkce.ForeColor == Color.DarkRed)
            {
                lblturkce.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblturkce.ForeColor = Color.DarkRed;
            }
        }

        private void lbling_Click(object sender, EventArgs e)
        {
            if (lbling.ForeColor == Color.DarkRed)
            {
                lbling.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lbling.ForeColor = Color.DarkRed;
            }
        }

        private void lblalyazı_Click(object sender, EventArgs e)
        {
            if (lblalyazı.ForeColor == Color.DarkRed)
            {
                lblalyazı.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblalyazı.ForeColor = Color.DarkRed;
            }
        }

        private void lblolumsuz_Click(object sender, EventArgs e)
        {
            if (lblolumsuz.ForeColor == Color.DarkRed)
            {
                lblolumsuz.ForeColor = Color.FromArgb(249, 164, 26);
                pbo.ImageLocation = @"C:\Users\arsla\OneDrive\Masaüstü\açıkk.png";
            }
            else
            {
                lblolumsuz.ForeColor = Color.DarkRed;
                pbo.ImageLocation = @"C:\Users\arsla\OneDrive\Masaüstü\kapalı.png";
            }
        }

        private void lblsiddet_Click(object sender, EventArgs e)
        {
            if (lblsiddet.ForeColor == Color.DarkRed)
            {
                lblsiddet.ForeColor = Color.FromArgb(249, 164, 26);
                pbs.ImageLocation = @"C:\Users\arsla\OneDrive\Masaüstü\açıkk.png";
            }
            else
            {
                lblsiddet.ForeColor = Color.DarkRed;
                pbs.ImageLocation = @"C:\Users\arsla\OneDrive\Masaüstü\kapalı.png";
            }
        }

        private void lblcinsl_Click(object sender, EventArgs e)
        {
            if (lblcinsl.ForeColor == Color.DarkRed)
            {
                lblcinsl.ForeColor = Color.FromArgb(249, 164, 26);
                pbc.ImageLocation = @"C:\Users\arsla\OneDrive\Masaüstü\açıkk.png";
            }
            else
            {
                lblcinsl.ForeColor = Color.DarkRed;
                pbc.ImageLocation = @"C:\Users\arsla\OneDrive\Masaüstü\kapalı.png";
            }
        }

        private void lblgerlimm_Click(object sender, EventArgs e)
        {
            if (lblgerlimm.ForeColor == Color.DarkRed)
            {
                lblgerlimm.ForeColor = Color.FromArgb(249, 164, 26);
                pbgi.ImageLocation = @"C:\Users\arsla\OneDrive\Masaüstü\açıkk.png";
            }
            else
            {
                lblgerlimm.ForeColor = Color.DarkRed;
                pbgi.ImageLocation = @"C:\Users\arsla\OneDrive\Masaüstü\kapalı.png";
            }
        }

        private void lbl7_Click(object sender, EventArgs e)
        {
            if (lbl7.ForeColor == Color.DarkRed)
            {
                lbl7.ForeColor = Color.FromArgb(249, 164, 26);
                pb7.ImageLocation = @"C:\Users\arsla\OneDrive\Masaüstü\açıkk.png";
            }
            else
            {
                lbl7.ForeColor = Color.DarkRed;
                pb7.ImageLocation = @"C:\Users\arsla\OneDrive\Masaüstü\kapalı.png";
            }
        }

        private void lbl13_Click(object sender, EventArgs e)
        {

            if (lbl13.ForeColor == Color.DarkRed)
            {
                lbl13.ForeColor = Color.FromArgb(249, 164, 26);
                pb13.ImageLocation = @"C:\Users\arsla\OneDrive\Masaüstü\açıkk.png";
            }
            else
            {
                lbl13.ForeColor = Color.DarkRed;
                pb13.ImageLocation = @"C:\Users\arsla\OneDrive\Masaüstü\kapalı.png";
            }
        }

        private void lbl18_Click(object sender, EventArgs e)
        {
            if (lbl18.ForeColor == Color.DarkRed)
            {
                lbl18.ForeColor = Color.FromArgb(249, 164, 26);
                pb18.ImageLocation = @"C:\Users\arsla\OneDrive\Masaüstü\açıkk.png";
            }
            else
            {
                lbl18.ForeColor = Color.DarkRed;
                pb18.ImageLocation = @"C:\Users\arsla\OneDrive\Masaüstü\kapalı.png";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vizyonTarihiHeapla();



            if (durum == "1")
            {
                DateTime dVTarih = Convert.ToDateTime(vTarih);
                DateTime bugunTarihi = DateTime.Today;
                TimeSpan tSpan = dVTarih - bugunTarihi;
                MessageBox.Show(txtfilm.Text.ToUpper() + " " + tSpan.TotalDays.ToString() + " GÜN SONRA VİZYONA GİRECEKTİR");

            }

            else if (durum == "0")
            {

                DateTime dVTarih = Convert.ToDateTime(vTarih);
                DateTime bugunTarihi = DateTime.Today;
                TimeSpan tSpan = dVTarih - bugunTarihi;

                if (tSpan.TotalDays == 0)
                {
                    MessageBox.Show(txtfilm.Text.ToUpper() + " FİLMİ BUGÜN VİZYONDA");
                }
                else if (tSpan.TotalDays < 0)
                {
                    MessageBox.Show("Bu tarih zaten geçtiği için işlem yapılamaz. Tarih bugüne sıfırlandı.", "Geçmiş Tarih Hatası");
                }
            }
        }
        string vTarih = "";
        string durum = "0";
        void vizyonTarihiHeapla()
        {
            vTarih = ngun.Value + "-" + nay.Value + "-" + nyil.Value;
            DateTime dVTarih = Convert.ToDateTime(vTarih);
            DateTime bugunTarihi = DateTime.Today;

            TimeSpan tSpan = dVTarih - bugunTarihi;
            if (tSpan.TotalDays < 0)
            {
               
                MessageBox.Show("GEÇMİŞ TARİHLERE AİT FİLM EKLENMESİ YAPILAMAZ ");
                ngun.Value = bugunTarihi.Day;
                nay.Value = bugunTarihi.Month;
                nyil.Value = bugunTarihi.Year;
            }
            else if (tSpan.TotalDays == 0)
            {
                 durum = "0";
              //  MessageBox.Show(txtfilm.Text.ToUpper() + " FİLMİ BUGÜN VİZYONDA");

                ;
            }
            else
            {
                 durum = "1";
                //MessageBox.Show(txtfilm.Text.ToUpper() + " " + tSpan.TotalDays.ToString() + " GÜN SONRA VİZYONA GİRECEKTİR");

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltarihh.Text = DateTime.Now.ToShortDateString();
            lblsaatt.Text = DateTime.Now.ToShortTimeString();
        }
        string yonetmen = "yönetmen";
        string oyuncu = "oyuncu";

        void secilenYonetmen()
        {
            yonetmen = "";
            string sorgu = "select * from tbl_secilenler WHERE TUR='YÖNETMEN'";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (yonetmen.Length > 0)
                    yonetmen += " ,";
                yonetmen += " ," + oku["KISI"].ToString();
            }
            baglanti.Close();
        }
        void secilenoyuncu()
        {
            oyuncu ="";
            string sorgu = "select * from tbl_secilenler WHERE TUR='OYUNCU'";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oyuncu.Length > 0)
                   oyuncu += " ,";
                oyuncu += " ," + oku["KISI"].ToString();
            }
            baglanti.Close();
        }
        void temizlemeMetodu()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            txtfilm.Focus();
            verileriSil();
            yListesiGetir();
            oListesiGetir();
            bugunTarihi();
        }
        private void btnfilmekle_Click(object sender, EventArgs e)
        {

            tur();
            ozellik();
            bicim();
            secilenYonetmen();
            secilenoyuncu();
            vizyonTarihiHeapla();



            if (txtfilm.Text !="" && txtbiygrafi.Text !="" && yonetmen!="" && resimYolu!="" && vTarih != "" && secilenbicim !="" && secilenozellik!="" && secilenTur!="")
            {
               
                 
            


            string sorgu = "insert into tbl_Filmler (ADI,TURU,OZELLIKLERI,BICIMI,YONETMEN,OYUNCU,DETAY,PUAN,AFIS,TARIH,DURUM) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11) ";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@p1", txtfilm.Text.ToUpper());
            if (secilenTur.Length > 2)
            {
                komut.Parameters.AddWithValue("@p2", secilenTur.Substring(2));

            }
            else
            {
                komut.Parameters.AddWithValue("@p2", secilenTur);
            }
            if (secilenozellik.Length > 2)
            {
                komut.Parameters.AddWithValue("@p3", secilenozellik.Substring(2));

            }
            else
            {
                komut.Parameters.AddWithValue("@p3", secilenozellik);
            }
            if (secilenbicim.Length > 2)
            {
                komut.Parameters.AddWithValue("@p4", secilenbicim.Substring(2));

            }
            else
            {
                komut.Parameters.AddWithValue("@p4", secilenbicim);
            }
            if (yonetmen.Length > 2)
            {
                komut.Parameters.AddWithValue("@p5", yonetmen.Substring(2));

            }
            else
            {
                komut.Parameters.AddWithValue("@p5", yonetmen);
            }
            if (oyuncu.Length > 2)
            {
                komut.Parameters.AddWithValue("@p6", oyuncu.Substring(2));

            }
            else
            {
                komut.Parameters.AddWithValue("@p6", oyuncu);
            }





            komut.Parameters.AddWithValue("@p7", txtbiygrafi.Text.ToUpper());
            komut.Parameters.AddWithValue("@p8", cmbimdb.Text);
            komut.Parameters.AddWithValue("@p9", resimYolu);
            komut.Parameters.AddWithValue("@p10", vTarih);
            komut.Parameters.AddWithValue("@p11", durum);

            komut.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("FİLM KAYDI BAŞARILI BİR ŞEKİLDE KAYDEDİLMİŞTİR");
                temizlemeMetodu();
            }
            else
            {
                MessageBox.Show("LÜTFEN İLGİLİ SEÇİMLERİ YAPINIZ");

            }

        }
        string secilenTur = "";
        string secilenozellik = "";
        string secilenbicim = "";
        void tur()
        {


            foreach (Control arac in gbtur.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.DarkRed)
                    {

                    }
                    else
                    {
                        secilenTur += " ," + arac.Text.ToString();
                    }
                }

            }

        }
        void ozellik()
        {


            foreach (Control arac in bgoz.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.DarkRed)
                    {

                    }
                    else
                    {
                        secilenozellik += " ," + arac.Text.ToString();
                    }
                }

            }
        }

        void bicim()
        {


            foreach (Control arac in gbbic.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.DarkRed)
                    {

                    }
                    else
                    {
                        secilenbicim += " ," + arac.Text.ToString();
                    }
                }

            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }
    }
}


