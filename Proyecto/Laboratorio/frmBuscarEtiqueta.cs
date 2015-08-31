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
      * Fecha de entrega: 06/08/2015
    ---------------------------------------------------------------------------------------------------------------------------------*/
    public partial class frmBuscarEtiqueta : Form
    {
        public string sFramePadre;
        String sEtiqueta;

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que carga los componentes iniciales del form cuando es abierto por generar analisis
        ---------------------------------------------------------------------------------------------------------------------------------*/
        public frmBuscarEtiqueta(String padre, String etiqueta)
        {
            InitializeComponent();
            sFramePadre = padre;
            sEtiqueta = etiqueta;
            funActualizar();
            txtNombre.Enabled = txtApellido.Enabled = txtMuestra.Enabled = false;
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que carga los componentes iniciales del form
        ---------------------------------------------------------------------------------------------------------------------------------*/
        public frmBuscarEtiqueta()
        {
            InitializeComponent();
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que pobla el grid con los datos de la BD
        ---------------------------------------------------------------------------------------------------------------------------------*/
        void funActualizar()
        {
            string sCodigo;
            string sNombre;
            string sMuestra;
            int iContador = 0;
            grdEtiqueta.Rows.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT MaETIQUETA.ncodetiqueta, MaPERSONA.cnombrepersona, MaPERSONA.capellidopersona, MaMUESTRA.cdescmuestra FROM MaPERSONA, MaMUESTRA, TrPACIENTE, MaETIQUETA WHERE TrPACIENTE.ncodpaciente = MaETIQUETA.ncodpaciente AND MaPERSONA.ncodpersona = TrPACIENTE.ncodpersona AND MaMUESTRA.ncodmuestra = MaETIQUETA.ncodmuestra"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sNombre = mReader.GetString(1) + " " + mReader.GetString(2);
                    sMuestra = mReader.GetString(3);
                    grdEtiqueta.Rows.Insert(iContador, sCodigo, sNombre, sMuestra);
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

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que havilita la seccion de busqueda por paciente y deshabilita el resto
        ---------------------------------------------------------------------------------------------------------------------------------*/        
        private void rbtnPaciente_CheckedChanged(object sender, EventArgs e)
        {
            txtApellido.Enabled = txtNombre.Enabled = true;
            txtMuestra.Enabled = false;
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que havilita la seccion de busqueda por muestra y deshabilita el resto
        ---------------------------------------------------------------------------------------------------------------------------------*/        
        private void rbtnMuestra_CheckedChanged(object sender, EventArgs e)
        {
            txtApellido.Enabled = txtNombre.Enabled = false;
            txtMuestra.Enabled = true;
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que devuelve el paciente seleccionado a su form padre
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (sFramePadre == "frmAnalisis")
            {
                frmAnalisis ver = new frmAnalisis();
                ver.cmbEtiqueta.Text = grdEtiqueta.Rows[grdEtiqueta.CurrentCell.RowIndex].Cells[1].Value + "-" + grdEtiqueta.Rows[grdEtiqueta.CurrentCell.RowIndex].Cells[2].Value;
                ver.MdiParent = this.MdiParent;
                ver.Show();
            }
            this.Close();
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que limpia los textbox o combobox
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtMuestra.Text = txtNombre.Text = txtApellido.Text = "";
            funActualizar();
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que cierra este form y regresa a su form padre
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (sFramePadre == "frmAnalisis")
            {
                frmAnalisis ver = new frmAnalisis();
                ver.MdiParent = this.MdiParent;
                ver.cmbEtiqueta.Text = sEtiqueta;
                ver.Show();
            }
            this.Close();
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que toma los valores de la fila seleccionada en el grid para mostrarlos en el form padre
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void grdPaciente_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que filtra los datos de la tabla en base a lo que se escribe en el textbox de nombre paciente, 
          se actualiza cada vez que se suelta una tecla
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            string sNombre, sCodigo, sMuestra;
            int iContador = 0;
            grdEtiqueta.Rows.Clear();
            try
            {
                if (String.IsNullOrEmpty(txtNombre.Text))
                {
                    funActualizar();
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format("SELECT MaPERSONA.cnombrepersona, MaPersona.capellidopersona, MaETIQUETA.ncodetiqueta, MaMUESTRA.cdescmuestra FROM MaPERSONA, TrPACIENTE, MaETIQUETA, MaMUESTRA WHERE MaPERSONA.cnombrepersona LIKE '{0}%' AND MaPERSONA.ncodpersona = TrPACIENTE.ncodpersona AND MaETIQUETA.ncodpaciente = TrPACIENTE.ncodpaciente AND MaETIQUETA.ncodmuestra = MaMUESTRA.ncodmuestra", txtNombre.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        sNombre = mReader.GetString(0) + " " + mReader.GetString(1);
                        sCodigo = mReader.GetString(2);
                        sMuestra = mReader.GetString(3);
                        grdEtiqueta.Rows.Insert(iContador, sCodigo, sNombre, sMuestra);
                        sCodigo = sNombre = "";
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
            string sNombre, sCodigo, sMuestra;
            int iContador = 0;
            grdEtiqueta.Rows.Clear();
            try
            {
                if (String.IsNullOrEmpty(txtApellido.Text))
                {
                    funActualizar();
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format("SELECT MaPERSONA.cnombrepersona, MaPersona.capellidopersona, MaETIQUETA.ncodetiqueta, MaMUESTRA.cdescmuestra FROM MaPERSONA, TrPACIENTE, MaETIQUETA, MaMUESTRA WHERE MaPERSONA.capellidopersona LIKE '{0}%' AND MaPERSONA.ncodpersona = TrPACIENTE.ncodpersona AND MaETIQUETA.ncodpaciente = TrPACIENTE.ncodpaciente AND MaETIQUETA.ncodmuestra = MaMUESTRA.ncodmuestra", txtApellido.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        sNombre = mReader.GetString(0) + " " + mReader.GetString(1);
                        sCodigo = mReader.GetString(2);
                        sMuestra = mReader.GetString(3);
                        grdEtiqueta.Rows.Insert(iContador, sCodigo, sNombre, sMuestra);
                        sCodigo = sNombre = "";
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
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string sNombre, sCodigo, sMuestra;
            int iContador = 0;
            grdEtiqueta.Rows.Clear();
            try
            {
                if (String.IsNullOrEmpty(txtMuestra.Text))
                {
                    funActualizar();
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format("SELECT MaPERSONA.cnombrepersona, MaPersona.capellidopersona, MaETIQUETA.ncodetiqueta, MaMUESTRA.cdescmuestra FROM MaPERSONA, TrPACIENTE, MaETIQUETA, MaMUESTRA WHERE MaMUESTRA.cdescmuestra LIKE '{0}%' AND MaPERSONA.ncodpersona = TrPACIENTE.ncodpersona AND MaETIQUETA.ncodpaciente = TrPACIENTE.ncodpaciente AND MaETIQUETA.ncodmuestra = MaMUESTRA.ncodmuestra", txtMuestra.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        sNombre = mReader.GetString(0) + " " + mReader.GetString(1);
                        sCodigo = mReader.GetString(2);
                        sMuestra = mReader.GetString(3);
                        grdEtiqueta.Rows.Insert(iContador, sCodigo, sNombre, sMuestra);
                        sCodigo = sNombre = "";
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
          Funcion que previene la escritura de numeros y simbolos en el textbox de muestra paciente
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
