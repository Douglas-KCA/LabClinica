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
    public partial class frmReporteDisponibilidad : Form
    {
        public frmReporteDisponibilidad()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Document doc = new Document(PageSize.LETTER);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("Disponibilidad para el cliente.pdf", FileMode.Create));
            doc.AddTitle("Disponibilidad para el cliente");
            doc.AddCreator("Dylan Corado");
            doc.Open();

            iTextSharp.text.Font fFontTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font fFontSubTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font fFontCuerpo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            iTextSharp.text.Image imagenEncabezado = iTextSharp.text.Image.GetInstance(@"C:\laboratoriologo.png");
            imagenEncabezado.Alignment = Element.ALIGN_LEFT;
            imagenEncabezado.ScaleToFit(50f, 50f);

            doc.Add(imagenEncabezado);

            Paragraph parrafoTitulo = new Paragraph("INSTRUCCIONES PARA EXAMENES", fFontTitulo);
            parrafoTitulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(parrafoTitulo);

            Paragraph parrafoTitulo3 = new Paragraph("\n", fFontTitulo);
            parrafoTitulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(parrafoTitulo3);

            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            // Creamos una tabla para el detalle
            PdfPTable tblPrueba = new PdfPTable(4);
            tblPrueba.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clExamen = new PdfPCell(new Phrase("Examen", _standardFont));
            clExamen.BorderWidth = 0;
            clExamen.BorderWidthBottom = 0.75f;

            PdfPCell clRequerimientos = new PdfPCell(new Phrase("Requerimientos", _standardFont));
            clRequerimientos.BorderWidth = 0;
            clRequerimientos.BorderWidthBottom = 0.75f;

            PdfPCell clMuestra = new PdfPCell(new Phrase("Muestra", _standardFont));
            clMuestra.BorderWidth = 0;
            clMuestra.BorderWidthBottom = 0.75f;

            PdfPCell clPrecio = new PdfPCell(new Phrase("Precio", _standardFont));
            clPrecio.BorderWidth = 0;
            clPrecio.BorderWidthBottom = 0.75f;

            // Añadimos las columnas a la tabla
            tblPrueba.AddCell(clExamen);
            tblPrueba.AddCell(clRequerimientos);
            tblPrueba.AddCell(clMuestra);
            tblPrueba.AddCell(clPrecio);

            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT MaTIPOEXAMEN.cdesctipoexamen, MaMUESTRA.crequerimientos, MaMUESTRA.cdescmuestra, MaTIPOEXAMEN.cpreciotipoexamen FROM MaTIPOEXAMEN, MaMUESTRA WHERE MaTIPOEXAMEN.ncodmuestra = MaMUESTRA.ncodmuestra"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                string sExamen;
                string sRequerimientos;
                string sMuestra;
                string sPrecio;

                while (mReader.Read())
                {

                    sExamen = mReader.GetString(0);
                    sRequerimientos = mReader.GetString(1);
                    sMuestra = mReader.GetString(2);
                    sPrecio = mReader.GetString(3);

                    // Llenamos la tabla con información
                    clExamen = new PdfPCell(new Phrase(sExamen, _standardFont));
                    clExamen.BorderWidth = 0;

                    clRequerimientos = new PdfPCell(new Phrase(sRequerimientos, _standardFont));
                    clRequerimientos.BorderWidth = 0;

                    clMuestra = new PdfPCell(new Phrase(sMuestra, _standardFont));
                    clMuestra.BorderWidth = 0;

                    clPrecio = new PdfPCell(new Phrase(sPrecio, _standardFont));
                    clPrecio.BorderWidth = 0;

                    // Añadimos las celdas a la tabla
                    tblPrueba.AddCell(clExamen);
                    tblPrueba.AddCell(clRequerimientos);
                    tblPrueba.AddCell(clMuestra);
                    tblPrueba.AddCell(clPrecio);
                }

                // Finalmente, añadimos la tabla al documento PDF y cerramos el documento

                doc.Add(tblPrueba);

                doc.Close();
                writer.Close();
                MessageBox.Show("Reporte Generado con Exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }
    }
}
