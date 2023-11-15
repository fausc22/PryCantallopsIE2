using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryCantallopsIE
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        clsUser objUser = new clsUser();

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            string user = objUser.ObtenerNombreUsuario();
            string rol = objUser.ObtenerRolUsuario();
            toolUsuario.Text = user;
            ActualizarMenuSegunRol(rol);
        }

        private void toolFecha_Click(object sender, EventArgs e)
        {

        }

        int contador = 0;
        private void timerHora_Tick(object sender, EventArgs e)
        {
            contador += 1000;
            toolHora.Text = Convert.ToString(DateTime.Now);
        }

        private void aaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroProveedores f = new frmRegistroProveedores();
            f.ShowDialog();

            string user = toolUsuario.Text;
            string Hora = Convert.ToString(DateTime.Now);
            string Ruta = "logsMenu.txt";
            string menu = registroDeProveedoresToolStripMenuItem.Text;

            using (StreamWriter writer = new StreamWriter(Ruta, true))
            {
                writer.WriteLine($"{user} - Hora de ingreso: {Hora} - Ingreso: {menu}");
            }
        }

        private void activosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedoresActivo f = new frmProveedoresActivo();
            f.ShowDialog();

            string user = toolUsuario.Text;
            string Hora = Convert.ToString(DateTime.Now);
            string Ruta = "logsMenu.txt";
            string menu = activosToolStripMenuItem.Text;

            using (StreamWriter writer = new StreamWriter(Ruta, true))
            {
                writer.WriteLine($"{user} - Hora de ingreso: {Hora} - Ingreso: {menu}");
            }
        }

        private void ActualizarMenuSegunRol(string rol)
        {
           

            if (rol == "ADMIN")
            {
                gestionToolStripMenuItem.Visible = true;
                aaToolStripMenuItem.Visible = true;
            }
            else 
            {
                if (rol == "GUEST")
                {
                    gestionToolStripMenuItem.Visible = true;
                    aaToolStripMenuItem.Visible = false;

                }
                
            }
        }

        private void crearNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsuarios = new frmUsuarios();
            frmUsuarios.ShowDialog();
        }
    }
}
