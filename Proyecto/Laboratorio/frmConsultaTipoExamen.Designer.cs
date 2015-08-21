namespace Laboratorio
{
    partial class frmConsultaTipoExamen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaTipoExamen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grdConsultarTipoExamen = new System.Windows.Forms.DataGridView();
            this.Tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deducible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTipoExamenBusqueda = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpActualizar = new System.Windows.Forms.GroupBox();
            this.cmbMuestra = new System.Windows.Forms.ComboBox();
            this.lblMuestra = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultarTipoExamen)).BeginInit();
            this.grpActualizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 318);
            this.panel1.TabIndex = 23;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 242);
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
            this.btnEliminar.Location = new System.Drawing.Point(12, 96);
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
            this.btnActualizar.Location = new System.Drawing.Point(12, 26);
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
            this.btnCancelar.Location = new System.Drawing.Point(12, 168);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 50);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grdConsultarTipoExamen
            // 
            this.grdConsultarTipoExamen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsultarTipoExamen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tarifa,
            this.Deducible,
            this.Column1,
            this.Column2});
            this.grdConsultarTipoExamen.Location = new System.Drawing.Point(166, 116);
            this.grdConsultarTipoExamen.Name = "grdConsultarTipoExamen";
            this.grdConsultarTipoExamen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdConsultarTipoExamen.Size = new System.Drawing.Size(506, 234);
            this.grdConsultarTipoExamen.TabIndex = 35;
            this.grdConsultarTipoExamen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdConsultarTipoExamen_CellContentClick);
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
            this.Deducible.HeaderText = "Tipo Examen";
            this.Deducible.Name = "Deducible";
            this.Deducible.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Precio";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Muestra";
            this.Column2.Name = "Column2";
            // 
            // txtTipoExamenBusqueda
            // 
            this.txtTipoExamenBusqueda.Location = new System.Drawing.Point(259, 12);
            this.txtTipoExamenBusqueda.Name = "txtTipoExamenBusqueda";
            this.txtTipoExamenBusqueda.Size = new System.Drawing.Size(400, 20);
            this.txtTipoExamenBusqueda.TabIndex = 37;
            this.txtTipoExamenBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipoExamenBusqueda_KeyPress);
            this.txtTipoExamenBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTipoExamenBusqueda_KeyUp);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(162, 12);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(96, 19);
            this.lblNombre.TabIndex = 36;
            this.lblNombre.Text = "Tipo Examen:";
            // 
            // grpActualizar
            // 
            this.grpActualizar.Controls.Add(this.cmbMuestra);
            this.grpActualizar.Controls.Add(this.lblMuestra);
            this.grpActualizar.Controls.Add(this.lblPrecio);
            this.grpActualizar.Controls.Add(this.txtPrecio);
            this.grpActualizar.Controls.Add(this.lblTipo);
            this.grpActualizar.Controls.Add(this.txtTipo);
            this.grpActualizar.Enabled = false;
            this.grpActualizar.Location = new System.Drawing.Point(167, 38);
            this.grpActualizar.Name = "grpActualizar";
            this.grpActualizar.Size = new System.Drawing.Size(493, 72);
            this.grpActualizar.TabIndex = 38;
            this.grpActualizar.TabStop = false;
            this.grpActualizar.Text = "Actualizar";
            // 
            // cmbMuestra
            // 
            this.cmbMuestra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMuestra.FormattingEnabled = true;
            this.cmbMuestra.Location = new System.Drawing.Point(81, 44);
            this.cmbMuestra.Name = "cmbMuestra";
            this.cmbMuestra.Size = new System.Drawing.Size(152, 21);
            this.cmbMuestra.TabIndex = 6;
            // 
            // lblMuestra
            // 
            this.lblMuestra.AutoSize = true;
            this.lblMuestra.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuestra.Location = new System.Drawing.Point(4, 43);
            this.lblMuestra.Name = "lblMuestra";
            this.lblMuestra.Size = new System.Drawing.Size(67, 19);
            this.lblMuestra.TabIndex = 5;
            this.lblMuestra.Text = "Muestra:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(257, 17);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 19);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(316, 17);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(176, 20);
            this.txtPrecio.TabIndex = 2;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(4, 17);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(41, 19);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(81, 17);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(152, 20);
            this.txtTipo.TabIndex = 0;
            // 
            // frmConsultaTipoExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.ControlBox = false;
            this.Controls.Add(this.grpActualizar);
            this.Controls.Add(this.txtTipoExamenBusqueda);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.grdConsultarTipoExamen);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsultaTipoExamen";
            this.Text = "Consulta Tipos de Examen";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultarTipoExamen)).EndInit();
            this.grpActualizar.ResumeLayout(false);
            this.grpActualizar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView grdConsultarTipoExamen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deducible;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox txtTipoExamenBusqueda;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grpActualizar;
        private System.Windows.Forms.ComboBox cmbMuestra;
        private System.Windows.Forms.Label lblMuestra;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtTipo;
    }
}