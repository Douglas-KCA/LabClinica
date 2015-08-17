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
    public partial class frmConsultaEmpleados : Form
    {
        string sCodigoUp;
        string sNombreUp;
        string sApellidoUp;
        string sDpiUp;
        string sFechaUp;
        string sSexoUp;
        string sNitUp;
        string sPuestoUp;
        public frmConsultaEmpleados()
        {
            InitializeComponent();
            funActualizar();
        }

        void funActualizar()
        {
            string sNombre;
            string sApellido;
            string sDpi;
            string sFecha;
            string sSexo;
            string sNit;
            string sPuesto;
            string sCodigo;
            int iContador = 0;
            grdConsultarEmpleados.Rows.Clear();

            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT mapersona.ncodpersona, cnombrepersona,capellidopersona,cdpipersona,dfechanacpersona,csexopersona,cnitpersona, ndescpuesto FROM MAPERSONA,MAPUESTO,TREMPLEADO WHERE MAPUESTO.ncodpuesto=TREMPLEADO.ncodpuesto and mapersona.ncodpersona = trempleado.ncodpersona"), clasConexion.funConexion());
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
                    sPuesto = mReader.GetString(7);
                    grdConsultarEmpleados.Rows.Insert(iContador,sCodigo, sDpi ,sNombre, sApellido,sSexo,sFecha,sNit,sPuesto);

                    sCodigo = "";
                    sNombre = "";
                    sApellido = "";
                    sDpi = "";
                    sFecha = "";
                    sSexo = "";
                    sNit = "";
                    sPuesto = "";
                    iContador++;
                    
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        void funUpdate()
        {
            try
            {
                if (MessageBox.Show("¿Desea modificar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlCommand mComando = new MySqlCommand(string.Format("UPDATE MaPERSONA SET cnombrepersona= '{0}',  capellidopersona= '{1}',  cdpipersona= '{2}',  dfechanacpersona= '{3}',  csexopersona= '{4}', cnitpersona = '{5}' WHERE MaPERSONA.ncodpersona = '{6}'",
                    sNombreUp, sApellidoUp, sDpiUp, sFechaUp, sSexoUp, sNitUp, sCodigoUp), clasConexion.funConexion());
                    mComando.ExecuteNonQuery();
                    MessageBox.Show("Se actualizo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Text = "";
                    funActualizar();
                }
                
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void grdConsultarAseguradora_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cmbDirecion.Items.Clear();
            cmbEmail.Items.Clear();
            cmbTelefono.Items.Clear(); 
            btnActualizar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;
            //btnBuscar.Enabled = false;
            txtNombre.Clear();
           // txtDpi.Clear();
            //txtDpi.Enabled = false;
            //txtNombre.Enabled = false;

            
            DataGridViewRow fila = grdConsultarEmpleados.CurrentRow;
            sCodigoUp = Convert.ToString(fila.Cells[0].Value);
            sDpiUp = Convert.ToString(fila.Cells[1].Value);
            sNombreUp = Convert.ToString(fila.Cells[2].Value);
            sApellidoUp = Convert.ToString(fila.Cells[3].Value);
            sSexoUp = Convert.ToString(fila.Cells[4].Value);
            sFechaUp = Convert.ToString(fila.Cells[5].Value);
            sNitUp = Convert.ToString(fila.Cells[6].Value);
            sPuestoUp = Convert.ToString(fila.Cells[7].Value);


            //MessageBox.Show(sCodigoUp+sDpiUp+sNombreUp+sApellidoUp+sSexoUp+sFechaUp+sNitUp+sPuestoUp);

            //Llenar Combo Box Direccion

            MySqlCommand mComandocmbDire = new MySqlCommand(String.Format(
            "SELECT ncoddireccion, cdireccion FROM trdireccion WHERE trdireccion.ncodpersona = '{0}' ", sCodigoUp), clasConexion.funConexion());
            MySqlDataReader mReadercmbDire = mComandocmbDire.ExecuteReader();

            while (mReadercmbDire.Read())
            {
                cmbDirecion.Items.Add(mReadercmbDire.GetString(0) + ". " + mReadercmbDire.GetString(1));
            }

            //Llenar Combo Box Telefono
            MySqlCommand mComandocmbTel = new MySqlCommand(String.Format(
           "SELECT ncodtelefono, ctelefono FROM trtelefono WHERE trtelefono.ncodpersona = '{0}' ", sCodigoUp), clasConexion.funConexion());
            MySqlDataReader mReadercmbTel = mComandocmbTel.ExecuteReader();

            while (mReadercmbTel.Read())
            {
                cmbTelefono.Items.Add(mReadercmbTel.GetString(0) + ". " + mReadercmbTel.GetString(1));
            }

            //Llenar Combo Box Email
            MySqlCommand mComandocmbEmail = new MySqlCommand(String.Format(
           "SELECT ncodemail, cemail FROM tremail WHERE tremail.ncodpersona = '{0}' ", sCodigoUp), clasConexion.funConexion());
            MySqlDataReader mReadercmbEmail = mComandocmbEmail.ExecuteReader();

            while (mReadercmbEmail.Read())
            {
                cmbEmail.Items.Add(mReadercmbEmail.GetString(0) + ". " + mReadercmbEmail.GetString(1));
            }

            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sCodigo;
            string sNombre;
            string sApellido;
            string sDpi;
            string sFecha;
            string sSexo;
            string sNit;
            string sPuesto;

            int iContador = 0;
            grdConsultarEmpleados.Rows.Clear();

            try
            {

                if (String.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    funActualizar();
                }
                else
                {
                    //SELECT persona.ncodpersona, cdireccionpersona,cemailpersona,cnombrepersona,capellidopersona,cdpipersona,dfechanacpersona,csexopersona,cnitpersona, ndescpuesto FROM PERSONA,PUESTO,EMPLEADO WHERE PUESTO.ncodpuesto=EMPLEADO.ncodpuesto and persona.ncodpersona = empleado.ncodpersona
                    MySqlCommand mComando = new MySqlCommand(String.Format(
                    "SELECT MaPERSONA.ncodpersona, cnombrepersona,capellidopersona,cdpipersona,dfechanacpersona,csexopersona,cnitpersona, ndescpuesto FROM MaPERSONA, MaPUESTO, TrEMPLEADO WHERE MaPUESTO.ncodpuesto=TrEMPLEADO.ncodpuesto and MaPERSONA.ncodpersona = TrEMPLEADO.ncodpersona AND MaPERSONA.cnombrepersona= '{0}' ", txtNombre.Text), clasConexion.funConexion());
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
                        sPuesto = mReader.GetString(7);
                        grdConsultarEmpleados.Rows.Insert(iContador, sCodigo, sDpi, sNombre, sApellido, sSexo, sFecha, sNit, sPuesto);
                        sCodigo = "";
                        sNombre = "";
                        sApellido = "";
                        sDpi = "";
                        sFecha = "";
                        sSexo = "";
                        sNit = "";
                        sPuesto = "";
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnBuscar.Enabled = true;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            //txtDpi.Text = "";
            txtNombre.Text = "";
            funActualizar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            funUpdate();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
