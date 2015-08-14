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
        public frmConsultaPacienteEtiqueta()
        {
            InitializeComponent();
            funBuscarPacientes();
        }

        void funBuscarPacientes() {
            string sCodigo;
            string sNombre;
            int iContador = 0;
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT paciente.ncodpaciente, persona.cnombrepersona FROM paciente, persona WHERE paciente.ncodpersona=persona.ncodpersona"), clasConexion.funConexion());
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
                funBuscarPacientes();
            }
            else {
                string sCodigo;
                //string sBuscaNombre;
                string sNombre;
                int iContador = 0;
                try
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format(
                    "SELECT paciente.ncodpaciente, persona.cnombrepersona FROM paciente, persona WHERE paciente.ncodpersona=persona.ncodpersona AND persona.cnombrepersona = '{0}' ", txtBuscarPaciente.Text), clasConexion.funConexion());
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
            funBuscarPacientes();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
