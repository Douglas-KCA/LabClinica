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
/*
 * Programador y analista: Diego Alberto Taracena Morales
 * Fecha de Entrega: 30 de agosto del 2015
 * 
 * 
 * */

namespace Laboratorio
{
    public partial class frmReporteRegistroClientes : Form
    {
        public frmReporteRegistroClientes()
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
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("Registro de Clientes.pdf", FileMode.Create));
            doc.AddTitle("Registro de Clientes");
            doc.AddCreator("Diego Taracena");
            doc.Open();

            iTextSharp.text.Font fFontTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font fFontSubTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font fFontCuerpo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            iTextSharp.text.Image imagenEncabezado = iTextSharp.text.Image.GetInstance(@"C:\laboratoriologo.png");
            imagenEncabezado.Alignment = Element.ALIGN_LEFT;
            imagenEncabezado.ScaleToFit(50f, 50f);

            doc.Add(imagenEncabezado);

            Paragraph parrafoTitulo = new Paragraph("Clientes Registrados", fFontTitulo);
            parrafoTitulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(parrafoTitulo);

            Paragraph parrafoTitulo3 = new Paragraph("\n", fFontTitulo);
            parrafoTitulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(parrafoTitulo3);

            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            // Creamos una tabla para el detalle
            PdfPTable tblPrueba = new PdfPTable(6);
            tblPrueba.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clCodigo = new PdfPCell(new Phrase("Codigo", _standardFont));
            clCodigo.BorderWidth = 0;
            clCodigo.BorderWidthBottom = 0.75f;

            PdfPCell clDpi = new PdfPCell(new Phrase("Dpi", _standardFont));
            clDpi.BorderWidth = 0;
            clDpi.BorderWidthBottom = 0.75f;

            PdfPCell clNombre = new PdfPCell(new Phrase("Nombre", _standardFont));
            clNombre.BorderWidth = 0;
            clNombre.BorderWidthBottom = 0.75f;

            PdfPCell clApellido = new PdfPCell(new Phrase("Apellido", _standardFont));
            clApellido.BorderWidth = 0;
            clApellido.BorderWidthBottom = 0.75f;

            PdfPCell clFecha = new PdfPCell(new Phrase("Fecha de Nacimiento", _standardFont));
            clFecha.BorderWidth = 0;
            clFecha.BorderWidthBottom = 0.75f;

            PdfPCell clNit = new PdfPCell(new Phrase("Nit", _standardFont));
            clNit.BorderWidth = 0;
            clNit.BorderWidthBottom = 0.75f;

            // Añadimos las columnas a la tabla
            tblPrueba.AddCell(clCodigo);
            tblPrueba.AddCell(clDpi);
            tblPrueba.AddCell(clNombre);
            tblPrueba.AddCell(clApellido);
            tblPrueba.AddCell(clFecha);
            tblPrueba.AddCell(clNit);

            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT MaPERSONA.ncodpersona, MaPERSONA.cnombrepersona, MaPERSONA.capellidopersona, MaPERSONA.cdpipersona, MaPERSONA.cnitpersona, MaPERSONA.dfechanacpersona from MaPERSONA, TrPACIENTE WHERE MaPERSONA.ncodpersona = TrPACIENTE.ncodpersona "), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                string sCodigo;
                string sNombre;
                string sApellido;
                string sDpi;
                string sNit;
                string sFecha;

                while (mReader.Read())
                {

                    sCodigo = mReader.GetString(0);
                    sNombre = mReader.GetString(1);
                    sApellido = mReader.GetString(2);
                    sDpi = mReader.GetString(3);
                    sNit = mReader.GetString(4);
                    sFecha = mReader.GetString(5);

                    // Llenamos la tabla con información
                    clCodigo = new PdfPCell(new Phrase(sCodigo, _standardFont));
                    clCodigo.BorderWidth = 0;

                    clDpi = new PdfPCell(new Phrase(sDpi, _standardFont));
                    clDpi.BorderWidth = 0;

                    clNombre = new PdfPCell(new Phrase(sNombre, _standardFont));
                    clNombre.BorderWidth = 0;

                    clApellido = new PdfPCell(new Phrase(sApellido, _standardFont));
                    clApellido.BorderWidth = 0;

                    clFecha = new PdfPCell(new Phrase(sFecha, _standardFont));
                    clFecha.BorderWidth = 0;

                    clNit = new PdfPCell(new Phrase(sNit, _standardFont));
                    clNit.BorderWidth = 0;

                    // Añadimos las celdas a la tabla
                    tblPrueba.AddCell(clCodigo);
                    tblPrueba.AddCell(clDpi);
                    tblPrueba.AddCell(clNombre);
                    tblPrueba.AddCell(clApellido);
                    tblPrueba.AddCell(clFecha);
                    tblPrueba.AddCell(clNit);
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
