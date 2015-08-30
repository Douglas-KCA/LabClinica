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
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpActualizar = new System.Windows.Forms.GroupBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbAcutalizarEmpleado = new System.Windows.Forms.ComboBox();
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
            this.txtApeEmpleado = new System.Windows.Forms.TextBox();
            this.txtApePaciente = new System.Windows.Forms.TextBox();
            this.lblApeEmpleado = new System.Windows.Forms.Label();
            this.lblApePaciente = new System.Windows.Forms.Label();
            this.rbtnEmpleado = new System.Windows.Forms.RadioButton();
            this.rbtnPaciente = new System.Windows.Forms.RadioButton();
            this.rbtnSucursal = new System.Windows.Forms.RadioButton();
            this.txtNomEmpleado = new System.Windows.Forms.TextBox();
            this.txtNomPaciente = new System.Windows.Forms.TextBox();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.Fecha,
            this.Hora,
            this.Estado,
            this.ubicacionSucursal,
            this.nombreSucursal,
            this.Empleado});
            this.grdCita.Location = new System.Drawing.Point(166, 278);
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
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // ubicacionSucursal
            // 
            this.ubicacionSucursal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ubicacionSucursal.HeaderText = "Paciente";
            this.ubicacionSucursal.Name = "ubicacionSucursal";
            // 
            // nombreSucursal
            // 
            this.nombreSucursal.HeaderText = "Sucursal";
            this.nombreSucursal.Name = "nombreSucursal";
            // 
            // Empleado
            // 
            this.Empleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
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
            this.panel1.Size = new System.Drawing.Size(133, 479);
            this.panel1.TabIndex = 13;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 353);
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
            this.btnEliminar.Location = new System.Drawing.Point(12, 206);
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
            this.btnBuscar.Location = new System.Drawing.Point(12, 63);
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
            this.btnActualizar.Location = new System.Drawing.Point(12, 135);
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
            this.btnCancelar.Location = new System.Drawing.Point(12, 279);
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
            this.grpActualizar.Controls.Add(this.cmbEstado);
            this.grpActualizar.Controls.Add(this.label2);
            this.grpActualizar.Controls.Add(this.button3);
            this.grpActualizar.Controls.Add(this.button2);
            this.grpActualizar.Controls.Add(this.button1);
            this.grpActualizar.Controls.Add(this.cmbAcutalizarEmpleado);
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
            this.grpActualizar.Location = new System.Drawing.Point(166, 156);
            this.grpActualizar.Name = "grpActualizar";
            this.grpActualizar.Size = new System.Drawing.Size(906, 107);
            this.grpActualizar.TabIndex = 38;
            this.grpActualizar.TabStop = false;
            this.grpActualizar.Text = "Actualizar";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activa",
            "Cancelada"});
            this.cmbEstado.Location = new System.Drawing.Point(678, 64);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(192, 21);
            this.cmbEstado.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(596, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "Estado:";
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(877, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 21);
            this.button3.TabIndex = 45;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(548, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 21);
            this.button2.TabIndex = 44;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(234, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 21);
            this.button1.TabIndex = 43;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbAcutalizarEmpleado
            // 
            this.cmbAcutalizarEmpleado.FormattingEnabled = true;
            this.cmbAcutalizarEmpleado.Location = new System.Drawing.Point(679, 24);
            this.cmbAcutalizarEmpleado.Name = "cmbAcutalizarEmpleado";
            this.cmbAcutalizarEmpleado.Size = new System.Drawing.Size(192, 21);
            this.cmbAcutalizarEmpleado.TabIndex = 9;
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
            this.cmbActualizarPaciente.Size = new System.Drawing.Size(194, 21);
            this.cmbActualizarPaciente.TabIndex = 8;
            // 
            // cmbActualizarSucursal
            // 
            this.cmbActualizarSucursal.FormattingEnabled = true;
            this.cmbActualizarSucursal.Location = new System.Drawing.Point(79, 24);
            this.cmbActualizarSucursal.Name = "cmbActualizarSucursal";
            this.cmbActualizarSucursal.Size = new System.Drawing.Size(149, 21);
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
            this.grpBuscar.Controls.Add(this.txtApeEmpleado);
            this.grpBuscar.Controls.Add(this.txtApePaciente);
            this.grpBuscar.Controls.Add(this.lblApeEmpleado);
            this.grpBuscar.Controls.Add(this.lblApePaciente);
            this.grpBuscar.Controls.Add(this.rbtnEmpleado);
            this.grpBuscar.Controls.Add(this.rbtnPaciente);
            this.grpBuscar.Controls.Add(this.rbtnSucursal);
            this.grpBuscar.Controls.Add(this.txtNomEmpleado);
            this.grpBuscar.Controls.Add(this.txtNomPaciente);
            this.grpBuscar.Controls.Add(this.txtSucursal);
            this.grpBuscar.Controls.Add(this.label1);
            this.grpBuscar.Controls.Add(this.label5);
            this.grpBuscar.Controls.Add(this.label6);
            this.grpBuscar.Location = new System.Drawing.Point(166, 20);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(906, 114);
            this.grpBuscar.TabIndex = 44;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar";
            // 
            // txtApeEmpleado
            // 
            this.txtApeEmpleado.Location = new System.Drawing.Point(679, 80);
            this.txtApeEmpleado.Name = "txtApeEmpleado";
            this.txtApeEmpleado.Size = new System.Drawing.Size(222, 20);
            this.txtApeEmpleado.TabIndex = 49;
            this.txtApeEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApeEmpleado_KeyPress);
            this.txtApeEmpleado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtApeEmpleado_KeyUp);
            // 
            // txtApePaciente
            // 
            this.txtApePaciente.Location = new System.Drawing.Point(349, 77);
            this.txtApePaciente.Name = "txtApePaciente";
            this.txtApePaciente.Size = new System.Drawing.Size(228, 20);
            this.txtApePaciente.TabIndex = 48;
            this.txtApePaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApePaciente_KeyPress);
            this.txtApePaciente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtApePaciente_KeyUp);
            // 
            // lblApeEmpleado
            // 
            this.lblApeEmpleado.AutoSize = true;
            this.lblApeEmpleado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApeEmpleado.Location = new System.Drawing.Point(597, 77);
            this.lblApeEmpleado.Name = "lblApeEmpleado";
            this.lblApeEmpleado.Size = new System.Drawing.Size(66, 19);
            this.lblApeEmpleado.TabIndex = 47;
            this.lblApeEmpleado.Text = "Apellido:";
            // 
            // lblApePaciente
            // 
            this.lblApePaciente.AutoSize = true;
            this.lblApePaciente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApePaciente.Location = new System.Drawing.Point(266, 79);
            this.lblApePaciente.Name = "lblApePaciente";
            this.lblApePaciente.Size = new System.Drawing.Size(66, 19);
            this.lblApePaciente.TabIndex = 46;
            this.lblApePaciente.Text = "Apellido:";
            // 
            // rbtnEmpleado
            // 
            this.rbtnEmpleado.AutoSize = true;
            this.rbtnEmpleado.Location = new System.Drawing.Point(600, 18);
            this.rbtnEmpleado.Name = "rbtnEmpleado";
            this.rbtnEmpleado.Size = new System.Drawing.Size(84, 17);
            this.rbtnEmpleado.TabIndex = 5;
            this.rbtnEmpleado.TabStop = true;
            this.rbtnEmpleado.Text = "EMPLEADO";
            this.rbtnEmpleado.UseVisualStyleBackColor = true;
            this.rbtnEmpleado.CheckedChanged += new System.EventHandler(this.rbtnEmpleado_CheckedChanged);
            // 
            // rbtnPaciente
            // 
            this.rbtnPaciente.AutoSize = true;
            this.rbtnPaciente.Location = new System.Drawing.Point(269, 18);
            this.rbtnPaciente.Name = "rbtnPaciente";
            this.rbtnPaciente.Size = new System.Drawing.Size(78, 17);
            this.rbtnPaciente.TabIndex = 4;
            this.rbtnPaciente.TabStop = true;
            this.rbtnPaciente.Text = "PACIENTE";
            this.rbtnPaciente.UseVisualStyleBackColor = true;
            this.rbtnPaciente.CheckedChanged += new System.EventHandler(this.rbtnPaciente_CheckedChanged);
            // 
            // rbtnSucursal
            // 
            this.rbtnSucursal.AutoSize = true;
            this.rbtnSucursal.Location = new System.Drawing.Point(6, 18);
            this.rbtnSucursal.Name = "rbtnSucursal";
            this.rbtnSucursal.Size = new System.Drawing.Size(83, 17);
            this.rbtnSucursal.TabIndex = 3;
            this.rbtnSucursal.Text = "SUCURSAL";
            this.rbtnSucursal.UseVisualStyleBackColor = true;
            this.rbtnSucursal.CheckedChanged += new System.EventHandler(this.rbtnSucursal_CheckedChanged);
            // 
            // txtNomEmpleado
            // 
            this.txtNomEmpleado.Location = new System.Drawing.Point(678, 44);
            this.txtNomEmpleado.Name = "txtNomEmpleado";
            this.txtNomEmpleado.Size = new System.Drawing.Size(222, 20);
            this.txtNomEmpleado.TabIndex = 45;
            this.txtNomEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomEmpleado_KeyPress);
            this.txtNomEmpleado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNomEmpleado_KeyUp);
            // 
            // txtNomPaciente
            // 
            this.txtNomPaciente.Location = new System.Drawing.Point(348, 41);
            this.txtNomPaciente.Name = "txtNomPaciente";
            this.txtNomPaciente.Size = new System.Drawing.Size(228, 20);
            this.txtNomPaciente.TabIndex = 44;
            this.txtNomPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomPaciente_KeyPress);
            this.txtNomPaciente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNomPaciente_KeyUp);
            // 
            // txtSucursal
            // 
            this.txtSucursal.Location = new System.Drawing.Point(79, 41);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(170, 20);
            this.txtSucursal.TabIndex = 43;
            this.txtSucursal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSucursal_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(596, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(265, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre:";
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
            // frmConsultaCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 511);
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
        public System.Windows.Forms.GroupBox grpActualizar;
        public System.Windows.Forms.ComboBox cmbActualizarPaciente;
        public System.Windows.Forms.ComboBox cmbActualizarSucursal;
        private System.Windows.Forms.Label lblActualizarHora;
        private System.Windows.Forms.Label lblActualizarFecha;
        private System.Windows.Forms.Label lblActualizarPaciente;
        private System.Windows.Forms.Label lblActualizarSucursal;
        public System.Windows.Forms.DateTimePicker dtpActualizarCitas;
        public System.Windows.Forms.ComboBox cmbActualizarHora;
        public System.Windows.Forms.ComboBox cmbActualizarMinutos;
        private System.Windows.Forms.Label lblDosPuntos;
        private System.Windows.Forms.Button btnHome;
        public System.Windows.Forms.ComboBox cmbAcutalizarEmpleado;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtnEmpleado;
        private System.Windows.Forms.RadioButton rbtnPaciente;
        private System.Windows.Forms.RadioButton rbtnSucursal;
        private System.Windows.Forms.TextBox txtNomEmpleado;
        private System.Windows.Forms.TextBox txtNomPaciente;
        private System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.TextBox txtApeEmpleado;
        private System.Windows.Forms.TextBox txtApePaciente;
        private System.Windows.Forms.Label lblApeEmpleado;
        private System.Windows.Forms.Label lblApePaciente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
    }
}