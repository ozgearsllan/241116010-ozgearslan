using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace zinematix.comV1
{
    public partial class Formanaform : Form
    {
        public Formanaform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string kisiAdiSoyadi = "";

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            FrmYonetmenKayit frm = new FrmYonetmenKayit();
            frm.ShowDialog();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            FrmYonetmenListesi frm = new FrmYonetmenListesi();
            frm.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            FrmOyucuKayit frm = new FrmOyucuKayit();
            frm.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            FrmOyuncuListesi frm = new FrmOyuncuListesi();
            frm.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            FrmKayit frm = new FrmKayit();
            frm.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            rmFilmKayit frm = new rmFilmKayit();
            frm.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            FrmFilmListe frm = new FrmFilmListe();
            frm.ShowDialog();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            FrmBiletOl frm = new FrmBiletOl();
            frm.ShowDialog();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            FrmBiletSorgulama frm = new FrmBiletSorgulama();
            frm.ShowDialog();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            FrmSalonAtama frm = new FrmSalonAtama();
           
            frm.ShowDialog();

        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            formAcilis acilis = new formAcilis();
            acilis.Show();
            this.Hide();
        }

        private void Formanaform_Load(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }
    }
}
