namespace Laboratorio
{
    partial class frmReporteTipoExamen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteTipoExamen));
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTipoExamen = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtTipoExamen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerar.Location = new System.Drawing.Point(179, 47);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(110, 50);
            this.btnGenerar.TabIndex = 67;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(295, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(21, 21);
            this.btnBuscar.TabIndex = 66;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTipoExamen
            // 
            this.lblTipoExamen.AutoSize = true;
            this.lblTipoExamen.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoExamen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoExamen.Location = new System.Drawing.Point(2, 9);
            this.lblTipoExamen.Name = "lblTipoExamen";
            this.lblTipoExamen.Size = new System.Drawing.Size(96, 19);
            this.lblTipoExamen.TabIndex = 64;
            this.lblTipoExamen.Text = "Tipo Examen:";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(46, 47);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(110, 50);
            this.btnHome.TabIndex = 68;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtTipoExamen
            // 
            this.txtTipoExamen.Enabled = false;
            this.txtTipoExamen.Location = new System.Drawing.Point(104, 10);
            this.txtTipoExamen.Name = "txtTipoExamen";
            this.txtTipoExamen.Size = new System.Drawing.Size(185, 20);
            this.txtTipoExamen.TabIndex = 1;
            // 
            // frmReporteTipoExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(324, 119);
            this.ControlBox = false;
            this.Controls.Add(this.txtTipoExamen);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblTipoExamen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReporteTipoExamen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Tipos de Examen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTipoExamen;
        private System.Windows.Forms.Button btnHome;
        public System.Windows.Forms.TextBox txtTipoExamen;
    }
}