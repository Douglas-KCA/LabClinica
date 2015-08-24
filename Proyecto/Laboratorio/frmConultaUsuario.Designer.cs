namespace Laboratorio
{
    partial class frmConultaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConultaUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.lblApeEmpleado = new System.Windows.Forms.Label();
            this.txtNomApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNomEmpleado = new System.Windows.Forms.TextBox();
            this.rbtnTipo = new System.Windows.Forms.RadioButton();
            this.rbtnUsuario = new System.Windows.Forms.RadioButton();
            this.rbtnEmpleado = new System.Windows.Forms.RadioButton();
            this.grpActualizar = new System.Windows.Forms.GroupBox();
            this.cmbActualizarTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtActualizarUsuario = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lblActualizarPassword = new System.Windows.Forms.Label();
            this.lblActualizarSucursal = new System.Windows.Forms.Label();
            this.grdUsuario = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.grpBuscar.SuspendLayout();
            this.grpActualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 384);
            this.panel1.TabIndex = 14;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 308);
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
            this.btnEliminar.Location = new System.Drawing.Point(12, 169);
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
            this.btnBuscar.Location = new System.Drawing.Point(12, 27);
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
            this.btnActualizar.Location = new System.Drawing.Point(12, 97);
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
            this.btnCancelar.Location = new System.Drawing.Point(12, 237);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 50);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.lblApeEmpleado);
            this.grpBuscar.Controls.Add(this.txtNomApellido);
            this.grpBuscar.Controls.Add(this.label2);
            this.grpBuscar.Controls.Add(this.cmbTipo);
            this.grpBuscar.Controls.Add(this.txtUsuario);
            this.grpBuscar.Controls.Add(this.txtNomEmpleado);
            this.grpBuscar.Controls.Add(this.rbtnTipo);
            this.grpBuscar.Controls.Add(this.rbtnUsuario);
            this.grpBuscar.Controls.Add(this.rbtnEmpleado);
            this.grpBuscar.Location = new System.Drawing.Point(157, 14);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(665, 108);
            this.grpBuscar.TabIndex = 46;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar";
            // 
            // lblApeEmpleado
            // 
            this.lblApeEmpleado.AutoSize = true;
            this.lblApeEmpleado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApeEmpleado.Location = new System.Drawing.Point(2, 73);
            this.lblApeEmpleado.Name = "lblApeEmpleado";
            this.lblApeEmpleado.Size = new System.Drawing.Size(66, 19);
            this.lblApeEmpleado.TabIndex = 67;
            this.lblApeEmpleado.Text = "Apellido:";
            // 
            // txtNomApellido
            // 
            this.txtNomApellido.Location = new System.Drawing.Point(75, 74);
            this.txtNomApellido.Name = "txtNomApellido";
            this.txtNomApellido.Size = new System.Drawing.Size(139, 20);
            this.txtNomApellido.TabIndex = 66;
            this.txtNomApellido.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNomApellido_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 65;
            this.label2.Text = "Nombre:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "secre",
            "doc",
            "admin"});
            this.cmbTipo.Location = new System.Drawing.Point(501, 44);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(151, 21);
            this.cmbTipo.TabIndex = 61;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(277, 45);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(167, 20);
            this.txtUsuario.TabIndex = 54;
            this.txtUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyUp);
            // 
            // txtNomEmpleado
            // 
            this.txtNomEmpleado.Location = new System.Drawing.Point(75, 46);
            this.txtNomEmpleado.Name = "txtNomEmpleado";
            this.txtNomEmpleado.Size = new System.Drawing.Size(139, 20);
            this.txtNomEmpleado.TabIndex = 53;
            this.txtNomEmpleado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEmpleado_KeyUp);
            // 
            // rbtnTipo
            // 
            this.rbtnTipo.AutoSize = true;
            this.rbtnTipo.Location = new System.Drawing.Point(501, 16);
            this.rbtnTipo.Name = "rbtnTipo";
            this.rbtnTipo.Size = new System.Drawing.Size(102, 17);
            this.rbtnTipo.TabIndex = 45;
            this.rbtnTipo.TabStop = true;
            this.rbtnTipo.Text = "TIPO USUARIO";
            this.rbtnTipo.UseVisualStyleBackColor = true;
            this.rbtnTipo.CheckedChanged += new System.EventHandler(this.rbtnTipo_CheckedChanged);
            // 
            // rbtnUsuario
            // 
            this.rbtnUsuario.AutoSize = true;
            this.rbtnUsuario.Location = new System.Drawing.Point(277, 17);
            this.rbtnUsuario.Name = "rbtnUsuario";
            this.rbtnUsuario.Size = new System.Drawing.Size(124, 17);
            this.rbtnUsuario.TabIndex = 4;
            this.rbtnUsuario.TabStop = true;
            this.rbtnUsuario.Text = "NOMBRE USUARIO";
            this.rbtnUsuario.UseVisualStyleBackColor = true;
            this.rbtnUsuario.CheckedChanged += new System.EventHandler(this.rbtnUsuario_CheckedChanged);
            // 
            // rbtnEmpleado
            // 
            this.rbtnEmpleado.AutoSize = true;
            this.rbtnEmpleado.Location = new System.Drawing.Point(6, 18);
            this.rbtnEmpleado.Name = "rbtnEmpleado";
            this.rbtnEmpleado.Size = new System.Drawing.Size(84, 17);
            this.rbtnEmpleado.TabIndex = 3;
            this.rbtnEmpleado.Text = "EMPLEADO";
            this.rbtnEmpleado.UseVisualStyleBackColor = true;
            this.rbtnEmpleado.CheckedChanged += new System.EventHandler(this.rbtnEmpleado_CheckedChanged);
            // 
            // grpActualizar
            // 
            this.grpActualizar.Controls.Add(this.cmbActualizarTipo);
            this.grpActualizar.Controls.Add(this.label1);
            this.grpActualizar.Controls.Add(this.txtPassword);
            this.grpActualizar.Controls.Add(this.txtActualizarUsuario);
            this.grpActualizar.Controls.Add(this.button3);
            this.grpActualizar.Controls.Add(this.lblActualizarPassword);
            this.grpActualizar.Controls.Add(this.lblActualizarSucursal);
            this.grpActualizar.Location = new System.Drawing.Point(157, 128);
            this.grpActualizar.Name = "grpActualizar";
            this.grpActualizar.Size = new System.Drawing.Size(665, 65);
            this.grpActualizar.TabIndex = 45;
            this.grpActualizar.TabStop = false;
            this.grpActualizar.Text = "Actualizar";
            // 
            // cmbActualizarTipo
            // 
            this.cmbActualizarTipo.FormattingEnabled = true;
            this.cmbActualizarTipo.Items.AddRange(new object[] {
            "secre",
            "doc",
            "admin"});
            this.cmbActualizarTipo.Location = new System.Drawing.Point(501, 25);
            this.cmbActualizarTipo.Name = "cmbActualizarTipo";
            this.cmbActualizarTipo.Size = new System.Drawing.Size(151, 21);
            this.cmbActualizarTipo.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 64;
            this.label1.Text = "Tipo:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(305, 25);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(139, 20);
            this.txtPassword.TabIndex = 63;
            // 
            // txtActualizarUsuario
            // 
            this.txtActualizarUsuario.Location = new System.Drawing.Point(75, 23);
            this.txtActualizarUsuario.Name = "txtActualizarUsuario";
            this.txtActualizarUsuario.Size = new System.Drawing.Size(139, 20);
            this.txtActualizarUsuario.TabIndex = 62;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(877, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 21);
            this.button3.TabIndex = 45;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblActualizarPassword
            // 
            this.lblActualizarPassword.AutoSize = true;
            this.lblActualizarPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarPassword.Location = new System.Drawing.Point(224, 25);
            this.lblActualizarPassword.Name = "lblActualizarPassword";
            this.lblActualizarPassword.Size = new System.Drawing.Size(75, 19);
            this.lblActualizarPassword.TabIndex = 3;
            this.lblActualizarPassword.Text = "Password:";
            // 
            // lblActualizarSucursal
            // 
            this.lblActualizarSucursal.AutoSize = true;
            this.lblActualizarSucursal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarSucursal.Location = new System.Drawing.Point(6, 24);
            this.lblActualizarSucursal.Name = "lblActualizarSucursal";
            this.lblActualizarSucursal.Size = new System.Drawing.Size(63, 19);
            this.lblActualizarSucursal.TabIndex = 1;
            this.lblActualizarSucursal.Text = "Usuario:";
            // 
            // grdUsuario
            // 
            this.grdUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.nombreSucursal,
            this.ubicacionSucursal,
            this.Password,
            this.tipoUsuario});
            this.grdUsuario.Location = new System.Drawing.Point(157, 199);
            this.grdUsuario.Name = "grdUsuario";
            this.grdUsuario.Size = new System.Drawing.Size(665, 199);
            this.grdUsuario.TabIndex = 47;
            this.grdUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUsuario_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // nombreSucursal
            // 
            this.nombreSucursal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreSucursal.HeaderText = "Empleado";
            this.nombreSucursal.Name = "nombreSucursal";
            // 
            // ubicacionSucursal
            // 
            this.ubicacionSucursal.HeaderText = "Nombre Usuario";
            this.ubicacionSucursal.Name = "ubicacionSucursal";
            this.ubicacionSucursal.Width = 125;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // tipoUsuario
            // 
            this.tipoUsuario.HeaderText = "Tipo Usuario";
            this.tipoUsuario.Name = "tipoUsuario";
            // 
            // frmConultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 410);
            this.ControlBox = false;
            this.Controls.Add(this.grdUsuario);
            this.Controls.Add(this.grpBuscar);
            this.Controls.Add(this.grpActualizar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConultaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConultaUsuario";
            this.panel1.ResumeLayout(false);
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            this.grpActualizar.ResumeLayout(false);
            this.grpActualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.RadioButton rbtnUsuario;
        private System.Windows.Forms.RadioButton rbtnEmpleado;
        private System.Windows.Forms.GroupBox grpActualizar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblActualizarPassword;
        private System.Windows.Forms.Label lblActualizarSucursal;
        private System.Windows.Forms.RadioButton rbtnTipo;
        private System.Windows.Forms.DataGridView grdUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtNomEmpleado;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoUsuario;
        private System.Windows.Forms.TextBox txtActualizarUsuario;
        private System.Windows.Forms.ComboBox cmbActualizarTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblApeEmpleado;
        private System.Windows.Forms.TextBox txtNomApellido;
        private System.Windows.Forms.Label label2;
    }
}