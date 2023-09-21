﻿using System;
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
    public partial class frmRegistroProveedores : Form
    {
        public frmRegistroProveedores()
        {
            InitializeComponent();
        }

        clsProveedores ObjP = new clsProveedores();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistroProveedores_Load(object sender, EventArgs e)
        {
            ObjP.CargarInfo(dgvProveedores, cmbJuzg, cmbJuri, cmbLiqui);
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNro.Text);
            string entidad = txtEntidad.Text;
            string apertura = dtpApertura.Value.ToShortDateString();
            string expediente = txtExpediente.Text;
            string juzgado = cmbJuzg.Text;
            string juris = cmbJuri.Text;
            string liqui = cmbLiqui.Text;
            string direccion = txtDireccion.Text;

            ObjP.Registrar(numero, entidad, apertura, expediente, juzgado, juris, direccion, liqui);
            ObjP.CargarInfo(dgvProveedores, cmbJuzg, cmbJuri, cmbLiqui);

        }

        private void dgvProveedores_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProveedores.Rows[e.RowIndex];

                txtNro.Text = fila.Cells[0].Value.ToString();
                txtEntidad.Text = fila.Cells[1].Value.ToString();
                txtNro.Text = fila.Cells[2].Value.ToString();
                dtpApertura.Value = Convert.ToDateTime(fila.Cells[3].Value.ToString());
                txtExpediente.Text = fila.Cells[0].Value.ToString();

            }
        }
    }
}