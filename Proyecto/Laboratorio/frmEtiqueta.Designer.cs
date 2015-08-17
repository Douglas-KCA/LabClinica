namespace Laboratorio
{
    partial class frmEtiqueta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEtiqueta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCodigoMuestra = new System.Windows.Forms.Label();
            this.lblCodigoPaciente = new System.Windows.Forms.Label();
            this.cmbCodMuestra = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTipoMuestra = new System.Windows.Forms.Label();
            this.lblInfoPaciente = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 311);
            this.panel1.TabIndex = 10;
            // 
            // btnHome
            // 
            this.btnHome.Enabled = false;
            this.btnHome.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(10, 196);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(110, 50);
            this.btnHome.TabIndex = 7;
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
            this.btnGuardar.Location = new System.Drawing.Point(12, 61);
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
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(12, 129);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 50);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblCodigoMuestra
            // 
            this.lblCodigoMuestra.AutoSize = true;
            this.lblCodigoMuestra.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoMuestra.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoMuestra.Location = new System.Drawing.Point(170, 28);
            this.lblCodigoMuestra.Name = "lblCodigoMuestra";
            this.lblCodigoMuestra.Size = new System.Drawing.Size(67, 19);
            this.lblCodigoMuestra.TabIndex = 32;
            this.lblCodigoMuestra.Text = "Muestra:";
            // 
            // lblCodigoPaciente
            // 
            this.lblCodigoPaciente.AutoSize = true;
            this.lblCodigoPaciente.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoPaciente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPaciente.Location = new System.Drawing.Point(170, 58);
            this.lblCodigoPaciente.Name = "lblCodigoPaciente";
            this.lblCodigoPaciente.Size = new System.Drawing.Size(69, 19);
            this.lblCodigoPaciente.TabIndex = 35;
            this.lblCodigoPaciente.Text = "Paciente:";
            // 
            // cmbCodMuestra
            // 
            this.cmbCodMuestra.FormattingEnabled = true;
            this.cmbCodMuestra.Location = new System.Drawing.Point(257, 29);
            this.cmbCodMuestra.Name = "cmbCodMuestra";
            this.cmbCodMuestra.Size = new System.Drawing.Size(392, 21);
            this.cmbCodMuestra.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Controls.Add(this.lblTipoMuestra);
            this.panel2.Controls.Add(this.lblInfoPaciente);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(174, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 202);
            this.panel2.TabIndex = 39;
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(123, 175);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(229, 23);
            this.lblFecha.TabIndex = 41;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTipoMuestra
            // 
            this.lblTipoMuestra.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMuestra.Location = new System.Drawing.Point(120, 7);
            this.lblTipoMuestra.Name = "lblTipoMuestra";
            this.lblTipoMuestra.Size = new System.Drawing.Size(229, 23);
            this.lblTipoMuestra.TabIndex = 2;
            this.lblTipoMuestra.Text = "Muestra";
            this.lblTipoMuestra.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfoPaciente
            // 
            this.lblInfoPaciente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoPaciente.Location = new System.Drawing.Point(123, 152);
            this.lblInfoPaciente.Name = "lblInfoPaciente";
            this.lblInfoPaciente.Size = new System.Drawing.Size(229, 23);
            this.lblInfoPaciente.TabIndex = 1;
            this.lblInfoPaciente.Text = "Paciente";
            this.lblInfoPaciente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(123, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(362, 310);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(110, 50);
            this.btnImprimir.TabIndex = 40;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(257, 57);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(392, 20);
            this.txtPaciente.TabIndex = 41;
            this.txtPaciente.Click += new System.EventHandler(this.txtPaciente_Click);
            // 
            // frmEtiqueta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(684, 366);
            this.ControlBox = false;
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbCodMuestra);
            this.Controls.Add(this.lblCodigoPaciente);
            this.Controls.Add(this.lblCodigoMuestra);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEtiqueta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etiqueta";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCodigoMuestra;
        private System.Windows.Forms.Label lblCodigoPaciente;
        private System.Windows.Forms.ComboBox cmbCodMuestra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTipoMuestra;
        private System.Windows.Forms.Label lblInfoPaciente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblFecha;
        public System.Windows.Forms.TextBox txtPaciente;
    }
}