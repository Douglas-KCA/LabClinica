using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio
{
    public partial class frmEnviarReporte : Form
    {

        clasCorreo c = new clasCorreo();
        public frmEnviarReporte()
        {
            InitializeComponent();
            txtEmisor.Text = "health.test.laboratory@gmail.com";
            txtPass.Text = "Cocodrilo";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAdjunto.Text) || String.IsNullOrEmpty(txtPass.Text) || String.IsNullOrEmpty(txtEmisor.Text) || String.IsNullOrEmpty(txtCuerpo.Text)
                || String.IsNullOrEmpty(txtAsunto.Text) || String.IsNullOrEmpty(txtReceptor.Text))
            {
                MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                c.enviarCorreo(txtEmisor.Text, txtPass.Text, txtCuerpo.Text, txtAsunto.Text, txtReceptor.Text, txtAdjunto.Text);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtAsunto.Text = txtCuerpo.Text = txtReceptor.Text = "";
            txtAdjunto.Clear();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    txtAdjunto.Text = this.openFileDialog1.FileName;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la ruta del archivo: " + ex.ToString());
            }
        }
    }
}
