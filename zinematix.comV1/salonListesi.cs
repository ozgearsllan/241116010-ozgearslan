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
    public partial class salonListesi : UserControl
    {
        public salonListesi()
        {
            InitializeComponent();
        }

        private void lblkoltuk_Click(object sender, EventArgs e)
        {

        }

        private void gel(object sender, MouseEventArgs e)
        {

            this.BackColor = Color.LightSalmon;
        }

        private void ayril(object sender, EventArgs e)
        {

            this.BackColor = Color.DarkRed;
        }

        private void salonListesi_Load(object sender, EventArgs e)
        {

        }
    }
}
