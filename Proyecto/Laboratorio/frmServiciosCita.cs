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
    public partial class frmServiciosCita : Form
    {
        //string sCodigoPaciente;
        string sExamen;
        string sPrecio;
        string sMuestra;
        string sCod;
        int iContador = 0;
        string sCodigoFactura;
        string sCodigoCita;
        public frmServiciosCita()
        {
            InitializeComponent();
            //string sCodigoPaciente; ;
            //funNombrePaciente(sCodigoPaciente);
            funExamenes();
        }

        void funNombrePaciente(string sCodigo){
            string sNombre;
            string sApellidos;
            cmbExamen.Items.Clear();
            MySqlCommand mComando = new MySqlCommand(String.Format("SELECT MaPERSONA.cnombrepersona, MaPERSONA.capellidopersona FROM MaPERSONA, TrPACIENTE WHERE TrPACIENTE.ncodpersona=MaPERSONA.ncodpersona AND MaPERSONA='{0}'", sCodigo), clasConexion.funConexion());
            MySqlDataReader mReader = mComando.ExecuteReader();

            while (mReader.Read())
            {
                sNombre = mReader.GetString(0);
                sApellidos = mReader.GetString(1);
                txtNombrePaciente.Text = sNombre + " " + sApellidos;
                sNombre = "";
                sApellidos = "";
            }
        }

        void funExamenes()
        {
            string sCodigo;
            string sDescripcionExamen;
            string sPrecioExamen;
            string sDescripcionMuestra;
            cmbExamen.Items.Clear();
            MySqlCommand mComando = new MySqlCommand(String.Format("SELECT MaTIPOEXAMEN.ncodtipo, MaTIPOEXAMEN.cdesctipoexamen, MaTIPOEXAMEN.cpreciotipoexamen, MaMUESTRA.cdescmuestra FROM MaTIPOEXAMEN, MaMUESTRA WHERE MaTIPOEXAMEN.ncodmuestra=MaMUESTRA.ncodmuestra"), clasConexion.funConexion());
            MySqlDataReader mReader = mComando.ExecuteReader();

            while (mReader.Read())
            {
                sCodigo = mReader.GetString(0);
                sDescripcionExamen = mReader.GetString(1);
                sPrecioExamen = mReader.GetString(2);
                sDescripcionMuestra = mReader.GetString(3);
                cmbExamen.Items.Add(sCodigo + ". " + sDescripcionExamen +" ("+sPrecioExamen+") -------- "+ sDescripcionMuestra+".");
                sCodigo = "";
                sDescripcionExamen = "";
                sPrecioExamen = "";
                sDescripcionMuestra = "";
            }

        }

        void funCodigos()
        {
            MySqlCommand mComando = new MySqlCommand(String.Format("SELECT MAX(MaFACTURA.ncodfactura), MAX(TrCITA.ncodigocita) FROM MaFACTURA, TrCITA"), clasConexion.funConexion());
            MySqlDataReader mReader = mComando.ExecuteReader();

            while (mReader.Read())
            {
                sCodigoFactura = mReader.GetString(0);
                sCodigoCita = mReader.GetString(1);
            }
        }

        void funCortador(string sCadena){
            //string sCadena = textBox1.Text;
            sExamen = "";
            sPrecio = "";
            sMuestra = "";
            sCod = "";
            int estado = 0;
            //int cont = 0;
            for (int i = 0; i < sCadena.Length; i++)
            {
                switch (estado)
                {
                    case 0:
                        if (sCadena.Substring(i, 1) != ".")
                        {
                            sCod = sCod + sCadena.Substring(i, 1);
                        }
                        else
                        {
                            //System.Console.WriteLine(sCod);
                            i++;
                            estado = 1;
                        }
                    break;
                    case 1:
                        if (sCadena.Substring(i, 1) != "(")
                        {
                            sExamen = sExamen + sCadena.Substring(i, 1);
                        }
                        else
                        {
                            //System.Console.WriteLine(sExamen);
                            //cont = i;
                            estado = 2;
                        }
                    break;
                    case 2:
                        if (sCadena.Substring(i, 1) != ")")
                        {
                            sPrecio = sPrecio + sCadena.Substring(i, 1);
                        }
                        else
                        {
                            //System.Console.WriteLine(sPrecio);
                            i = i + 10;
                            estado = 3;
                        }
                    break;
                    case 3:
                        if (sCadena.Substring(i, 1) != ".")
                        {
                            sMuestra = sMuestra + sCadena.Substring(i, 1);
                        }
                        else
                        {
                            //System.Console.WriteLine(sMuestra);
                        }
                    break;

                }
            }
        }

        void funInsertar()
        {
            string sCodExamen="";
            int iFila = grdDatosExamenes.RowCount;
            funCodigos();            
            for (int i = 0; i < iFila-1;i++)
            {              
                sCodExamen= grdDatosExamenes.Rows[i].Cells[0].Value.ToString();                

                MySqlCommand comando2 = new MySqlCommand(string.Format("INSERT into TrSERVICIO (ncodfactura, ncodigocita, ncodtipo) values ('{0}','{1}','{2}')",
                sCodigoFactura, sCodigoCita, sCodExamen), clasConexion.funConexion());
                comando2.ExecuteNonQuery();
                sCodExamen = "";
            }
            MessageBox.Show("La Datos se guardaron con Exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string sCadena = cmbExamen.SelectedItem.ToString();
            if (string.IsNullOrEmpty(sCadena))
            {
                MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                funCortador(sCadena);
                grdDatosExamenes.Rows.Insert(iContador, sCod, sExamen, sPrecio, sMuestra);
                iContador++;
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea guardar los datos?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                funInsertar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar el dato seleccionado?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                grdDatosExamenes.Rows.RemoveAt(grdDatosExamenes.CurrentRow.Index);
                iContador--;
                MessageBox.Show("Dato eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
