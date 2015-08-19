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
        string sNombreExamen;
        int iCadPrecioInicio;
        int iContador = 0;
        public frmFactura()
        {
            InitializeComponent();
        }

        void funLlenarCita(){
            string sCodigocmb;
            string sFechacmb;
            string sHoracmb;
            cmbCita.Items.Clear();
            try
            {                
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT ncodigocita, dfechacita, choracita FROM TrCITA WHERE ncodpaciente='{0}'", sCodigoPacienteFactura), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {                    
                    sCodigocmb = mReader.GetString(0);
                    sFechacmb = mReader.GetString(1);
                    sHoracmb = mReader.GetString(2);
                    cmbCita.Items.Add(sCodigocmb + ". " + sFechacmb + " --- " + sHoracmb);
                    sCodigocmb = "";
                    sFechacmb = "";
                    sHoracmb = "";
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error cmbLlenarCita", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void funLlenarSucursal(){
            string sCodigocmb;
            string sNombreSucursalcmb;            
            cmbSucursal.Items.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT ncodsucursal, cnombresucursal FROM MaSUCURSAL"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigocmb = mReader.GetString(0);
                    sNombreSucursalcmb = mReader.GetString(1);                    
                    cmbSucursal.Items.Add(sCodigocmb + ". " + sNombreSucursalcmb);
                    sCodigocmb = "";
                    sNombreSucursalcmb = "";
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error cmbLlenarSucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        
        void funLlenarExamen(){
            string sCodigocmb;
            string sNombrecmb;
            string sPreciocmb;
            cmbExamen.Items.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT ncodtipo, cdesctipoexamen, cpreciotipoexamen FROM MaTIPOEXAMEN"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigocmb = mReader.GetString(0);
                    sNombrecmb = mReader.GetString(1);
                    sPreciocmb = mReader.GetString(2);
                    cmbExamen.Items.Add(sCodigocmb + ". " + sNombrecmb + " (Q" + sPreciocmb + ")");
                    sCodigocmb = "";
                    sNombrecmb = "";
                    sPreciocmb = "";
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error cmbLlenarExamen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        void funLlenarDoctor(){
            string sCodigocmb;
            string sNombrecmb;
            string sApellidocmb;
            cmbDoctor.Items.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT TrEMPLEADO.ncodempleado, MaPERSONA.cnombrepersona, MaPERSONA.capellidopersona FROM MaPERSONA, TrEMPLEADO WHERE TrEMPLEADO.ncodpersona=MaPERSONA.ncodpersona AND TrEMPLEADO.ncodpuesto=4"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigocmb = mReader.GetString(0);
                    sNombrecmb = mReader.GetString(1);
                    sApellidocmb = mReader.GetString(2);
                    cmbDoctor.Items.Add(sCodigocmb + ". " + sNombrecmb + " " + sApellidocmb);
                    sCodigocmb = "";
                    sNombrecmb = "";
                    sApellidocmb = "";
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error cmbLlenarDoctor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void funCodigoFactura(){
            try
            {
                string sCodFactura;
                    MySqlCommand mComando = new MySqlCommand(String.Format(
                    "SELECT MAX(ncodfactura) FROM MaFACTURA"), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        sCodFactura = mReader.GetString(0);                        
                        txtNo.Text = sCodFactura;
                    }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string funCortadorNombreExamen(string sDato)
        {
            sNombreExamen = "";
            iCadPrecioInicio = 0;
            try
            {
                for (int i = 0; i < sDato.Length; i++)
                {
                    if (sDato.Substring(i, 1) != "(")
                    {
                        sNombreExamen = sNombreExamen + sDato.Substring(i, 1);
                        iCadPrecioInicio++;
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

            return sNombreExamen;
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
                        funLlenarCita();

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
//<<<<<<< HEAD
            
            sTipoPago = "Efectivo";
//<<<<<<< HEAD
            //lblTarjeta.Visible = false;
            //txtNoTarjeta.Visible = false;
            //lblVencimiento.Visible = false;
            //txtVencimiento.Visible = false;
//=======
            /*
            lblTarjeta.Visible = false;
            txtNoTarjeta.Visible = false;
            lblVencimiento.Visible = false;
            txtVencimiento.Visible = false;
            */
//=======
            /*sTipoPago = "Efectivo";
            lblTarjeta.Visible = false;
            txtNoTarjeta.Visible = false;
            lblVencimiento.Visible = false;
            txtVencimiento.Visible = false;*/
//>>>>>>> master
//>>>>>>> master
        }

        private void rbTarjeta_MouseClick(object sender, MouseEventArgs e)
        {
//<<<<<<< HEAD
            
            sTipoPago = "Tarjeta de Credito";
//<<<<<<< HEAD
            //lblTarjeta.Visible = true;
            //txtNoTarjeta.Visible = true;
            //lblVencimiento.Visible = true;
            //txtVencimiento.Visible = true;
//=======
            /*
            lblTarjeta.Visible = true;
            txtNoTarjeta.Visible = true;
            lblVencimiento.Visible = true;
            txtVencimiento.Visible = true;
            */
//=======
            /*sTipoPago = "Tarjeta de Credito";
            lblTarjeta.Visible = true;
            txtNoTarjeta.Visible = true;
            lblVencimiento.Visible = true;
            txtVencimiento.Visible = true;*/
//>>>>>>> master
            //>>>>>>> master
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
                    pServicios.Enabled = true;
                    funCodigoFactura();
                    btnAgregar.Enabled = true;
                    //funLlenarCita();
                    //funLlenarSucursal();
                    funLlenarExamen();
                    funLlenarDoctor();
                }                                
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNombre.Text)){
                cmbCita.Items.Clear();
                cmbSucursal.Items.Clear();
                cmbCita.Enabled = false;
                cmbSucursal.Enabled = false;
            }else{
                cmbCita.Enabled = true;            
                funLlenarCita();
                funLlenarSucursal();
            }
            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /*iContador++;
            string sCortar = cmbExamen.SelectedItem.ToString();
            sNombreExamen = funCortadorNombreExamen(sCortar);
            int isuma=1;
            MessageBox.Show(sNombreExamen+ "----" +iCadPrecioInicio+1+"---"+(sCortar.Length-2).ToString());
            string sPrecio = sCortar.Substring(sCortar.Length-2, iCadPrecioInicio+1);
            MessageBox.Show(cmbDoctor.SelectedItem.ToString() +"--"+ sNombreExamen + "--" + sPrecio, "Informacion Llego");
            //grdDetalleFactura.Rows.Insert(iContador, cmbDoctor.SelectedItem.ToString(), sNombreExamen, sPrecio);*/
        }
    }
}
