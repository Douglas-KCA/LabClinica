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
        string sCadena;
        public frmConsultaEmpleados()
        {
            InitializeComponent();
            grPuesto.Visible = false;
            funActualizar();
            funPuesto();
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
                "SELECT MaPERSONA.ncodpersona, cnombrepersona,capellidopersona,cdpipersona,dfechanacpersona,csexopersona,cnitpersona, ndescpuesto FROM MaPERSONA,MaPUESTO,TrEMPLEADO WHERE MaPUESTO.ncodpuesto=TrEMPLEADO.ncodpuesto and MaPERSONA.ncodpersona = TrEMPLEADO.ncodpersona"), clasConexion.funConexion());
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

        void funPuesto()
        {
            string sCodigo;
            string sNombre;
            cmbPuesto.Items.Clear();
            MySqlCommand mComando = new MySqlCommand(String.Format(
                   "SELECT ncodpuesto, ndescpuesto FROM MaPUESTO"), clasConexion.funConexion());
            MySqlDataReader mReader = mComando.ExecuteReader();

            while (mReader.Read())
            {
                sCodigo = mReader.GetString(0);
                sNombre = mReader.GetString(1);
                cmbPuesto.Items.Add(sCodigo + ". " + sNombre);
                sCodigo = "";
                sNombre = "";
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
        
        void funUpdate()
        {
            try
            {
                if (MessageBox.Show("¿Desea modificar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    String sPuesto = funCortador(cmbPuesto.SelectedItem.ToString());
                    
                    MySqlCommand mComando = new MySqlCommand(string.Format("UPDATE MaPERSONA SET cnombrepersona= '{0}',  capellidopersona= '{1}',  cdpipersona= '{2}',  dfechanacpersona= '{3}',  csexopersona= '{4}', cnitpersona = '{5}' WHERE MaPERSONA.ncodpersona = '{6}'",
                    sNombreUp, sApellidoUp, sDpiUp, sFechaUp, sSexoUp, sNitUp, sCodigoUp), clasConexion.funConexion());
                    mComando.ExecuteNonQuery();

                    MySqlCommand mComandoPuesto = new MySqlCommand(string.Format("UPDATE TrEMPLEADO SET ncodpuesto= '{0}' WHERE ncodpersona = '{1}'",
                    sPuesto, sCodigoUp), clasConexion.funConexion());
                    mComandoPuesto.ExecuteNonQuery();

                    MessageBox.Show("Se actualizo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Text = "";
                    grPuesto.Visible = false;
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

                    MySqlCommand mComandoPuesto = new MySqlCommand(string.Format("DELETE FROM TrEMPLEADO WHERE ncodpersona = '{0}'",
                    sCodigoUp), clasConexion.funConexion());
                    mComandoPuesto.ExecuteNonQuery();

                    MessageBox.Show("Se elimino con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Text = "";
                    grPuesto.Visible = false;
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
            btnActualizar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true; 

            
            DataGridViewRow fila = grdConsultarEmpleados.CurrentRow;
            sCodigoUp = Convert.ToString(fila.Cells[0].Value);
            sDpiUp = Convert.ToString(fila.Cells[1].Value);
            sNombreUp = Convert.ToString(fila.Cells[2].Value);
            sApellidoUp = Convert.ToString(fila.Cells[3].Value);
            sSexoUp = Convert.ToString(fila.Cells[4].Value);
            sFechaUp = Convert.ToString(fila.Cells[5].Value);
            sNitUp = Convert.ToString(fila.Cells[6].Value);
            sPuestoUp = Convert.ToString(fila.Cells[7].Value);


           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            //txtDpi.Text = "";
            txtNombre.Clear(); 
            grPuesto.Visible = false;
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

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
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
                    funActualizar();
                }
                else
                {
                    //SELECT persona.ncodpersona, cdireccionpersona,cemailpersona,cnombrepersona,capellidopersona,cdpipersona,dfechanacpersona,csexopersona,cnitpersona, ndescpuesto FROM PERSONA,PUESTO,EMPLEADO WHERE PUESTO.ncodpuesto=EMPLEADO.ncodpuesto and persona.ncodpersona = empleado.ncodpersona
                    MySqlCommand mComando = new MySqlCommand(String.Format(
                    "SELECT MaPERSONA.ncodpersona, cnombrepersona,capellidopersona,cdpipersona,dfechanacpersona,csexopersona,cnitpersona, ndescpuesto FROM MaPERSONA, MaPUESTO, TrEMPLEADO WHERE MaPUESTO.ncodpuesto=TrEMPLEADO.ncodpuesto and MaPERSONA.ncodpersona = TrEMPLEADO.ncodpersona AND MaPERSONA.cnombrepersona LIKE '{0}%' ", txtNombre.Text), clasConexion.funConexion());
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

        private void grdConsultarEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grPuesto.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            funDelete();
        }
    }
}
