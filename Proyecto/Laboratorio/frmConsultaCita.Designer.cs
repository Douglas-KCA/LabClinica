namespace Laboratorio
{
    partial class frmConsultaCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCita));
            this.grdCita = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpActualizar = new System.Windows.Forms.GroupBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cmbActualizarHora = new System.Windows.Forms.ComboBox();
            this.dtpActualizarCitas = new System.Windows.Forms.DateTimePicker();
            this.cmbActualizarMinutos = new System.Windows.Forms.ComboBox();
            this.lblDosPuntos = new System.Windows.Forms.Label();
            this.cmbActualizarPaciente = new System.Windows.Forms.ComboBox();
            this.cmbActualizarSucursal = new System.Windows.Forms.ComboBox();
            this.lblActualizarHora = new System.Windows.Forms.Label();
            this.lblActualizarFecha = new System.Windows.Forms.Label();
            this.lblActualizarPaciente = new System.Windows.Forms.Label();
            this.lblActualizarSucursal = new System.Windows.Forms.Label();
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdCita)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpActualizar.SuspendLayout();
            this.grpBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdCita
            // 
            this.grdCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.nombreSucursal,
            this.ubicacionSucursal,
            this.Fecha,
            this.Hora});
            this.grdCita.Location = new System.Drawing.Point(166, 224);
            this.grdCita.Name = "grdCita";
            this.grdCita.Size = new System.Drawing.Size(906, 221);
            this.grdCita.TabIndex = 1;
            this.grdCita.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCita_CellEnter);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // nombreSucursal
            // 
            this.nombreSucursal.HeaderText = "Sucursal";
            this.nombreSucursal.Name = "nombreSucursal";
            // 
            // ubicacionSucursal
            // 
            this.ubicacionSucursal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ubicacionSucursal.HeaderText = "Paciente";
            this.ubicacionSucursal.Name = "ubicacionSucursal";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(12, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 425);
            this.panel1.TabIndex = 13;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 333);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(110, 50);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(12, 186);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 50);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(12, 43);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 50);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(12, 115);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(110, 50);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(12, 259);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 50);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grpActualizar
            // 
            this.grpActualizar.Controls.Add(this.cmbEmpleado);
            this.grpActualizar.Controls.Add(this.lblEmpleado);
            this.grpActualizar.Controls.Add(this.cmbActualizarHora);
            this.grpActualizar.Controls.Add(this.dtpActualizarCitas);
            this.grpActualizar.Controls.Add(this.cmbActualizarMinutos);
            this.grpActualizar.Controls.Add(this.lblDosPuntos);
            this.grpActualizar.Controls.Add(this.cmbActualizarPaciente);
            this.grpActualizar.Controls.Add(this.cmbActualizarSucursal);
            this.grpActualizar.Controls.Add(this.lblActualizarHora);
            this.grpActualizar.Controls.Add(this.lblActualizarFecha);
            this.grpActualizar.Controls.Add(this.lblActualizarPaciente);
            this.grpActualizar.Controls.Add(this.lblActualizarSucursal);
            this.grpActualizar.Location = new System.Drawing.Point(166, 101);
            this.grpActualizar.Name = "grpActualizar";
            this.grpActualizar.Size = new System.Drawing.Size(906, 107);
            this.grpActualizar.TabIndex = 38;
            this.grpActualizar.TabStop = false;
            this.grpActualizar.Text = "Actualizar";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(679, 24);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(221, 21);
            this.cmbEmpleado.TabIndex = 9;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(596, 25);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(77, 19);
            this.lblEmpleado.TabIndex = 42;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // cmbActualizarHora
            // 
            this.cmbActualizarHora.FormattingEnabled = true;
            this.cmbActualizarHora.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cmbActualizarHora.Location = new System.Drawing.Point(353, 63);
            this.cmbActualizarHora.Name = "cmbActualizarHora";
            this.cmbActualizarHora.Size = new System.Drawing.Size(46, 21);
            this.cmbActualizarHora.TabIndex = 11;
            this.cmbActualizarHora.SelectedIndexChanged += new System.EventHandler(this.cmbActualizarHora_SelectedIndexChanged);
            // 
            // dtpActualizarCitas
            // 
            this.dtpActualizarCitas.CustomFormat = "yyyy-MM-dd";
            this.dtpActualizarCitas.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpActualizarCitas.Location = new System.Drawing.Point(79, 65);
            this.dtpActualizarCitas.Name = "dtpActualizarCitas";
            this.dtpActualizarCitas.Size = new System.Drawing.Size(170, 20);
            this.dtpActualizarCitas.TabIndex = 10;
            // 
            // cmbActualizarMinutos
            // 
            this.cmbActualizarMinutos.FormattingEnabled = true;
            this.cmbActualizarMinutos.ItemHeight = 13;
            this.cmbActualizarMinutos.Items.AddRange(new object[] {
            "00",
            "30"});
            this.cmbActualizarMinutos.Location = new System.Drawing.Point(428, 64);
            this.cmbActualizarMinutos.Name = "cmbActualizarMinutos";
            this.cmbActualizarMinutos.Size = new System.Drawing.Size(46, 21);
            this.cmbActualizarMinutos.TabIndex = 40;
            // 
            // lblDosPuntos
            // 
            this.lblDosPuntos.AutoSize = true;
            this.lblDosPuntos.BackColor = System.Drawing.Color.Transparent;
            this.lblDosPuntos.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDosPuntos.Location = new System.Drawing.Point(407, 60);
            this.lblDosPuntos.Name = "lblDosPuntos";
            this.lblDosPuntos.Size = new System.Drawing.Size(15, 23);
            this.lblDosPuntos.TabIndex = 39;
            this.lblDosPuntos.Text = ":";
            // 
            // cmbActualizarPaciente
            // 
            this.cmbActualizarPaciente.FormattingEnabled = true;
            this.cmbActualizarPaciente.Location = new System.Drawing.Point(348, 26);
            this.cmbActualizarPaciente.Name = "cmbActualizarPaciente";
            this.cmbActualizarPaciente.Size = new System.Drawing.Size(228, 21);
            this.cmbActualizarPaciente.TabIndex = 8;
            // 
            // cmbActualizarSucursal
            // 
            this.cmbActualizarSucursal.FormattingEnabled = true;
            this.cmbActualizarSucursal.Location = new System.Drawing.Point(79, 24);
            this.cmbActualizarSucursal.Name = "cmbActualizarSucursal";
            this.cmbActualizarSucursal.Size = new System.Drawing.Size(170, 21);
            this.cmbActualizarSucursal.TabIndex = 7;
            // 
            // lblActualizarHora
            // 
            this.lblActualizarHora.AutoSize = true;
            this.lblActualizarHora.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarHora.Location = new System.Drawing.Point(269, 66);
            this.lblActualizarHora.Name = "lblActualizarHora";
            this.lblActualizarHora.Size = new System.Drawing.Size(44, 19);
            this.lblActualizarHora.TabIndex = 5;
            this.lblActualizarHora.Text = "Hora:";
            // 
            // lblActualizarFecha
            // 
            this.lblActualizarFecha.AutoSize = true;
            this.lblActualizarFecha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarFecha.Location = new System.Drawing.Point(6, 64);
            this.lblActualizarFecha.Name = "lblActualizarFecha";
            this.lblActualizarFecha.Size = new System.Drawing.Size(51, 19);
            this.lblActualizarFecha.TabIndex = 4;
            this.lblActualizarFecha.Text = "Fecha:";
            // 
            // lblActualizarPaciente
            // 
            this.lblActualizarPaciente.AutoSize = true;
            this.lblActualizarPaciente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarPaciente.Location = new System.Drawing.Point(265, 27);
            this.lblActualizarPaciente.Name = "lblActualizarPaciente";
            this.lblActualizarPaciente.Size = new System.Drawing.Size(69, 19);
            this.lblActualizarPaciente.TabIndex = 3;
            this.lblActualizarPaciente.Text = "Paciente:";
            // 
            // lblActualizarSucursal
            // 
            this.lblActualizarSucursal.AutoSize = true;
            this.lblActualizarSucursal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarSucursal.Location = new System.Drawing.Point(6, 24);
            this.lblActualizarSucursal.Name = "lblActualizarSucursal";
            this.lblActualizarSucursal.Size = new System.Drawing.Size(67, 19);
            this.lblActualizarSucursal.TabIndex = 1;
            this.lblActualizarSucursal.Text = "Sucursal:";
            // 
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.radioButton3);
            this.grpBuscar.Controls.Add(this.radioButton2);
            this.grpBuscar.Controls.Add(this.radioButton1);
            this.grpBuscar.Controls.Add(this.txtEmpleado);
            this.grpBuscar.Controls.Add(this.txtPaciente);
            this.grpBuscar.Controls.Add(this.txtSucursal);
            this.grpBuscar.Controls.Add(this.label1);
            this.grpBuscar.Controls.Add(this.label5);
            this.grpBuscar.Controls.Add(this.label6);
            this.grpBuscar.Location = new System.Drawing.Point(166, 20);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(906, 75);
            this.grpBuscar.TabIndex = 44;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(596, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Empleado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(265, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Paciente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sucursal:";
            // 
            // txtSucursal
            // 
            this.txtSucursal.Location = new System.Drawing.Point(79, 41);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(170, 20);
            this.txtSucursal.TabIndex = 43;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(348, 41);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(228, 20);
            this.txtPaciente.TabIndex = 44;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(678, 44);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(228, 20);
            this.txtEmpleado.TabIndex = 45;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "SUCURSAL";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(269, 18);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "PACIENTE";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(600, 18);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(84, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "EMPLEADO";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // frmConsultaCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.ControlBox = false;
            this.Controls.Add(this.grpBuscar);
            this.Controls.Add(this.grpActualizar);
            this.Controls.Add(this.grdCita);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsultaCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Citas";
            ((System.ComponentModel.ISupportInitialize)(this.grdCita)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grpActualizar.ResumeLayout(false);
            this.grpActualizar.PerformLayout();
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCita;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox grpActualizar;
        private System.Windows.Forms.ComboBox cmbActualizarPaciente;
        private System.Windows.Forms.ComboBox cmbActualizarSucursal;
        private System.Windows.Forms.Label lblActualizarHora;
        private System.Windows.Forms.Label lblActualizarFecha;
        private System.Windows.Forms.Label lblActualizarPaciente;
        private System.Windows.Forms.Label lblActualizarSucursal;
        private System.Windows.Forms.DateTimePicker dtpActualizarCitas;
        private System.Windows.Forms.ComboBox cmbActualizarHora;
        private System.Windows.Forms.ComboBox cmbActualizarMinutos;
        private System.Windows.Forms.Label lblDosPuntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.TextBox txtSucursal;
    }
}