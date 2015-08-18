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
/*---------------------------------------------------------------------------------------------------------------------------------
   Programador y Analista: Josue Revolorio
 * Fecha de asignacion: 03/08/2015
 * Fecha de entrega: 05/08/2015
---------------------------------------------------------------------------------------------------------------------------------*/

    public partial class frmConsultaAnalisis : Form
    {
        public frmConsultaAnalisis()
        {
            InitializeComponent();
            funCargarCombos();
            funActualizar();
        }
        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que toma los valores de la fila seleccionada en el grid para mostrarlos en los campos de texto de edicion
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void grdAnalisis_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //QUERY
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que pobla el grid con los datos de la BD
        ---------------------------------------------------------------------------------------------------------------------------------*/
        void funActualizar()
        {
            string sNombre = "";
            string sEtiqueta = "";
            string sCodigo = "";
            string sMuestra = "";
            int iContador = 0;
            grdAnalisis.Rows.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT ncodanalisis, ncodetiqueta FROM TrANALISIS"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();
                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sEtiqueta = mReader.GetString(1);

                    MySqlCommand mComando2 = new MySqlCommand(String.Format(
                    "SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona = (SELECT ncodpersona FROM TrPACIENTE WHERE ncodpaciente = (SELECT ncodpaciente FROM MaEtiqueta WHERE ncodetiqueta = '{0}'))", sEtiqueta), clasConexion.funConexion());
                    MySqlDataReader mReader2 = mComando2.ExecuteReader();
                    if (mReader2.Read())
                        sNombre = mReader2.GetString(0) + " " + mReader2.GetString(1);

                    MySqlCommand mComando3 = new MySqlCommand(String.Format(
                    "SELECT cdescmuestra FROM MaMUESTRA WHERE ncodmuestra = (SELECT ncodmuestra FROM MaETIQUETA WHERE ncodetiqueta = '{0}')", sEtiqueta), clasConexion.funConexion());
                    MySqlDataReader mReader3 = mComando3.ExecuteReader();
                    if (mReader3.Read())
                        sMuestra = mReader3.GetString(0);

                    grdAnalisis.Rows.Insert(iContador, sCodigo, sNombre, sMuestra);
                    sNombre = sCodigo = sMuestra = "";
                    iContador++;
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void funCargarCombos()
        {
            String sMuestra, sPaciente;
            try
            {
                
                    MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cdescmuestra FROM MaMUESTRA"), clasConexion.funConexion());
                    MySqlDataReader mReader2 = mComando2.ExecuteReader();
                    while (mReader2.Read())
                    {
                        sMuestra = mReader2.GetString(0);
                        cmbMuestra.Items.Add(sMuestra);
                    }

                    MySqlCommand mComando3 = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona IN (SELECT ncodpersona FROM TrPaciente)"), clasConexion.funConexion());
                    MySqlDataReader mReader3 = mComando3.ExecuteReader();
                    while (mReader3.Read()) 
                    { 
                        sPaciente = mReader3.GetString(0) + " " + mReader3.GetString(1);
                        cmbPaciente.Items.Add(sPaciente);
                    }
                
                
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int iContador = 0;
            bool existe = false;
            string sCodigo = "";
            string sNombre = "";
            string sMuestra = "";
            grdAnalisis.Rows.Clear();
            try
            {

                if (String.IsNullOrEmpty(cmbPaciente.Text) || String.IsNullOrEmpty(cmbMuestra.Text))
                {
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    String[] nombres = cmbPaciente.Text.Split(' ');
                    MySqlCommand mComando = new MySqlCommand(String.Format(
                    "SELECT ncodetiqueta FROM MaETIQUETA WHERE ncodpaciente = (SELECT ncodpaciente FROM TrPACIENTE WHERE ncodpersona = (SELECT ncodpersona FROM MaPERSONA WHERE cnombrepersona = '{0}' AND capellidopersona = '{1}')) AND ncodmuestra = (SELECT ncodmuestra FROM MaMUESTRA WHERE cdescmuestra = '{2}') ", nombres[0],nombres[1],cmbMuestra.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();
                    while (mReader.Read())
                    {
                        existe = true;
                        sCodigo = mReader.GetString(0);

                        MySqlCommand mComando2 = new MySqlCommand(String.Format(
                        "SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona = (SELECT ncodpersona FROM TrPACIENTE WHERE ncodpaciente = (SELECT ncodpaciente FROM MaEtiqueta WHERE ncodetiqueta = '{0}'))", sCodigo), clasConexion.funConexion());
                        MySqlDataReader mReader2 = mComando2.ExecuteReader();
                        if (mReader2.Read())
                            sNombre = mReader2.GetString(0) + " " + mReader2.GetString(1);

                        MySqlCommand mComando3 = new MySqlCommand(String.Format(
                        "SELECT cdescmuestra FROM MaMUESTRA WHERE ncodmuestra = (SELECT ncodmuestra FROM MaETIQUETA WHERE ncodetiqueta = '{0}')", sCodigo), clasConexion.funConexion());
                        MySqlDataReader mReader3 = mComando3.ExecuteReader();
                        if (mReader3.Read())
                            sMuestra = mReader3.GetString(0);
                        
                        grdAnalisis.Rows.Insert(iContador, sCodigo, sNombre, sMuestra);
                        sMuestra = "";
                        sNombre = "";
                        iContador++;
                    }

                    if (existe == false)
                    {
                        MessageBox.Show("No se encontraron resultados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
