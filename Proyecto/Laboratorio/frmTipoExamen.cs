using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Laboratorio
{
    /*
         * Programador y Analista: Dylan Corado
         * Fecha de Asignacion: 07 de Agosto
         * Fecha de Entrega: 10 de Agosto
   */
    public partial class frmTipoExamen : Form
    {
        string sCadena;
        public frmTipoExamen()
        {
            InitializeComponent();
            funLlenarMuestra();
        }

        void funLlenarMuestra()
        {

            string sCodigo;
            string sNombre;
            cmbMuestra.Items.Clear();

            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT ncodmuestra, cdescmuestra FROM MaMUESTRA"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sNombre = mReader.GetString(1);
                    cmbMuestra.Items.Add(sCodigo + ". " + sNombre);
                    sCodigo = "";
                    sNombre = "";
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string funCortador(string sDato)
        {
            sCadena = "";
            try
            {
                for (int i = 0; i < sDato.Length; i++)
                {
                    if (sDato.Substring(i, 1) != ".")
                    {
                        sCadena = sCadena + sDato.Substring(i, 1);
                    }
                    else
                    {
                        break;
                    }
                }

            }
            catch
            {
                MessageBox.Show("Error al obtener Codigo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return sCadena;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtTipoExamen.Clear();
            txtPrecio.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (String.IsNullOrEmpty(txtTipoExamen.Text) && String.IsNullOrEmpty(txtPrecio.Text))
                {
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {

                    string sCodMuestra = funCortador(cmbMuestra.SelectedItem.ToString());
                    MySqlCommand mComando = new MySqlCommand(string.Format("Insert into MaTIPOEXAMEN (cdesctipoexamen, cpreciotipoexamen, ncodmuestra) values ('{0}', '{1}', '{2}')",
                    txtTipoExamen.Text, txtPrecio.Text,sCodMuestra), clasConexion.funConexion());
                    mComando.ExecuteNonQuery();
                    MessageBox.Show("Se inserto con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTipoExamen.Clear();
                    txtPrecio.Clear();
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTipoExamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
