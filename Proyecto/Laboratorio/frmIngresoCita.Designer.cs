namespace Laboratorio
{
    partial class frmIngresoCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresoCita));
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.dtpCitas = new System.Windows.Forms.DateTimePicker();
            this.lblDosPuntos = new System.Windows.Forms.Label();
            this.cmbMinutos = new System.Windows.Forms.ComboBox();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.BackColor = System.Drawing.Color.Transparent;
            this.lblSucursal.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblSucursal.Location = new System.Drawing.Point(163, 42);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(67, 19);
            this.lblSucursal.TabIndex = 16;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.BackColor = System.Drawing.Color.Transparent;
            this.lblPaciente.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblPaciente.Location = new System.Drawing.Point(163, 83);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(69, 19);
            this.lblPaciente.TabIndex = 14;
            this.lblPaciente.Text = "Paciente:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(14, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 206);
            this.panel1.TabIndex = 13;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 135);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(110, 50);
            this.btnHome.TabIndex = 10;
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
            this.btnGuardar.Location = new System.Drawing.Point(12, 23);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 50);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(12, 79);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 50);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(246, 46);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(398, 21);
            this.cmbSucursal.TabIndex = 19;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblFecha.Location = new System.Drawing.Point(163, 154);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 19);
            this.lblFecha.TabIndex = 20;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblHora.Location = new System.Drawing.Point(163, 190);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(44, 19);
            this.lblHora.TabIndex = 21;
            this.lblHora.Text = "Hora:";
            // 
            // dtpCitas
            // 
            this.dtpCitas.CustomFormat = "yyyy-MM-dd";
            this.dtpCitas.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCitas.Location = new System.Drawing.Point(243, 152);
            this.dtpCitas.Name = "dtpCitas";
            this.dtpCitas.Size = new System.Drawing.Size(114, 20);
            this.dtpCitas.TabIndex = 28;
            // 
            // lblDosPuntos
            // 
            this.lblDosPuntos.AutoSize = true;
            this.lblDosPuntos.BackColor = System.Drawing.Color.Transparent;
            this.lblDosPuntos.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDosPuntos.Location = new System.Drawing.Point(300, 188);
            this.lblDosPuntos.Name = "lblDosPuntos";
            this.lblDosPuntos.Size = new System.Drawing.Size(15, 23);
            this.lblDosPuntos.TabIndex = 27;
            this.lblDosPuntos.Text = ":";
            // 
            // cmbMinutos
            // 
            this.cmbMinutos.FormattingEnabled = true;
            this.cmbMinutos.Items.AddRange(new object[] {
            "00",
            "30"});
            this.cmbMinutos.Location = new System.Drawing.Point(321, 192);
            this.cmbMinutos.Name = "cmbMinutos";
            this.cmbMinutos.Size = new System.Drawing.Size(46, 21);
            this.cmbMinutos.TabIndex = 29;
            // 
            // cmbHora
            // 
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
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
            this.cmbHora.Location = new System.Drawing.Point(246, 191);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(46, 21);
            this.cmbHora.TabIndex = 30;
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(246, 83);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(398, 21);
            this.cmbPaciente.TabIndex = 31;
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(245, 116);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(399, 21);
            this.cmbEmpleado.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.Location = new System.Drawing.Point(162, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Empleado:";
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarEmpleado.Image")));
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(650, 83);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarEmpleado.TabIndex = 63;
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(651, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 21);
            this.button1.TabIndex = 64;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(650, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 21);
            this.button2.TabIndex = 65;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmIngresoCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 241);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscarEmpleado);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPaciente);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.cmbMinutos);
            this.Controls.Add(this.dtpCitas);
            this.Controls.Add(this.lblDosPuntos);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIngresoCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cita";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        public System.Windows.Forms.DateTimePicker dtpCitas;
        private System.Windows.Forms.Label lblDosPuntos;
        public System.Windows.Forms.ComboBox cmbMinutos;
        public System.Windows.Forms.ComboBox cmbHora;
        public System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.Button btnHome;
        public System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}