namespace PryCantallopsIE
{
    partial class frmProveedoresActivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedoresActivo));
            this.tvCarpetas = new System.Windows.Forms.TreeView();
            this.rtbContenidoArchivo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tvCarpetas
            // 
            this.tvCarpetas.Location = new System.Drawing.Point(12, 84);
            this.tvCarpetas.Name = "tvCarpetas";
            this.tvCarpetas.Size = new System.Drawing.Size(319, 281);
            this.tvCarpetas.TabIndex = 0;
            this.tvCarpetas.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvCarpetas_AfterSelect);
            // 
            // rtbContenidoArchivo
            // 
            this.rtbContenidoArchivo.Location = new System.Drawing.Point(337, 84);
            this.rtbContenidoArchivo.Name = "rtbContenidoArchivo";
            this.rtbContenidoArchivo.ReadOnly = true;
            this.rtbContenidoArchivo.Size = new System.Drawing.Size(366, 281);
            this.rtbContenidoArchivo.TabIndex = 1;
            this.rtbContenidoArchivo.Text = "";
            this.rtbContenidoArchivo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "SELECCIONE UN ARCHIVO";
            // 
            // frmProveedoresActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 377);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbContenidoArchivo);
            this.Controls.Add(this.tvCarpetas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProveedoresActivo";
            this.Text = "PROVEEDORES ACTIVO";
            this.Load += new System.EventHandler(this.frmProveedoresActivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvCarpetas;
        private System.Windows.Forms.RichTextBox rtbContenidoArchivo;
        private System.Windows.Forms.Label label1;
    }
}