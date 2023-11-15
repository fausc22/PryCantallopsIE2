using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PryCantallopsIE
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            
        }
        int contador = 0;

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtUsuario.Text != null)
            {
                txtContrasenia.Enabled = true;
            }
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
            if (txtContrasenia.Text != "" && txtContrasenia.Text != null)
            {
                btnIniciar.Enabled = true;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string pw = txtContrasenia.Text;
            string Hora = Convert.ToString(DateTime.Now);
            
            
            clsUser ObjUser = new clsUser();

            
            
            if (ObjUser.IniciarSesion(user, pw))
            {
                this.Hide();
                frmMain f = new frmMain();
                f.Show();
                ObjUser.RegistrarLog(Hora, user, "Inicio de Sesion");
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos.", "ERROR", MessageBoxButtons.OK);
                txtUsuario.Text = "";
                txtContrasenia.Text = "";
                contador++;
                if (contador == 3)
                {
                    MessageBox.Show("Has alcanzado el limite de intentos incorrectos.", "ERROR", MessageBoxButtons.OK);
                    this.Close();
                }

            }
            
            
            




            //int contador = 0;

            //if (contador < 3)
            //{
            //    if (txtUsuario.Text == "admin" && txtContrasenia.Text == "123")
            //    {
            //        this.Hide();
            //        frmMain f = new frmMain();
            //        f.Show();
            //    }
            //    else if (txtUsuario.Text == "guest" && txtContrasenia.Text == "123")
            //    {
            //        this.Hide();
            //        frmMain f = new frmMain();
            //        f.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Usuario y/o contraseña incorrectos.", "ERROR", MessageBoxButtons.OK);
            //        txtUsuario.Text = "";
            //        txtContrasenia.Text = "";
            //        contador++;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Ha alcanzado el límite de intentos incorrectos. El formulario se cerrará.", "ERROR", MessageBoxButtons.OK);
            //    this.Close();
            //}































        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
