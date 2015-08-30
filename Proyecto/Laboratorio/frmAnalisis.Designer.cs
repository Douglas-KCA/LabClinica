namespace Laboratorio
{
    partial class frmAnalisis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalisis));
            this.txtAnalisis = new System.Windows.Forms.TextBox();
            this.lblAnalisis = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.cmbEtiqueta = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAnalisis
            // 
            this.txtAnalisis.Location = new System.Drawing.Point(162, 84);
            this.txtAnalisis.Multiline = true;
            this.txtAnalisis.Name = "txtAnalisis";
            this.txtAnalisis.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtAnalisis.Size = new System.Drawing.Size(510, 122);
            this.txtAnalisis.TabIndex = 34;
            // 
            // lblAnalisis
            // 
            this.lblAnalisis.AutoSize = true;
            this.lblAnalisis.BackColor = System.Drawing.Color.Transparent;
            this.lblAnalisis.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnalisis.Location = new System.Drawing.Point(158, 59);
            this.lblAnalisis.Name = "lblAnalisis";
            this.lblAnalisis.Size = new System.Drawing.Size(64, 19);
            this.lblAnalisis.TabIndex = 33;
            this.lblAnalisis.Text = "Analisis:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(12, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 190);
            this.panel1.TabIndex = 35;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 123);
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
            this.btnGuardar.Location = new System.Drawing.Point(12, 11);
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
            this.btnCancelar.Location = new System.Drawing.Point(12, 67);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 50);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.BackColor = System.Drawing.Color.Transparent;
            this.lblEtiqueta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.Location = new System.Drawing.Point(158, 17);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(67, 19);
            this.lblEtiqueta.TabIndex = 37;
            this.lblEtiqueta.Text = "Etiqueta:";
            // 
            // cmbEtiqueta
            // 
            this.cmbEtiqueta.FormattingEnabled = true;
            this.cmbEtiqueta.Location = new System.Drawing.Point(238, 17);
            this.cmbEtiqueta.Name = "cmbEtiqueta";
            this.cmbEtiqueta.Size = new System.Drawing.Size(404, 21);
            this.cmbEtiqueta.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(648, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 21);
            this.button1.TabIndex = 44;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 225);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbEtiqueta);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAnalisis);
            this.Controls.Add(this.lblAnalisis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAnalisis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analisis";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnalisis;
        private System.Windows.Forms.Label lblAnalisis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblEtiqueta;
        public  System.Windows.Forms.ComboBox cmbEtiqueta;
        private System.Windows.Forms.Button button1;
    }
}