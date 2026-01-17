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
    public partial class yListearacı : UserControl
    {
        public yListearacı()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=sinematix.db; Integrated Security=True;Encrypt=False;TrustServerCertificate=True;");


        private void lblAdi_Click(object sender, EventArgs e)
        {
            if (lblAdi.ForeColor == Color.DarkRed)
            {
                lblAdi.ForeColor = Color.FromArgb(249, 164, 26);
                pba.ImageLocation = @"C:\Users\arsla\OneDrive\Masaüstü\plus--v1.jpg";
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into tbl_secilenler (KISI,TUR) VALUES (@kisi,@tur)", baglanti);
                komut.Parameters.AddWithValue("@kisi", lblAdi.Text);
                komut.Parameters.AddWithValue("@tur", "YÖNETMEN");
                komut.ExecuteNonQuery();
                baglanti.Close();

            }
            else
            {
                lblAdi.ForeColor = Color.DarkRed;
                pba.ImageLocation = @"C:\Users\arsla\OneDrive\Masaüstü\62.png";
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from tbl_secilenler where KISI=@kisi AND TUR=@tur", baglanti);
                komut.Parameters.AddWithValue("@kisi", lblAdi.Text);
                komut.Parameters.AddWithValue("@tur", "YÖNETMEN");
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void lblAdi_MouseMove(object sender, MouseEventArgs e)
        {
            //lblAdi.Font = new Font(lblAdi.Font.Name, 9, FontStyle.Underline);
            lblAdi.Font = new Font(lblAdi.Font, lblAdi.Font.Style | FontStyle.Underline);
        }
        private void lblAdi_MouseLeave(object sender, EventArgs e)
        {
            lblAdi.Font = new Font(lblAdi.Font, lblAdi.Font.Style & ~FontStyle.Underline);
            //lblAdi.Font = new Font(lblAdi.Font.Name,9, FontStyle.Regular);
        }

        private void yListearacı_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_secilenler WHERE KISI=@kisi AND TUR=@tur", baglanti);
            komut.Parameters.AddWithValue("@kisi",lblAdi.Text);
            komut.Parameters.AddWithValue("@tur", "YÖNETMEN");
            SqlDataReader oku =komut.ExecuteReader();
            if(oku.Read())
            {
                lblAdi.ForeColor = Color.FromArgb(249, 164, 26);
                pba.ImageLocation = @"C:\Users\arsla\OneDrive\Masaüstü\plus--v1.jpg";
            }
            else
            {
                lblAdi.ForeColor = Color.DarkRed;
                pba.ImageLocation = @"C:\Users\arsla\OneDrive\Masaüstü\62.png";
            }
                baglanti.Close();
        }
    }
}
