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
  Fecha de asignacion: 03/08/2015
  Fecha de entrega: 06/08/2015
---------------------------------------------------------------------------------------------------------------------------------*/
    public partial class frmConultaUsuario : Form
    {
        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que carga los componentes iniciales del form
        ---------------------------------------------------------------------------------------------------------------------------------*/
        public frmConultaUsuario()
        {
            InitializeComponent();
            funActualizar();
            btnActualizar.Enabled = false;
            grpBuscar.Enabled = false;
            grpActualizar.Enabled = false;
            txtNomEmpleado.Enabled = txtNomApellido.Enabled = txtUsuario.Enabled = cmbTipo.Enabled = false;
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que toma los valores de la fila seleccionada en el grid para mostrarlos en los campos de texto de edicion
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void grdUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grpActualizar.Enabled = true;
            grpBuscar.Enabled = false;
            btnActualizar.Enabled = true;
            btnBuscar.Enabled = false;

            txtActualizarUsuario.Text = grdUsuario.Rows[grdUsuario.CurrentCell.RowIndex].Cells[2].Value + "";

            txtPassword.Text = grdUsuario.Rows[grdUsuario.CurrentCell.RowIndex].Cells[3].Value + "";

            cmbActualizarTipo.Text = grdUsuario.Rows[grdUsuario.CurrentCell.RowIndex].Cells[4].Value + "";

        }
        
        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que pobla el grid con los datos de la BD
        ---------------------------------------------------------------------------------------------------------------------------------*/
        void funActualizar()
        {
            string sEmpleado, sUsuario, sPassword, sTipo, sCodigo;
            int iContador = 0;
            grdUsuario.Rows.Clear();
            try{
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT * FROM TrUSUARIO"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sUsuario = mReader.GetString(1);
                    sTipo = mReader.GetString(2);
                    sPassword = mReader.GetString(3);
                    sEmpleado = mReader.GetString(4);

                    try{
                        MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona = (SELECT ncodpersona FROM TrEMPLEADO WHERE ncodempleado = '{0}')", sEmpleado), clasConexion.funConexion());
                        MySqlDataReader mReader2 = mComando2.ExecuteReader();
                        if (mReader2.Read())
                            sEmpleado = mReader2.GetString(0) + " " + mReader2.GetString(1);
                    }
                    catch {
                        MessageBox.Show("Se produjo un error buscando nombre de empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    grdUsuario.Rows.Insert(iContador, sCodigo, sEmpleado, sUsuario, sPassword, sTipo);
                    
                    sCodigo = sUsuario = sTipo = sPassword = sEmpleado = "";
                    iContador++;
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error actualizando la tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtActualizarUsuario.Text = txtPassword.Text = cmbActualizarTipo.Text = "";
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que toma los datos del grid y los actualiza en la base de datos en caso exista un cambio
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT ncodusuario FROM TrUSUARIO WHERE cnombreusuario = '{0}' AND ncodusuario != '{1}'", txtActualizarUsuario.Text, grdUsuario.Rows[grdUsuario.CurrentCell.RowIndex].Cells[0].Value + ""), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();
                if (mReader.Read())
                {
                    MessageBox.Show("Ese nombre de usuario ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MySqlCommand comando = new MySqlCommand(string.Format("UPDATE TrUSUARIO SET cnombreusuario = '{0}', cpasswordusuario = '{1}', ctipousuario = '{2}' WHERE ncodusuario = '{3}'", txtActualizarUsuario.Text, txtPassword.Text, cmbActualizarTipo.Text, grdUsuario.Rows[grdUsuario.CurrentCell.RowIndex].Cells[0].Value + ""), clasConexion.funConexion());
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
          Funcion que limpia los textbox o combobox
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            funActualizar();
            grpActualizar.Enabled = grpBuscar.Enabled = false;
            txtActualizarUsuario.Text = txtPassword.Text = cmbActualizarTipo.Text = "";
            txtNomApellido.Text = txtNomEmpleado.Text = cmbTipo.Text = txtUsuario.Text = "";
            btnBuscar.Enabled = true;
            btnActualizar.Enabled = false;
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
                    MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM TrUSUARIO WHERE ncodusuario = '{0}'",
                    grdUsuario.Rows[grdUsuario.CurrentCell.RowIndex].Cells[0].Value + ""), clasConexion.funConexion());
                    comando.ExecuteNonQuery();
                    funActualizar();
                    MessageBox.Show("Dato eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    funActualizar();
                    txtActualizarUsuario.Text = txtPassword.Text = cmbActualizarTipo.Text = "";
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
          Funcion que havilita la seccion de busqueda por empleado y deshabilita el resto
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void rbtnEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            txtNomEmpleado.Enabled = txtNomApellido.Enabled =true;
            txtUsuario.Enabled = cmbTipo.Enabled = false;
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que havilita la seccion de busqueda por nombre de usuario y deshabilita el resto
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void rbtnUsuario_CheckedChanged(object sender, EventArgs e)
        {
            txtUsuario.Enabled = true;
            txtNomEmpleado.Enabled = txtNomApellido.Enabled = cmbTipo.Enabled = false;
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que havilita la seccion de busqueda por tipo de usuario y deshabilita el resto
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void rbtnTipo_CheckedChanged(object sender, EventArgs e)
        {
            cmbTipo.Enabled = true;
            txtNomEmpleado.Enabled = txtNomApellido.Enabled = txtUsuario.Enabled = false;
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que filtra los datos de la tabla en base a lo que se escribe en el textbox de nombre empleado, 
          se actualiza cada vez que se suelta una tecla
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void txtEmpleado_KeyUp(object sender, KeyEventArgs e)
        {
            string sEmpleado, sUsuario, sPassword, sTipo, sCodigo;
            int iContador = 0;
            grdUsuario.Rows.Clear();
            try
            {
                if (String.IsNullOrEmpty(txtNomEmpleado.Text))
                {
                    funActualizar();
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format("SELECT * FROM TrUSUARIO WHERE ncodempleado IN (SELECT ncodempleado FROM TrEMPLEADO WHERE ncodpersona IN (SELECT ncodpersona FROM MaPERSONA WHERE cnombrepersona LIKE '{0}%'))", txtNomEmpleado.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        sCodigo = mReader.GetString(0);
                        sUsuario = mReader.GetString(1);
                        sTipo = mReader.GetString(2);
                        sPassword = mReader.GetString(3);
                        sEmpleado = mReader.GetString(4);

                        try
                        {
                            MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona = (SELECT ncodpersona FROM TrEMPLEADO WHERE ncodempleado = '{0}')", sEmpleado), clasConexion.funConexion());
                            MySqlDataReader mReader2 = mComando2.ExecuteReader();
                            if (mReader2.Read())
                                sEmpleado = mReader2.GetString(0) + " " + mReader2.GetString(1);
                        }
                        catch
                        {
                            MessageBox.Show("Se produjo un error buscando nombre de empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        grdUsuario.Rows.Insert(iContador, sCodigo, sEmpleado, sUsuario, sPassword, sTipo);
                        sCodigo = sUsuario = sTipo = sPassword = sEmpleado = "";
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
          Funcion que filtra los datos de la tabla en base a lo que se escribe en el textbox de usuario, 
          se actualiza cada vez que se suelta una tecla
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void txtUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            string sEmpleado, sUsuario, sPassword, sTipo, sCodigo;
            int iContador = 0;
            grdUsuario.Rows.Clear();
            try
            {
                if (String.IsNullOrEmpty(txtUsuario.Text))
                {
                    funActualizar();
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format("SELECT * FROM TrUSUARIO WHERE cnombreusuario LIKE '{0}%'", txtUsuario.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        sCodigo = mReader.GetString(0);
                        sUsuario = mReader.GetString(1);
                        sTipo = mReader.GetString(2);
                        sPassword = mReader.GetString(3);
                        sEmpleado = mReader.GetString(4);

                        try
                        {
                            MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona = (SELECT ncodpersona FROM TrEMPLEADO WHERE ncodempleado = '{0}')", sEmpleado), clasConexion.funConexion());
                            MySqlDataReader mReader2 = mComando2.ExecuteReader();
                            if (mReader2.Read())
                                sEmpleado = mReader2.GetString(0) + " " + mReader2.GetString(1);
                        }
                        catch
                        {
                            MessageBox.Show("Se produjo un error buscando nombre de empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        grdUsuario.Rows.Insert(iContador, sCodigo, sEmpleado, sUsuario, sPassword, sTipo);
                        sCodigo = sUsuario = sTipo = sPassword = sEmpleado = "";
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
          Funcion que filtra los datos de la tabla en base a lo que se escribe en el combobox de tipo, 
          se actualiza cada vez que se suelta una tecla
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sEmpleado, sUsuario, sPassword, sTipo, sCodigo;
            int iContador = 0;
            grdUsuario.Rows.Clear();
            try
            {
                if (String.IsNullOrEmpty(cmbTipo.Text))
                {
                    funActualizar();
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format("SELECT * FROM TrUSUARIO WHERE ctipousuario = '{0}'", cmbTipo.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        sCodigo = mReader.GetString(0);
                        sUsuario = mReader.GetString(1);
                        sTipo = mReader.GetString(2);
                        sPassword = mReader.GetString(3);
                        sEmpleado = mReader.GetString(4);

                        try
                        {
                            MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona = (SELECT ncodpersona FROM TrEMPLEADO WHERE ncodempleado = '{0}')", sEmpleado), clasConexion.funConexion());
                            MySqlDataReader mReader2 = mComando2.ExecuteReader();
                            if (mReader2.Read())
                                sEmpleado = mReader2.GetString(0) + " " + mReader2.GetString(1);
                        }
                        catch
                        {
                            MessageBox.Show("Se produjo un error buscando nombre de empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        grdUsuario.Rows.Insert(iContador, sCodigo, sEmpleado, sUsuario, sPassword, sTipo);
                        sCodigo = sUsuario = sTipo = sPassword = sEmpleado = "";
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
          Funcion que filtra los datos de la tabla en base a lo que se escribe en el textbox de apellido empleado, 
          se actualiza cada vez que se suelta una tecla
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void txtNomApellido_KeyUp(object sender, KeyEventArgs e)
        {
            string sEmpleado, sUsuario, sPassword, sTipo, sCodigo;
            int iContador = 0;
            grdUsuario.Rows.Clear();
            try
            {
                if (String.IsNullOrEmpty(txtNomApellido.Text))
                {
                    funActualizar();
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format("SELECT * FROM TrUSUARIO WHERE ncodempleado IN (SELECT ncodempleado FROM TrEMPLEADO WHERE ncodpersona IN (SELECT ncodpersona FROM MaPERSONA WHERE capellidopersona LIKE '{0}%'))", txtNomApellido.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        sCodigo = mReader.GetString(0);
                        sUsuario = mReader.GetString(1);
                        sTipo = mReader.GetString(2);
                        sPassword = mReader.GetString(3);
                        sEmpleado = mReader.GetString(4);

                        try
                        {
                            MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona = (SELECT ncodpersona FROM TrEMPLEADO WHERE ncodempleado = '{0}')", sEmpleado), clasConexion.funConexion());
                            MySqlDataReader mReader2 = mComando2.ExecuteReader();
                            if (mReader2.Read())
                                sEmpleado = mReader2.GetString(0) + " " + mReader2.GetString(1);
                        }
                        catch
                        {
                            MessageBox.Show("Se produjo un error buscando nombre de empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        grdUsuario.Rows.Insert(iContador, sCodigo, sEmpleado, sUsuario, sPassword, sTipo);
                        sCodigo = sUsuario = sTipo = sPassword = sEmpleado = "";
                        iContador++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error actualizando la tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
