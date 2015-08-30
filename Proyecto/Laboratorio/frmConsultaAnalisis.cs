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
 * Fecha de entrega: 05/08/2015
---------------------------------------------------------------------------------------------------------------------------------*/

    public partial class frmConsultaAnalisis : Form
    {
        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que carga los componentes iniciales del form
        ---------------------------------------------------------------------------------------------------------------------------------*/
        public frmConsultaAnalisis()
        {
            InitializeComponent();
            funActualizar();
            btnActualizar.Enabled = false;
            grpBuscar.Enabled = false;
            grpActualizar.Enabled = false;
            txtApellido.Enabled = txtMuestra.Enabled = txtNombre.Enabled = false;
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que toma los valores de la fila seleccionada en el grid para mostrarlos en los campos de texto de edicion
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void grdAnalisis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grpActualizar.Enabled = true;
            grpBuscar.Enabled = false;
            btnActualizar.Enabled = true;
            btnBuscar.Enabled = false;

            String[] sNombres = (grdAnalisis.Rows[grdAnalisis.CurrentCell.RowIndex].Cells[1].Value + "").Split(' ');

            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT cdescripcion FROM TrANALISIS WHERE ncodanalisis = '{0}' AND ncodetiqueta = (SELECT ncodetiqueta FROM MaETIQUETA "
                + "WHERE ncodmuestra = (SELECT ncodmuestra from MaMUESTRA WHERE cdescmuestra = '{1}') AND ncodpaciente = (SELECT ncodpaciente "
                + "FROM TrPACIENTE WHERE ncodpersona = (SELECT ncodpersona FROM MaPERSONA WHERE cnombrepersona = '{2}' AND capellidopersona = '{3}')))"
                , grdAnalisis.Rows[grdAnalisis.CurrentCell.RowIndex].Cells[0].Value + "", grdAnalisis.Rows[grdAnalisis.CurrentCell.RowIndex].Cells[2].Value + "", sNombres[0], sNombres[1]), clasConexion.funConexion());
               
                MySqlDataReader mReader = mComando.ExecuteReader();

                if (mReader.Read())
                {
                    txtAnalisis.Text = mReader.GetString(0);
                }
            }
            catch{
                MessageBox.Show("Se produjo un error cargando el analisis", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que pobla el grid con los datos de la BD
        ---------------------------------------------------------------------------------------------------------------------------------*/
        void funActualizar()
        {
            string sNombre = "";
            string sEtiqueta = "";
            string sCodigo = "";
            string sMuestra = "";
            int iContador = 0;
            grdAnalisis.Rows.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT ncodanalisis, ncodetiqueta FROM TrANALISIS"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();
                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sEtiqueta = mReader.GetString(1);

                    MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona = (SELECT ncodpersona FROM TrPACIENTE WHERE ncodpaciente = (SELECT ncodpaciente FROM MaEtiqueta WHERE ncodetiqueta = '{0}'))", sEtiqueta), clasConexion.funConexion());
                    MySqlDataReader mReader2 = mComando2.ExecuteReader();
                    if (mReader2.Read())
                        sNombre = mReader2.GetString(0) + " " + mReader2.GetString(1);

                    MySqlCommand mComando3 = new MySqlCommand(String.Format("SELECT cdescmuestra FROM MaMUESTRA WHERE ncodmuestra = (SELECT ncodmuestra FROM MaETIQUETA WHERE ncodetiqueta = '{0}')", sEtiqueta), clasConexion.funConexion());
                    MySqlDataReader mReader3 = mComando3.ExecuteReader();
                    if (mReader3.Read())
                        sMuestra = mReader3.GetString(0);

                    grdAnalisis.Rows.Insert(iContador, sCodigo, sNombre, sMuestra);
                    sNombre = sCodigo = sMuestra = "";
                    iContador++;
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que filtra el grid a partir del parametro que se indica en el textbox
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            grpBuscar.Enabled = true;
            grpActualizar.Enabled = false;
            btnActualizar.Enabled = false;
            btnBuscar.Enabled = false;
            txtAnalisis.Enabled = false;
            txtAnalisis.Text = "";
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que havilita la seccion de busqueda por muestra y deshabilita el resto
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void rbtnMuestra_CheckedChanged(object sender, EventArgs e)
        {
            txtMuestra.Enabled = true;
            txtNombre.Enabled = txtApellido.Enabled = false;
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que havilita la seccion de busqueda por paciente y deshabilita el resto
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void rbtnPaciente_CheckedChanged(object sender, EventArgs e)
        {
            txtMuestra.Enabled = false;
            txtNombre.Enabled = txtApellido.Enabled = true;
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que filtra los datos de la tabla en base a lo que se escribe en el textbox de nombre paciente, 
          se actualiza cada vez que se suelta una tecla
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            string sCodigo, sDescripcion, sEtiqueta, sMuestra= "", sPaciente= "";
            int iContador = 0;
            grdAnalisis.Rows.Clear();
            try
            {
                if (String.IsNullOrEmpty(txtNombre.Text))
                {
                    funActualizar();
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format(
                   "SELECT * FROM TrANALISIS WHERE ncodetiqueta IN (SELECT ncodetiqueta FROM MaETIQUETA WHERE ncodpaciente IN (SELECT ncodpaciente FROM TrPACIENTE WHERE ncodpersona IN (SELECT ncodpersona FROM MaPERSONA WHERE cnombrepersona LIKE '{0}%')))"
                   , txtNombre.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        sCodigo = mReader.GetString(0);
                        sDescripcion = mReader.GetString(1);
                        sEtiqueta = mReader.GetString(2);
                        try
                        {
                            MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT MaPERSONA.cnombrepersona, MaPERSONA.capellidopersona, MaMUESTRA.cdescmuestra FROM MaETIQUETA, MaPERSONA, MaMUESTRA, TrPACIENTE WHERE MaETIQUETA.ncodetiqueta = '{0}' and MaMUESTRA.ncodmuestra = MaETIQUETA.ncodmuestra and TrPACIENTE.ncodpersona = MaPERSONA.ncodpersona and MaETIQUETA.ncodpaciente = TrPACIENTE.ncodpaciente", sEtiqueta), clasConexion.funConexion());
                            MySqlDataReader mReader2 = mComando2.ExecuteReader();
                            if (mReader2.Read()){
                                sPaciente = mReader2.GetString(0) + " " + mReader2.GetString(1);
                                sMuestra = mReader2.GetString(2);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Se produjo un error buscando nombre de empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                        grdAnalisis.Rows.Insert(iContador, sCodigo, sPaciente, sMuestra);
                        sCodigo = sPaciente = sMuestra = "";
                        iContador++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error actualizando la tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que filtra los datos de la tabla en base a lo que se escribe en el textbox de apellido paciente, 
          se actualiza cada vez que se suelta una tecla
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void txtApellido_KeyUp(object sender, KeyEventArgs e)
        {
            string sCodigo, sDescripcion, sEtiqueta, sMuestra = "", sPaciente = "";
            int iContador = 0;
            grdAnalisis.Rows.Clear();
            try
            {
                if (String.IsNullOrEmpty(txtApellido.Text))
                {
                    funActualizar();
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format(
                   "SELECT * FROM TrANALISIS WHERE ncodetiqueta IN (SELECT ncodetiqueta FROM MaETIQUETA WHERE ncodpaciente IN (SELECT ncodpaciente FROM TrPACIENTE WHERE ncodpersona IN (SELECT ncodpersona FROM MaPERSONA WHERE capellidopersona LIKE '{0}%')))"
                   , txtApellido.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        sCodigo = mReader.GetString(0);
                        sDescripcion = mReader.GetString(1);
                        sEtiqueta = mReader.GetString(2);
                        try
                        {
                            MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT MaPERSONA.cnombrepersona, MaPERSONA.capellidopersona, MaMUESTRA.cdescmuestra FROM MaETIQUETA, MaPERSONA, MaMUESTRA, TrPACIENTE WHERE MaETIQUETA.ncodetiqueta = '{0}' and MaMUESTRA.ncodmuestra = MaETIQUETA.ncodmuestra and TrPACIENTE.ncodpersona = MaPERSONA.ncodpersona and MaETIQUETA.ncodpaciente = TrPACIENTE.ncodpaciente", sEtiqueta), clasConexion.funConexion());
                            MySqlDataReader mReader2 = mComando2.ExecuteReader();
                            if (mReader2.Read())
                            {
                                sPaciente = mReader2.GetString(0) + " " + mReader2.GetString(1);
                                sMuestra = mReader2.GetString(2);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Se produjo un error buscando los datos por el apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                        grdAnalisis.Rows.Insert(iContador, sCodigo, sPaciente, sMuestra);
                        sCodigo = sPaciente = sMuestra = "";
                        iContador++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error actualizando la tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que filtra los datos de la tabla en base a lo que se escribe en el textbox de muestra, 
          se actualiza cada vez que se suelta una tecla
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void txtMuestra_KeyUp(object sender, KeyEventArgs e)
        {
            string sCodigo, sDescripcion, sEtiqueta, sMuestra= "", sPaciente= "";
            int iContador = 0;
            grdAnalisis.Rows.Clear();
            try
            {
                if (String.IsNullOrEmpty(txtMuestra.Text))
                {
                    funActualizar();
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format(
                   "SELECT * FROM TrANALISIS WHERE ncodetiqueta IN (SELECT ncodetiqueta FROM MaETIQUETA WHERE ncodmuestra IN (SELECT ncodmuestra FROM MaMUESTRA WHERE cdescmuestra LIKE '{0}%'))"
                   , txtMuestra.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        sCodigo = mReader.GetString(0);
                        sDescripcion = mReader.GetString(1);
                        sEtiqueta = mReader.GetString(2);
                        try
                        {
                            MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT MaPERSONA.cnombrepersona, MaPERSONA.capellidopersona, MaMUESTRA.cdescmuestra FROM MaETIQUETA, MaPERSONA, MaMUESTRA, TrPACIENTE WHERE MaETIQUETA.ncodetiqueta = '{0}' and MaMUESTRA.ncodmuestra = MaETIQUETA.ncodmuestra and TrPACIENTE.ncodpersona = MaPERSONA.ncodpersona and MaETIQUETA.ncodpaciente = TrPACIENTE.ncodpaciente", sEtiqueta), clasConexion.funConexion());
                            MySqlDataReader mReader2 = mComando2.ExecuteReader();
                            if (mReader2.Read()){
                                sPaciente = mReader2.GetString(0) + " " + mReader2.GetString(1);
                                sMuestra = mReader2.GetString(2);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Se produjo un error buscando por muestra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                        grdAnalisis.Rows.Insert(iContador, sCodigo, sPaciente, sMuestra);
                        sCodigo = sPaciente = sMuestra = "";
                        iContador++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error actualizando la tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que limpia los textbox o combobox
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            funActualizar();
            grpActualizar.Enabled = grpBuscar.Enabled = false;
            txtAnalisis.Text = txtApellido.Text = txtNombre.Text = txtMuestra.Text = "";
            btnBuscar.Enabled = true;
            btnActualizar.Enabled = false;
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que actualiza los datos con los de los textbox en la seccion de actualiza
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seguro que quiere actualizar los datos", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlCommand comando = new MySqlCommand(string.Format("UPDATE TrANALISIS SET cdescripcion = '{0}' WHERE ncodanalisis = '{1}'", txtAnalisis.Text, grdAnalisis.Rows[grdAnalisis.CurrentCell.RowIndex].Cells[0].Value + ""), clasConexion.funConexion());
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Se actualizo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    funActualizar();
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que Elimina la fila seleccionada
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seguro que quiere eliminar los datos", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM TrANALISIS WHERE ncodanalisis = '{0}'",
                    grdAnalisis.Rows[grdAnalisis.CurrentCell.RowIndex].Cells[0].Value + ""), clasConexion.funConexion());
                    comando.ExecuteNonQuery();
                    funActualizar();
                    MessageBox.Show("Dato eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    funActualizar();
                    txtAnalisis.Text = txtApellido.Text = txtNombre.Text = txtMuestra.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que Regresa al menu principal
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que previene la escritura de numeros y simbolos en el textbox de nombre paciente
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que previene la escritura de numeros y simbolos en el textbox de apellido paciente
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que previene la escritura de numeros y simbolos en el textbox de muestra
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void txtMuestra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

    }
}
