namespace PryCantallopsIE
{
    partial class frmRegistroProveedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroProveedores));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtpApertura = new System.Windows.Forms.DateTimePicker();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.cmbJuzg = new System.Windows.Forms.ComboBox();
            this.cmbLiqui = new System.Windows.Forms.ComboBox();
            this.cmbJuri = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtExpediente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nroexp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JUZG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JURISD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LIQUIDADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.dtpApertura);
            this.groupBox1.Controls.Add(this.txtEntidad);
            this.groupBox1.Controls.Add(this.cmbJuzg);
            this.groupBox1.Controls.Add(this.cmbLiqui);
            this.groupBox1.Controls.Add(this.cmbJuri);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtNro);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtExpediente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1089, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(625, 500);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos proveedor";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(303, 441);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(183, 48);
            this.btnEliminar.TabIndex = 30;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(27, 442);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(183, 47);
            this.btnModificar.TabIndex = 29;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(27, 390);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(183, 48);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // dtpApertura
            // 
            this.dtpApertura.Location = new System.Drawing.Point(268, 142);
            this.dtpApertura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpApertura.Name = "dtpApertura";
            this.dtpApertura.Size = new System.Drawing.Size(268, 22);
            this.dtpApertura.TabIndex = 27;
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(268, 95);
            this.txtEntidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(268, 22);
            this.txtEntidad.TabIndex = 26;
            // 
            // cmbJuzg
            // 
            this.cmbJuzg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJuzg.FormattingEnabled = true;
            this.cmbJuzg.Location = new System.Drawing.Point(271, 217);
            this.cmbJuzg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbJuzg.Name = "cmbJuzg";
            this.cmbJuzg.Size = new System.Drawing.Size(268, 24);
            this.cmbJuzg.TabIndex = 25;
            // 
            // cmbLiqui
            // 
            this.cmbLiqui.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLiqui.FormattingEnabled = true;
            this.cmbLiqui.Location = new System.Drawing.Point(271, 308);
            this.cmbLiqui.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbLiqui.Name = "cmbLiqui";
            this.cmbLiqui.Size = new System.Drawing.Size(268, 24);
            this.cmbLiqui.TabIndex = 24;
            // 
            // cmbJuri
            // 
            this.cmbJuri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJuri.FormattingEnabled = true;
            this.cmbJuri.Location = new System.Drawing.Point(271, 260);
            this.cmbJuri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbJuri.Name = "cmbJuri";
            this.cmbJuri.Size = new System.Drawing.Size(268, 24);
            this.cmbJuri.TabIndex = 23;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(271, 348);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(268, 22);
            this.txtDireccion.TabIndex = 21;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtNro
            // 
            this.txtNro.Location = new System.Drawing.Point(268, 49);
            this.txtNro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(268, 22);
            this.txtNro.TabIndex = 16;
            this.txtNro.TextChanged += new System.EventHandler(this.txtNro_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Jurisdiccion";
            // 
            // txtExpediente
            // 
            this.txtExpediente.Location = new System.Drawing.Point(268, 177);
            this.txtExpediente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExpediente.Name = "txtExpediente";
            this.txtExpediente.Size = new System.Drawing.Size(268, 22);
            this.txtExpediente.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Liquidacion Responsable";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Juzgazo ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "N° Expediente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apertura";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "N°";
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro,
            this.Entidad,
            this.Apertura,
            this.Nroexp,
            this.JUZG,
            this.JURISD,
            this.DIRECCION,
            this.LIQUIDADOR});
            this.dgvProveedores.Location = new System.Drawing.Point(15, 43);
            this.dgvProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.RowHeadersWidth = 51;
            this.dgvProveedores.RowTemplate.Height = 24;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(1068, 500);
            this.dgvProveedores.TabIndex = 4;
            this.dgvProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellClick);
            this.dgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellContentClick);
            this.dgvProveedores.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProveedores_CellMouseDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(724, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(289, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "Registrar Datos del Proveedor";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Location = new System.Drawing.Point(303, 390);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(183, 47);
            this.btnLimpiar.TabIndex = 31;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Nro
            // 
            this.Nro.HeaderText = "N°";
            this.Nro.Name = "Nro";
            this.Nro.ReadOnly = true;
            // 
            // Entidad
            // 
            this.Entidad.HeaderText = "Entidad";
            this.Entidad.Name = "Entidad";
            this.Entidad.ReadOnly = true;
            // 
            // Apertura
            // 
            this.Apertura.HeaderText = "APERTURA";
            this.Apertura.Name = "Apertura";
            // 
            // Nroexp
            // 
            this.Nroexp.HeaderText = "N° EXPTE.";
            this.Nroexp.Name = "Nroexp";
            this.Nroexp.ReadOnly = true;
            // 
            // JUZG
            // 
            this.JUZG.HeaderText = "JUZG.";
            this.JUZG.Name = "JUZG";
            this.JUZG.ReadOnly = true;
            // 
            // JURISD
            // 
            this.JURISD.HeaderText = "JURISD";
            this.JURISD.Name = "JURISD";
            this.JURISD.ReadOnly = true;
            // 
            // DIRECCION
            // 
            this.DIRECCION.HeaderText = "DIRECCION";
            this.DIRECCION.Name = "DIRECCION";
            this.DIRECCION.ReadOnly = true;
            // 
            // LIQUIDADOR
            // 
            this.LIQUIDADOR.HeaderText = "LIQUIDADOR RESPONSABLE";
            this.LIQUIDADOR.Name = "LIQUIDADOR";
            this.LIQUIDADOR.ReadOnly = true;
            // 
            // frmRegistroProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1716, 574);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRegistroProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Datos del Proveedor";
            this.Load += new System.EventHandler(this.frmRegistroProveedores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExpediente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNro;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbJuzg;
        private System.Windows.Forms.ComboBox cmbLiqui;
        private System.Windows.Forms.ComboBox cmbJuri;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.DateTimePicker dtpApertura;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nroexp;
        private System.Windows.Forms.DataGridViewTextBoxColumn JUZG;
        private System.Windows.Forms.DataGridViewTextBoxColumn JURISD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIQUIDADOR;
    }
}