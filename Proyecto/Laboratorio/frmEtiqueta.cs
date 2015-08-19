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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO; 

namespace Laboratorio
{
    public partial class frmEtiqueta : Form
    {
        /*
         * Programador: Kevin Cajbon
         * Fecha de Astignacion: 07 de agosto
         * Fecha de Entrega: 08 de Agosto
         *   
        */
        DateTime fecha = DateTime.Today;
        string sCadena;
        string sFecha;
        public frmEtiqueta()
        {
            sFecha = fecha.ToString("d");
            //lblFecha.Text = sFecha;
            InitializeComponent();
            funLlenarMuestra();
            //funLlenarPaciente();
        }

        string funCortador(string sDato)
        {
            sCadena = "";
            try
            {
                for (int i = 0; i < sDato.Length; i++)
                {
                    if (sDato.Substring(i, 1) != ".")
                    {
                        sCadena = sCadena + sDato.Substring(i, 1);
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
            return sCadena;
        }

        void funDatosEtiqueta() {
            //string sCodMuestra = "";
            //string sCodigoMuestra = "";
            //string sCodPaciente = "";
            //string sCodigoPaciente = "";
            lblTipoMuestra.Text = cmbCodMuestra.SelectedItem.ToString();
            //sCodMuestra = funCortador(sCodigoMuestra);
            lblInfoPaciente.Text = txtPaciente.Text;
            //sCodigoPaciente = funCortador(sCodPaciente);
            btnImprimir.Enabled = true;
            btnGuardar.Enabled = false;
        }

        void funLlenarMuestra() {
            string sCodigo;
            string sDescripcionMuestra;            
            int iContador = 0;
            cmbCodMuestra.Items.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT ncodmuestra, cdescmuestra FROM MaMUESTRA"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sDescripcionMuestra = mReader.GetString(1);                    
                    cmbCodMuestra.Items.Add(sCodigo + ". " + sDescripcionMuestra);
                    sCodigo = "";
                    sDescripcionMuestra = "";                    
                    iContador++;
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //sFecha = fecha.ToString("d");
                lblFecha.Text = sFecha;
                string sCodMuestra = "";
                string sCodigoMuestra = "";
                string sCodPaciente = "";
                string sCodigoPaciente = "";
                sCodigoMuestra = cmbCodMuestra.SelectedItem.ToString();
                sCodMuestra = funCortador(sCodigoMuestra);
                sCodigoPaciente = txtPaciente.Text;
                sCodPaciente = funCortador(sCodigoPaciente);
                //sCodigoPaciente = txtPaciente.Text;

                MySqlCommand mComando = new MySqlCommand(string.Format("Insert into MaETIQUETA (cfecetiqueta, ncodmuestra, ncodpaciente) values ('{0}', '{1}', '{2}')",
                    sFecha, sCodMuestra, sCodPaciente), clasConexion.funConexion());
                mComando.ExecuteNonQuery();
                MessageBox.Show("Se inserto con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                funDatosEtiqueta();
            }
            catch
            {
                MessageBox.Show("Seleccione los Valores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se imprime la Etiqueta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnGuardar.Enabled = true;
            btnImprimir.Enabled = false;

            //Generar PDF Etiqueta
            
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream("Etiqueta.pdf", FileMode.OpenOrCreate));
            document.Open();

            Chunk chunk = new Chunk("                                                       "+lblTipoMuestra.Text, FontFactory.GetFont("ARIAL", 11, iTextSharp.text.Font.NORMAL));
            document.Add(new Paragraph(chunk));

            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@"C:\codigo_barras.png");
            jpg.Alignment = iTextSharp.text.Image.MIDDLE_ALIGN;
            document.Add(jpg);
            Chunk chunk1 = new Chunk("                                                       " + lblInfoPaciente.Text, FontFactory.GetFont("ARIAL", 11, iTextSharp.text.Font.NORMAL));
            document.Add(new Paragraph(chunk1)); 
            document.Close();


        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPaciente_Click(object sender, EventArgs e)
        {
            frmConsultaPacienteEtiqueta ver = new frmConsultaPacienteEtiqueta();
            this.Hide();
            ver.Show();
        }
    }
}
