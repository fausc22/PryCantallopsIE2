using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryCantallopsIE
{
    public partial class frmLogo : Form
    {
        public frmLogo()
        {
            InitializeComponent();
        }

        int contador = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador += 1000;

            if (contador > 3000)
            {
                this.Hide();
                frmLogin frm = new frmLogin();
                frm.Show();
                timer1.Enabled = false;
            }
        }
    }
}
