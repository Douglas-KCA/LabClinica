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
    public partial class frmBuscarSucursal : Form
    {
        public string sFramePadre;
        public string sSucursal, sEmpleado, sPaciente, sFecha, sHora, sMinuto, sEstado;

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que carga los componentes iniciales del form cuando es avierto por crear cita
        ---------------------------------------------------------------------------------------------------------------------------------*/
        public frmBuscarSucursal(String padre, String sucursal, String paciente, String empleado, String hora, String minuto, String fecha)
        {
            InitializeComponent();
            sFramePadre = padre;
            sSucursal = sucursal;
            sPaciente = paciente;
            sEmpleado = empleado;
            sHora = hora;
            sMinuto = minuto;
            sFecha = fecha;
            funActualizar();
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que carga los componentes iniciales del form cuando es avierto por consultaro o modificar cita
        ---------------------------------------------------------------------------------------------------------------------------------*/
        public frmBuscarSucursal(String padre, String sucursal, String empleado, String paciente, String fecha, String hora, String minuto, String estado)
        {
            InitializeComponent();
            sFramePadre = padre;
            sSucursal = sucursal;
            sEmpleado = empleado;
            sPaciente = paciente;
            sFecha = fecha;
            sHora = hora;
            sMinuto = minuto;
            sEstado = estado;
            funActualizar();
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que carga los componentes iniciales del form
        ---------------------------------------------------------------------------------------------------------------------------------*/
        public frmBuscarSucursal()
        {
            InitializeComponent();
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que pobla el grid con los datos de la BD
        ---------------------------------------------------------------------------------------------------------------------------------*/
        void funActualizar()
        {
            string sUbicacion;
            string sNombre;
            string sCodigo;
            int iContador = 0;
            grdSucursal.Rows.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT ncodsucursal, cnombresucursal, cubicacion FROM MaSUCURSAL"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sNombre = mReader.GetString(1);
                    sUbicacion = mReader.GetString(2);
                    grdSucursal.Rows.Insert(iContador, sCodigo, sNombre, sUbicacion);
                    sUbicacion = "";
                    sNombre = "";
                    sCodigo = "";
                    iContador++;
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que devuelve el paciente seleccionado a su form padre
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (sFramePadre == "frmConsultaCita")
            {
                frmConsultaCita ver = new frmConsultaCita();
                ver.cmbActualizarSucursal.Text = grdSucursal.Rows[grdSucursal.CurrentCell.RowIndex].Cells[1].Value + "" ;
                ver.cmbAcutalizarEmpleado.Text = sEmpleado;
                ver.cmbActualizarPaciente.Text = sPaciente;
                ver.dtpActualizarCitas.Text = sFecha;
                ver.cmbActualizarHora.Text = sHora;
                ver.cmbActualizarMinutos.Text = sMinuto;
                ver.cmbEstado.Text = sEstado;
                ver.grpActualizar.Enabled = true;
                ver.MdiParent = this.MdiParent;
                ver.Show();
            }
            else if (sFramePadre == "frmIngresoCita")
            {
                frmIngresoCita ver = new frmIngresoCita();
                ver.cmbSucursal.Text = grdSucursal.Rows[grdSucursal.CurrentCell.RowIndex].Cells[1].Value + "";
                ver.cmbPaciente.Text = sPaciente;
                ver.cmbEmpleado.Text = sEmpleado;
                ver.dtpCitas.Text = sFecha;
                ver.cmbHora.Text = sHora;
                ver.cmbMinutos.Text = sMinuto;
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
            txtNombre.Text = "";
            btnCancelar.Enabled = btnAceptar.Enabled = false;
            funActualizar();
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que cierra este form y regresa a su form padre
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (sFramePadre == "frmConsultaCita")
            {
                frmConsultaCita ver = new frmConsultaCita();
                ver.cmbActualizarSucursal.Text = sSucursal;
                ver.cmbAcutalizarEmpleado.Text = sEmpleado;
                ver.cmbActualizarPaciente.Text = sPaciente;
                ver.dtpActualizarCitas.Text = sFecha;
                ver.cmbActualizarHora.Text = sHora;
                ver.cmbActualizarMinutos.Text = sMinuto;
                ver.cmbEstado.Text = sEstado;
                ver.grpActualizar.Enabled = true;
                ver.MdiParent = this.MdiParent;
                ver.Show();
            }
            else if (sFramePadre == "frmIngresoCita")
            {
                frmIngresoCita ver = new frmIngresoCita();
                ver.cmbSucursal.Text = sSucursal;
                ver.cmbPaciente.Text = sPaciente;
                ver.cmbEmpleado.Text = sEmpleado;
                ver.dtpCitas.Text = sFecha;
                ver.cmbHora.Text = sHora;
                ver.cmbMinutos.Text = sMinuto;
                ver.MdiParent = this.MdiParent;
                ver.Show();
            }
            this.Close();
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que filtra los datos de la tabla en base a lo que se escribe en el textbox de nombre sucursal, 
          se actualiza cada vez que se suelta una tecla
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            string sCodigo;
            string sNombre;
            string sUbicacion;
            int iContador = 0;
            grdSucursal.Rows.Clear();

            try
            {
                if (String.IsNullOrEmpty(txtNombre.Text))
                {
                    funActualizar();
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format(
                    "SELECT ncodsucursal, cnombresucursal, cubicacion FROM MaSUCURSAL WHERE cnombresucursal LIKE '{0}%'", txtNombre.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        sCodigo = mReader.GetString(0);
                        sNombre = mReader.GetString(1);
                        sUbicacion = mReader.GetString(2);
                        grdSucursal.Rows.Insert(iContador, sCodigo, sNombre, sUbicacion);
                        sCodigo = sNombre = sUbicacion = "";
                        iContador++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que previene la escritura de numeros y simbolos en el textbox de nombre sucursal
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
          Funcion que toma los valores de la fila seleccionada en el grid para mostrarlos en el form padre
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void grdSucursal_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
        }

    }
}
