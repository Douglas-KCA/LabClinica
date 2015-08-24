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
    public partial class frmConsultaAseguradora : Form
    {
        /*
         * Programador y Analista: Dylan Corado
         * Fecha de Asignacion: 03 de Agosto
         * Fecha de Entrega: 04 de Agosto
        */
        string sCodigoTabla;
        public frmConsultaAseguradora()
        {
            InitializeComponent();
            funActualizar();
        }

        void funCancelar()
        {
            txtActualizarNombre.Clear();
            txtNombre.Clear();
            txtNombre.Enabled = true;
            grpActualizar.Enabled = false;
            btnActualizar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
            funActualizar();
            //grdConsultaMembresia.LostFocus=0;
        }

        void funActualizar()
        {

            string sCodigo;
            string sNombre;
            int iContador = 0;
            grdConsultarAseguradora.Rows.Clear();

            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT ncodaseguradora, cempresaseguro FROM MaASEGURADORA"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sNombre = mReader.GetString(1);
                    grdConsultarAseguradora.Rows.Insert(iContador, sCodigo, sNombre);
                    sCodigo = "";
                    sNombre = "";
                    iContador++;
                }
                grdConsultarAseguradora.ClearSelection();

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

      
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea modificar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlCommand mComando = new MySqlCommand(string.Format("UPDATE MaASEGURADORA SET cempresaseguro = '{0}' WHERE ncodaseguradora = '{1}'",
                    txtActualizarNombre.Text, sCodigoTabla), clasConexion.funConexion());
                    mComando.ExecuteNonQuery();
                    funActualizar();
                    MessageBox.Show("Se actualizo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Text = "";
                    funCancelar();
                    funActualizar();
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

        private void grdConsultaAseguradora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlCommand mComando = new MySqlCommand(string.Format("DELETE FROM MaASEGURADORA WHERE ncodaseguradora = '{0}'",
                    sCodigoTabla), clasConexion.funConexion());
                    mComando.ExecuteNonQuery();
                    funActualizar();
                    MessageBox.Show("Dato eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Text = "";
                    funCancelar();
                    funActualizar();
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void grdConsultarAseguradora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
            btnCancelar.Enabled = true;
            grpActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            txtNombre.Clear();
            txtNombre.Enabled = false;

            string sNombre;
            DataGridViewRow fila = grdConsultarAseguradora.CurrentRow;
            sCodigoTabla = Convert.ToString(fila.Cells[0].Value);
            sNombre = Convert.ToString(fila.Cells[1].Value);
            txtActualizarNombre.Text = sNombre;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            string sCodigo;
            string sNombre;
            int iContador = 0;
            bool existe = false;
            grdConsultarAseguradora.Rows.Clear();

            try
            {

                if (String.IsNullOrEmpty(txtNombre.Text))
                {
                    funActualizar();
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format(
                    "SELECT ncodaseguradora, cempresaseguro FROM MaASEGURADORA WHERE cempresaseguro LIKE '{0}%'", txtNombre.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        existe = true;
                        sCodigo = mReader.GetString(0);
                        sNombre = mReader.GetString(1);
                        grdConsultarAseguradora.Rows.Insert(iContador, sCodigo, sNombre);
                        sCodigo = "";
                        sNombre = "";
                        iContador++;
                    }


                    btnCancelar.Enabled = true;
                    if (existe == false)
                    {
                        MessageBox.Show("No se encontraron resultados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        funActualizar();
                        btnCancelar.Enabled = false;
                        txtNombre.Clear();
                    }

                }



            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}
