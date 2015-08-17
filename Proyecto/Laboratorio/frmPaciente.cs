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

    /*------------------------------------------------------------------------------------------------------
     * Programador y analista: Diego Taracena
     * Fecha de asignacion: 7-8-2015
     * Fecha de Entrega: 10-8-2015
     * -------------------------------------------------------------------------------------------------------
     * */
{
    public partial class frmPaciente : Form
    {
        string sSexo;
        string sCodigoPersona;
        string sCadena;
        string sCodSeguro, sCodMembresia;

        public frmPaciente()
        {
            InitializeComponent();
            funBuscarAseguro();
            funBuscarMembresia();
            cmbSeguro.Enabled = false;
            cmbMembresia.Enabled = false;
            txtEmail.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
        }

        
        void funBuscarAseguro()
        {
            string sCodigo;
            string sAseguradora;
            string sTarifa;
            cmbSeguro.Items.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT TrSEGURO.ncodseguro, MaTARIFASEGURO.nporcentajetarifa, MaASEGURADORA.cempresaseguro from TrSEGURO,MaTARIFASEGURO,MaASEGURADORA WHERE TrSEGURO.ncodtarifa = MaTARIFASEGURO.ncodtarifa and TrSEGURO.ncodaseguradora = MaASEGURADORA.ncodaseguradora"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sAseguradora = mReader.GetString(1);
                    sTarifa = mReader.GetString(2);
                    cmbSeguro.Items.Add(sCodigo + ". " + sAseguradora +" Tarifa: "+sTarifa);
                    sCodigo = "";
                    sAseguradora = "";
                    sTarifa = "";
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void funBuscarMembresia()
        {
            string sCodigo;
            string sMembrecia;
            cmbMembresia.Items.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT ncodmembresia, ctipomembresia FROM MaMEMBRESIA"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sMembrecia = mReader.GetString(1);
                    cmbMembresia.Items.Add(sCodigo + ".  Tipo:" + sMembrecia);
                    sCodigo = "";
                    sMembrecia = "";
               
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void funObtenerCodPersona()
        {
            MySqlCommand mComando = new MySqlCommand(String.Format(
                   "SELECT ncodpersona FROM MAPERSONA WHERE cdpipersona= '{0}'", txtDpi.Text), clasConexion.funConexion());
            MySqlDataReader mReader = mComando.ExecuteReader();

            while (mReader.Read())
            {
                sCodigoPersona = mReader.GetString(0);
                funInsertarTablaPaciente(sCodigoPersona);
            }

        }

        void funInsertarTablaPaciente(string sCodigoPersona)
        {
            string sCmbCodSeguro, sCmbCodMembresia;
           
            if (cbSeguro.Checked)
            {
                sCmbCodSeguro = cmbSeguro.SelectedItem.ToString();
                sCodSeguro = funCortador(sCmbCodSeguro);
            }
            else
            {
                sCodSeguro = null;

            }

            if (cbMembresia.Checked)
            {
                sCmbCodMembresia = cmbMembresia.SelectedItem.ToString();
                sCodMembresia = funCortador(sCmbCodMembresia);
            }
            else
            {
                sCodMembresia = null;

            }
            
            //string sCmbCodPuesto = cmbPuesto.SelectedItem.ToString();
            //string sCodPuesto = funCortador(sCmbCodPuesto);

            try
            {
                MySqlCommand mComando = new MySqlCommand(string.Format("Insert into TrPACIENTE (crefpaciente,ncodpersona,ncodseguro,ncodmembresia) values ('{0}','{1}','{2}','{3}')",
                txtReferencia.Text,sCodigoPersona,sCodSeguro,sCodMembresia), clasConexion.funConexion());
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
                    if (rbMasculino.Checked == true)
                    {
                        sSexo = "Masculino";
                    }
                    else if (rbFemenino.Checked == true)
                    {
                        sSexo = "Femenino";
                    }
                    //MessageBox.Show(txtDireccion.Text + txtEmail.Text + txtNombre.Text + txtApellido.Text + txtDpi.Text + dtpNacimiento.Text + sSexo + txtNit.Text);
                    MySqlCommand mComando = new MySqlCommand(string.Format("Insert into MAPERSONA (cnombrepersona,capellidopersona,cdpipersona,dfechanacpersona,csexopersona,cnitpersona) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
                    txtNombre.Text, txtApellido.Text, txtDpi.Text, dtpNacimiento.Text, sSexo, txtNit.Text), clasConexion.funConexion());
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
                    btnGuardar.Enabled = false;
                    txtReferencia.Enabled = false;
                    txtDireccion.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtEmail.Enabled = true;
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
            txtReferencia.Clear();
            txtReferencia.Enabled = true;
            rbFemenino.Enabled = true;
            rbMasculino.Enabled = true;
            dtpNacimiento.Enabled = true;
            btnGuardar.Enabled = true;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            txtTelefono.Clear();
            txtEmail.Enabled = false;
            txtEmail.Clear();

        }

        private void cbSeguro_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSeguro.Checked)
            {
                cmbSeguro.Enabled = true;
            }
            else
            {
                cmbSeguro.Enabled = false;

            }
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
                    MySqlCommand mComando = new MySqlCommand(string.Format("Insert into TRDIRECCION (cdireccion,ncodpersona) values ('{0}','{1}')",
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
                    MySqlCommand mComando = new MySqlCommand(string.Format("Insert into TRTELEFONO (ctelefono,ncodpersona) values ('{0}','{1}')",
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
                    MySqlCommand mComando = new MySqlCommand(string.Format("Insert into TREMAIL (cemail,ncodpersona) values ('{0}','{1}')",
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

        private void cbMembresia_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMembresia.Checked)
            {
                cmbMembresia.Enabled = true;
            }
            else
            {
                cmbMembresia.Enabled = false;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
