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
    public partial class frmReporteTipoExamen : Form
    {
        string sCodigo;
        string sNombre;
        public frmReporteTipoExamen()
        {
            InitializeComponent();
            funCmbTipoExamen();
        }

        void funCmbTipoExamen()
        {
            string sCodigo;
            string sNombre;
            cmbTipoExamen.Items.Clear();

            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT ncodtipo, cdesctipoexamen FROM MaTIPOEXAMEN "), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        sCodigo = mReader.GetString(0);
                        sNombre = mReader.GetString(1);
                        cmbTipoExamen.Items.Add(sCodigo + ". " + sNombre);
                        sCodigo = "";
                        sNombre = "";
                    } 
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void funCortador()
        {
            string sCadena = cmbTipoExamen.SelectedItem.ToString()+"(";
            sCodigo = "";
            sNombre = "";
            int estado = 0;
            //int cont = 0;
            for (int i = 0; i < sCadena.Length; i++)
            {
                switch (estado)
                {
                    case 0:
                        if (sCadena.Substring(i, 1) != ".")
                        {
                            sCodigo += sCadena.Substring(i, 1);
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
                            sNombre += sCadena.Substring(i, 1);
                        }
                        else
                        {
                            //System.Console.WriteLine(sExamen);
                            //cont = i;
                        }
                    break;

                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            funCortador();
            //System.Console.WriteLine("Codigo: "+sCodigo+" Nombre: "+sNombre);
            
            Document doc = new Document(PageSize.LETTER);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("Reporte, Examen " + sNombre + ".pdf", FileMode.Create));
            doc.AddTitle("Reporte Examen " + sNombre);
            doc.AddCreator("Dylan Corado");
            doc.Open();

            iTextSharp.text.Font fFontTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font fFontSubTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font fFontCuerpo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            iTextSharp.text.Image imagenEncabezado = iTextSharp.text.Image.GetInstance(@"C:\laboratoriologo.png");
            imagenEncabezado.Alignment = Element.ALIGN_LEFT;
            imagenEncabezado.ScaleToFit(50f, 50f);

            doc.Add(imagenEncabezado);

            Paragraph parrafoTitulo = new Paragraph("TIPO DE EXAMEN \n"+sNombre, fFontTitulo);
            parrafoTitulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(parrafoTitulo);

            Paragraph parrafoTitulo3 = new Paragraph("\n", fFontTitulo);
            parrafoTitulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(parrafoTitulo3);

            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            // Creamos una tabla para el detalle
            PdfPTable tblPrueba = new PdfPTable(3);
            tblPrueba.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clPaciente = new PdfPCell(new Phrase("Paciente", _standardFont));
            clPaciente.BorderWidth = 0;
            clPaciente.BorderWidthBottom = 0.75f;

            PdfPCell clFecha = new PdfPCell(new Phrase("Fecha", _standardFont));
            clFecha.BorderWidth = 0;
            clFecha.BorderWidthBottom = 0.75f;

            PdfPCell clHora = new PdfPCell(new Phrase("Hora", _standardFont));
            clHora.BorderWidth = 0;
            clHora.BorderWidthBottom = 0.75f;

            // Añadimos las columnas a la tabla
            tblPrueba.AddCell(clPaciente);
            tblPrueba.AddCell(clFecha);
            tblPrueba.AddCell(clHora);

            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT MaPERSONA.cnombrepersona, MaPERSONA.capellidopersona, TrCITA.dfechacita, TrCITA.choracita FROM MaPERSONA, TrSERVICIO, TrPACIENTE, MaFACTURA, TrCITA WHERE MaPERSONA.ncodpersona = TrPACIENTE.ncodpersona AND MaFACTURA.ncodfactura = TrSERVICIO.ncodfactura AND MaFACTURA.ncodpaciente = TrPACIENTE.ncodpaciente AND TrSERVICIO.ncodigocita = TrCITA.ncodigocita AND TrSERVICIO.ncodtipo = '{0}'", sCodigo), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                string sNombrePaciente;
                string sFecha;
                string sHora;

                while (mReader.Read())
                {

                    sNombrePaciente = mReader.GetString(0) + " " + mReader.GetString(1);
                    sFecha = mReader.GetString(2);
                    sHora = mReader.GetString(3);

                    // Llenamos la tabla con información
                    clPaciente = new PdfPCell(new Phrase(sNombrePaciente, _standardFont));
                    clPaciente.BorderWidth = 0;

                    clFecha = new PdfPCell(new Phrase(sFecha, _standardFont));
                    clFecha.BorderWidth = 0;

                    clHora = new PdfPCell(new Phrase(sHora, _standardFont));
                    clHora.BorderWidth = 0;

                    // Añadimos las celdas a la tabla
                    tblPrueba.AddCell(clPaciente);
                    tblPrueba.AddCell(clFecha);
                    tblPrueba.AddCell(clHora);
                }

                // Finalmente, añadimos la tabla al documento PDF y cerramos el documento

                doc.Add(tblPrueba);

                doc.Close();
                writer.Close();
                MessageBox.Show("Reporte Generado con Exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Se produjo un error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
            
            
                
        }
    }
}
