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
    public partial class filmListesi : UserControl
    {
        public filmListesi()
        {
            InitializeComponent();
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void btnyuklee_Click(object sender, EventArgs e)
        {
            FrmFilmDetay frm = new FrmFilmDetay();
            frm.idno = lblıd.Text;
            frm.ShowDialog();

        }
    }
}
