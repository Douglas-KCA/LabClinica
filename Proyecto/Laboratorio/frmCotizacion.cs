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
    public partial class frmCotizacion : Form
    {
        string sExamen;
        string sPrecio;
        string sMuestra;
        string sCod;
        int iContador = 0;
        int iTotal = 0;
        string sCodigoFactura;
        string sCodigoCita;
        string sNpoliza;
        string sNombreAseguradora;
        public string sFecha;
        public string sCodigoPacienteFactura;

        public frmCotizacion()
        {
            InitializeComponent();
            funExamenes();
        }

        void funExamenes()
        {
            string sCodigo;
            string sDescripcionExamen;
            string sPrecioExamen;            
            cmbExamen.Items.Clear();
            MySqlCommand mComando = new MySqlCommand(String.Format("SELECT MaTIPOEXAMEN.ncodtipo, MaTIPOEXAMEN.cdesctipoexamen, MaTIPOEXAMEN.cpreciotipoexamen FROM MaTIPOEXAMEN"), clasConexion.funConexion());
            MySqlDataReader mReader = mComando.ExecuteReader();

            while (mReader.Read())
            {
                sCodigo = mReader.GetString(0);
                sDescripcionExamen = mReader.GetString(1);
                sPrecioExamen = mReader.GetString(2);               
                cmbExamen.Items.Add(sCodigo + ". " + sDescripcionExamen + " (" + sPrecioExamen + ")");
                sCodigo = "";
                sDescripcionExamen = "";
                sPrecioExamen = "";                
            }

        }

        void funCortador(string sCadena)
        {
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
                            
                        }
                    break;                    
                }
            }
        }

        void funFacturaPaciente()
        {
            DateTime fecha = DateTime.Now;
            // Creamos el documento con el tamaño de página tradicional
            Document doc = new Document(PageSize.LETTER);
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("Cotizacion-" + fecha.ToString() + ".pdf", FileMode.Create));

            // Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento
            doc.AddTitle("Cotizacion PDF");
            doc.AddCreator("Clinica");

            // Abrimos el archivo
            doc.Open();
            // Creamos el tipo de Font que vamos utilizar
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);


            // Creamos una tabla para el encabezado
            //PdfPTable tblEncabezado = new PdfPTable(2);
            //tblEncabezado.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            //PdfPCell clColumna1 = new PdfPCell(new Phrase("", _standardFont));
            //clColumna1.BorderWidth = 0;
            //PdfPCell clColumna2 = new PdfPCell(new Phrase("Fecha: " + sFecha, _standardFont));
            //clColumna2.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            //tblEncabezado.AddCell(clColumna1);
            //tblEncabezado.AddCell(clColumna2);


            //clColumna1 = new PdfPCell(new Phrase("Nombre: " + txtNombrePaciente.Text, _standardFont));
            //clColumna1.BorderWidth = 0;
            //clColumna2 = new PdfPCell(new Phrase("No. " + sCodigoFactura, _standardFont));
            //clColumna2.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            //tblEncabezado.AddCell(clColumna1);
            //tblEncabezado.AddCell(clColumna2);

            //clColumna1 = new PdfPCell(new Phrase("Nit: 3557338-4", _standardFont));
            //clColumna1.BorderWidth = 0;
            //clColumna2 = new PdfPCell(new Phrase("Direccion: Ciudad", _standardFont));
            //clColumna2.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            //tblEncabezado.AddCell(clColumna1);
            //tblEncabezado.AddCell(clColumna2);

            //Linea en blanco


            // Creamos una tabla para el detalle
            PdfPTable tblPrueba = new PdfPTable(3);
            tblPrueba.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clCantidad = new PdfPCell(new Phrase("Cantidad", _standardFont));
            clCantidad.BorderWidth = 0;
            clCantidad.BorderWidthBottom = 0.75f;

            PdfPCell clExamen = new PdfPCell(new Phrase("Examen", _standardFont));
            clExamen.BorderWidth = 0;
            clExamen.BorderWidthBottom = 0.75f;

            PdfPCell clPrecio = new PdfPCell(new Phrase("Precio", _standardFont));
            clPrecio.BorderWidth = 0;
            clPrecio.BorderWidthBottom = 0.75f;

            // Añadimos las columnas a la tabla
            tblPrueba.AddCell(clCantidad);
            tblPrueba.AddCell(clExamen);
            tblPrueba.AddCell(clPrecio);

            int iFila = grdDatosExamenes.RowCount;
            int iColumna = 1;
            string sExamen;
            string sPrecio;
            float iTotal = 0;
            float iPrecio;

            for (int i = 0; i < iFila - 1; i++)
            {
                for (iColumna = 1; iColumna < 2; iColumna++)
                {
                    sExamen = grdDatosExamenes.Rows[i].Cells[iColumna].Value.ToString();
                    sPrecio = grdDatosExamenes.Rows[i].Cells[iColumna + 1].Value.ToString();

                    iPrecio = float.Parse(sPrecio);
                    iTotal += iPrecio;
                    iPrecio = 0;

                    // Llenamos la tabla con información
                    clCantidad = new PdfPCell(new Phrase("1", _standardFont));
                    clCantidad.BorderWidth = 0;

                    clExamen = new PdfPCell(new Phrase(sExamen, _standardFont));
                    clExamen.BorderWidth = 0;

                    clPrecio = new PdfPCell(new Phrase(sPrecio, _standardFont));
                    clPrecio.BorderWidth = 0;

                    // Añadimos las celdas a la tabla
                    tblPrueba.AddCell(clCantidad);
                    tblPrueba.AddCell(clExamen);
                    tblPrueba.AddCell(clPrecio);

                    sExamen = "";
                    sPrecio = "";
                }
            }

            clCantidad = new PdfPCell(new Phrase("", _standardFont));
            clCantidad.BorderWidth = 0;
            clCantidad.BorderWidthBottom = 0.75f;

            clExamen = new PdfPCell(new Phrase("", _standardFont));
            clExamen.BorderWidth = 0;
            clExamen.BorderWidthBottom = 0.75f;

            clPrecio = new PdfPCell(new Phrase("", _standardFont));
            clPrecio.BorderWidth = 0;
            clPrecio.BorderWidthBottom = 0.75f;

            tblPrueba.AddCell(clCantidad);
            tblPrueba.AddCell(clExamen);
            tblPrueba.AddCell(clPrecio);

            clCantidad = new PdfPCell(new Phrase("", _standardFont));
            clCantidad.BorderWidth = 0;

            clExamen = new PdfPCell(new Phrase("", _standardFont));
            clExamen.BorderWidth = 0;

            clPrecio = new PdfPCell(new Phrase("TOTAL: " + txtTotal.Text, _standardFont));
            clPrecio.BorderWidth = 0;

            tblPrueba.AddCell(clCantidad);
            tblPrueba.AddCell(clExamen);
            tblPrueba.AddCell(clPrecio);

            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento

            //doc.Add(tblEncabezado);
            doc.Add(tblPrueba);

            doc.Close();
            writer.Close();

            //INSERCION EN LA TABLA DE DEUDA
            //int iCero = 0;
            //MySqlCommand comando2 = new MySqlCommand(string.Format("INSERT into MaDEUDA (ntotaldeuda, nsaldodeuda, ncodfactura, ncodtipopago, ccantpago) values ('{0}','{1}','{2}','{3}','{4}')",
            //iTotal, iTotal, sCodigoFactura, null, iCero), clasConexion.funConexion());
            //comando2.ExecuteNonQuery();

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
                grdDatosExamenes.Rows.Insert(iContador, sCod, sExamen, sPrecio);
                iTotal += Int32.Parse(sPrecio);
                txtTotal.Text = iTotal.ToString();
                iContador++;
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar el dato seleccionado?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sResta;
                sResta = grdDatosExamenes.Rows[grdDatosExamenes.CurrentRow.Index].Cells[2].Value.ToString();
                iTotal -= Int32.Parse(txtTotal.Text);
                grdDatosExamenes.Rows.RemoveAt(grdDatosExamenes.CurrentRow.Index);
                iContador--;
                MessageBox.Show("Dato eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
