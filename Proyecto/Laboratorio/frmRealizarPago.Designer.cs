namespace Laboratorio
{
    partial class frmRealizarPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRealizarPago));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDpi = new System.Windows.Forms.TextBox();
            this.lblDpi = new System.Windows.Forms.Label();
            this.grdPago = new System.Windows.Forms.DataGridView();
            this.nombreSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPagoRealizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblImporte = new System.Windows.Forms.Label();
            this.txtHacerPago = new System.Windows.Forms.TextBox();
            this.lblConfirmacionPago = new System.Windows.Forms.Label();
            this.txtConfirmePago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatosPersonales = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPago)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 311);
            this.panel1.TabIndex = 9;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 206);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(110, 50);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(12, 45);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 50);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Hacer Pago.";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(12, 126);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 50);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDpi
            // 
            this.txtDpi.Location = new System.Drawing.Point(195, 33);
            this.txtDpi.Name = "txtDpi";
            this.txtDpi.Size = new System.Drawing.Size(400, 20);
            this.txtDpi.TabIndex = 17;
            this.txtDpi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDpi_KeyPress);
            this.txtDpi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDpi_KeyUp);
            // 
            // lblDpi
            // 
            this.lblDpi.AutoSize = true;
            this.lblDpi.BackColor = System.Drawing.Color.Transparent;
            this.lblDpi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDpi.Location = new System.Drawing.Point(154, 32);
            this.lblDpi.Name = "lblDpi";
            this.lblDpi.Size = new System.Drawing.Size(35, 19);
            this.lblDpi.TabIndex = 16;
            this.lblDpi.Text = "Dpi:";
            // 
            // grdPago
            // 
            this.grdPago.AllowUserToDeleteRows = false;
            this.grdPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreSucursal,
            this.txtTotal,
            this.txtSaldo,
            this.txtPagoRealizado,
            this.txtEstado});
            this.grdPago.Location = new System.Drawing.Point(158, 185);
            this.grdPago.Name = "grdPago";
            this.grdPago.ReadOnly = true;
            this.grdPago.Size = new System.Drawing.Size(545, 195);
            this.grdPago.TabIndex = 18;
            this.grdPago.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPago_CellContentClick);
            // 
            // nombreSucursal
            // 
            this.nombreSucursal.HeaderText = "No. Factura.";
            this.nombreSucursal.Name = "nombreSucursal";
            this.nombreSucursal.ReadOnly = true;
            // 
            // txtTotal
            // 
            this.txtTotal.HeaderText = "Total Fac.";
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            // 
            // txtSaldo
            // 
            this.txtSaldo.HeaderText = "Saldo.";
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            // 
            // txtPagoRealizado
            // 
            this.txtPagoRealizado.HeaderText = "Pago Realizado.";
            this.txtPagoRealizado.Name = "txtPagoRealizado";
            this.txtPagoRealizado.ReadOnly = true;
            // 
            // txtEstado
            // 
            this.txtEstado.HeaderText = "Estado.";
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.BackColor = System.Drawing.Color.Transparent;
            this.lblImporte.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(199, 67);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(78, 19);
            this.lblImporte.TabIndex = 22;
            this.lblImporte.Text = "Importe Q.";
            // 
            // txtHacerPago
            // 
            this.txtHacerPago.Location = new System.Drawing.Point(283, 67);
            this.txtHacerPago.Name = "txtHacerPago";
            this.txtHacerPago.Size = new System.Drawing.Size(146, 20);
            this.txtHacerPago.TabIndex = 21;
            this.txtHacerPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHacerPago_KeyPress);
            // 
            // lblConfirmacionPago
            // 
            this.lblConfirmacionPago.AutoSize = true;
            this.lblConfirmacionPago.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmacionPago.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmacionPago.Location = new System.Drawing.Point(155, 94);
            this.lblConfirmacionPago.Name = "lblConfirmacionPago";
            this.lblConfirmacionPago.Size = new System.Drawing.Size(122, 19);
            this.lblConfirmacionPago.TabIndex = 24;
            this.lblConfirmacionPago.Text = "Confirme Pago Q.";
            // 
            // txtConfirmePago
            // 
            this.txtConfirmePago.Location = new System.Drawing.Point(283, 95);
            this.txtConfirmePago.Name = "txtConfirmePago";
            this.txtConfirmePago.Size = new System.Drawing.Size(146, 20);
            this.txtConfirmePago.TabIndex = 23;
            this.txtConfirmePago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmePago_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Datos del Paciente.";
            // 
            // txtDatosPersonales
            // 
            this.txtDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatosPersonales.Location = new System.Drawing.Point(296, 146);
            this.txtDatosPersonales.Name = "txtDatosPersonales";
            this.txtDatosPersonales.ReadOnly = true;
            this.txtDatosPersonales.Size = new System.Drawing.Size(400, 29);
            this.txtDatosPersonales.TabIndex = 26;
            // 
            // frmRealizarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 428);
            this.Controls.Add(this.txtDatosPersonales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConfirmacionPago);
            this.Controls.Add(this.txtConfirmePago);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.txtHacerPago);
            this.Controls.Add(this.grdPago);
            this.Controls.Add(this.txtDpi);
            this.Controls.Add(this.lblDpi);
            this.Controls.Add(this.panel1);
            this.Name = "frmRealizarPago";
            this.Text = "frmRealizarPago";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtDpi;
        private System.Windows.Forms.Label lblDpi;
        private System.Windows.Forms.DataGridView grdPago;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.TextBox txtHacerPago;
        private System.Windows.Forms.Label lblConfirmacionPago;
        private System.Windows.Forms.TextBox txtConfirmePago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatosPersonales;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPagoRealizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEstado;
    }
}