using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace zinematix.comV1
{
    public partial class FrmBiletOl : Form
    {
        public FrmBiletOl()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=sinematix.db; Integrated Security=True;Encrypt=False;TrustServerCertificate=True;");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void BiletSorgu()
        {
            string sorgu = "select * from tbl_Biletler where BKOD=@no";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@no", bltno.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            if (!oku.Read())
            {
                kaydetme();
            }
            else
            {
                biletNoLUSTUR();
                baglanti.Close();
                BiletSorgu();
            }
            baglanti.Close();
        }
        void kaydetme()
        {
            string sorgu = " insert into tbl_Biletler (BKOD,ADSOYAD,TELNO,KOLTUKNO,FILMADI,TARIH,SAAT,SALON,TUR,ISLEMSAATI) Values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)";
            baglanti.Close();
            baglanti.Open();
            SqlCommand kayit = new SqlCommand(sorgu, baglanti);

            kayit.Parameters.AddWithValue("@p1", bltno.Text.ToString());
            kayit.Parameters.AddWithValue("@p2", txtisim.Text.ToUpper().ToString());
            kayit.Parameters.AddWithValue("@p3", txttelno.Text.ToString());
            kayit.Parameters.AddWithValue("@p4", txtkoltuklar.Text.ToString());
            kayit.Parameters.AddWithValue("@p5", cbfilm.Text.ToString());
            kayit.Parameters.AddWithValue("@p6", cbtarih.Text.ToString());
            kayit.Parameters.AddWithValue("@p7", lblsaat.Text.ToString());
            kayit.Parameters.AddWithValue("@p8", cbsalon.Text.ToString());
            kayit.Parameters.AddWithValue("@p9", cbblttur.Text.ToString());
            kayit.Parameters.AddWithValue("@p10", DateTime.Now.ToString());
            kayit.ExecuteNonQuery();
            baglanti.Close();

            //güncellme
            string sorgu2 = " UPDATE tbl_Control  SET KOLTUKLAR=@koltukg WHERE FILMADI=@filmadi AND TARIH=@tarih AND SAAT=@saat AND SALONADI=@salonadi";
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand(sorgu2, baglanti);
            lblgelenko.Text = lblgelenko.Text.Trim(',');
            txtkoltuklar.Text = txtkoltuklar.Text.Trim(',');
            string yeniKoltukListesi = lblgelenko.Text + "," + txtkoltuklar.Text;
            yeniKoltukListesi = yeniKoltukListesi.Trim(',');

            guncelle.Parameters.AddWithValue("@koltukg", yeniKoltukListesi);
            guncelle.Parameters.AddWithValue("@filmadi", cbfilm.Text.ToString());
            guncelle.Parameters.AddWithValue("@tarih", cbtarih.Text.ToString());
            guncelle.Parameters.AddWithValue("@saat", lblsaat.Text.ToString());
            guncelle.Parameters.AddWithValue("@salonadi", cbsalon.Text.ToString());
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            koltukGetir();

            MessageBox.Show("BİLET ALIM İŞLEMİNİZ BAŞARIYLA GERÇEKLEŞMİŞTİR. İYİ SEYİRLER ");
            SalonDurumu();
            lblgelenko.Text = "";
            listegelen.Items.Clear();
            lbsecilen.Items.Clear();
            txtkoltuklar.Text = "";
            silme();

        }


        private void btnbiletal_Click(object sender, EventArgs e)
        {
            if (bltno.Text != "" && txtisim.Text != "" && txttelno.Text != "" && txtkoltuklar.Text != "" && cbfilm.Text != "" && cbtarih.Text != "" && cbsalon.Text != "" && cbblttur.Text != "")
            {
                BiletSorgu();

            }
            else
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI EKSİKSİZ DOLDURUNUZ");
            }
        }
        void Sectiklerimiz()
        {
            txtkoltuklar.Text = "";
            foreach (string item in lbsecilen.Items)
            {
                txtkoltuklar.Text += "," + item;

            }
            if (txtkoltuklar.Text.Length > 1)
            {
                txtkoltuklar.Text = txtkoltuklar.Text.Substring(1);
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (bt.ForeColor == Color.White)
            {
                //dolu
                MessageBox.Show("BU KOLTUK DOLUDUR");
            }
            else
            {
                if (bt.ForeColor == Color.Snow)
                {
                    bt.BackgroundImage = Properties.Resources.sari;
                    bt.ForeColor = Color.DarkRed;
                    lbsecilen.Items.Add(bt.Text);
                    Sectiklerimiz();

                }
                else
                {
                    bt.BackgroundImage = Properties.Resources.bos;
                    bt.ForeColor = Color.Snow;
                    lbsecilen.Items.Remove(bt.Text);
                    Sectiklerimiz();
                }
            }
        }
        void biletNoLUSTUR()
        {
            Random rnd = new Random();
            string karakterler = "01234567898761234567898765432123456789876543212345678987654321234567898765432543210";
            string kod = "";
            for (int i = 0; i < 11; i++)

            {
                kod += karakterler[rnd.Next(karakterler.Length)];
            }
            bltno.Text = kod.ToString();
        }

        private void FrmBiletOl_Load(object sender, EventArgs e)
        {
            filmAdiGetir();
            biletNoLUSTUR();
        }
        void filmAdiGetir()
        {
            string sorgu = "select * from tbl_Filmler ORDER BY ADI ASC";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                string gelentarih = oku["TARIH"].ToString();
                DateTime fTarih = Convert.ToDateTime(gelentarih);
                DateTime bugun = DateTime.Today;

                TimeSpan timeSpan = fTarih - bugun;
                if (timeSpan.TotalDays <= 0)
                {
                    cbfilm.Items.Add(oku["ADI"].ToString());
                }

                cbfilm.Items.Add(oku["ADI"].ToString());
            }

            baglanti.Close();
        }

        private void bltno_TextChanged(object sender, EventArgs e)
        {


        }

        private void cbfilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbtarih.Items.Clear();
            string sorgu = "SELECT DISTINCT TARIH from tbl_Control WHERE FILMADI=@filmadi";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@filmadi", cbfilm.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cbtarih.Items.Add(oku["TARIH"].ToString());
            }
            baglanti.Close();
        }

        private void cbtarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            fpsaat.Controls.Clear();
            string saat = "";
            string sorgu = "SELECT DISTINCT SAAT from tbl_Control WHERE FILMADI=@filmadi AND TARIH=@tarih";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@filmadi", cbfilm.Text.ToString());
            komut.Parameters.AddWithValue("@tarih", cbtarih.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                saat = oku["SAAT"].ToString();
                RadioButton rdb = new RadioButton();
                rdb.Text = saat;
                rdb.Width = 75;
                rdb.Height = 42;
                rdb.CheckedChanged += new EventHandler(SeansSaatler);

                fpsaat.Controls.Add(rdb);

            }
            baglanti.Close();
        }
        void SeansSaatler(object sender, EventArgs e)
        {
            cbsalon.Items.Clear();
            foreach (RadioButton item in fpsaat.Controls)
            {
                if (item.Checked)
                {
                    lblsaat.Text = item.Text;

                    string sorgu = "SELECT DISTINCT SALONADI from tbl_Control WHERE FILMADI=@filmadi AND TARIH=@tarih AND SAAT=@saat";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@filmadi", cbfilm.Text.ToString());
                    komut.Parameters.AddWithValue("@tarih", cbtarih.Text.ToString());
                    komut.Parameters.AddWithValue("@saat", lblsaat.Text.ToString());
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        cbsalon.Items.Add(oku["SALONADI"].ToString());
                    }
                    baglanti.Close();
                }
            }
        }

        private void cbsalon_SelectedIndexChanged(object sender, EventArgs e)
        {

            SalonDurumu();
        }
        void SalonDurumu()
        {
            string sorgu = "SELECT * from tbl_salonlar WHERE SALONADI=@salonadi";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@salonadi", cbsalon.Text.ToString());

            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblssad.Text = (oku["KOLTUKSAYISI"].ToString());
            }
            baglanti.Close();
            koltukGetir();
            Doldur();
        }
        void Doldur()
        {
            fkoltukpnali.Controls.Clear();
            int sayi = Convert.ToInt32(lblssad.Text);
            for (int i = 0; i < sayi; i++)
            {
                Button bt = new Button();
                string koltukNo = "";


                if (i < 11)
                {
                    koltukNo = "A" + (i).ToString();
                }

                else if (i < 22)
                {
                    koltukNo = "B" + (i - 11).ToString();
                }

                else if (i < 33)
                {
                    koltukNo = "C" + (i - 22).ToString();
                }

                else if (i < 44)
                {
                    koltukNo = "D" + (i - 33).ToString();
                }
                else if (i < 55)
                {
                    koltukNo = "E" + (i - 44).ToString();
                }
                else
                {
                    koltukNo = "F" + (i - 55).ToString();
                }
                bt.Text = koltukNo;
                bt.Name = koltukNo;
                bt.Width = 50;
                bt.Height = 50;
                bt.FlatStyle = FlatStyle.Flat;
                bt.FlatAppearance.BorderSize = 0;

                bt.TextAlign = ContentAlignment.MiddleCenter;
                bt.Font = new Font("Segeo UI", 8, FontStyle.Bold);
                bt.Click += Btn_Click;
                bt.BackgroundImage = Properties.Resources.bos;
                bt.ForeColor = Color.Snow;
                //bt.Click += Btn_Click;

                if (listegelen.Items.Contains(bt.Text))
                {
                    bt.ForeColor = Color.White;

                    bt.BackgroundImage = Properties.Resources.krm;
                    // bt.ImageAlign = ContentAlignment.MiddleCenter;

                }
                //  else
                /// {
                //    bt.ForeColor = Color.White;
                //    bt.BackgroundImage = Properties.Resources.krm;
                //}

                bt.BackgroundImageLayout = ImageLayout.Stretch;

                fkoltukpnali.Controls.Add(bt);

            }
        }
        void koltukGetir()
        {
            lblgelenko.Text = "";
            string sorgu = "SELECT * from tbl_Control WHERE FILMADI=@filmadi AND TARIH=@tarih AND SAAT=@saat AND SALONADI=@salonadi";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@filmadi", cbfilm.Text.ToString());
            komut.Parameters.AddWithValue("@tarih", cbtarih.Text.ToString());
            komut.Parameters.AddWithValue("@saat", lblsaat.Text.ToString());
            komut.Parameters.AddWithValue("@salonadi", cbsalon.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                string koltuk = oku["KOLTUKLAR"].ToString();
                if (lblgelenko.Text == "")
                    lblgelenko.Text = koltuk;             // İlk koltuk
                else
                    lblgelenko.Text += "," + koltuk;
            }
            baglanti.Close();

            koltukAyırma();


        }
        void koltukAyırma()
        {
            listegelen.Items.Clear();
            string no = "";
            string[] sec;
            no = lblgelenko.Text.ToString();
            sec = no.Split(',');
            foreach (string bulunan in sec)
            {
                if (bulunan.Trim() != "")
                {
                    listegelen.Items.Add(bulunan);
                }
            }

        }
        void silme()
        {
            txtisim.Text = "";
            txttelno.Text = "";
            txtkoltuklar.Text = "";
            cbblttur.Items.Clear();
            bltno.Text = "";
            lblgelenko.Text = "";
            lblsaat.Text = "";
            lblssad.Text = "";
            lbltarih.Text = "";
            cbfilm.Items.Clear();
            cbsalon.Items.Clear();
            cbsalon.Text = "";
            cbtarih.Items.Clear();
            fpsaat.Controls.Clear();
            fkoltukpnali.Controls.Clear();
            listegelen.Items.Clear();
            lbsecilen.Items.Clear();
            cbblttur.Items.Add("YETİŞKİN");
            cbblttur.Items.Add("ÖĞRENCİ");
            cbblttur.Items.Add("ÇOCUK(3-12)");
            biletNoLUSTUR();


            filmAdiGetir();

        }
        private void btntemizle_Click(object sender, EventArgs e)
        {

            silme();


        }
    }
}

