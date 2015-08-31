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

/*
 * Programador y analista: Diego Alberto Taracena Morales
 * 
 * 
 * */

namespace Laboratorio
{
    public partial class frmConsultaPacientes : Form
    {
        string sCodigoUp;
        string sCodPacienteUp;
        string sNombreUp;
        string sApellidoUp;
        string sDpiUp;
        string sFechaUp;
        string sSexoUp;
        string sNitUp;
        string sReferenciaUp;
        string sPolizaUp;
        string sCadena;

        public frmConsultaPacientes()
        {
            InitializeComponent();
            funActualizar();
            funBuscarAseguro();
            funBuscarMembresia();
            gbSeguro.Enabled = false;
        }


        void funActualizar()
        {
            string sNombre;
            string sApellido;
            string sDpi;
            string sFecha;
            string sSexo;
            string sNit;
            string sReferencia;
            string sPoliza;
            string sCodigo;
            int iContador = 0;
            grdConsultarPacientes.Rows.Clear();

            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT MaPERSONA.ncodpersona, MaPERSONA.cnombrepersona, MaPERSONA.capellidopersona, MaPERSONA.cdpipersona, MaPERSONA.csexopersona, MaPERSONA.cnitpersona, MaPERSONA.dfechanacpersona, TrPACIENTE.crefpaciente, TrSEGURO.npoliza from MaPERSONA, TrPACIENTE, TrSEGURO WHERE MaPERSONA.ncodpersona = TrPACIENTE.ncodpersona AND TrPACIENTE.ncodpaciente = TrSEGURO.ncodpaciente"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sNombre = mReader.GetString(1);
                    sApellido = mReader.GetString(2);
                    sDpi = mReader.GetString(3);
                    sSexo = mReader.GetString(4);
                    sNit = mReader.GetString(5);
                    sFecha = mReader.GetString(6);
                    sReferencia = mReader.GetString(7);
                    sPoliza = mReader.GetString(8);
                    grdConsultarPacientes.Rows.Insert(iContador, sCodigo, sDpi, sNombre, sApellido, sSexo, sFecha, sNit, sReferencia, sPoliza);

                    sCodigo = "";
                    sNombre = "";
                    sApellido = "";
                    sDpi = "";
                    sFecha = "";
                    sSexo = "";
                    sNit = "";
                    sReferencia = "";
                    sPoliza = "";
                    iContador++;

                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //funcion para llenar el combo box de aseguradora
        void funBuscarAseguro()
        {
            string sCodigo;
            string sAseguradora;

            cmbAseguradora.Items.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT ncodaseguradora, cempresaseguro from MaASEGURADORA"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sAseguradora = mReader.GetString(1);

                    cmbAseguradora.Items.Add(sCodigo + ". " + sAseguradora);
                    sCodigo = "";
                    sAseguradora = "";
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //funcion que llena el combo box de membresia
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

        //obtenemos el codigo del paciente
        void funObtenerPaciente()
        {
            MySqlCommand mComando = new MySqlCommand(String.Format(
                  "SELECT TrPACIENTE.ncodpaciente FROM TrPACIENTE, MaPERSONA where TrPACIENTE.ncodpersona = MaPERSONA.ncodpersona and MaPERSONA.ncodpersona = '{0}'", sCodigoUp), clasConexion.funConexion());
            MySqlDataReader mReader = mComando.ExecuteReader();

            while (mReader.Read())
            {
                sCodPacienteUp = mReader.GetString(0);
                
            }

        }
        
        void funUpdate()
        {
            try
            {
                if (MessageBox.Show("¿Desea modificar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    String sMembresia = funCortador(cmbMembresia.SelectedItem.ToString());
                    String sAseguradora = funCortador(cmbAseguradora.SelectedItem.ToString());

                    MySqlCommand mComando = new MySqlCommand(string.Format("UPDATE MaPERSONA SET cnombrepersona= '{0}',  capellidopersona= '{1}',  cdpipersona= '{2}',  dfechanacpersona= '{3}',  csexopersona= '{4}', cnitpersona = '{5}' WHERE MaPERSONA.ncodpersona = '{6}'",
                    sNombreUp, sApellidoUp, sDpiUp, sFechaUp, sSexoUp, sNitUp, sCodigoUp), clasConexion.funConexion());
                    mComando.ExecuteNonQuery();

                    MySqlCommand mComandoPaciente = new MySqlCommand(string.Format("UPDATE TrPACIENTE SET crefpaciente='{0}', ncodmembresia='{1}' WHERE ncodpersona = '{2}'",
                    sReferenciaUp, sMembresia, sCodigoUp), clasConexion.funConexion());
                    mComandoPaciente.ExecuteNonQuery();

                    MySqlCommand mComandoSeguro = new MySqlCommand(string.Format("UPDATE TrSEGURO SET npoliza='{0}', ncodaseguradora='{1}' WHERE ncodpaciente = '{2}'",
                    sPolizaUp, sAseguradora, sCodPacienteUp), clasConexion.funConexion());
                    mComandoSeguro.ExecuteNonQuery();

                    MessageBox.Show("Se actualizo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDpi.Clear();
                    gbSeguro.Enabled = false;
                    funActualizar();
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 

        }
        void funDelete()
        {
            try
            {
                if (MessageBox.Show("¿Desea Eliminar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlCommand mComando = new MySqlCommand(string.Format("DELETE FROM MaPERSONA WHERE ncodpersona = '{0}'",
                    sCodigoUp), clasConexion.funConexion());
                    mComando.ExecuteNonQuery();

                    MySqlCommand mComandoPaciente = new MySqlCommand(string.Format("DELETE FROM TrPACIENTE WHERE ncodpersona = '{0}'",
                    sCodigoUp), clasConexion.funConexion());
                    mComandoPaciente.ExecuteNonQuery();

                    MySqlCommand mComandoSeguro = new MySqlCommand(string.Format("DELETE FROM TrSEGURO WHERE ncodpaciente = '{0}'",
                    sCodPacienteUp), clasConexion.funConexion());
                    mComandoSeguro.ExecuteNonQuery();

                    MessageBox.Show("Se elimino con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDpi.Clear();
                    gbSeguro.Enabled = false;
                    funActualizar();
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void grdConsultarPacientes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;


            DataGridViewRow fila = grdConsultarPacientes.CurrentRow;
            sCodigoUp = Convert.ToString(fila.Cells[0].Value);
            sDpiUp = Convert.ToString(fila.Cells[1].Value);
            sNombreUp = Convert.ToString(fila.Cells[2].Value);
            sApellidoUp = Convert.ToString(fila.Cells[3].Value);
            sSexoUp = Convert.ToString(fila.Cells[4].Value);
            sFechaUp = Convert.ToString(fila.Cells[5].Value);
            sNitUp = Convert.ToString(fila.Cells[6].Value);
            sReferenciaUp = Convert.ToString(fila.Cells[7].Value);
            sPolizaUp = Convert.ToString(fila.Cells[8].Value);
            funObtenerPaciente();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            //txtDpi.Text = "";
            txtDpi.Clear();
            gbSeguro.Enabled = false;
            funActualizar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            funUpdate();
        }

        private void txtDpi_KeyUp(object sender, KeyEventArgs e)
        {
            string sCodigo;
            string sNombre;
            string sApellido;
            string sDpi;
            string sFecha;
            string sSexo;
            string sNit;
            string sReferencia;
            string sPoliza;

            int iContador = 0;
            grdConsultarPacientes.Rows.Clear();

            try
            {

                if (String.IsNullOrEmpty(txtDpi.Text))
                {
                    funActualizar();
                }
                else
                {
                    //SELECT persona.ncodpersona, cdireccionpersona,cemailpersona,cnombrepersona,capellidopersona,cdpipersona,dfechanacpersona,csexopersona,cnitpersona, ndescpuesto FROM PERSONA,PUESTO,EMPLEADO WHERE PUESTO.ncodpuesto=EMPLEADO.ncodpuesto and persona.ncodpersona = empleado.ncodpersona
                    MySqlCommand mComando = new MySqlCommand(String.Format(
                    "SELECT MaPERSONA.ncodpersona, MaPERSONA.cnombrepersona, MaPERSONA.capellidopersona, MaPERSONA.cdpipersona, MaPERSONA.csexopersona, MaPERSONA.cnitpersona, MaPERSONA.dfechanacpersona, TrPACIENTE.crefpaciente, TrSEGURO.npoliza from MaPERSONA, TrPACIENTE, TrSEGURO WHERE MaPERSONA.ncodpersona = TrPACIENTE.ncodpersona AND TrPACIENTE.ncodpaciente = TrSEGURO.ncodpaciente AND MaPERSONA.cdpipersona  LIKE '{0}%' ", txtDpi.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        sCodigo = mReader.GetString(0);
                        sNombre = mReader.GetString(1);
                        sApellido = mReader.GetString(2);
                        sDpi = mReader.GetString(3);
                        sFecha = mReader.GetString(4);
                        sSexo = mReader.GetString(5);
                        sNit = mReader.GetString(6);
                        sReferencia = mReader.GetString(7);
                        sPoliza = mReader.GetString(8);
                        grdConsultarPacientes.Rows.Insert(iContador, sCodigo, sDpi, sNombre, sApellido, sSexo, sFecha, sNit, sReferencia, sPoliza);
                        sCodigo = "";
                        sNombre = "";
                        sApellido = "";
                        sDpi = "";
                        sFecha = "";
                        sSexo = "";
                        sNit = "";
                        sReferencia = "";
                        sPoliza = "";
                        iContador++;
                    }
                    btnCancelar.Enabled = true;
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdConsultarPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gbSeguro.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            funDelete();
        }
    }
}
