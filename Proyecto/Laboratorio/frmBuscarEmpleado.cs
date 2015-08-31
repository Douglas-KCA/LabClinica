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
    public partial class frmBuscarEmpleado : Form
    {
        public string sFramePadre;
        public string sSucursal, sPaciente, sEmpleado, sFecha, sHora, sMinuto, sEstado;
        public string sUsuario, sPass, sTipo;

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que carga los componentes iniciales del form cuando es abierto por el reporte de ultima visita
        ---------------------------------------------------------------------------------------------------------------------------------*/
        public frmBuscarEmpleado(String padre, String empleado, String usuario, String pass, String tipo)
        {
            InitializeComponent();
            sFramePadre = padre;
            sEmpleado = empleado;
            sUsuario = usuario;
            sPass = pass;
            sTipo = tipo;
            funActualizar();
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que carga los componentes iniciales del form cuando es avierto por crear cita
        ---------------------------------------------------------------------------------------------------------------------------------*/
        public frmBuscarEmpleado(String padre, String sucursal, String paciente, String empleado, String hora, String minuto, String fecha)
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
        public frmBuscarEmpleado(String padre, String sucursal, String paciente, String empleado, String fecha, String hora, String minuto, String estado)
        {
            InitializeComponent();
            sFramePadre = padre;
            sSucursal = sucursal;
            sPaciente = paciente;
            sEmpleado = empleado;
            sFecha = fecha;
            sHora = hora;
            sMinuto = minuto;
            sEstado = estado;
            funActualizar();
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que carga los componentes iniciales del form
        ---------------------------------------------------------------------------------------------------------------------------------*/
        public frmBuscarEmpleado()
        {
            InitializeComponent();
            funActualizar();
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que pobla el grid con los datos de la BD
        ---------------------------------------------------------------------------------------------------------------------------------*/
        void funActualizar()
        {
            string sCodigo;
            string sNombre;
            int iContador = 0;
            grdEmpleado.Rows.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT TrEMPLEADO.ncodempleado, MaPERSONA.cnombrepersona, MaPERSONA.capellidopersona FROM TrEMPLEADO, MaPERSONA WHERE TrEMPLEADO.ncodpersona=MaPERSONA.ncodpersona"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sNombre = mReader.GetString(1) + " " + mReader.GetString(2);
                    grdEmpleado.Rows.Insert(iContador, sCodigo, sNombre);
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
          Funcion que envia los datos de la fila seleccionada en el grid al from padre
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (sFramePadre == "frmUsuario")
            {
                frmUsuario ver = new frmUsuario();
                ver.cmbEmpleado.Text = grdEmpleado.Rows[grdEmpleado.CurrentCell.RowIndex].Cells[1].Value + "";
                ver.txtNombre.Text = sUsuario;
                ver.txtPass.Text = sPass;
                ver.cmbTipo.Text = sTipo;
                ver.MdiParent = this.MdiParent;
                ver.Show();
            }else if(sFramePadre == "frmConsultaCita"){
                frmConsultaCita ver = new frmConsultaCita();
                ver.cmbActualizarSucursal.Text = sSucursal;
                ver.cmbAcutalizarEmpleado.Text = grdEmpleado.Rows[grdEmpleado.CurrentCell.RowIndex].Cells[1].Value + "";
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
                ver.cmbEmpleado.Text = grdEmpleado.Rows[grdEmpleado.CurrentCell.RowIndex].Cells[1].Value + "";
                ver.dtpCitas.Text = sFecha;
                ver.cmbHora.Text = sHora;
                ver.cmbMinutos.Text = sMinuto;
                ver.MdiParent = this.MdiParent;
                ver.Show();
            }
            this.Close();
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que limpia los datos de los textbox y actualiza el grid
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = txtNombre.Text = "";
            btnCancelar.Enabled = btnAceptar.Enabled = false;
            funActualizar();
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que regresa al frame anterior
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (sFramePadre == "frmUsuario")
            {
                frmUsuario ver = new frmUsuario();
                ver.cmbEmpleado.Text = sEmpleado;
                ver.txtNombre.Text = sUsuario;
                ver.txtPass.Text = sPass;
                ver.cmbTipo.Text = sTipo;
                ver.MdiParent = this.MdiParent;
                ver.Show();
            }
            else if (sFramePadre == "frmConsultaCita")
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
          Funcion que filtra los datos de la tabla en base a lo que se escribe en el textbox de nombre empleado, 
          se actualiza cada vez que se suelta una tecla
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void txtBuscarPaciente_KeyUp(object sender, KeyEventArgs e)
        {
            string sNombre, sCodigo;
            int iContador = 0;
            grdEmpleado.Rows.Clear();
            try{
                if (String.IsNullOrEmpty(txtNombre.Text)){
                    funActualizar();
                }
                else{
                    MySqlCommand mComando = new MySqlCommand(String.Format("SELECT MaPERSONA.cnombrepersona, MaPersona.capellidopersona, TrEMPLEADO.ncodempleado FROM MaPERSONA, TrEMPLEADO WHERE MaPERSONA.cnombrepersona LIKE '{0}%' AND MaPERSONA.ncodpersona = TrEMPLEADO.ncodpersona", txtNombre.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read()){
                        sNombre = mReader.GetString(0) + " " + mReader.GetString(1);
                        sCodigo = mReader.GetString(2);
                        
                        grdEmpleado.Rows.Insert(iContador, sCodigo, sNombre);
                        sCodigo = sNombre = "";
                        iContador++;
                    }
                }
            }
            catch{
                MessageBox.Show("Se produjo un error actualizando la tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que filtra los datos de la tabla en base a lo que se escribe en el textbox de apellido empleado, 
          se actualiza cada vez que se suelta una tecla
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void txtApellido_KeyUp(object sender, KeyEventArgs e)
        {
            string sNombre, sCodigo;
            int iContador = 0;
            grdEmpleado.Rows.Clear();
            try
            {
                if (String.IsNullOrEmpty(txtApellido.Text))
                {
                    funActualizar();
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format("SELECT MaPERSONA.cnombrepersona, MaPersona.capellidopersona, TrEMPLEADO.ncodempleado FROM MaPERSONA, TrEMPLEADO WHERE MaPERSONA.capellidopersona LIKE '{0}%' AND MaPERSONA.ncodpersona = TrEMPLEADO.ncodpersona", txtApellido.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        sNombre = mReader.GetString(0) + " " + mReader.GetString(1);
                        sCodigo = mReader.GetString(2);

                        grdEmpleado.Rows.Insert(iContador, sCodigo, sNombre);
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
          Funcion que bloquea la busqueda por apellido
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            funActualizar();
            btnCancelar.Enabled = true;
        }
        
        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que bloquea la busqueda por nombre
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void txtApellido_Enter(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            funActualizar();
            btnCancelar.Enabled = true;
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que toma los valores de la fila seleccionada en el grid para mostrarlos en el form padre
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void grdEmpleado_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que previene la escritura de numeros y simbolos en el textbox de nombre empleado
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
          Funcion que previene la escritura de numeros y simbolos en el textbox de apellido empleado
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
    }
}
