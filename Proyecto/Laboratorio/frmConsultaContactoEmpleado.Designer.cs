namespace Laboratorio
{
    partial class frmConsultaContactoEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaContactoEmpleado));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grdConsultaTelefono = new System.Windows.Forms.DataGridView();
            this.Tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deducible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdConsultaCorreo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpActualizar = new System.Windows.Forms.GroupBox();
            this.lblActualizarTelefono = new System.Windows.Forms.Label();
            this.txtActualizarTelefono = new System.Windows.Forms.TextBox();
            this.grpActualizar2 = new System.Windows.Forms.GroupBox();
            this.lblActualizarCorreo = new System.Windows.Forms.Label();
            this.txtActualizarCorreo = new System.Windows.Forms.TextBox();
            this.rbTelefono = new System.Windows.Forms.RadioButton();
            this.rbCorreo = new System.Windows.Forms.RadioButton();
            this.grdConsultaDireccion = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpActualizar3 = new System.Windows.Forms.GroupBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtActualizarDireccion = new System.Windows.Forms.TextBox();
            this.rbDireccion = new System.Windows.Forms.RadioButton();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaCorreo)).BeginInit();
            this.grpActualizar.SuspendLayout();
            this.grpActualizar2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaDireccion)).BeginInit();
            this.grpActualizar3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 342);
            this.panel1.TabIndex = 23;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 243);
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
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(12, 109);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 50);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(12, 43);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(110, 50);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(12, 176);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 50);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(260, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(212, 20);
            this.txtNombre.TabIndex = 32;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyUp);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(173, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 19);
            this.lblNombre.TabIndex = 31;
            this.lblNombre.Text = "Nombre:";
            // 
            // grdConsultaTelefono
            // 
            this.grdConsultaTelefono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsultaTelefono.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tarifa,
            this.Deducible});
            this.grdConsultaTelefono.Location = new System.Drawing.Point(165, 148);
            this.grdConsultaTelefono.Name = "grdConsultaTelefono";
            this.grdConsultaTelefono.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdConsultaTelefono.Size = new System.Drawing.Size(239, 234);
            this.grdConsultaTelefono.TabIndex = 35;
            this.grdConsultaTelefono.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdConsultaTelefono_CellContentClick);
            // 
            // Tarifa
            // 
            this.Tarifa.HeaderText = "No.";
            this.Tarifa.Name = "Tarifa";
            this.Tarifa.ReadOnly = true;
            // 
            // Deducible
            // 
            this.Deducible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Deducible.HeaderText = "Nombre";
            this.Deducible.Name = "Deducible";
            this.Deducible.ReadOnly = true;
            // 
            // grdConsultaCorreo
            // 
            this.grdConsultaCorreo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsultaCorreo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.grdConsultaCorreo.Location = new System.Drawing.Point(410, 148);
            this.grdConsultaCorreo.Name = "grdConsultaCorreo";
            this.grdConsultaCorreo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdConsultaCorreo.Size = new System.Drawing.Size(235, 234);
            this.grdConsultaCorreo.TabIndex = 36;
            this.grdConsultaCorreo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdConsultaCorreo_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "No.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // grpActualizar
            // 
            this.grpActualizar.Controls.Add(this.lblActualizarTelefono);
            this.grpActualizar.Controls.Add(this.txtActualizarTelefono);
            this.grpActualizar.Enabled = false;
            this.grpActualizar.Location = new System.Drawing.Point(165, 85);
            this.grpActualizar.Name = "grpActualizar";
            this.grpActualizar.Size = new System.Drawing.Size(239, 50);
            this.grpActualizar.TabIndex = 37;
            this.grpActualizar.TabStop = false;
            this.grpActualizar.Text = "Actualizar";
            // 
            // lblActualizarTelefono
            // 
            this.lblActualizarTelefono.AutoSize = true;
            this.lblActualizarTelefono.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarTelefono.Location = new System.Drawing.Point(6, 24);
            this.lblActualizarTelefono.Name = "lblActualizarTelefono";
            this.lblActualizarTelefono.Size = new System.Drawing.Size(69, 19);
            this.lblActualizarTelefono.TabIndex = 1;
            this.lblActualizarTelefono.Text = "Telefono:";
            // 
            // txtActualizarTelefono
            // 
            this.txtActualizarTelefono.Location = new System.Drawing.Point(83, 24);
            this.txtActualizarTelefono.MaxLength = 8;
            this.txtActualizarTelefono.Name = "txtActualizarTelefono";
            this.txtActualizarTelefono.Size = new System.Drawing.Size(116, 20);
            this.txtActualizarTelefono.TabIndex = 0;
            this.txtActualizarTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtActualizarTelefono_KeyPress);
            // 
            // grpActualizar2
            // 
            this.grpActualizar2.Controls.Add(this.lblActualizarCorreo);
            this.grpActualizar2.Controls.Add(this.txtActualizarCorreo);
            this.grpActualizar2.Enabled = false;
            this.grpActualizar2.Location = new System.Drawing.Point(410, 85);
            this.grpActualizar2.Name = "grpActualizar2";
            this.grpActualizar2.Size = new System.Drawing.Size(235, 50);
            this.grpActualizar2.TabIndex = 38;
            this.grpActualizar2.TabStop = false;
            this.grpActualizar2.Text = "Actualizar";
            // 
            // lblActualizarCorreo
            // 
            this.lblActualizarCorreo.AutoSize = true;
            this.lblActualizarCorreo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarCorreo.Location = new System.Drawing.Point(6, 24);
            this.lblActualizarCorreo.Name = "lblActualizarCorreo";
            this.lblActualizarCorreo.Size = new System.Drawing.Size(56, 19);
            this.lblActualizarCorreo.TabIndex = 1;
            this.lblActualizarCorreo.Text = "Correo:";
            // 
            // txtActualizarCorreo
            // 
            this.txtActualizarCorreo.Location = new System.Drawing.Point(68, 25);
            this.txtActualizarCorreo.Name = "txtActualizarCorreo";
            this.txtActualizarCorreo.Size = new System.Drawing.Size(152, 20);
            this.txtActualizarCorreo.TabIndex = 0;
            // 
            // rbTelefono
            // 
            this.rbTelefono.AutoSize = true;
            this.rbTelefono.Location = new System.Drawing.Point(177, 56);
            this.rbTelefono.Name = "rbTelefono";
            this.rbTelefono.Size = new System.Drawing.Size(116, 17);
            this.rbTelefono.TabIndex = 39;
            this.rbTelefono.TabStop = true;
            this.rbTelefono.Text = "Actualizar Telefono";
            this.rbTelefono.UseVisualStyleBackColor = true;
            this.rbTelefono.Click += new System.EventHandler(this.rbTelefono_Click);
            // 
            // rbCorreo
            // 
            this.rbCorreo.AutoSize = true;
            this.rbCorreo.Location = new System.Drawing.Point(299, 56);
            this.rbCorreo.Name = "rbCorreo";
            this.rbCorreo.Size = new System.Drawing.Size(105, 17);
            this.rbCorreo.TabIndex = 40;
            this.rbCorreo.TabStop = true;
            this.rbCorreo.Text = "Actualizar Correo";
            this.rbCorreo.UseVisualStyleBackColor = true;
            this.rbCorreo.Click += new System.EventHandler(this.rbCorreo_Click);
            // 
            // grdConsultaDireccion
            // 
            this.grdConsultaDireccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsultaDireccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.grdConsultaDireccion.Location = new System.Drawing.Point(651, 148);
            this.grdConsultaDireccion.Name = "grdConsultaDireccion";
            this.grdConsultaDireccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdConsultaDireccion.Size = new System.Drawing.Size(242, 234);
            this.grdConsultaDireccion.TabIndex = 41;
            this.grdConsultaDireccion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdConsultaDireccion_CellContentClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "No.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // grpActualizar3
            // 
            this.grpActualizar3.Controls.Add(this.lblDireccion);
            this.grpActualizar3.Controls.Add(this.txtActualizarDireccion);
            this.grpActualizar3.Enabled = false;
            this.grpActualizar3.Location = new System.Drawing.Point(651, 85);
            this.grpActualizar3.Name = "grpActualizar3";
            this.grpActualizar3.Size = new System.Drawing.Size(242, 50);
            this.grpActualizar3.TabIndex = 42;
            this.grpActualizar3.TabStop = false;
            this.grpActualizar3.Text = "Actualizar";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(6, 24);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(74, 19);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtActualizarDireccion
            // 
            this.txtActualizarDireccion.Location = new System.Drawing.Point(86, 25);
            this.txtActualizarDireccion.Name = "txtActualizarDireccion";
            this.txtActualizarDireccion.Size = new System.Drawing.Size(152, 20);
            this.txtActualizarDireccion.TabIndex = 0;
            // 
            // rbDireccion
            // 
            this.rbDireccion.AutoSize = true;
            this.rbDireccion.Location = new System.Drawing.Point(410, 56);
            this.rbDireccion.Name = "rbDireccion";
            this.rbDireccion.Size = new System.Drawing.Size(119, 17);
            this.rbDireccion.TabIndex = 43;
            this.rbDireccion.TabStop = true;
            this.rbDireccion.Text = "Actualizar Direccion";
            this.rbDireccion.UseVisualStyleBackColor = true;
            this.rbDireccion.Click += new System.EventHandler(this.rbDireccion_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(565, 23);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(188, 20);
            this.txtApellido.TabIndex = 45;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            this.txtApellido.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtApellido_KeyUp);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(478, 22);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 19);
            this.lblApellido.TabIndex = 44;
            this.lblApellido.Text = "Apellido:";
            // 
            // frmConsultaContactoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 389);
            this.ControlBox = false;
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.rbDireccion);
            this.Controls.Add(this.grpActualizar3);
            this.Controls.Add(this.grdConsultaDireccion);
            this.Controls.Add(this.rbTelefono);
            this.Controls.Add(this.rbCorreo);
            this.Controls.Add(this.grpActualizar2);
            this.Controls.Add(this.grpActualizar);
            this.Controls.Add(this.grdConsultaCorreo);
            this.Controls.Add(this.grdConsultaTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaContactoEmpleado";
            this.Text = "Modificacion Contacto Empleado.";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaCorreo)).EndInit();
            this.grpActualizar.ResumeLayout(false);
            this.grpActualizar.PerformLayout();
            this.grpActualizar2.ResumeLayout(false);
            this.grpActualizar2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaDireccion)).EndInit();
            this.grpActualizar3.ResumeLayout(false);
            this.grpActualizar3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView grdConsultaTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deducible;
        private System.Windows.Forms.DataGridView grdConsultaCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox grpActualizar;
        private System.Windows.Forms.Label lblActualizarTelefono;
        private System.Windows.Forms.TextBox txtActualizarTelefono;
        private System.Windows.Forms.GroupBox grpActualizar2;
        private System.Windows.Forms.Label lblActualizarCorreo;
        private System.Windows.Forms.TextBox txtActualizarCorreo;
        private System.Windows.Forms.RadioButton rbTelefono;
        private System.Windows.Forms.RadioButton rbCorreo;
        private System.Windows.Forms.DataGridView grdConsultaDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox grpActualizar3;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtActualizarDireccion;
        private System.Windows.Forms.RadioButton rbDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
    }
}