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
    public partial class frmConsultaPacienteEtiqueta : Form
    {
        string sInformacionPaciente;
        public frmConsultaPacienteEtiqueta()
        {
            InitializeComponent();
            funLlenarPacientes();
        }

        void funCancelar() {
            txtBuscarPaciente.Clear();
            funLlenarPacientes();
        }

        void funLlenarPacientes()
        {
            string sCodigo;
            string sNombre;
            int iContador = 0;
            grdConsultaPacientes.Rows.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT TrPACIENTE.ncodpaciente, MaPERSONA.cnombrepersona FROM TrPACIENTE, MaPERSONA WHERE TrPACIENTE.ncodpersona=MaPERSONA.ncodpersona"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sNombre = mReader.GetString(1);
                    grdConsultaPacientes.Rows.Insert(iContador, sCodigo, sNombre);
                    sCodigo = "";
                    sNombre = "";
                    iContador++;
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtBuscarPaciente_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarPaciente.Text))
            {
                funLlenarPacientes();
            }
            else {
                string sCodigo;
                //string sBuscaNombre;
                string sNombre;
                int iContador = 0;
                grdConsultaPacientes.Rows.Clear();
                try
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format(
                    "SELECT TrPACIENTE.ncodpaciente, MaPERSONA.cnombrepersona FROM TrPACIENTE, MaPERSONA WHERE TrPACIENTE.ncodpersona=MaPERSONA.ncodpersona AND MaPERSONA.cnombrepersona = '{0}' ", txtBuscarPaciente.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        sCodigo = mReader.GetString(0);
                        sNombre = mReader.GetString(1);
                        grdConsultaPacientes.Rows.Insert(iContador, sCodigo, sNombre);
                        sCodigo = "";
                        sNombre = "";
                        iContador++;
                    }

                }
                catch
                {
                    MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtBuscarPaciente.Clear();
            funLlenarPacientes();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdConsultaPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Prueba = "";
            string sCodigoTabla;
            string sNombreTabla;
            DataGridViewRow fila = grdConsultaPacientes.CurrentRow;
            sCodigoTabla = Convert.ToString(fila.Cells[0].Value);
            sNombreTabla = Convert.ToString(fila.Cells[1].Value);
            sInformacionPaciente = sCodigoTabla + ". "+sNombreTabla;
            btnAceptar.Enabled = true;
            //txtBuscarPaciente.Text = Prueba;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmEtiqueta ver = new frmEtiqueta();
            ver.txtPaciente.Text = sInformacionPaciente;
            this.Hide();
            ver.Show();
        }
    }
}
