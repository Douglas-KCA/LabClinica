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
    public partial class frmFactura : Form
    {

        string sCodigoPacienteFactura;
        string sTipoPago;
        public frmFactura()
        {
            InitializeComponent();
        }

        private void txtNit_TextChanged(object sender, EventArgs e)
        {
           
                string sNombre;
                string sApellido;
                try
                {

                    if (String.IsNullOrEmpty(txtNit.Text))
                    {
                        txtNombre.Clear();
                    }
                    else
                    {

                        MySqlCommand mComando = new MySqlCommand(String.Format(
                        "SELECT TrPACIENTE.ncodpaciente, MaPERSONA.cnombrepersona, MaPERSONA.capellidopersona FROM TrPACIENTE, MaPERSONA WHERE TrPACIENTE.ncodpersona=MaPERSONA.ncodpersona AND MaPERSONA.cnitpersona = '{0}' ", txtNit.Text), clasConexion.funConexion());
                        MySqlDataReader mReader = mComando.ExecuteReader();

                        while (mReader.Read())
                        {
                            sCodigoPacienteFactura = mReader.GetString(0);
                            sNombre = mReader.GetString(1);
                            sApellido = mReader.GetString(2);
                            txtNombre.Text = sNombre + " " + sApellido;
                        }

                        DateTime fecha = DateTime.Today;
                        txtFecha.Text = fecha.ToString("d");
                    }
                }catch
                {
                    MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void rbEfectivo_MouseClick(object sender, MouseEventArgs e)
        {
            sTipoPago = "Efectivo";
            lblTarjeta.Visible = false;
            txtNoTarjeta.Visible = false;
            lblVencimiento.Visible = false;
            txtVencimiento.Visible = false;
        }

        private void rbTarjeta_MouseClick(object sender, MouseEventArgs e)
        {
            sTipoPago = "Tarjeta de Credito";
            lblTarjeta.Visible = true;
            txtNoTarjeta.Visible = true;
            lblVencimiento.Visible = true;
            txtVencimiento.Visible = true;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNombre.Text) && (rbEfectivo.Checked == false || rbTarjeta.Checked == false))
                {
                    MessageBox.Show("Por favor ingresa un cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(string.Format("Insert into MaFACTURA (ctipopago, dfechafactura, ncodpaciente) values ('{0}','{1}','{2}')",
                    sTipoPago, txtFecha.Text, sCodigoPacienteFactura), clasConexion.funConexion());
                    mComando.ExecuteNonQuery();
                    pPanelEncabezado.Enabled = false;
                    btnGenerar.Enabled = false;
                }
                
                
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
    }
}
