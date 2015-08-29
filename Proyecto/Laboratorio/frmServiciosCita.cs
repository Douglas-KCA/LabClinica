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
        string sNpoliza;
        string sNombreAseguradora;
        public string sFecha;
        public string sCodigoPacienteFactura;
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

        void funTipoFactura()
        {
            string sTipoFactura="";
            MySqlCommand mComando = new MySqlCommand(String.Format("SELECT ctipofactura FROM MaFACTURA WHERE ncodfactura ='{0}'",sCodigoFactura), clasConexion.funConexion());
            MySqlDataReader mReader = mComando.ExecuteReader();

            while (mReader.Read())
            {
                sTipoFactura = mReader.GetString(0).Trim();
            }

            if(sTipoFactura.Equals("paciente"))
            {
                funFacturaPaciente();
            }else
            {
                funFacturaPaciente();
                funFacturaAseguradora();
            }
        }

        void funDatosAseguradora()
        {
            MySqlCommand mComando = new MySqlCommand(String.Format("SELECT npoliza, cempresaseguro FROM TrSEGURO, MaASEGURADORA WHERE TrSEGURO.ncodpaciente = '{0}' AND TrSEGURO.ncodaseguradora = MaASEGURADORA.ncodaseguradora", sCodigoPacienteFactura), clasConexion.funConexion());
            MySqlDataReader mReader = mComando.ExecuteReader();

            while (mReader.Read())
            {
                sNpoliza = mReader.GetString(0);
                sNombreAseguradora = mReader.GetString(1);
            }
        }

        void funFacturaPaciente()
        {
            
            // Creamos el documento con el tamaño de página tradicional
            Document doc = new Document(PageSize.LETTER);
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("Factura-" + txtNombrePaciente.Text + ".pdf", FileMode.Create));

            // Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento
            doc.AddTitle("Mi primer PDF");
            doc.AddCreator("Dylan Corado");

            // Abrimos el archivo
            doc.Open();
            // Creamos el tipo de Font que vamos utilizar
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);


            // Creamos una tabla para el encabezado
            PdfPTable tblEncabezado = new PdfPTable(2);
            tblEncabezado.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clColumna1 = new PdfPCell(new Phrase("", _standardFont));
            clColumna1.BorderWidth = 0;
            PdfPCell clColumna2 = new PdfPCell(new Phrase("Fecha: " + sFecha, _standardFont));
            clColumna2.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblEncabezado.AddCell(clColumna1);
            tblEncabezado.AddCell(clColumna2);


            clColumna1 = new PdfPCell(new Phrase("Nombre: " + txtNombrePaciente.Text, _standardFont));
            clColumna1.BorderWidth = 0;
            clColumna2 = new PdfPCell(new Phrase("No. "+ sCodigoFactura, _standardFont));
            clColumna2.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblEncabezado.AddCell(clColumna1);
            tblEncabezado.AddCell(clColumna2);

            clColumna1 = new PdfPCell(new Phrase("Nit: 3557338-4", _standardFont));
            clColumna1.BorderWidth = 0;
            clColumna2 = new PdfPCell(new Phrase("Direccion: Ciudad", _standardFont));
            clColumna2.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblEncabezado.AddCell(clColumna1);
            tblEncabezado.AddCell(clColumna2);

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
            float iTotal=0;
            float iPrecio;
            
            for (int i = 0; i < iFila - 1; i++)
            {
                for (iColumna = 1; iColumna <2;  iColumna++)
                {
                    sExamen = grdDatosExamenes.Rows[i].Cells[iColumna].Value.ToString();
                    sPrecio = grdDatosExamenes.Rows[i].Cells[iColumna+1].Value.ToString();

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
            
            clPrecio = new PdfPCell(new Phrase("TOTAL: " + iTotal, _standardFont));
            clPrecio.BorderWidth = 0;

            tblPrueba.AddCell(clCantidad);
            tblPrueba.AddCell(clExamen);
            tblPrueba.AddCell(clPrecio);
            
            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            
            doc.Add(tblEncabezado);
            doc.Add(tblPrueba);

            doc.Close();
            writer.Close();

            //INSERCION EN LA TABLA DE DEUDA
            int iCero = 0;
            MySqlCommand comando2 = new MySqlCommand(string.Format("INSERT into MaDEUDA (ntotaldeuda, nsaldodeuda, ncodfactura, ncodtipopago, ccantpago) values ('{0}','{1}','{2}','{3}','{4}')",
            iTotal, iTotal, sCodigoFactura, null, iCero), clasConexion.funConexion());
            comando2.ExecuteNonQuery();

        }

        void funFacturaAseguradora()
        {
            funDatosAseguradora();
            // Creamos el documento con el tamaño de página tradicional
            Document doc = new Document(PageSize.LETTER);
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\DylanIsaac\Desktop\Aseguradora-" + txtNombrePaciente.Text + ".pdf", FileMode.Create));

            // Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento
            doc.AddTitle("Mi primer PDF");
            doc.AddCreator("Dylan Corado");

            // Abrimos el archivo
            doc.Open();
            // Creamos el tipo de Font que vamos utilizar
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);


            // Creamos una tabla para el encabezado
            PdfPTable tblEncabezado = new PdfPTable(2);
            tblEncabezado.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clColumna1 = new PdfPCell(new Phrase("", _standardFont));
            clColumna1.BorderWidth = 0;
            PdfPCell clColumna2 = new PdfPCell(new Phrase("Fecha: " + sFecha, _standardFont));
            clColumna2.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblEncabezado.AddCell(clColumna1);
            tblEncabezado.AddCell(clColumna2);

            // Configuramos el título de las columnas de la tabla
            clColumna1 = new PdfPCell(new Phrase("No. Poliza: "+sNpoliza+", Aseguradora: "+sNombreAseguradora, _standardFont));
            clColumna1.BorderWidth = 0;
            clColumna2 = new PdfPCell(new Phrase("", _standardFont));
            clColumna2.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblEncabezado.AddCell(clColumna1);
            tblEncabezado.AddCell(clColumna2);


            clColumna1 = new PdfPCell(new Phrase("Nombre: " + txtNombrePaciente.Text, _standardFont));
            clColumna1.BorderWidth = 0;
            clColumna2 = new PdfPCell(new Phrase("No. "+ sCodigoFactura, _standardFont));
            clColumna2.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblEncabezado.AddCell(clColumna1);
            tblEncabezado.AddCell(clColumna2);

            clColumna1 = new PdfPCell(new Phrase("Nit: 3557338-4", _standardFont));
            clColumna1.BorderWidth = 0;
            clColumna2 = new PdfPCell(new Phrase("Direccion: Ciudad", _standardFont));
            clColumna2.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblEncabezado.AddCell(clColumna1);
            tblEncabezado.AddCell(clColumna2);

            //Linea en blanco
            clColumna1 = new PdfPCell(new Phrase("", _standardFont));
            clColumna1.BorderWidth = 0;
            clColumna2 = new PdfPCell(new Phrase("", _standardFont));
            clColumna2.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblEncabezado.AddCell(clColumna1);
            tblEncabezado.AddCell(clColumna2);

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
            float iTotal=0;
            float iPrecio;
            
            for (int i = 0; i < iFila - 1; i++)
            {
                for (iColumna = 1; iColumna <2;  iColumna++)
                {
                    sExamen = grdDatosExamenes.Rows[i].Cells[iColumna].Value.ToString();
                    sPrecio = grdDatosExamenes.Rows[i].Cells[iColumna+1].Value.ToString();

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
            
            clPrecio = new PdfPCell(new Phrase("TOTAL: " + iTotal, _standardFont));
            clPrecio.BorderWidth = 0;

            tblPrueba.AddCell(clCantidad);
            tblPrueba.AddCell(clExamen);
            tblPrueba.AddCell(clPrecio);
            
            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            
            doc.Add(tblEncabezado);
            doc.Add(tblPrueba);

            doc.Close();
            writer.Close();
        
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
                funTipoFactura();
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
