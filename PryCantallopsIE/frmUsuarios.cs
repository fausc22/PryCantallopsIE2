using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace PryCantallopsIE
{
    public partial class frmUsuarios : Form
    {
        private List<Point> points = new List<Point>();
        private bool isDrawing = false;
        string rutaArchivo = @"../../firma.png";
        clsUser objBD = new clsUser();
        public frmUsuarios()
        {
            InitializeComponent();
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            points.Add(e.Location);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                points.Add(e.Location);
                pictureBox1.Invalidate(); // Redibujar el PictureBox
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (points.Count > 1)
            {
                using (Pen pen = new Pen(Color.Black, 2))
                {
                    e.Graphics.DrawCurve(pen, points.ToArray());
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string pw = txtPass.Text;
            string rol = cmbRol.Text;
            
            objBD.CargarUsuario(user, pw, rol, ObtenerFirma());
        }

        private byte[] ObtenerFirma()
        {
            Bitmap signatureBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            using (Graphics g = Graphics.FromImage(signatureBitmap))
            {
                g.Clear(Color.White);
                if (points.Count > 1)
                {
                    using (Pen pen = new Pen(Color.Black, 2))
                    {
                        g.DrawCurve(pen, points.ToArray());
                    }
                }
            }

            using (MemoryStream stream = new MemoryStream())
            {
                signatureBitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        //private void GuardarFirma()
        //{
        //    Bitmap signatureBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

        //    using (Graphics g = Graphics.FromImage(signatureBitmap))
        //    {
        //        g.Clear(Color.White); 
        //        if (points.Count > 1)
        //        {
        //            using (Pen pen = new Pen(Color.Black, 2))
        //            {
        //                g.DrawCurve(pen, points.ToArray());
        //            }
        //        }
        //    }



        //    signatureBitmap.Save(rutaArchivo, System.Drawing.Imaging.ImageFormat.Png);
        //}
    }
}
