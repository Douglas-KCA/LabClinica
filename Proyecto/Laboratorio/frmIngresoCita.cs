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
   * Fecha de entrega: 07/08/2015
---------------------------------------------------------------------------------------------------------------------------------*/
    public partial class frmIngresoCita : Form
    {

        public frmIngresoCita()
        {
            InitializeComponent();
            funCargarCombos();
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que carga los datos a los combos del programa al iniciar el form
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void funCargarCombos()
        {
            String sNombre;
            String sPersona;
            String sPaciente;

            try{
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT cnombresucursal FROM MaSUCURSAL"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read()){
                    sNombre = mReader.GetString(0);
                    cmbSucursal.Items.Add(sNombre);
                }
            }
            catch{
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT ncodpersona FROM TrPACIENTE"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();
                while(mReader.Read()){
                    sPersona = mReader.GetString(0);
                    MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona = '{0}' ", sPersona), clasConexion.funConexion());
                    MySqlDataReader mReader2 = mComando2.ExecuteReader();
                    while (mReader2.Read())
                    {
                        sPaciente = mReader2.GetString(0) + " " + mReader2.GetString(1);
                        cmbPaciente.Items.Add(sPaciente);
                    }
                    sPersona = "";
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que guarda los datos de la cita en la BD y las añade a la tabla en el form 
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String sCodigoPaciente = "";
            String sCodigoSucursal = ""; 
            String sCodigoPersona = "";
            try{
                if (String.IsNullOrEmpty(cmbSucursal.Text) || String.IsNullOrEmpty(cmbPaciente.Text) || String.IsNullOrEmpty(cmbHora.Text) || String.IsNullOrEmpty(cmbMinutos.Text)){
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else{
                    String[] nombres = cmbPaciente.Text.Split(' ');
                    
                    MySqlCommand mComando = new MySqlCommand(String.Format("SELECT ncodpersona FROM MaPERSONA WHERE cnombrepersona = '{0}' AND capellidopersona = '{1}' ", nombres[0],nombres[1]), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();
                    if (mReader.Read())
                        sCodigoPersona = mReader.GetString(0);

                    MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT ncodpaciente FROM TrPACIENTE WHERE ncodpersona = '{0}' ", sCodigoPersona), clasConexion.funConexion());
                    MySqlDataReader mReader2 = mComando2.ExecuteReader();
                    if (mReader2.Read())
                        sCodigoPaciente = mReader2.GetString(0);

                    MySqlCommand mComando3 = new MySqlCommand(String.Format("SELECT ncodsucursal FROM MaSUCURSAL WHERE cnombresucursal = '{0}' ", cmbSucursal.Text), clasConexion.funConexion());
                    MySqlDataReader mReader3 = mComando3.ExecuteReader();
                    if (mReader3.Read())
                        sCodigoSucursal = mReader3.GetString(0);

                    MySqlCommand mComando4 = new MySqlCommand(String.Format("SELECT ncodigocita FROM TrCITA WHERE dfechacita = '{0}' AND choracita = '{1}' AND ncodsucursal = '{2}'", dtpCitas.Text, cmbHora.Text + ":" + cmbMinutos.Text, sCodigoSucursal), clasConexion.funConexion());
                    MySqlDataReader mReader4 = mComando4.ExecuteReader();
                    if (mReader4.Read()) {
                        MessageBox.Show("Ya se tiene una cita para ese momento o lugar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MySqlCommand comando4 = new MySqlCommand(string.Format("INSERT into TrCITA (ncodsucursal, ncodpaciente, dfechacita, choracita) values ('{0}','{1}','{2}','{3}')",
                        sCodigoSucursal, sCodigoPaciente, dtpCitas.Text, cmbHora.Text + ":" + cmbMinutos.Text), clasConexion.funConexion());
                        comando4.ExecuteNonQuery();
                        MessageBox.Show("La cita se Genero con Exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbHora.Text = cmbMinutos.Text = cmbPaciente.Text = cmbSucursal.Text = "";
                    }
                }
            }catch{
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Limpia los textbox o combobox 
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cmbHora.Text = "";
            cmbMinutos.Text = "";
            cmbPaciente.Text = "";
            cmbSucursal.Text = "";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
