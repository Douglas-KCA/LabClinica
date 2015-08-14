namespace Laboratorio
{
    partial class frmConsultaDeuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaDeuda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtBuscarDeuda = new System.Windows.Forms.TextBox();
            this.lblBuscarDeuda = new System.Windows.Forms.Label();
            this.grdDeuda = new System.Windows.Forms.DataGridView();
            this.nombrePersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeuda)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 163);
            this.panel1.TabIndex = 14;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(12, 42);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 50);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(12, 98);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 50);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtBuscarDeuda
            // 
            this.txtBuscarDeuda.Location = new System.Drawing.Point(277, 29);
            this.txtBuscarDeuda.Name = "txtBuscarDeuda";
            this.txtBuscarDeuda.Size = new System.Drawing.Size(386, 20);
            this.txtBuscarDeuda.TabIndex = 33;
            // 
            // lblBuscarDeuda
            // 
            this.lblBuscarDeuda.AutoSize = true;
            this.lblBuscarDeuda.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarDeuda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarDeuda.Location = new System.Drawing.Point(153, 25);
            this.lblBuscarDeuda.Name = "lblBuscarDeuda";
            this.lblBuscarDeuda.Size = new System.Drawing.Size(118, 19);
            this.lblBuscarDeuda.TabIndex = 32;
            this.lblBuscarDeuda.Text = "Codigo Paciente:";
            // 
            // grdDeuda
            // 
            this.grdDeuda.AllowUserToAddRows = false;
            this.grdDeuda.AllowUserToDeleteRows = false;
            this.grdDeuda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDeuda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombrePersona,
            this.apellidoPersona,
            this.numeroFactura,
            this.fechaFactura,
            this.totalDeuda,
            this.saldoDeuda});
            this.grdDeuda.Location = new System.Drawing.Point(157, 55);
            this.grdDeuda.Name = "grdDeuda";
            this.grdDeuda.ReadOnly = true;
            this.grdDeuda.Size = new System.Drawing.Size(603, 89);
            this.grdDeuda.TabIndex = 34;
            // 
            // nombrePersona
            // 
            this.nombrePersona.DataPropertyName = "jj";
            this.nombrePersona.HeaderText = "Nombre";
            this.nombrePersona.Name = "nombrePersona";
            this.nombrePersona.ReadOnly = true;
            // 
            // apellidoPersona
            // 
            this.apellidoPersona.HeaderText = "Apellido";
            this.apellidoPersona.Name = "apellidoPersona";
            this.apellidoPersona.ReadOnly = true;
            // 
            // numeroFactura
            // 
            this.numeroFactura.HeaderText = "No. Factura";
            this.numeroFactura.Name = "numeroFactura";
            this.numeroFactura.ReadOnly = true;
            // 
            // fechaFactura
            // 
            this.fechaFactura.HeaderText = "Fecha Emision";
            this.fechaFactura.Name = "fechaFactura";
            this.fechaFactura.ReadOnly = true;
            // 
            // totalDeuda
            // 
            this.totalDeuda.HeaderText = "Total Deuda";
            this.totalDeuda.Name = "totalDeuda";
            this.totalDeuda.ReadOnly = true;
            // 
            // saldoDeuda
            // 
            this.saldoDeuda.HeaderText = "Saldo";
            this.saldoDeuda.Name = "saldoDeuda";
            this.saldoDeuda.ReadOnly = true;
            // 
            // frmConsultaDeuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 188);
            this.Controls.Add(this.grdDeuda);
            this.Controls.Add(this.txtBuscarDeuda);
            this.Controls.Add(this.lblBuscarDeuda);
            this.Controls.Add(this.panel1);
            this.Name = "frmConsultaDeuda";
            this.Text = "frmConsultaDeuda";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDeuda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtBuscarDeuda;
        private System.Windows.Forms.Label lblBuscarDeuda;
        private System.Windows.Forms.DataGridView grdDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDeuda;
    }
}