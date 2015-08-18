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
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.cmbCita = new System.Windows.Forms.ComboBox();
            this.lblCita = new System.Windows.Forms.Label();
            this.gbTipoPago = new System.Windows.Forms.GroupBox();
            this.rbTarjeta = new System.Windows.Forms.RadioButton();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.pServicios = new System.Windows.Forms.Panel();
            this.grdDetalleFactura = new System.Windows.Forms.DataGridView();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbExamen = new System.Windows.Forms.ComboBox();
            this.lblTipoExamen = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Examen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPanelEncabezado.SuspendLayout();
            this.gbTipoPago.SuspendLayout();
            this.pServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleFactura)).BeginInit();
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
            this.pPanelEncabezado.Controls.Add(this.cmbSucursal);
            this.pPanelEncabezado.Controls.Add(this.lblSucursal);
            this.pPanelEncabezado.Controls.Add(this.cmbCita);
            this.pPanelEncabezado.Controls.Add(this.lblCita);
            this.pPanelEncabezado.Controls.Add(this.gbTipoPago);
            this.pPanelEncabezado.Controls.Add(this.txtNo);
            this.pPanelEncabezado.Controls.Add(this.label3);
            this.pPanelEncabezado.Controls.Add(this.label2);
            this.pPanelEncabezado.Controls.Add(this.txtFecha);
            this.pPanelEncabezado.Controls.Add(this.label1);
            this.pPanelEncabezado.Controls.Add(this.txtNombre);
            this.pPanelEncabezado.Controls.Add(this.lblNombre);
            this.pPanelEncabezado.Controls.Add(this.txtNit);
            this.pPanelEncabezado.Location = new System.Drawing.Point(159, 12);
            this.pPanelEncabezado.Name = "pPanelEncabezado";
            this.pPanelEncabezado.Size = new System.Drawing.Size(911, 151);
            this.pPanelEncabezado.TabIndex = 1;
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(526, 112);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(343, 21);
            this.cmbSucursal.TabIndex = 48;
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.BackColor = System.Drawing.Color.Transparent;
            this.lblSucursal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.Location = new System.Drawing.Point(451, 111);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(67, 19);
            this.lblSucursal.TabIndex = 47;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // cmbCita
            // 
            this.cmbCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCita.Enabled = false;
            this.cmbCita.FormattingEnabled = true;
            this.cmbCita.Location = new System.Drawing.Point(109, 110);
            this.cmbCita.Name = "cmbCita";
            this.cmbCita.Size = new System.Drawing.Size(319, 21);
            this.cmbCita.TabIndex = 46;
            // 
            // lblCita
            // 
            this.lblCita.AutoSize = true;
            this.lblCita.BackColor = System.Drawing.Color.Transparent;
            this.lblCita.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCita.Location = new System.Drawing.Point(21, 110);
            this.lblCita.Name = "lblCita";
            this.lblCita.Size = new System.Drawing.Size(39, 19);
            this.lblCita.TabIndex = 45;
            this.lblCita.Text = "Cita:";
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
            // txtNo
            // 
            this.txtNo.Enabled = false;
            this.txtNo.Location = new System.Drawing.Point(822, 18);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(47, 20);
            this.txtNo.TabIndex = 43;
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
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(524, 64);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(345, 20);
            this.txtFecha.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "Fecha:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(109, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(319, 20);
            this.txtNombre.TabIndex = 38;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(21, 65);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 19);
            this.lblNombre.TabIndex = 37;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerar.Location = new System.Drawing.Point(1076, 52);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(110, 50);
            this.btnGenerar.TabIndex = 49;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // pServicios
            // 
            this.pServicios.Controls.Add(this.grdDetalleFactura);
            this.pServicios.Controls.Add(this.cmbDoctor);
            this.pServicios.Controls.Add(this.label4);
            this.pServicios.Controls.Add(this.cmbExamen);
            this.pServicios.Controls.Add(this.lblTipoExamen);
            this.pServicios.Enabled = false;
            this.pServicios.Location = new System.Drawing.Point(45, 169);
            this.pServicios.Name = "pServicios";
            this.pServicios.Size = new System.Drawing.Size(1154, 334);
            this.pServicios.TabIndex = 50;
            // 
            // grdDetalleFactura
            // 
            this.grdDetalleFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalleFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Doctor,
            this.Examen,
            this.Precio});
            this.grdDetalleFactura.Location = new System.Drawing.Point(25, 46);
            this.grdDetalleFactura.Name = "grdDetalleFactura";
            this.grdDetalleFactura.Size = new System.Drawing.Size(1100, 267);
            this.grdDetalleFactura.TabIndex = 46;
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(335, 14);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(261, 21);
            this.cmbDoctor.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 44;
            this.label4.Text = "Doctor:";
            // 
            // cmbExamen
            // 
            this.cmbExamen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExamen.FormattingEnabled = true;
            this.cmbExamen.Location = new System.Drawing.Point(85, 15);
            this.cmbExamen.Name = "cmbExamen";
            this.cmbExamen.Size = new System.Drawing.Size(182, 21);
            this.cmbExamen.TabIndex = 43;
            // 
            // lblTipoExamen
            // 
            this.lblTipoExamen.AutoSize = true;
            this.lblTipoExamen.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoExamen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoExamen.Location = new System.Drawing.Point(21, 15);
            this.lblTipoExamen.Name = "lblTipoExamen";
            this.lblTipoExamen.Size = new System.Drawing.Size(64, 19);
            this.lblTipoExamen.TabIndex = 42;
            this.lblTipoExamen.Text = "Examen:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(1076, 108);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 50);
            this.btnAgregar.TabIndex = 51;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Doctor
            // 
            this.Doctor.HeaderText = "Doctor";
            this.Doctor.Name = "Doctor";
            this.Doctor.ReadOnly = true;
            // 
            // Examen
            // 
            this.Examen.HeaderText = "Examen";
            this.Examen.Name = "Examen";
            this.Examen.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1253, 529);
            this.ControlBox = false;
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pServicios);
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
            this.pServicios.ResumeLayout(false);
            this.pServicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Panel pPanelEncabezado;
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
        private System.Windows.Forms.Panel pServicios;
        private System.Windows.Forms.ComboBox cmbExamen;
        private System.Windows.Forms.Label lblTipoExamen;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView grdDetalleFactura;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.ComboBox cmbCita;
        private System.Windows.Forms.Label lblCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Examen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;

    }
}