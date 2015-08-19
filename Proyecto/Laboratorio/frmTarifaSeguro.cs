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
    public partial class frmTarifaSeguro : Form
    {
        /*---------------------------------------------------------------------------------------------------
         * Programador: Diego Taracena
         * Fecha de Astignacion: 03 de agosto
         * Fecha de Entrega: 05 de Agosto
         * -------------------------------------------------------------------------------------------------- 
        */
        public frmTarifaSeguro()
        {
            InitializeComponent();
            funActualizar();
        }

        private void lblTarifa_Click(object sender, EventArgs e)
        {

        }
    //---- Esta funcion hace una consulta para llenar datos en el data grid view-----------------------------------------------
        void funActualizar()
        {

            string sTarifa;
            int iContador = 0;
            grdTarifa.Rows.Clear();

            try
            {
                MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT nporcentajetarifa FROM MaTARIFASEGURO"), clasConexion.funConexion());
                MySqlDataReader _reader = _comando.ExecuteReader();

                while (_reader.Read())
                {
                    sTarifa = _reader.GetString(0);
                    grdTarifa.Rows.Insert(iContador, sTarifa);
                    sTarifa = "";
                    iContador++;
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //---- esta funcion toma los datos de los campos y los ingresa en su respectiva tabla-----------------------------------------

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((String.IsNullOrEmpty(txtTarifa.Text)))
                {
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MySqlCommand comando = new MySqlCommand(string.Format("Insert into MaTARIFASEGURO (nporcentajetarifa) values ('{0}')",
                    txtTarifa.Text), clasConexion.funConexion());
                    comando.ExecuteNonQuery();
                    funActualizar();
                    txtTarifa.Clear();
                    MessageBox.Show("Se inserto con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtTarifa.Clear();
            funActualizar();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTarifa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTarifa_KeyPress(object sender, KeyPressEventArgs e)
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
