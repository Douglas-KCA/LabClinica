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

/*
 * Programador: Diego Taracena
 * Fecha de asignacion: 11 de agosto
 * Fecha de entrega: 16 de agosto
 * */

namespace Laboratorio
{

    public partial class frmConsultaSeguro : Form
    {

        string sCadena;
        string sCodigoTabla;
        public frmConsultaSeguro()
        {
            InitializeComponent();
            funActualizar();
            funBuscarAseguro();
            funBuscarTarifa();
        }

        void funCancelar()
        {
            
            txtActualizarDeducible.Clear();
            btnBuscar.Enabled = true;
            cmbAseguradora.Enabled = true;
            grpActualizar.Enabled = false;
            btnActualizar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
            funActualizar();
            //grdConsultaMembresia.LostFocus=0;
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

        void funActualizar()
        {
            string sCodigo;
            string sTarifa;
            string sAseguradora;
            string sDeducible;
            int iContador = 0;
            grdPuesto.Rows.Clear();

            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT TrSEGURO.ncodseguro as codigo, MaASEGURADORA.cempresaseguro as aseguradora, MaTARIFASEGURO.nporcentajetarifa as tarifa, TrSEGURO.ndeducible as deducible from TrSEGURO, MaASEGURADORA, MaTARIFASEGURO where TrSEGURO.ncodtarifa = MaTARIFASEGURO.ncodtarifa and TrSEGURO.ncodaseguradora = MaASEGURADORA.ncodaseguradora"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sAseguradora = mReader.GetString(1);
                    sTarifa = mReader.GetString(2);
                    sDeducible = mReader.GetString(3);
                    grdPuesto.Rows.Insert(iContador, sCodigo, sAseguradora, sTarifa, sDeducible);
                    sCodigo = "";
                    sTarifa = "";
                    sAseguradora = "";
                    sDeducible = "";
                    iContador++;
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            funBuscarAseguro();
            funBuscarTarifa();

        }

        void funBuscarTarifa()
        {
            string sCodigo;
            string sTarifa;
            int iContador = 0;
            cmbActualizarTarifa.Items.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT ncodtarifa, nporcentajetarifa FROM MaTARIFASEGURO"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sTarifa = mReader.GetString(1);
                    cmbActualizarTarifa.Items.Add(sCodigo + ". Tarifa: " + sTarifa);
                    sCodigo = "";
                    sTarifa = "";
                    iContador++;
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        void funBuscarAseguro()
        {
            string sCodigo;
            string sSeguro;
            int iContador = 0;
            cmbAseguradora.Items.Clear();
            cmbActualizarAseguradora.Items.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT ncodaseguradora, cempresaseguro FROM MaASEGURADORA"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sSeguro = mReader.GetString(1);
                    cmbAseguradora.Items.Add(sCodigo + ". " + sSeguro);
                    cmbActualizarAseguradora.Items.Add(sCodigo + ". " + sSeguro);
                    sCodigo = "";
                    sSeguro = "";
                    iContador++;
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sCodigo, sTarifa, sDeducible;
            string sAseguradora, sCodAseguradora;
            int iContador = 0;
            bool existe = false;
            grdPuesto.Rows.Clear();

            try
            {
                sCodAseguradora = funCortador(cmbAseguradora.SelectedItem.ToString());
                    MySqlCommand mComando = new MySqlCommand(String.Format(
                    "SELECT TrSEGURO.ncodseguro as codigo, MaASEGURADORA.cempresaseguro as aseguradora, MaTARIFASEGURO.nporcentajetarifa as tarifa, TrSEGURO.ndeducible as deducible from TrSEGURO, MaASEGURADORA, MaTARIFASEGURO where TrSEGURO.ncodtarifa = MaTARIFASEGURO.ncodtarifa and TrSEGURO.ncodaseguradora = MaASEGURADORA.ncodaseguradora and TrSEGURO.ncodaseguradora = '{0}' ", sCodAseguradora), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        existe = true;
                        sCodigo = mReader.GetString(0);
                        sAseguradora = mReader.GetString(1);
                        sTarifa = mReader.GetString(2);
                        sDeducible = mReader.GetString(3);
                        grdPuesto.Rows.Insert(iContador, sCodigo, sAseguradora, sTarifa, sDeducible);
                        sCodigo = "";
                        sAseguradora = "";
                        sTarifa = "";
                        sDeducible = "";
                        iContador++;
                    }


                    btnCancelar.Enabled = true;
                    if (existe == false)
                    {
                        MessageBox.Show("No se encontraron resultados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        funActualizar();
                        btnCancelar.Enabled = false;
                        
                    }

                



            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            funCancelar();
        }

        private void grdPuesto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
            btnCancelar.Enabled = true;
            grpActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnBuscar.Enabled = false;
            cmbAseguradora.Enabled = false;
            
            string sDeducible;
            DataGridViewRow fila = grdPuesto.CurrentRow;
            sCodigoTabla = Convert.ToString(fila.Cells[0].Value);
            sDeducible = Convert.ToString(fila.Cells[3].Value);
            txtActualizarDeducible.Text = sDeducible;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string sActualizarAseguradora, sActualizarTarifa;
            try
            {
                sActualizarAseguradora = funCortador(cmbActualizarAseguradora.SelectedItem.ToString());
                sActualizarTarifa = funCortador(cmbActualizarTarifa.SelectedItem.ToString());

                if (MessageBox.Show("¿Desea modificar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlCommand mComando = new MySqlCommand(string.Format("UPDATE TrSEGURO SET ndeducible = '{0}', ncodtarifa = '{1}', ncodaseguradora = '{2}' WHERE ncodseguro = '{3}'",
                    txtActualizarDeducible.Text, sActualizarTarifa, sActualizarAseguradora ,sCodigoTabla), clasConexion.funConexion());
                    mComando.ExecuteNonQuery();
                    funActualizar();
                    MessageBox.Show("Se actualizo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtActualizarDeducible.Text = "";
                    funCancelar();
                    funActualizar();
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlCommand mComando = new MySqlCommand(string.Format("DELETE FROM TrSEGURO WHERE ncodseguro = '{0}'",
                    sCodigoTabla), clasConexion.funConexion());
                    mComando.ExecuteNonQuery();
                    funActualizar();
                    MessageBox.Show("Dato eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtActualizarDeducible.Text = "";
                    funCancelar();
                    funActualizar();
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
    }
}
