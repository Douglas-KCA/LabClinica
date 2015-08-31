namespace Laboratorio
{
    partial class frmReporteFechaHora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteFechaHora));
            this.btnHome = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.rbtnDia = new System.Windows.Forms.RadioButton();
            this.rbtnFecha = new System.Windows.Forms.RadioButton();
            this.gbReporte = new System.Windows.Forms.GroupBox();
            this.gbReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(41, 81);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(110, 50);
            this.btnHome.TabIndex = 70;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerar.Location = new System.Drawing.Point(174, 81);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(110, 50);
            this.btnGenerar.TabIndex = 69;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "yyyy-MM-dd";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(151, 47);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(114, 20);
            this.dtpFecha.TabIndex = 72;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblFecha.Location = new System.Drawing.Point(71, 50);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 19);
            this.lblFecha.TabIndex = 71;
            this.lblFecha.Text = "Fecha:";
            // 
            // rbtnDia
            // 
            this.rbtnDia.AutoSize = true;
            this.rbtnDia.Checked = true;
            this.rbtnDia.Location = new System.Drawing.Point(19, 16);
            this.rbtnDia.Name = "rbtnDia";
            this.rbtnDia.Size = new System.Drawing.Size(41, 17);
            this.rbtnDia.TabIndex = 73;
            this.rbtnDia.TabStop = true;
            this.rbtnDia.Text = "Dia";
            this.rbtnDia.UseVisualStyleBackColor = true;
            this.rbtnDia.CheckedChanged += new System.EventHandler(this.rbtnDia_CheckedChanged);
            // 
            // rbtnFecha
            // 
            this.rbtnFecha.AutoSize = true;
            this.rbtnFecha.Location = new System.Drawing.Point(107, 14);
            this.rbtnFecha.Name = "rbtnFecha";
            this.rbtnFecha.Size = new System.Drawing.Size(55, 17);
            this.rbtnFecha.TabIndex = 74;
            this.rbtnFecha.TabStop = true;
            this.rbtnFecha.Text = "Fecha";
            this.rbtnFecha.UseVisualStyleBackColor = true;
            this.rbtnFecha.CheckedChanged += new System.EventHandler(this.rbtnFecha_CheckedChanged);
            // 
            // gbReporte
            // 
            this.gbReporte.Controls.Add(this.rbtnDia);
            this.gbReporte.Controls.Add(this.rbtnFecha);
            this.gbReporte.Location = new System.Drawing.Point(65, 0);
            this.gbReporte.Name = "gbReporte";
            this.gbReporte.Size = new System.Drawing.Size(200, 41);
            this.gbReporte.TabIndex = 75;
            this.gbReporte.TabStop = false;
            // 
            // frmReporteFechaHora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(324, 139);
            this.ControlBox = false;
            this.Controls.Add(this.gbReporte);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnGenerar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReporteFechaHora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Fecha y Dia";
            this.gbReporte.ResumeLayout(false);
            this.gbReporte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnGenerar;
        public System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.RadioButton rbtnDia;
        private System.Windows.Forms.RadioButton rbtnFecha;
        private System.Windows.Forms.GroupBox gbReporte;
    }
}