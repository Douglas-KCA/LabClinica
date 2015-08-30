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
    public partial class frmBuscarPaciente : Form
    {
        public string sFramePadre;
        public string sSucursal, sEmpleado, sFecha, sHora, sMinuto, sEstado;
        public frmBuscarPaciente(String padre)
        {
            InitializeComponent();
            sFramePadre = padre;
            funActualizar();
        }

        public frmBuscarPaciente(String padre, String sucursal, String empleado, String fecha, String hora, String minuto, String estado)
        {
            InitializeComponent();
            sFramePadre = padre;
            sSucursal = sucursal;
            sEmpleado = empleado;
            sFecha = fecha;
            sMinuto = minuto;
            sEstado = estado;
            funActualizar();
        }

        public frmBuscarPaciente()
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
            grdPaciente.Rows.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT TrPACIENTE.ncodpaciente, MaPERSONA.cnombrepersona, MaPERSONA.capellidopersona FROM TrPACIENTE, MaPERSONA WHERE TrPACIENTE.ncodpersona=MaPERSONA.ncodpersona"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sNombre = mReader.GetString(1) + " " + mReader.GetString(2);
                    grdPaciente.Rows.Insert(iContador, sCodigo, sNombre);
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (sFramePadre == "frmReporteUltimaVisita")
            {
                frmReporteUltimaVisita ver = new frmReporteUltimaVisita();
                ver.cmbPaciente.Text = grdPaciente.Rows[grdPaciente.CurrentCell.RowIndex].Cells[1].Value + "";
                ver.Show();
            }
            else if (sFramePadre == "frmConsultaCita")
            {
                frmConsultaCita ver = new frmConsultaCita();
                ver.cmbActualizarSucursal.Text = sSucursal;
                ver.cmbAcutalizarEmpleado.Text = sEmpleado;
                ver.cmbActualizarPaciente.Text = grdPaciente.Rows[grdPaciente.CurrentCell.RowIndex].Cells[1].Value + "";
                ver.dtpActualizarCitas.Text = sFecha;
                ver.cmbActualizarHora.Text = sHora;
                ver.cmbActualizarMinutos.Text = sMinuto;
                ver.cmbEstado.Text = sEstado;
            }else if(sFramePadre == "frmIngresoCita"){
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = txtNombre.Text = "";
            btnCancelar.Enabled = btnAceptar.Enabled = false;
            funActualizar();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (sFramePadre == "frmReporteUltimaVisita")
            {
                frmReporteUltimaVisita ver = new frmReporteUltimaVisita();
                ver.Show();
            }
            else if (sFramePadre == "frmConsultaCita")
            {

            }
            else if (sFramePadre == "frmIngresoCita")
            {
            }
            this.Close();
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            string sNombre, sCodigo;
            int iContador = 0;
            grdPaciente.Rows.Clear();
            try
            {
                if (String.IsNullOrEmpty(txtNombre.Text))
                {
                    funActualizar();
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format("SELECT MaPERSONA.cnombrepersona, MaPersona.capellidopersona, TrPACIENTE.ncodpaciente FROM MaPERSONA, TrPACIENTE WHERE MaPERSONA.cnombrepersona LIKE '{0}%' AND MaPERSONA.ncodpersona = TrPACIENTE.ncodpersona", txtNombre.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        sNombre = mReader.GetString(0) + " " + mReader.GetString(1);
                        sCodigo = mReader.GetString(2);

                        grdPaciente.Rows.Insert(iContador, sCodigo, sNombre);
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

        private void txtApellido_KeyUp(object sender, KeyEventArgs e)
        {
            string sNombre, sCodigo;
            int iContador = 0;
            grdPaciente.Rows.Clear();
            try
            {
                if (String.IsNullOrEmpty(txtApellido.Text))
                {
                    funActualizar();
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format("SELECT MaPERSONA.cnombrepersona, MaPersona.capellidopersona, TrPACIENTE.ncodpaciente FROM MaPERSONA, TrPACIENTE WHERE MaPERSONA.capellidopersona LIKE '{0}%' AND MaPERSONA.ncodpersona = TrPACIENTE.ncodpersona", txtApellido.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        sNombre = mReader.GetString(0) + " " + mReader.GetString(1);
                        sCodigo = mReader.GetString(2);

                        grdPaciente.Rows.Insert(iContador, sCodigo, sNombre);
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

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            funActualizar();
            btnCancelar.Enabled = true;
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            funActualizar();
            btnCancelar.Enabled = true;
        }

        private void grdPaciente_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void grdPaciente_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
        }


    }
}
