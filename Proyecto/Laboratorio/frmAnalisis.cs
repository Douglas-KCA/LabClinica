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
/*---------------------------------------------------------------------------------------------------------------------------------
   Programador y Analista: Josue Revolorio
   * Fecha de asignacion: 03/08/2015
   * Fecha de entrega: 07/08/2015
---------------------------------------------------------------------------------------------------------------------------------*/

    public partial class frmAnalisis : Form
    {
        string path;

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que carga los componentes iniciales del form
        ---------------------------------------------------------------------------------------------------------------------------------*/
        public frmAnalisis()
        {
            InitializeComponent();
            funCargarCombos();
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que carga los datos a los combos del programa al iniciar el form
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void funCargarCombos()
        {
            String sMuestra, sPaciente;
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT ncodmuestra, ncodpaciente FROM MaETIQUETA", ""), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();
                while (mReader.Read())
                {
                    sMuestra = mReader.GetString(0);
                    sPaciente = mReader.GetString(1);

                    MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cdescmuestra FROM MaMUESTRA WHERE ncodmuestra = '{0}'", sMuestra), clasConexion.funConexion());
                    MySqlDataReader mReader2 = mComando2.ExecuteReader();
                    if(mReader2.Read())
                        sMuestra = mReader2.GetString(0);

                    MySqlCommand mComando3 = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona = (SELECT ncodpersona FROM TrPaciente WHERE ncodpaciente = '{0}')", sPaciente), clasConexion.funConexion());
                    MySqlDataReader mReader3 = mComando3.ExecuteReader();
                    if (mReader3.Read())
                    {
                        sPaciente = mReader3.GetString(0) +" "+ mReader3.GetString(1);
                        cmbEtiqueta.Items.Add(sPaciente + "-" + sMuestra);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que genera un archivo PDF en el escritorio con el analisis realizado por el empleado
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void funReporteAnalisis()
        {
            Document doc = new Document(PageSize.LETTER);
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string ruta = path + "/Analisis-";
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(ruta + cmbEtiqueta.Text + ".pdf", FileMode.Create));
            

            doc.AddTitle("Analisis "+cmbEtiqueta.Text);
            doc.AddCreator("Josue Revolorio");
            doc.Open();
            
            iTextSharp.text.Font fFontTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font fFontSubTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font fFontCuerpo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            string mdoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);  //C:\Users\Usuario\Documents
            string ruta2 = mdoc + "/GitHub/LabClinica/Proyecto/Laboratorio/Img/laboratoriologo.png";
            iTextSharp.text.Image imagenEncabezado = iTextSharp.text.Image.GetInstance(ruta2);
            imagenEncabezado.Alignment = Element.ALIGN_LEFT;
            imagenEncabezado.ScaleToFit(50f, 50f);

            doc.Add(imagenEncabezado);
            
            Paragraph parrafoTitulo = new Paragraph("RESULTADOS DE ANALISIS",fFontTitulo);
            parrafoTitulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(parrafoTitulo);
            
            Paragraph parrafoSubTitulo = new Paragraph("\n" + (cmbEtiqueta.Text).ToUpper()+
                "\n________________________________________________________________________________", fFontSubTitulo);
            parrafoSubTitulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(parrafoSubTitulo);
            
            Paragraph parrafoCuerpo = new Paragraph(txtAnalisis.Text, fFontCuerpo);
            doc.Add(parrafoCuerpo);

            
            

            doc.Close();
            writer.Close();
            

        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que Regresa al menu principal
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que limpia los textbox o combobox
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtAnalisis.Text = cmbEtiqueta.Text = "";
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que guarda los datos de la sucursal en la BD y las añade a la tabla en el form 
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmbEtiqueta.Text))
            {
                MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                String sEtiqueta = "";
                String[] datos = cmbEtiqueta.Text.Split('-');
                String[] nombres = datos[0].Split(' ');
                
                try
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format("SELECT ncodetiqueta FROM MaETIQUETA WHERE ncodmuestra = (SELECT ncodmuestra FROM MaMUESTRA WHERE cdescmuestra = '{0}') AND ncodpaciente = (SELECT ncodpaciente FROM TrPACIENTE WHERE ncodpersona = (SELECT ncodpersona FROM MaPersona WHERE cnombrepersona = '{1}' AND capellidopersona = '{2}'))", datos[1], nombres[0], nombres[1]), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();
                    if (mReader.Read())
                        sEtiqueta = mReader.GetString(0);

                    MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT ncodanalisis FROM TrANALISIS WHERE ncodetiqueta = '{0}'",sEtiqueta), clasConexion.funConexion());
                    MySqlDataReader mReader2 = mComando2.ExecuteReader();
                    if (mReader2.Read())
                    {
                        MessageBox.Show("Esa muestra ya tiene un analisis", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAnalisis.Text = cmbEtiqueta.Text = "";
                    }
                    else {
                        MySqlCommand comando = new MySqlCommand(string.Format("INSERT into TrANALISIS (cdescripcion, ncodetiqueta) values ('{0}','{1}')",
                            txtAnalisis.Text, sEtiqueta), clasConexion.funConexion());
                        comando.ExecuteNonQuery();
                        MessageBox.Show("El analisis se guardo exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        funReporteAnalisis();
                        txtAnalisis.Text = cmbEtiqueta.Text = "";
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Se produjo un error " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que abre un form para busqueda de etiquetas de una manera mas eficiente
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void button1_Click(object sender, EventArgs e)
        {
            frmBuscarEtiqueta ver = new frmBuscarEtiqueta("frmAnalisis", cmbEtiqueta.Text);
            ver.MdiParent = this.MdiParent;
            ver.Show();
            this.Close();
        }
    }
}
