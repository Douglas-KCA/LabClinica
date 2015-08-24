namespace Laboratorio
{
    partial class frmConsultaPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaPacientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDpi = new System.Windows.Forms.Label();
            this.txtDpi = new System.Windows.Forms.TextBox();
            this.grdConsultarPacientes = new System.Windows.Forms.DataGridView();
            this.lblMembresia = new System.Windows.Forms.Label();
            this.lblAseguradora = new System.Windows.Forms.Label();
            this.cmbAseguradora = new System.Windows.Forms.ComboBox();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSeguro = new System.Windows.Forms.GroupBox();
            this.cmbMembresia = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultarPacientes)).BeginInit();
            this.gbSeguro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 311);
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
            this.btnEliminar.Location = new System.Drawing.Point(12, 88);
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
            this.btnActualizar.Location = new System.Drawing.Point(12, 13);
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
            this.btnCancelar.Location = new System.Drawing.Point(12, 166);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 50);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblDpi
            // 
            this.lblDpi.AutoSize = true;
            this.lblDpi.BackColor = System.Drawing.Color.Transparent;
            this.lblDpi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDpi.Location = new System.Drawing.Point(299, 29);
            this.lblDpi.Name = "lblDpi";
            this.lblDpi.Size = new System.Drawing.Size(35, 19);
            this.lblDpi.TabIndex = 37;
            this.lblDpi.Text = "Dpi:";
            // 
            // txtDpi
            // 
            this.txtDpi.Location = new System.Drawing.Point(340, 30);
            this.txtDpi.Name = "txtDpi";
            this.txtDpi.Size = new System.Drawing.Size(274, 20);
            this.txtDpi.TabIndex = 39;
            this.txtDpi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDpi_KeyUp);
            // 
            // grdConsultarPacientes
            // 
            this.grdConsultarPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsultarPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.DPI,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column8,
            this.Poliza});
            this.grdConsultarPacientes.Location = new System.Drawing.Point(165, 101);
            this.grdConsultarPacientes.Name = "grdConsultarPacientes";
            this.grdConsultarPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdConsultarPacientes.Size = new System.Drawing.Size(716, 234);
            this.grdConsultarPacientes.TabIndex = 40;
            this.grdConsultarPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdConsultarPacientes_CellContentClick);
            this.grdConsultarPacientes.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdConsultarPacientes_CellEnter);
            // 
            // lblMembresia
            // 
            this.lblMembresia.AutoSize = true;
            this.lblMembresia.BackColor = System.Drawing.Color.Transparent;
            this.lblMembresia.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembresia.Location = new System.Drawing.Point(22, 7);
            this.lblMembresia.Name = "lblMembresia";
            this.lblMembresia.Size = new System.Drawing.Size(86, 19);
            this.lblMembresia.TabIndex = 41;
            this.lblMembresia.Text = "Membresia:";
            // 
            // lblAseguradora
            // 
            this.lblAseguradora.AutoSize = true;
            this.lblAseguradora.BackColor = System.Drawing.Color.Transparent;
            this.lblAseguradora.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAseguradora.Location = new System.Drawing.Point(348, 7);
            this.lblAseguradora.Name = "lblAseguradora";
            this.lblAseguradora.Size = new System.Drawing.Size(95, 19);
            this.lblAseguradora.TabIndex = 43;
            this.lblAseguradora.Text = "Aseguradora:";
            // 
            // cmbAseguradora
            // 
            this.cmbAseguradora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAseguradora.FormattingEnabled = true;
            this.cmbAseguradora.Location = new System.Drawing.Point(461, 8);
            this.cmbAseguradora.Name = "cmbAseguradora";
            this.cmbAseguradora.Size = new System.Drawing.Size(183, 21);
            this.cmbAseguradora.TabIndex = 44;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "No.";
            this.Column9.Name = "Column9";
            // 
            // DPI
            // 
            this.DPI.HeaderText = "DPI";
            this.DPI.Name = "DPI";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sexo";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nacimiento";
            this.Column4.Name = "Column4";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Nit";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Referencia";
            this.Column8.Name = "Column8";
            // 
            // Poliza
            // 
            this.Poliza.HeaderText = "Poliza";
            this.Poliza.Name = "Poliza";
            // 
            // gbSeguro
            // 
            this.gbSeguro.Controls.Add(this.cmbMembresia);
            this.gbSeguro.Controls.Add(this.lblMembresia);
            this.gbSeguro.Controls.Add(this.cmbAseguradora);
            this.gbSeguro.Controls.Add(this.lblAseguradora);
            this.gbSeguro.Location = new System.Drawing.Point(165, 56);
            this.gbSeguro.Name = "gbSeguro";
            this.gbSeguro.Size = new System.Drawing.Size(716, 32);
            this.gbSeguro.TabIndex = 45;
            this.gbSeguro.TabStop = false;
            // 
            // cmbMembresia
            // 
            this.cmbMembresia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMembresia.FormattingEnabled = true;
            this.cmbMembresia.Location = new System.Drawing.Point(138, 5);
            this.cmbMembresia.Name = "cmbMembresia";
            this.cmbMembresia.Size = new System.Drawing.Size(183, 21);
            this.cmbMembresia.TabIndex = 45;
            // 
            // frmConsultaPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(904, 361);
            this.ControlBox = false;
            this.Controls.Add(this.gbSeguro);
            this.Controls.Add(this.grdConsultarPacientes);
            this.Controls.Add(this.txtDpi);
            this.Controls.Add(this.lblDpi);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsultaPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Pacientes";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultarPacientes)).EndInit();
            this.gbSeguro.ResumeLayout(false);
            this.gbSeguro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDpi;
        private System.Windows.Forms.TextBox txtDpi;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView grdConsultarPacientes;
        private System.Windows.Forms.Label lblMembresia;
        private System.Windows.Forms.Label lblAseguradora;
        private System.Windows.Forms.ComboBox cmbAseguradora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poliza;
        private System.Windows.Forms.GroupBox gbSeguro;
        private System.Windows.Forms.ComboBox cmbMembresia;
    }
}