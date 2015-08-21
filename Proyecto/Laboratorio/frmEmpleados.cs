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
    public partial class frmEmpleados : Form
    {
        /*
         * Programador y Analista: Manuel Chuquiej
         * Fecha de Asignacion: 01 de Agosto
         * Fecha de Entrega: 04 de Agosto
        */
        string sSexo;
        string sCadena;
        string sCodigoPersona;
        public frmEmpleados()
        {
            InitializeComponent();
            funPuesto();
        }

        void funPuesto()
        {
            string sCodigo;
            string sNombre;
            cmbPuesto.Items.Clear();
            MySqlCommand mComando = new MySqlCommand(String.Format(
                   "SELECT ncodpuesto, ndescpuesto FROM MaPUESTO", txtNombre.Text), clasConexion.funConexion());
            MySqlDataReader mReader = mComando.ExecuteReader();

            while (mReader.Read())
            {
                sCodigo = mReader.GetString(0);
                sNombre = mReader.GetString(1);
                cmbPuesto.Items.Add(sCodigo+". "+sNombre);
                sCodigo = "";
                sNombre = "";
            }

        }

        void funObtenerCodPersona()
        {
            MySqlCommand mComando = new MySqlCommand(String.Format(
                   "SELECT ncodpersona FROM MaPERSONA WHERE cdpipersona= '{0}'", txtDpi.Text), clasConexion.funConexion());
            MySqlDataReader mReader = mComando.ExecuteReader();

            while (mReader.Read())
            {
                sCodigoPersona = mReader.GetString(0);
                funInsertarTablaEmpleado(sCodigoPersona);
            }

        }

        void funInsertarTablaEmpleado(string sCodigoPersona)
        {

            string sCmbCodPuesto = cmbPuesto.SelectedItem.ToString();
            string sCodPuesto = funCortador(sCmbCodPuesto);

            try
            {
                    MySqlCommand mComando = new MySqlCommand(string.Format("Insert into TrEMPLEADO (ncodpersona,ncodpuesto) values ('{0}','{1}')",
                    sCodigoPersona, sCodPuesto), clasConexion.funConexion());
                    mComando.ExecuteNonQuery();

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtDpi.Text) && String.IsNullOrEmpty(txtNombre.Text) && String.IsNullOrEmpty(txtApellido.Text) && String.IsNullOrEmpty(txtNit.Text))
                {
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if(rbMasculino.Checked == true)
                    {
                        sSexo = "Masculino";
                    }else if(rbFemenino.Checked==true)
                    {
                        sSexo = "Femenino";
                    }
                    //MessageBox.Show(txtDireccion.Text + txtEmail.Text + txtNombre.Text + txtApellido.Text + txtDpi.Text + dtpNacimiento.Text + sSexo + txtNit.Text);
                    MySqlCommand mComando = new MySqlCommand(string.Format("Insert into MaPERSONA (cnombrepersona,capellidopersona,cdpipersona,dfechanacpersona,csexopersona,cnitpersona) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
                    txtNombre.Text,txtApellido.Text,txtDpi.Text,dtpNacimiento.Text,sSexo,txtNit.Text), clasConexion.funConexion());
                    mComando.ExecuteNonQuery();
                    MessageBox.Show("Se inserto con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    funObtenerCodPersona();
                    txtDpi.Enabled = false;
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    rbFemenino.Enabled = false;
                    rbMasculino.Enabled = false;
                    dtpNacimiento.Enabled = false;
                    txtNit.Enabled = false;
                    cmbPuesto.Enabled = false;
                    btnGuardar.Enabled = false;
                    txtDireccion.Clear();
                    txtTelefono.Clear();
                    txtEmail.Clear();
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblAgregarDireccion_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtDireccion.Text))
                {
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(string.Format("Insert into TrDIRECCION (cdireccion,ncodpersona) values ('{0}','{1}')",
                    txtDireccion.Text, sCodigoPersona), clasConexion.funConexion());
                    mComando.ExecuteNonQuery();
                    MessageBox.Show("Se inserto con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDireccion.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblAgregarTelefono_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtTelefono.Text))
                {
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(string.Format("Insert into TrTELEFONO (ctelefono,ncodpersona) values ('{0}','{1}')",
                    txtTelefono.Text, sCodigoPersona), clasConexion.funConexion());
                    mComando.ExecuteNonQuery();
                    MessageBox.Show("Se inserto con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTelefono.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblAgregarEmail_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtEmail.Text))
                {
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(string.Format("Insert into TrEMAIL (cemail,ncodpersona) values ('{0}','{1}')",
                    txtEmail.Text, sCodigoPersona), clasConexion.funConexion());
                    mComando.ExecuteNonQuery();
                    MessageBox.Show("Se inserto con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmail.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDpi.Enabled = true;
            txtDpi.Clear();
            txtNombre.Enabled = true;
            txtNombre.Clear();
            txtApellido.Enabled = true;
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtNit.Enabled = true;
            txtNit.Clear();
            dtpNacimiento.Enabled = true;
            grpSexo.Enabled = true;
            btnGuardar.Enabled = true;


        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
