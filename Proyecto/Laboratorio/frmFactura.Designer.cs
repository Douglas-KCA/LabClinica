namespace Laboratorio
{
    partial class frmFactura
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
            this.txtNit = new System.Windows.Forms.TextBox();
            this.pPanelEncabezado = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.gbTipoPago = new System.Windows.Forms.GroupBox();
            this.txtNoTarjeta = new System.Windows.Forms.TextBox();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.txtVencimiento = new System.Windows.Forms.TextBox();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.rbTarjeta = new System.Windows.Forms.RadioButton();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.pPanelEncabezado.SuspendLayout();
            this.gbTipoPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(59, 18);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(180, 20);
            this.txtNit.TabIndex = 0;
            this.txtNit.TextChanged += new System.EventHandler(this.txtNit_TextChanged);
            // 
            // pPanelEncabezado
            // 
            this.pPanelEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPanelEncabezado.Controls.Add(this.txtVencimiento);
            this.pPanelEncabezado.Controls.Add(this.lblVencimiento);
            this.pPanelEncabezado.Controls.Add(this.txtNoTarjeta);
            this.pPanelEncabezado.Controls.Add(this.lblTarjeta);
            this.pPanelEncabezado.Controls.Add(this.gbTipoPago);
            this.pPanelEncabezado.Controls.Add(this.txtNo);
            this.pPanelEncabezado.Controls.Add(this.label3);
            this.pPanelEncabezado.Controls.Add(this.label2);
            this.pPanelEncabezado.Controls.Add(this.txtFecha);
            this.pPanelEncabezado.Controls.Add(this.label1);
            this.pPanelEncabezado.Controls.Add(this.txtNombre);
            this.pPanelEncabezado.Controls.Add(this.lblNombre);
            this.pPanelEncabezado.Controls.Add(this.txtNit);
            this.pPanelEncabezado.Location = new System.Drawing.Point(183, 26);
            this.pPanelEncabezado.Name = "pPanelEncabezado";
            this.pPanelEncabezado.Size = new System.Drawing.Size(911, 151);
            this.pPanelEncabezado.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(109, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(319, 20);
            this.txtNombre.TabIndex = 38;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(21, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 19);
            this.lblNombre.TabIndex = 37;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(524, 69);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(345, 20);
            this.txtFecha.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(785, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "Nit:";
            // 
            // txtNo
            // 
            this.txtNo.Enabled = false;
            this.txtNo.Location = new System.Drawing.Point(822, 18);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(47, 20);
            this.txtNo.TabIndex = 43;
            // 
            // gbTipoPago
            // 
            this.gbTipoPago.Controls.Add(this.rbTarjeta);
            this.gbTipoPago.Controls.Add(this.rbEfectivo);
            this.gbTipoPago.Location = new System.Drawing.Point(371, 6);
            this.gbTipoPago.Name = "gbTipoPago";
            this.gbTipoPago.Size = new System.Drawing.Size(238, 47);
            this.gbTipoPago.TabIndex = 44;
            this.gbTipoPago.TabStop = false;
            this.gbTipoPago.Text = "Tipo de Pago";
            // 
            // txtNoTarjeta
            // 
            this.txtNoTarjeta.Location = new System.Drawing.Point(109, 113);
            this.txtNoTarjeta.Name = "txtNoTarjeta";
            this.txtNoTarjeta.Size = new System.Drawing.Size(319, 20);
            this.txtNoTarjeta.TabIndex = 46;
            this.txtNoTarjeta.Visible = false;
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.lblTarjeta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarjeta.Location = new System.Drawing.Point(21, 114);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(84, 19);
            this.lblTarjeta.TabIndex = 45;
            this.lblTarjeta.Text = "No. Tarjeta:";
            this.lblTarjeta.Visible = false;
            // 
            // txtVencimiento
            // 
            this.txtVencimiento.Location = new System.Drawing.Point(608, 111);
            this.txtVencimiento.Name = "txtVencimiento";
            this.txtVencimiento.Size = new System.Drawing.Size(261, 20);
            this.txtVencimiento.TabIndex = 48;
            this.txtVencimiento.Visible = false;
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblVencimiento.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimiento.Location = new System.Drawing.Point(451, 110);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(155, 19);
            this.lblVencimiento.TabIndex = 47;
            this.lblVencimiento.Text = "Fecha de Vencimiento:";
            this.lblVencimiento.Visible = false;
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Location = new System.Drawing.Point(20, 19);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rbEfectivo.TabIndex = 0;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            this.rbEfectivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbEfectivo_MouseClick);
            // 
            // rbTarjeta
            // 
            this.rbTarjeta.AutoSize = true;
            this.rbTarjeta.Location = new System.Drawing.Point(108, 19);
            this.rbTarjeta.Name = "rbTarjeta";
            this.rbTarjeta.Size = new System.Drawing.Size(109, 17);
            this.rbTarjeta.TabIndex = 1;
            this.rbTarjeta.TabStop = true;
            this.rbTarjeta.Text = "Tarjeta de Credito";
            this.rbTarjeta.UseVisualStyleBackColor = true;
            this.rbTarjeta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbTarjeta_MouseClick);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerar.Location = new System.Drawing.Point(1100, 127);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(110, 50);
            this.btnGenerar.TabIndex = 49;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1253, 477);
            this.ControlBox = false;
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.pPanelEncabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.pPanelEncabezado.ResumeLayout(false);
            this.pPanelEncabezado.PerformLayout();
            this.gbTipoPago.ResumeLayout(false);
            this.gbTipoPago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Panel pPanelEncabezado;
        private System.Windows.Forms.TextBox txtVencimiento;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.TextBox txtNoTarjeta;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.GroupBox gbTipoPago;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.RadioButton rbTarjeta;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.Button btnGenerar;

    }
}