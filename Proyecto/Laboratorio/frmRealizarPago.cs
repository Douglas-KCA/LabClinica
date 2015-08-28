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

/*
 * Programador: Manuel Alejandro Chuquiej Buch
 * Formulario designado por: Josue Revolorio.
 * 
 */

namespace Laboratorio
{
    public partial class frmRealizarPago : Form
    {
        //declaracion de variables
        string sCodPaciente;
        bool existe=false;
        string sCodiFactura,sEstadoFactura,sNitPersona,sNombrePersona,SApellidoPersona,sTotalDeuda,sSaldoDeuda,sCantPago;
        string sSaldoEvaluar;

        public frmRealizarPago()
        {
            InitializeComponent();
            funCancelar();
        }

        //funcion que toma el nombre del paciente conforme al dpi
        String funCodigoPaciente(string sDpiPaciente) {
         
            MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT TrPACIENTE.ncodpaciente FROM TrPACIENTE,MaPERSONA WHERE MaPERSONA.ncodpersona=TrPACIENTE.ncodpersona AND MaPERSONA.cdpipersona='"+sDpiPaciente+"'"), clasConexion.funConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                existe = true;
                sCodPaciente = _reader.GetString(0);
            }

            if (existe==false){
                System.Console.WriteLine("no exixte codigo");
            }
            
        return sCodPaciente;
        }//----------fin de funcion obtener codigo paciente------------

        //-------------funcion para boton cancelar----------------
        void funCancelar() {
            txtDpi.Text = "";
            grdPago.Rows.Clear();
            btnGuardar.Enabled = false;
            lblConfirmacionPago.Enabled = false;
            lblImporte.Enabled = false;
            txtHacerPago.Enabled = false;
            txtConfirmePago.Enabled = false;
        }
        //------------fin funcion boton cancelar------------------

        //-------------funcion para clic en grid----------------
        void fuhabilitar()
        {
            //txtDpi.Text = "";
            //grdPago.Rows.Clear();
            btnGuardar.Enabled = true;
            lblConfirmacionPago.Enabled = true;
            lblImporte.Enabled = true;
            txtHacerPago.Enabled = true;
            txtConfirmePago.Enabled = true;
        }
        //------------fin funcion para click grid------------------

        void funObtenerEstado() {
            //try
            //{
                DataGridViewRow fila = grdPago.CurrentRow;
                String codigoFactura = Convert.ToString(fila.Cells[0].Value);
               
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT MaDEUDA.nsaldodeuda FROM MaFACTURA,MaDEUDA WHERE MaFACTURA.ncodfactura=MaDEUDA.ncodfactura and MaFACTURA.ncodfactura='"+codigoFactura+"'"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();
                System.Console.WriteLine("si llego hasta el codigo" + codigoFactura);
                while (mReader.Read())
                {
                   
                    sSaldoEvaluar = mReader.GetString(1);

                    //int evaluador=Convert.ToInt16(sSaldoEvaluar);
                    //System.Console.WriteLine("si llego hasta el codigo" + codigoFactura);
                    /*if(evaluador.Equals(0)){

                        MySqlCommand mComando2 = new MySqlCommand(string.Format("UPDATE MaFACTURA SET cestado='INACTIVA' WHERE ncodfactura='" + codigoFactura + "'"), clasConexion.funConexion());
                        mComando2.ExecuteNonQuery();
                    
                    }*/
                    
                }
            //}
            //catch { 
              // MessageBox.Show("Se produjo al obtener el estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        } 
            
            }
        

        private void txtDpi_KeyUp(object sender, KeyEventArgs e)
        {
            sCodPaciente = "";
            int iContador = 0;
            string sdpitxt = txtDpi.Text;
            funCodigoPaciente(sdpitxt);
            grdPago.Rows.Clear();
            //System.Console.WriteLine("codigo paciente---:  "+sCodPaciente);

            //-------con este procedimiento se tomara el estado de la factura para evaluarla.
            MySqlCommand _comando = new MySqlCommand(String.Format(
              "SELECT MaFACTURA.ncodfactura,MaFACTURA.cestado,MaPERSONA.cnitpersona,MaPERSONA.cnombrepersona,MaPERSONA.capellidopersona,MaDEUDA.ntotaldeuda,MaDEUDA.nsaldodeuda,MaDEUDA.ccantpago FROM MaFACTURA,TrPACIENTE,MaPERSONA,MaDEUDA WHERE TrPACIENTE.ncodpaciente=MaFACTURA.ncodpaciente AND TrPACIENTE.ncodpersona=MaPERSONA.ncodpersona  AND MaFACTURA.ncodfactura=MaDEUDA.ncodfactura AND TrPACIENTE.ncodpaciente='" + sCodPaciente + "' AND MaFACTURA.cestado='ACTIVA'"), clasConexion.funConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                existe = true;
                sCodiFactura=_reader.GetString(0);
                sEstadoFactura = _reader.GetString(1);
                sNitPersona = _reader.GetString(2);
                sNombrePersona = _reader.GetString(3);
                SApellidoPersona = _reader.GetString(4);
                sTotalDeuda = _reader.GetString(5);
                sSaldoDeuda = _reader.GetString(6);
                sCantPago = _reader.GetString(7);
                /*System.Console.WriteLine(" ----:" + sCodiFactura);
                System.Console.WriteLine(" ----:" +sEstadoFactura);
                System.Console.WriteLine(" ----:" +sNombrePersona);
                System.Console.WriteLine(" ----:" +SApellidoPersona);
                System.Console.WriteLine(" ----:" +sTotalDeuda);
                System.Console.WriteLine(" ----:" +sSaldoDeuda);
                System.Console.WriteLine(" ----:" +sCantPago);*/
                grdPago.Rows.Insert(iContador,sCodiFactura,sTotalDeuda,sSaldoDeuda,sCantPago,sEstadoFactura);
                sCodiFactura = "";
                sEstadoFactura = "";
                //sNitPersona = "";
                //sNombrePersona = "";
                //SApellidoPersona = "";
                sTotalDeuda = "";
                sSaldoDeuda = "";
                sCantPago = "";
                iContador++;
                
            }
           //-------------fin de procedimiento de evaluacion de factura-----------
            txtDatosPersonales.Text = "Nit:   " + sNitPersona + "   " + "Nombre:   " + sNombrePersona + "   " + SApellidoPersona;
            
            if (existe==false){
                System.Console.WriteLine("no hay datos todavia");
            }


        }//-------fin de la consulta automatica------------------

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            funCancelar();
        } //-------fin de la boton cancelar------------------

        private void grdPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fuhabilitar();
            //-------fin del evento del grid------------------

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //----variables para tomar las celdas seleccionadas-------
            string codigo; //toma el numero de factura
            string sTomaTotal; //toma el total de la fila
            string sTomaSaldo;//toma el valor del saldo
            string sTomaCantPago;//toma la fila de cantitdad pago

            //------variables para tomar los pagoas de los textbox-----
            string tomarpago = txtHacerPago.Text;
            string confirpago = txtConfirmePago.Text;

            if (tomarpago != confirpago) {
                 MessageBox.Show("Los capos de pago deben ser iguales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 txtHacerPago.Text = "";
                 txtConfirmePago.Text = "";
            }
            else
            {
                DataGridViewRow fila = grdPago.CurrentRow;
                codigo = Convert.ToString(fila.Cells[0].Value);
                sTomaTotal = Convert.ToString(fila.Cells[1].Value);
                sTomaSaldo = Convert.ToString(fila.Cells[2].Value);
                sTomaCantPago = Convert.ToString(fila.Cells[3].Value);

                float sConvertirPagoTxt = float.Parse(tomarpago);
                float sConvertirPagogrd = float.Parse(sTomaTotal);
                float SConvertirCantpago = float.Parse(sTomaCantPago);
                float sConvertirSaldo = float.Parse(sTomaSaldo);
                    
                if (sConvertirPagoTxt > sConvertirPagogrd || sConvertirPagoTxt>sConvertirSaldo){

                    MessageBox.Show("El pago no puede ser mayor al total de la factura o al saldo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHacerPago.Text = "";
                    txtConfirmePago.Text = "";
            
                }else{
                    
                    float resultado = sConvertirSaldo - sConvertirPagoTxt; //el resultado sera el nuevo saldo
          
                    float nuevacantidad =  SConvertirCantpago + sConvertirPagoTxt;//toma lo que pago y le suma el textbox con una cantidad nueva
                    //string xresult = Convert.ToString(resultado);
                    //string xnuevcant = Convert.ToString(nuevacantidad);
                    try
                    {
                        if (MessageBox.Show("¿Desea Realizar el Pago?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            
                            MySqlCommand mComando = new MySqlCommand(string.Format("UPDATE MaDEUDA SET nsaldodeuda='" + resultado + "', ccantpago='" + nuevacantidad + "' WHERE ncodfactura='"+codigo+"'"), clasConexion.funConexion());
                            mComando.ExecuteNonQuery();
                            MessageBox.Show("Su pago se realizo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtConfirmePago.Text = "";
                            txtHacerPago.Text = "";
                            //funObtenerEstado();
                            //System.Console.WriteLine(resultado);
                            //System.Console.WriteLine(codigo);
                            //System.Console.WriteLine(nuevacantidad);

                        }

                        //----prueba para cambiar estado----
                        MySqlCommand mComando3 = new MySqlCommand(String.Format("SELECT MaDEUDA.nsaldodeuda FROM MaFACTURA,MaDEUDA WHERE MaFACTURA.ncodfactura=MaDEUDA.ncodfactura and MaFACTURA.ncodfactura='" + codigo + "'"), clasConexion.funConexion());
                        MySqlDataReader mReader3 = mComando3.ExecuteReader();
                        while(mReader3.Read()){
                            sSaldoEvaluar = mReader3.GetString(0);
                            float conversorevaluar = float.Parse(sSaldoEvaluar);
                            System.Console.WriteLine("se convirtio a flotante" + sSaldoEvaluar);
                            if (conversorevaluar==0) {
                                string mensaje = "INACTIVA";
                                MySqlCommand mComando = new MySqlCommand(string.Format("UPDATE MaFACTURA SET cestado='"+mensaje+"' WHERE ncodfactura='"+codigo+"'"), clasConexion.funConexion());
                                mComando.ExecuteNonQuery();
                                System.Console.WriteLine("llego el salido" + sSaldoEvaluar);
                            }
                        
                        }
                        //fin prueba act saldo
                    }
                    catch {
                        MessageBox.Show("Error al Realizar el pago", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtConfirmePago.Text = "";
                        txtHacerPago.Text = "";
                    }

                
                }
                

            }

        }

        private void txtHacerPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar.ToString() != "."))
            {
                MessageBox.Show("Solo se permiten numeros y punto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtConfirmePago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar.ToString() != "."))
            {
                MessageBox.Show("Solo se permiten numeros y punto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDpi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros y punto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }//-------fin del boton realizarpago------------------

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        } //-------fin del boton home------------------


    }//---------fin del encapsulado principal
}
