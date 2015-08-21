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
    public partial class frmConsultaTipoExamen : Form
    {
        string sCodigoTabla;
        string sCadena;
        public frmConsultaTipoExamen()
        {
            InitializeComponent();
            funActualizar();
        }

        void funActualizar()
        {
            string sCodigo;
            string sTipo;
            string sPrecio;
            string sMuestra;
            int iContador = 0;
            grdConsultarTipoExamen.Rows.Clear();

            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT ncodtipo, cdesctipoexamen, cpreciotipoexamen, MaMUESTRA.cdescmuestra FROM MaTIPOEXAMEN, MaMUESTRA WHERE MaTIPOEXAMEN.ncodmuestra = MaMUESTRA.ncodmuestra"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sTipo = mReader.GetString(1);
                    sPrecio = mReader.GetString(2);
                    sMuestra = mReader.GetString(3);
                    grdConsultarTipoExamen.Rows.Insert(iContador, sCodigo, sTipo,sPrecio,sMuestra);
                    sCodigo = "";
                    sTipo = "";
                    sPrecio = "";
                    sMuestra = "";
                    iContador++;
                }

                //LLenar combobox para actualizar

                string sCodigocmb;
                string sNombrecmb;
                cmbMuestra.Items.Clear();

                try
                {
                    MySqlCommand mComandocmb = new MySqlCommand(String.Format(
                    "SELECT ncodmuestra, cdescmuestra FROM MaMUESTRA"), clasConexion.funConexion());
                    MySqlDataReader mReadercmb = mComandocmb.ExecuteReader();

                    while (mReadercmb.Read())
                    {
                        sCodigocmb = mReadercmb.GetString(0);
                        sNombrecmb = mReadercmb.GetString(1);
                        cmbMuestra.Items.Add(sCodigocmb + ". " + sNombrecmb);
                        sCodigocmb = "";
                        sNombrecmb = "";
                    }

                }
                catch
                {
                    MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        void funCancelar()
        {
            txtTipo.Clear();
            txtPrecio.Clear();
            txtTipoExamenBusqueda.Clear();
            txtTipoExamenBusqueda.Enabled = true;
            grpActualizar.Enabled = false;
            btnActualizar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
            funActualizar();
            //grdConsultaMembresia.LostFocus=0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            txtTipoExamenBusqueda.Enabled = true;
            grpActualizar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;
            txtTipoExamenBusqueda.Clear();
            txtPrecio.Clear();
            txtTipo.Clear();
            funActualizar();
        }

        private void grdConsultarTipoExamen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
            btnCancelar.Enabled = true;
            grpActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            txtTipoExamenBusqueda.Clear();
            txtTipoExamenBusqueda.Enabled = false;

            string sTipo;
            string sPrecio;
            string sMuestra;
            DataGridViewRow fila = grdConsultarTipoExamen.CurrentRow;
            sCodigoTabla = Convert.ToString(fila.Cells[0].Value);
            sTipo = Convert.ToString(fila.Cells[1].Value);
            sPrecio = Convert.ToString(fila.Cells[2].Value);
            sMuestra = Convert.ToString(fila.Cells[3].Value);
            txtTipo.Text = sTipo;
            txtPrecio.Text = sPrecio;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string sCodcmb = funCortador(cmbMuestra.SelectedItem.ToString());
                if (MessageBox.Show("¿Desea modificar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlCommand mComando = new MySqlCommand(string.Format("UPDATE MaTIPOEXAMEN SET cdesctipoexamen = '{0}', cpreciotipoexamen = '{1}', ncodmuestra = '{2}' WHERE ncodtipo = '{3}'",
                    txtTipo.Text, txtPrecio.Text, sCodcmb, sCodigoTabla), clasConexion.funConexion());
                    mComando.ExecuteNonQuery();
                    funActualizar();
                    MessageBox.Show("Se actualizo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTipo.Clear();
                    txtPrecio.Clear();
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
                    MySqlCommand mComando = new MySqlCommand(string.Format("DELETE FROM MaTIPOEXAMEN WHERE ncodtipo = '{0}'",
                    sCodigoTabla), clasConexion.funConexion());
                    mComando.ExecuteNonQuery();
                    funActualizar();
                    MessageBox.Show("Dato eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTipoExamenBusqueda.Text = "";
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

        private void txtTipoExamenBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTipoExamenBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            string sCodigo;
            string sTipo;
            string sPrecio;
            string sMuestra;
            int iContador = 0;
            bool existe = false;
            grdConsultarTipoExamen.Rows.Clear();

            try
            {

                if (String.IsNullOrEmpty(txtTipoExamenBusqueda.Text))
                {
                    funActualizar();
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format(
                    "SELECT ncodtipo, cdesctipoexamen, cpreciotipoexamen, MaMUESTRA.cdescmuestra FROM MaTIPOEXAMEN, MaMUESTRA WHERE MaTIPOEXAMEN.ncodmuestra = MaMUESTRA.ncodmuestra AND MaTIPOEXAMEN.cdesctipoexamen LIKE '{0}%'", txtTipoExamenBusqueda.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        existe = true;
                        sCodigo = mReader.GetString(0);
                        sTipo = mReader.GetString(1);
                        sPrecio = mReader.GetString(2);
                        sMuestra = mReader.GetString(3);
                        grdConsultarTipoExamen.Rows.Insert(iContador, sCodigo, sTipo, sPrecio, sMuestra);
                        sCodigo = "";
                        sTipo = "";
                        sPrecio = "";
                        sMuestra = "";
                        iContador++;
                    }


                    btnCancelar.Enabled = true;
                    if (existe == false)
                    {
                        btnCancelar.Enabled = false;
                        MessageBox.Show("No se encontraron resultados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        funActualizar();
                        txtTipoExamenBusqueda.Clear();
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
