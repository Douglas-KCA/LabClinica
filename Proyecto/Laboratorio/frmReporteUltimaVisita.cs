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
    public partial class frmReporteUltimaVisita : Form
    {
        String sCodigo, sEmpleado, sExamen, sSucursal;

        public frmReporteUltimaVisita()
        {
            InitializeComponent();
            funCargarCombos();
        }

        private void funCargarCombos()
        {
            String sPaciente;
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona IN (SELECT ncodpersona FROM TrPACIENTE)"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();
                while (mReader.Read())
                {
                    sPaciente = mReader.GetString(0) + " " + mReader.GetString(1);
                    cmbPaciente.Items.Add(sPaciente);
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String[] Nombres = cmbPaciente.Text.Split(' ');

            Document doc = new Document(PageSize.LETTER);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("UltimaVisita"+cmbPaciente.Text + ".pdf", FileMode.Create));
            doc.AddTitle("Ultima Visita " + cmbPaciente.Text);
            doc.AddCreator("Josue Revolorio");
            doc.Open();

            iTextSharp.text.Font fFontTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font fFontSubTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font fFontCuerpo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            iTextSharp.text.Image imagenEncabezado = iTextSharp.text.Image.GetInstance(@"C:\laboratoriologo.png");
            imagenEncabezado.Alignment = Element.ALIGN_LEFT;
            imagenEncabezado.ScaleToFit(50f, 50f);

            doc.Add(imagenEncabezado);

            Paragraph parrafoTitulo = new Paragraph("ULTIMA VISITA DEL PACIENTE", fFontTitulo);
            parrafoTitulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(parrafoTitulo);

            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT MAX(choracita), ncodigocita FROM TrCITA WHERE ncodigocita IN (SELECT ncodigocita "+
                    "FROM TrCITA WHERE dfechacita = (SELECT MAX(dfechacita) FROM TrCITA WHERE ncodpaciente = (SELECT ncodpaciente FROM TrPACIENTE WHERE ncodpersona "+
                    "= (SELECT ncodpersona FROM MaPERSONA WHERE cnombrepersona = '{0}' AND capellidopersona = '{1}')) AND dfechacita <= CURRENT_DATE))", Nombres[0], Nombres[1]), clasConexion.funConexion());

                MySqlDataReader mReader = mComando.ExecuteReader();
                if (mReader.Read())
                {
                    sCodigo = mReader.GetString(1);
                    //MessageBox.Show(sCodigo);
                    MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT MaPERSONA.cnombrepersona, MaPERSONA.capellidopersona,"+
                    " MaSUCURSAL.cnombresucursal, MaTIPOEXAMEN.cdesctipoexamen FROM MaPERSONA, MaSUCURSAL, TrCITA, TrEMPLEADO, MaTIPOEXAMEN, "+
                    "TrSERVICIO WHERE MaSUCURSAL.ncodsucursal = TrCITA.ncodsucursal AND TrEMPLEADO.ncodempleado = TrCITA.ncodempleado AND MaPERSONA.ncodpersona "+
                    "= TrEMPLEADO.ncodpersona AND MaTIPOEXAMEN.ncodtipo = TrSERVICIO.ncodtipo AND TrSERVICIO.ncodigocita = TrCITA.ncodigocita AND "+
                    "TrCITA.ncodigocita = '{0}'", sCodigo), clasConexion.funConexion());
                    MySqlDataReader mReader2 = mComando2.ExecuteReader();
                    if (mReader2.Read())
                    {
                        Paragraph parrafoSubTitulo = new Paragraph("\n" + (cmbPaciente.Text).ToUpper(), fFontSubTitulo);
                        parrafoSubTitulo.Alignment = Element.ALIGN_CENTER;
                        doc.Add(parrafoSubTitulo);
                        
                        sEmpleado = mReader2.GetString(0) + " " + mReader2.GetString(1);
                        sSucursal = mReader2.GetString(2);
                        Paragraph parrafoDatosCita = new Paragraph(("\nSUCURSAL: " + sSucursal + "\nEMPLEADO: " + sEmpleado).ToUpper() +
                        "\n_______________________________________________________________________________________________", fFontSubTitulo);
                        parrafoDatosCita.Alignment = Element.ALIGN_CENTER;
                        doc.Add(parrafoDatosCita);
                        Paragraph parrafoSUBTITULO2 = new Paragraph(("\nEXAMENES: " + sEmpleado).ToUpper(), fFontSubTitulo);
                        parrafoDatosCita.Alignment = Element.ALIGN_CENTER;
                        doc.Add(parrafoSUBTITULO2);

                    }

                    while(mReader2.Read()){
                        sExamen = mReader2.GetString(3);
                        //MessageBox.Show(sEmpleado + " " + sSucursal + " " + sExamen);
                        Paragraph parrafoExamen = new Paragraph("\n"+sExamen, fFontCuerpo);
                        parrafoExamen.Alignment = Element.ALIGN_LEFT;
                        doc.Add(parrafoExamen);
            
                    }
                    MessageBox.Show("Reporte Generado con Exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Se produjo un error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            doc.Close();
            writer.Close();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
