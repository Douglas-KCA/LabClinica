namespace Laboratorio
{
    partial class frmSeguro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeguro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblAseguradora = new System.Windows.Forms.Label();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.cmbAseguradora = new System.Windows.Forms.ComboBox();
            this.cmbTarifa = new System.Windows.Forms.ComboBox();
            this.lblDeducible = new System.Windows.Forms.Label();
            this.txtDeducible = new System.Windows.Forms.TextBox();
            this.grdPuesto = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aseguradora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deducible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 311);
            this.panel1.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(12, 37);
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
            this.btnCancelar.Location = new System.Drawing.Point(12, 114);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 50);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblAseguradora
            // 
            this.lblAseguradora.AutoSize = true;
            this.lblAseguradora.BackColor = System.Drawing.Color.Transparent;
            this.lblAseguradora.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAseguradora.Location = new System.Drawing.Point(181, 25);
            this.lblAseguradora.Name = "lblAseguradora";
            this.lblAseguradora.Size = new System.Drawing.Size(95, 19);
            this.lblAseguradora.TabIndex = 15;
            this.lblAseguradora.Text = "Aseguradora:";
            // 
            // lblTarifa
            // 
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.BackColor = System.Drawing.Color.Transparent;
            this.lblTarifa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarifa.Location = new System.Drawing.Point(181, 67);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(50, 19);
            this.lblTarifa.TabIndex = 16;
            this.lblTarifa.Text = "Tarifa:";
            // 
            // cmbAseguradora
            // 
            this.cmbAseguradora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAseguradora.FormattingEnabled = true;
            this.cmbAseguradora.Location = new System.Drawing.Point(292, 27);
            this.cmbAseguradora.Name = "cmbAseguradora";
            this.cmbAseguradora.Size = new System.Drawing.Size(262, 21);
            this.cmbAseguradora.TabIndex = 17;
            // 
            // cmbTarifa
            // 
            this.cmbTarifa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarifa.FormattingEnabled = true;
            this.cmbTarifa.Location = new System.Drawing.Point(293, 65);
            this.cmbTarifa.Name = "cmbTarifa";
            this.cmbTarifa.Size = new System.Drawing.Size(262, 21);
            this.cmbTarifa.TabIndex = 18;
            // 
            // lblDeducible
            // 
            this.lblDeducible.AutoSize = true;
            this.lblDeducible.BackColor = System.Drawing.Color.Transparent;
            this.lblDeducible.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeducible.Location = new System.Drawing.Point(183, 107);
            this.lblDeducible.Name = "lblDeducible";
            this.lblDeducible.Size = new System.Drawing.Size(78, 19);
            this.lblDeducible.TabIndex = 19;
            this.lblDeducible.Text = "Deducible:";
            // 
            // txtDeducible
            // 
            this.txtDeducible.Location = new System.Drawing.Point(292, 105);
            this.txtDeducible.Name = "txtDeducible";
            this.txtDeducible.Size = new System.Drawing.Size(263, 20);
            this.txtDeducible.TabIndex = 20;
            this.txtDeducible.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeducible_KeyPress);
            // 
            // grdPuesto
            // 
            this.grdPuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Aseguradora,
            this.Tarifa,
            this.Deducible});
            this.grdPuesto.Location = new System.Drawing.Point(166, 141);
            this.grdPuesto.Name = "grdPuesto";
            this.grdPuesto.Size = new System.Drawing.Size(506, 192);
            this.grdPuesto.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // frmSeguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.ControlBox = false;
            this.Controls.Add(this.grdPuesto);
            this.Controls.Add(this.txtDeducible);
            this.Controls.Add(this.lblDeducible);
            this.Controls.Add(this.cmbTarifa);
            this.Controls.Add(this.cmbAseguradora);
            this.Controls.Add(this.lblTarifa);
            this.Controls.Add(this.lblAseguradora);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSeguro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguro";
            this.Load += new System.EventHandler(this.frmSeguro_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPuesto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblAseguradora;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.ComboBox cmbAseguradora;
        private System.Windows.Forms.ComboBox cmbTarifa;
        private System.Windows.Forms.Label lblDeducible;
        private System.Windows.Forms.TextBox txtDeducible;
        private System.Windows.Forms.DataGridView grdPuesto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aseguradora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deducible;
    }
}