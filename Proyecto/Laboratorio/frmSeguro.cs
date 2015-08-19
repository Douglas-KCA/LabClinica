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
    public partial class frmSeguro : Form
    {
        /*---------------------------------------------------------------------------------------------------
         * Programador: Diego Taracena
         * Fecha de Astignacion: 07 de agosto
         * Fecha de Entrega: 09 de Agosto
         * -------------------------------------------------------------------------------------------------- 
        */

        string sCadena;
        public frmSeguro()
        {
            InitializeComponent();
            funBuscarAseguro();
            funBuscarTarifa();
            funActualizar();
        }

        void funActualizar()
        {

            string sCodigo;
            string sTarifa;
            string sAseguradora;
            string sDeducible;
            int iContador = 0;
            grdPuesto.Rows.Clear();

            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT TrSEGURO.ncodseguro as codigo, MaASEGURADORA.cempresaseguro as aseguradora, MaTARIFASEGURO.nporcentajetarifa as tarifa, TrSEGURO.ndeducible as deducible from TrSEGURO, MaASEGURADORA, MaTARIFASEGURO where TrSEGURO.ncodtarifa = MaTARIFASEGURO.ncodtarifa and TrSEGURO.ncodaseguradora = MaASEGURADORA.ncodaseguradora"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sAseguradora = mReader.GetString(1);
                    sTarifa = mReader.GetString(2);
                    sDeducible = mReader.GetString(3);
                    grdPuesto.Rows.Insert(iContador, sCodigo, sAseguradora, sTarifa, sDeducible);
                    sCodigo = "";
                    sTarifa = "";
                    sAseguradora = "";
                    sDeducible = "";
                    iContador++;
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void funBuscarTarifa()
        {
            string sCodigo;
            string sTarifa;
            int iContador = 0;
            cmbTarifa.Items.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT ncodtarifa, nporcentajetarifa FROM MaTARIFASEGURO"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sTarifa = mReader.GetString(1);
                    cmbTarifa.Items.Add(sCodigo + ". Tarifa: " + sTarifa);
                    sCodigo = "";
                    sTarifa = "";
                    iContador++;
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
       
        void funBuscarAseguro()
        {
            string sCodigo;
            string sSeguro;
            int iContador = 0;
            cmbAseguradora.Items.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT ncodaseguradora, cempresaseguro FROM MaASEGURADORA"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sSeguro = mReader.GetString(1);
                    cmbAseguradora.Items.Add(sCodigo + ". " + sSeguro);
                    sCodigo = "";
                    sSeguro = "";
                    iContador++;
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void frmSeguro_Load(object sender, EventArgs e)
        {

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
            string sTarifa, sAseguradora;
            


            try
            {
                sTarifa = funCortador(cmbTarifa.SelectedItem.ToString());
                sAseguradora = funCortador(cmbAseguradora.SelectedItem.ToString());
                if (String.IsNullOrEmpty(txtDeducible.Text))
                {
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(string.Format("Insert into TrSEGURO (ndeducible, ncodtarifa, ncodaseguradora) values ('{0}', '{1}','{2}')",
                        txtDeducible.Text, sTarifa, sAseguradora), clasConexion.funConexion());
                    mComando.ExecuteNonQuery();
                    funActualizar();
                    MessageBox.Show("Se inserto con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDeducible.Clear();
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            funBuscarAseguro();
            funBuscarTarifa();
            funActualizar();
            txtDeducible.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDeducible_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
