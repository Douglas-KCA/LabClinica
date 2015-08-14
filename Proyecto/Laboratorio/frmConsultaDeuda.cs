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
//programador: Manuel Alejandro Chuquiej Buch
//ingenieria en sistemas A

namespace Laboratorio
{
    public partial class frmConsultaDeuda : Form
    {
        //---------Definicion de Variables-----------
        String scodigopaciente;
        String snombrepersona, sapellidopersona, inumerofactura, dfechafactura,itotaldeuda,isaldodeuda;
        int m;
        public frmConsultaDeuda()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscarDeuda.Text.Equals(""))
            {
                MessageBox.Show("El campo de busqueda debe contener un dato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                scodigopaciente = txtBuscarDeuda.Text;
                try {
                    MySqlCommand _comando = new MySqlCommand(String.Format(
               "SELECT npersona.cnombrepersona, apersona.capellidopersona, nfactura.ncodfactura, ffactura.dfechafactura from paciente pac inner JOIN persona npersona ON pac.ncodpersona=npersona.ncodpersona inner JOIN persona apersona ON pac.ncodpersona=apersona.ncodpersona inner JOIN factura nfactura ON pac.ncodpaciente=nfactura.ncodpaciente inner JOIN factura ffactura ON pac.ncodpaciente=ffactura.ncodpaciente WHERE pac.ncodpaciente='"+scodigopaciente+"'"), clasConexion.funConexion());
                    MySqlDataReader _reader = _comando.ExecuteReader();
                    
                    while (_reader.Read())
                    {
                        snombrepersona = _reader.GetString(0);
                        sapellidopersona = _reader.GetString(1);
                        inumerofactura = _reader.GetString(2);
                        dfechafactura = _reader.GetString(3);
                        /*System.Console.WriteLine("prueba: " + snombrepersona);
                        System.Console.WriteLine("prueba: " + sapellidopersona);
                        System.Console.WriteLine("prueba: " + inumerofactura);
                        System.Console.WriteLine("prueba: " + dfechafactura);*/
                        
                       // grdDeuda.Rows.Clear();
                        try
                        {
                            MySqlCommand _comando2 = new MySqlCommand(String.Format(
                            "Select totdeuda.ntotaldeuda, saldeuda.nsaldodeuda from factura factu INNER JOIN deuda totdeuda on factu.ncodfactura=totdeuda.ncodfactura INNER JOIN deuda saldeuda on factu.ncodfactura=saldeuda.ncodfactura where factu.ncodfactura='" + inumerofactura + "'"), clasConexion.funConexion());
                            MySqlDataReader _reader2 = _comando2.ExecuteReader();

                            
                            while (_reader2.Read())
                            {
                                int contador=0;
                                contador++;
                                 itotaldeuda= _reader2.GetString(0);
                                 isaldodeuda = _reader2.GetString(1);
                                 /*System.Console.WriteLine("prueba: " + snombrepersona);
                                 System.Console.WriteLine("prueba: " + sapellidopersona);
                                 System.Console.WriteLine("prueba: " + inumerofactura);
                                 System.Console.WriteLine("prueba: " + dfechafactura);
                                 System.Console.WriteLine("prueba: " + itotaldeuda);
                                 System.Console.WriteLine("prueba: " + isaldodeuda);*/
                                //-------Agregando informacion a data grid
                                 grdDeuda.Rows.Add(snombrepersona,sapellidopersona,inumerofactura,dfechafactura,itotaldeuda,isaldodeuda);
                            }
                        }
                        catch {
                            MessageBox.Show("Error en en busqueda de deuda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } 
                       

                    }
                
                }catch(MySqlException ex){
                    MessageBox.Show("Error en en busqueda de factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
    
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grdDeuda.Rows.Clear(); //limpia el grid
        }
    }
}
