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
    /*---------------------------------------------------------------------------------------------------
     * Programador: Diego Taracena
     * Fecha de Astignacion: 01 de agosto
     * Fecha de Entrega: 02 de Agosto
     * -------------------------------------------------------------------------------------------------- 
     */
    public partial class frmConsultarPuesto : Form
    {
        string sCodigoTabla;
        public frmConsultarPuesto()
        {
            InitializeComponent();
            funActualizar();
        }
        /*-----------------------------------------------------------------------------------------------
         * Esta funcion hace una consulta y muestra todos los datos disponibles en el data grid view
         * ----------------------------------------------------------------------------------------------
         * */

        void funCancelar()
        {
            txtActualizarPuesto.Clear();
            txtPuesto.Clear();
            btnBuscar.Enabled = true;
            txtPuesto.Enabled = true;
            grpActualizar.Enabled = false;
            btnActualizar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
            funActualizar();
            //grdConsultaMembresia.LostFocus=0;
        }
        void funActualizar()
        {
            string sNumero;
            string sPuesto;
            int iContador = 0;
            grdPuesto.Rows.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT ncodpuesto, ndescpuesto FROM MaPUESTO"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sNumero = mReader.GetString(0);
                    sPuesto = mReader.GetString(1);
                    grdPuesto.Rows.Insert(iContador, sNumero, sPuesto);
                    sNumero = "";
                    sPuesto = "";
                    iContador++;
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /*------------------------------------------------------------------------------------------------------------------
         * Esta funcion toma los datos de los campos y muestra en el data grid view los resultados de la consulta
         * -----------------------------------------------------------------------------------------------------------------
         * */
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            funCancelar();
        }

        private void grdPuesto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
            btnCancelar.Enabled = true;
            grpActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnBuscar.Enabled = false;
            txtPuesto.Clear();
            txtPuesto.Enabled = false;

            string sCodigo, sPuesto;
            DataGridViewRow fila = grdPuesto.CurrentRow;
            sCodigo = Convert.ToString(fila.Cells[0].Value);
            sPuesto = Convert.ToString(fila.Cells[1].Value);
            sCodigoTabla = sCodigo;
            txtActualizarPuesto.Text = sPuesto;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea modificar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlCommand mComando = new MySqlCommand(string.Format("UPDATE MaPUESTO SET ndescpuesto = '{0}' WHERE ncodpuesto = '{1}'",
                    txtActualizarPuesto.Text, sCodigoTabla), clasConexion.funConexion());
                    mComando.ExecuteNonQuery();
                    funActualizar();
                    MessageBox.Show("Se actualizo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPuesto.Text = "";
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
                    MySqlCommand mComando = new MySqlCommand(string.Format("DELETE FROM MaPUESTO WHERE ncodpuesto = '{0}'",
                    sCodigoTabla), clasConexion.funConexion());
                    mComando.ExecuteNonQuery();
                    funActualizar();
                    MessageBox.Show("Dato eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPuesto.Text = "";
                    funCancelar();
                    funActualizar();
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtActualizarPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPuesto_KeyUp(object sender, KeyEventArgs e)
        {
            string sCodigo;
            string sPuesto;
            int iContador = 0;
            
            grdPuesto.Rows.Clear();

            try
            {

                if (String.IsNullOrEmpty(txtPuesto.Text))
                {
                    funActualizar();
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format(
                    "SELECT ncodpuesto, ndescpuesto FROM MaPUESTO WHERE ndescpuesto Like '{0}%' ", txtPuesto.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        
                        sCodigo = mReader.GetString(0);
                        sPuesto = mReader.GetString(1);
                        grdPuesto.Rows.Insert(iContador, sCodigo, sPuesto);
                        sCodigo = "";
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
    }
}
