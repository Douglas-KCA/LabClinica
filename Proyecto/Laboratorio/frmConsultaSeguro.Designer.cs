namespace Laboratorio
{
    partial class frmConsultaSeguro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaSeguro));
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpActualizar = new System.Windows.Forms.GroupBox();
            this.lblActualizarTarifa = new System.Windows.Forms.Label();
            this.lblActualizarAseguradora = new System.Windows.Forms.Label();
            this.lblAseguradora = new System.Windows.Forms.Label();
            this.cmbAseguradora = new System.Windows.Forms.ComboBox();
            this.lblActualizarDeducible = new System.Windows.Forms.Label();
            this.cmbActualizarAseguradora = new System.Windows.Forms.ComboBox();
            this.cmbActualizarTarifa = new System.Windows.Forms.ComboBox();
            this.txtActualizarDeducible = new System.Windows.Forms.TextBox();
            this.grdPuesto = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aseguradora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deducible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBotones.SuspendLayout();
            this.grpActualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotones
            // 
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotones.Controls.Add(this.btnHome);
            this.pnlBotones.Controls.Add(this.btnEliminar);
            this.pnlBotones.Controls.Add(this.btnBuscar);
            this.pnlBotones.Controls.Add(this.btnActualizar);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Location = new System.Drawing.Point(10, 12);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(133, 328);
            this.pnlBotones.TabIndex = 35;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 251);
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
            this.btnEliminar.Location = new System.Drawing.Point(12, 138);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 50);
            this.btnEliminar.TabIndex = 8;
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
            this.btnBuscar.Location = new System.Drawing.Point(12, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 50);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(12, 80);
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
            this.btnCancelar.Location = new System.Drawing.Point(12, 195);
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
            this.grpActualizar.Controls.Add(this.txtActualizarDeducible);
            this.grpActualizar.Controls.Add(this.cmbActualizarTarifa);
            this.grpActualizar.Controls.Add(this.cmbActualizarAseguradora);
            this.grpActualizar.Controls.Add(this.lblActualizarDeducible);
            this.grpActualizar.Controls.Add(this.lblActualizarTarifa);
            this.grpActualizar.Controls.Add(this.lblActualizarAseguradora);
            this.grpActualizar.Enabled = false;
            this.grpActualizar.Location = new System.Drawing.Point(166, 57);
            this.grpActualizar.Name = "grpActualizar";
            this.grpActualizar.Size = new System.Drawing.Size(506, 115);
            this.grpActualizar.TabIndex = 39;
            this.grpActualizar.TabStop = false;
            this.grpActualizar.Text = "Actualizar";
            // 
            // lblActualizarTarifa
            // 
            this.lblActualizarTarifa.AutoSize = true;
            this.lblActualizarTarifa.BackColor = System.Drawing.Color.Transparent;
            this.lblActualizarTarifa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarTarifa.Location = new System.Drawing.Point(6, 50);
            this.lblActualizarTarifa.Name = "lblActualizarTarifa";
            this.lblActualizarTarifa.Size = new System.Drawing.Size(50, 19);
            this.lblActualizarTarifa.TabIndex = 34;
            this.lblActualizarTarifa.Text = "Tarifa:";
            // 
            // lblActualizarAseguradora
            // 
            this.lblActualizarAseguradora.AutoSize = true;
            this.lblActualizarAseguradora.BackColor = System.Drawing.Color.Transparent;
            this.lblActualizarAseguradora.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarAseguradora.Location = new System.Drawing.Point(6, 21);
            this.lblActualizarAseguradora.Name = "lblActualizarAseguradora";
            this.lblActualizarAseguradora.Size = new System.Drawing.Size(95, 19);
            this.lblActualizarAseguradora.TabIndex = 32;
            this.lblActualizarAseguradora.Text = "Aseguradora:";
            // 
            // lblAseguradora
            // 
            this.lblAseguradora.AutoSize = true;
            this.lblAseguradora.BackColor = System.Drawing.Color.Transparent;
            this.lblAseguradora.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAseguradora.Location = new System.Drawing.Point(172, 12);
            this.lblAseguradora.Name = "lblAseguradora";
            this.lblAseguradora.Size = new System.Drawing.Size(95, 19);
            this.lblAseguradora.TabIndex = 40;
            this.lblAseguradora.Text = "Aseguradora:";
            // 
            // cmbAseguradora
            // 
            this.cmbAseguradora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAseguradora.FormattingEnabled = true;
            this.cmbAseguradora.Location = new System.Drawing.Point(273, 13);
            this.cmbAseguradora.Name = "cmbAseguradora";
            this.cmbAseguradora.Size = new System.Drawing.Size(262, 21);
            this.cmbAseguradora.TabIndex = 41;
            // 
            // lblActualizarDeducible
            // 
            this.lblActualizarDeducible.AutoSize = true;
            this.lblActualizarDeducible.BackColor = System.Drawing.Color.Transparent;
            this.lblActualizarDeducible.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarDeducible.Location = new System.Drawing.Point(6, 79);
            this.lblActualizarDeducible.Name = "lblActualizarDeducible";
            this.lblActualizarDeducible.Size = new System.Drawing.Size(78, 19);
            this.lblActualizarDeducible.TabIndex = 35;
            this.lblActualizarDeducible.Text = "Deducible:";
            // 
            // cmbActualizarAseguradora
            // 
            this.cmbActualizarAseguradora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActualizarAseguradora.FormattingEnabled = true;
            this.cmbActualizarAseguradora.Location = new System.Drawing.Point(137, 20);
            this.cmbActualizarAseguradora.Name = "cmbActualizarAseguradora";
            this.cmbActualizarAseguradora.Size = new System.Drawing.Size(262, 21);
            this.cmbActualizarAseguradora.TabIndex = 36;
            // 
            // cmbActualizarTarifa
            // 
            this.cmbActualizarTarifa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActualizarTarifa.FormattingEnabled = true;
            this.cmbActualizarTarifa.Location = new System.Drawing.Point(138, 51);
            this.cmbActualizarTarifa.Name = "cmbActualizarTarifa";
            this.cmbActualizarTarifa.Size = new System.Drawing.Size(262, 21);
            this.cmbActualizarTarifa.TabIndex = 37;
            // 
            // txtActualizarDeducible
            // 
            this.txtActualizarDeducible.Location = new System.Drawing.Point(137, 80);
            this.txtActualizarDeducible.Name = "txtActualizarDeducible";
            this.txtActualizarDeducible.Size = new System.Drawing.Size(263, 20);
            this.txtActualizarDeducible.TabIndex = 38;
            // 
            // grdPuesto
            // 
            this.grdPuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Aseguradora,
            this.Tarifa,
            this.Deducible});
            this.grdPuesto.Location = new System.Drawing.Point(166, 178);
            this.grdPuesto.Name = "grdPuesto";
            this.grdPuesto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPuesto.Size = new System.Drawing.Size(506, 177);
            this.grdPuesto.TabIndex = 42;
            this.grdPuesto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPuesto_CellContentClick);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Aseguradora
            // 
            this.Aseguradora.HeaderText = "Aseguradora";
            this.Aseguradora.Name = "Aseguradora";
            this.Aseguradora.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Tarifa
            // 
            this.Tarifa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tarifa.HeaderText = "Tarifa";
            this.Tarifa.Name = "Tarifa";
            this.Tarifa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Deducible
            // 
            this.Deducible.HeaderText = "Deducible";
            this.Deducible.Name = "Deducible";
            this.Deducible.ReadOnly = true;
            // 
            // frmConsultaSeguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.ControlBox = false;
            this.Controls.Add(this.grdPuesto);
            this.Controls.Add(this.cmbAseguradora);
            this.Controls.Add(this.lblAseguradora);
            this.Controls.Add(this.grpActualizar);
            this.Controls.Add(this.pnlBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsultaSeguro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaSeguro";
            this.pnlBotones.ResumeLayout(false);
            this.grpActualizar.ResumeLayout(false);
            this.grpActualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPuesto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpActualizar;
        private System.Windows.Forms.Label lblActualizarTarifa;
        private System.Windows.Forms.Label lblActualizarAseguradora;
        private System.Windows.Forms.Label lblAseguradora;
        private System.Windows.Forms.Label lblActualizarDeducible;
        private System.Windows.Forms.ComboBox cmbAseguradora;
        private System.Windows.Forms.ComboBox cmbActualizarAseguradora;
        private System.Windows.Forms.ComboBox cmbActualizarTarifa;
        private System.Windows.Forms.TextBox txtActualizarDeducible;
        private System.Windows.Forms.DataGridView grdPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aseguradora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deducible;
    }
}