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
            String sEmpleado;
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
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona IN (SELECT ncodpersona FROM TrPACIENTE)"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();
                while (mReader.Read())
                {
                    sPaciente = mReader.GetString(0) + " " + mReader.GetString(1);
                    cmbPaciente.Items.Add(sPaciente);
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona IN (SELECT ncodpersona FROM TrEMPLEADO)"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();
                while (mReader.Read())
                {
                    sEmpleado = mReader.GetString(0) + " " + mReader.GetString(1);
                    cmbEmpleado.Items.Add(sEmpleado);
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
            String sCodigoEmpleado = "";
            String sPoliza = "";
            String sTipoFact = "";
            String sNombre = "";
            String sApellido = "";
            String sNombreCompleto = "";
            DateTime dateTime = DateTime.Today;

            if (String.IsNullOrEmpty(cmbSucursal.Text) || String.IsNullOrEmpty(cmbPaciente.Text) || String.IsNullOrEmpty(cmbHora.Text) || String.IsNullOrEmpty(cmbMinutos.Text)){
                MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else{
                String[] sNombresPac = cmbPaciente.Text.Split(' ');
                String[] sNombresEmp = cmbEmpleado.Text.Split(' ');

                try{
                    MySqlCommand mComando = new MySqlCommand(String.Format("SELECT ncodpaciente FROM TrPACIENTE WHERE ncodpersona = (SELECT ncodpersona FROM MaPERSONA WHERE cnombrepersona = '{0}' AND capellidopersona = '{1}')", sNombresPac[0], sNombresPac[1]), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();
                    if (mReader.Read())
                        sCodigoPaciente = mReader.GetString(0);
                }
                catch{
                    MessageBox.Show("Se produjo un error al obtener paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try{
                    MySqlCommand mComando = new MySqlCommand(String.Format("SELECT npoliza FROM TrSEGURO WHERE ncodpaciente = '{0}'", sCodigoPaciente), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();
                    if (mReader.Read()){
                        sPoliza = mReader.GetString(0);
                        sTipoFact = "aseguradora";
                    }
                    else{
                        sTipoFact = "paciente";
                    }
                        
                }
                catch{
                    MessageBox.Show("Se produjo un error al obtener poliza", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try{
                    MySqlCommand mComando = new MySqlCommand(String.Format("SELECT ncodempleado FROM TrEMPLEADO WHERE ncodpersona = (SELECT ncodpersona FROM MaPERSONA WHERE cnombrepersona = '{0}' AND capellidopersona = '{1}')", sNombresEmp[0], sNombresEmp[1]), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();
                    if (mReader.Read())
                        sCodigoEmpleado = mReader.GetString(0);
                }
                catch{
                    MessageBox.Show("Se produjo un error al obtener empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try{
                    MySqlCommand mComando = new MySqlCommand(String.Format("SELECT ncodsucursal FROM MaSUCURSAL WHERE cnombresucursal = '{0}'", cmbSucursal.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();
                    if (mReader.Read())
                        sCodigoSucursal = mReader.GetString(0);
                }
                catch{
                    MessageBox.Show("Se produjo un error al obtener sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try{
                    MySqlCommand mComando = new MySqlCommand(String.Format("SELECT ncodigocita FROM TrCITA WHERE ncodempleado = '{0}' AND dfechacita = '{1}' AND choracita = '{2}' AND cestado = 'Activa'", sCodigoEmpleado, dtpCitas.Text, cmbHora.Text + ":" + cmbMinutos.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();
                    if (mReader.Read()){
                        MessageBox.Show("Ya se tiene una cita para ese momento o lugar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else{
                        MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT ncodigocita FROM TrCITA WHERE ncodsucursal = '{0}' AND dfechacita = '{1}' AND choracita = '{2}' AND cestado = 'Activa'", sCodigoSucursal, dtpCitas.Text, cmbHora.Text + ":" + cmbMinutos.Text), clasConexion.funConexion());
                        MySqlDataReader mReader2 = mComando2.ExecuteReader();
                        if (mReader2.Read()){
                            MessageBox.Show("Ya se tiene una cita en esa sucursal en ese momento o lugar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else{
                            MySqlCommand comando = new MySqlCommand(string.Format("INSERT into TrCITA (dfechacita, choracita, cestado, ncodpaciente, ncodsucursal, ncodempleado) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
                            dtpCitas.Text, cmbHora.Text + ":" + cmbMinutos.Text, "Activa", sCodigoPaciente, sCodigoSucursal, sCodigoEmpleado), clasConexion.funConexion());
                            comando.ExecuteNonQuery();
                            
                            MySqlCommand comando2 = new MySqlCommand(string.Format("INSERT into MaFACTURA (ctipofactura, dfechafactura, ncodpaciente, cestado) values ('{0}','{1}','{2}','{3}')",
                            sTipoFact, dateTime.ToString("d"), sCodigoPaciente, "ACTIVA"), clasConexion.funConexion());
                            comando2.ExecuteNonQuery();

                            MessageBox.Show("La cita se Genero con Exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmbHora.Text = cmbMinutos.Text = cmbPaciente.Text = cmbEmpleado.Text = cmbSucursal.Text = "";
                                                        
                            frmServiciosCita ver = new frmServiciosCita();
                            ver.txtNombrePaciente.Text = cmbPaciente.SelectedItem.ToString();
                            ver.sFecha = dtpCitas.Text;
                            ver.sCodigoPacienteFactura = sCodigoPaciente;
                            this.Close();
                            ver.Show();
                        }
                    }
                }
                catch{
                    MessageBox.Show("Se produjo un error al ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Limpia los textbox o combobox 
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cmbHora.Text = cmbMinutos.Text = cmbPaciente.Text = cmbSucursal.Text = cmbEmpleado.Text = "";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBuscarSucursal ver = new frmBuscarSucursal("frmIngresoCita", cmbSucursal.Text, cmbPaciente.Text, cmbEmpleado.Text, cmbHora.Text, cmbMinutos.Text, dtpCitas.Text);
            ver.MdiParent = this.MdiParent;
            ver.Show();
            this.Close();
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            frmBuscarPaciente ver = new frmBuscarPaciente("frmIngresoCita", cmbSucursal.Text, cmbPaciente.Text, cmbEmpleado.Text, cmbHora.Text, cmbMinutos.Text, dtpCitas.Text);
            ver.MdiParent = this.MdiParent;
            ver.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBuscarEmpleado ver = new frmBuscarEmpleado("frmIngresoCita", cmbSucursal.Text, cmbPaciente.Text, cmbEmpleado.Text, cmbHora.Text, cmbMinutos.Text, dtpCitas.Text);
            ver.MdiParent = this.MdiParent;
            ver.Show();
            this.Close();
        }

    }
}
