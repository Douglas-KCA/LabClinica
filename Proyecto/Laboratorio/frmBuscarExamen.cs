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
    public partial class frmBuscarExamen : Form
    {
        string sCodigoTabla;
        string sNombreTabla;
        public frmBuscarExamen()
        {
            InitializeComponent();
            funActualizar();
        }

        void funActualizar()
        {
            string sCodigo;
            string sNombre;
            int iContador = 0;
            grdTipoExamen.Rows.Clear();

            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT ncodtipo, cdesctipoexamen FROM MaTIPOEXAMEN "), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        sCodigo = mReader.GetString(0);
                        sNombre = mReader.GetString(1);
                        grdTipoExamen.Rows.Insert(iContador, sCodigo, sNombre);
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


        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            string sCodigo;
            string sNombre;
            int iContador = 0;
            grdTipoExamen.Rows.Clear();

            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT ncodtipo, cdesctipoexamen FROM MaTIPOEXAMEN WHERE cdesctipoexamen LIKE '{0}%' ",txtNombre.Text), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sNombre = mReader.GetString(1);
                    grdTipoExamen.Rows.Insert(iContador, sCodigo, sNombre);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            btnCancelar.Enabled = btnAceptar.Enabled = false;
            funActualizar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmReporteTipoExamen ver = new frmReporteTipoExamen();
            ver.sFormTipoExamen = sCodigoTabla;
            ver.sFormNombreExamen = sNombreTabla;
            ver.txtTipoExamen.Text = sCodigoTabla + ". " + sNombreTabla;
            ver.Show();
            this.Close();
        }

        private void grdTipoExamen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAceptar.Enabled = true;
            DataGridViewRow fila = grdTipoExamen.CurrentRow;
            sCodigoTabla = Convert.ToString(fila.Cells[0].Value);
            sNombreTabla = Convert.ToString(fila.Cells[1].Value);
        }
    }
}
