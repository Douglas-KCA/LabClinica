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
    

    public partial class frmConsultarTarifa : Form
    {
        /*---------------------------------------------------------------------------------------------------
         * Programador: Diego Taracena
         * Fecha de Astignacion: 03 de agosto
         * Fecha de Entrega: 05 de Agosto
         * -------------------------------------------------------------------------------------------------- 
        */

        string sCodigoTabla;
        public frmConsultarTarifa()
        {
            InitializeComponent();
            funActualizar();
        }

        void funCancelar()
        {
            txtActualizarTarifa.Clear();
            txtTarifa.Clear();
            btnBuscar.Enabled = true;
            txtTarifa.Enabled = true;
            grpActualizar.Enabled = false;
            btnActualizar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
            funActualizar();
            //grdConsultaMembresia.LostFocus=0;
        }
        /*-----------------------------------------------------------------------------------------------
        * Esta funcion hace una consulta y muestra todos los datos disponibles en el data grid view
        * ----------------------------------------------------------------------------------------------
        * */
        void funActualizar()
        {
            string sCodigo;
            string sTarifa;
            int iContador = 0;
            grdTarifa.Rows.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT ncodtarifa, nporcentajetarifa FROM MaTARIFASEGURO"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sTarifa = mReader.GetString(1);
                    grdTarifa.Rows.Insert(iContador, sCodigo, sTarifa);
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
       /*----------------------------------------------------------------------------------------------------------------------
        * Esta funcion realiza una consulta con los datos que se encuentren en los campos
        * ---------------------------------------------------------------------------------------------------------------------
        * */

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sCodigo;
            string sTarifa;
            int iContador = 0;
            bool existe = false;
            grdTarifa.Rows.Clear();

            try
            {

                if (String.IsNullOrEmpty(txtTarifa.Text))
                {
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    funActualizar();
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format(
                    "SELECT ncodtarifa, nporcentajetarifa FROM MaTARIFASEGURO WHERE nporcentajetarifa = '{0}' ", txtTarifa.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        existe = true;
                        sCodigo = mReader.GetString(0);
                        sTarifa = mReader.GetString(1);
                        grdTarifa.Rows.Insert(iContador, sCodigo, sTarifa);
                        sCodigo = "";
                        sTarifa = "";
                        iContador++;
                    }


                    btnCancelar.Enabled = true;
                    if (existe == false)
                    {
                        MessageBox.Show("No se encontraron resultados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        funActualizar();
                        btnCancelar.Enabled = false;
                        txtTarifa.Clear();
                    }

                }



            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        /*----------------------------------------------------------------------------------------------------
         * Esta funcion regresa el form a su forma original
         * ---------------------------------------------------------------------------------------------------
         * */

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            funCancelar();
        }

        private void grdTarifa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
            btnCancelar.Enabled = true;
            grpActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnBuscar.Enabled = false;
            txtTarifa.Clear();
            txtTarifa.Enabled = false;

            string sCodigo, sTarifa;
            DataGridViewRow fila = grdTarifa.CurrentRow;
            sCodigo = Convert.ToString(fila.Cells[0].Value);
            sTarifa = Convert.ToString(fila.Cells[1].Value);
            sCodigoTabla = sCodigo;
            txtActualizarTarifa.Text = sTarifa;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea modificar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlCommand mComando = new MySqlCommand(string.Format("UPDATE MaTARIFASEGURO SET nporcentajetarifa = '{0}' WHERE ncodtarifa = '{1}'",
                    txtActualizarTarifa.Text, sCodigoTabla), clasConexion.funConexion());
                    mComando.ExecuteNonQuery();
                    funActualizar();
                    MessageBox.Show("Se actualizo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTarifa.Text = "";
                    funCancelar();
                    funActualizar();
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlCommand mComando = new MySqlCommand(string.Format("DELETE FROM MaTARIFASEGURO WHERE ncodtarifa = '{0}'",
                    sCodigoTabla), clasConexion.funConexion());
                    mComando.ExecuteNonQuery();
                    funActualizar();
                    MessageBox.Show("Dato eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTarifa.Text = "";
                    funCancelar();
                    funActualizar();
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtActualizarTarifa_KeyPress(object sender, KeyPressEventArgs e)
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
