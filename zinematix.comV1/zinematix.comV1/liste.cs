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
    public partial class liste : UserControl
    {
        public liste()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=sinematix.db; Integrated Security=True;Encrypt=False;TrustServerCertificate=True;");
        private void lblad_Click(object sender, EventArgs e)
        {
            if (lblad.ForeColor == Color.DarkRed)
            {
                lblad.ForeColor = Color.FromArgb(249, 164, 26);
                pbaa.ImageLocation = @"C:\Users\arsla\OneDrive\Masaüstü\plus--v1.jpg";
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into tbl_secilenler (KISI,TUR) VALUES (@kisi,@tur)", baglanti);
                komut.Parameters.AddWithValue("@kisi", lblad.Text);
                komut.Parameters.AddWithValue("@tur", "OYUNCU");
                komut.ExecuteNonQuery();
                baglanti.Close();

            }
            else
            {
                lblad.ForeColor = Color.DarkRed;
                pbaa.ImageLocation = @"C:\Users\arsla\OneDrive\Masaüstü\62.png";
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from tbl_secilenler where KISI=@kisi AND TUR=@tur", baglanti);
                komut.Parameters.AddWithValue("@kisi", lblad.Text);
                komut.Parameters.AddWithValue("@tur", "OYUNCU");
                komut.ExecuteNonQuery();
                baglanti.Close();

            }
        }



        private void lblad_MouseMove_1(object sender, MouseEventArgs e)
        {
            lblad.Font = new Font(lblad.Font, lblad.Font.Style | FontStyle.Underline);
        }

        private void lblad_MouseLeave_1(object sender, EventArgs e)
        {
            lblad.Font = new Font(lblad.Font, lblad.Font.Style & ~FontStyle.Underline);
        }

        private void liste_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_secilenler WHERE KISI=@kisi AND TUR=@tur", baglanti);
            komut.Parameters.AddWithValue("@kisi", lblad.Text);
            komut.Parameters.AddWithValue("@tur", "OYUNCU");
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                lblad.ForeColor = Color.FromArgb(249, 164, 26);
                pbaa.ImageLocation = @"C:\Users\arsla\OneDrive\Masaüstü\plus--v1.jpg";
            }
            else
            {
                lblad.ForeColor = Color.DarkRed;
                pbaa.ImageLocation = @"C:\Users\arsla\OneDrive\Masaüstü\62.png";
            }
            baglanti.Close();
        }
    }




}
