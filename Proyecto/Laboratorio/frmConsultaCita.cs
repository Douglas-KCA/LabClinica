﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Laboratorio
{
/*---------------------------------------------------------------------------------------------------------------------------------
  Programador y Analista: Josue Revolorio
* Fecha de asignacion: 03/08/2015
* Fecha de entrega: 06/08/2015
---------------------------------------------------------------------------------------------------------------------------------*/
    public partial class frmConsultaCita : Form
    {
        public frmConsultaCita()
        {
            InitializeComponent();
            funActualizar();
            funCargarCombos();
            btnActualizar.Enabled = false;
            grpBuscar.Enabled = false;
            grpActualizar.Enabled = false;
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que carga los datos a los combos del programa al iniciar el form
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void funCargarCombos()
        {
            String sNombre;
            String sPersona;
            String sPaciente;
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT cnombresucursal FROM MaSUCURSAL"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sNombre = mReader.GetString(0);
                    cmbActualizarSucursal.Items.Add(sNombre);
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT ncodpersona FROM TrPACIENTE"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();
                while (mReader.Read())
                {
                    sPersona = mReader.GetString(0);
                    MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona = '{0}' ", sPersona), clasConexion.funConexion());
                    MySqlDataReader mReader2 = mComando2.ExecuteReader();
                    while (mReader2.Read())
                    {
                        sPaciente = mReader2.GetString(0) + " " + mReader2.GetString(1);
                        cmbActualizarPaciente.Items.Add(sPaciente);
                    }
                    sPersona = "";
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que toma los valores de la fila seleccionada en el grid para mostrarlos en los campos de texto de edicion
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void grdCita_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            /*cmbActualizarSucursal.Text = grdCita.Rows[grdCita.CurrentCell.RowIndex].Cells[1].Value + "";
            cmbActualizarPaciente.Text = grdCita.Rows[grdCita.CurrentCell.RowIndex].Cells[2].Value + "";
            dtpActualizarCitas.Text = grdCita.Rows[grdCita.CurrentCell.RowIndex].Cells[3].Value + "";
            String[] sTiempo = (grdCita.Rows[grdCita.CurrentCell.RowIndex].Cells[4].Value + "").Split(':');
            cmbActualizarHora.Text = sTiempo[0];
            cmbActualizarMinutos.Text = sTiempo[1];*/
            btnActualizar.Enabled = true;
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que pobla el grid con los datos de la BD
        ---------------------------------------------------------------------------------------------------------------------------------*/
        void funActualizar()
        {
            string sSucursal, sPaciente, sCodigo, sFecha, sTiempo;
            int iContador = 0;
            grdCita.Rows.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT * FROM TrCITA WHERE dfechacita >= CURRENT_DATE()"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sSucursal = mReader.GetString(1);
                    sPaciente = mReader.GetString(2);
                    sFecha = mReader.GetString(3);
                    sTiempo = mReader.GetString(4);

                    MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT ncodpersona FROM TrPACIENTE WHERE ncodpaciente = '{0}' ", sPaciente), clasConexion.funConexion());
                    MySqlDataReader mReader2 = mComando2.ExecuteReader();
                    if (mReader2.Read())
                        sPaciente = mReader2.GetString(0);

                    MySqlCommand mComando3 = new MySqlCommand(String.Format("SELECT cnombrepersona ,capellidopersona FROM MaPERSONA WHERE ncodpersona = '{0}' ", sPaciente), clasConexion.funConexion());
                    MySqlDataReader mReader3 = mComando3.ExecuteReader();
                    if (mReader3.Read())
                        sPaciente = mReader3.GetString(0) + " "+ mReader3.GetString(1);
                     
                    MySqlCommand mComando4 = new MySqlCommand(String.Format("SELECT cnombresucursal FROM MaSUCURSAL WHERE ncodsucursal = '{0}' ", sSucursal), clasConexion.funConexion());
                    MySqlDataReader mReader4 = mComando4.ExecuteReader();
                    if (mReader4.Read())
                        sSucursal = mReader4.GetString(0);

                    String[] sFechaSola = sFecha.Split(' ');

                    grdCita.Rows.Insert(iContador, sCodigo, sSucursal, sPaciente, sFechaSola[0], sTiempo);
                    sCodigo = sSucursal = sPaciente = sFecha = sTiempo ="";
                    iContador++;
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que filtra el grid a partir del parametro que se indica en el textbox
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            grpBuscar.Enabled = true;
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que toma los datos del grid y los actualiza en la base de datos en caso exista un cambio
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string sCodigoPersona = "", sCodigoPaciente = "", sCodigoSucursal = "";
            try
            {
                String[] nombres = cmbActualizarPaciente.Text.Split(' ');

                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT ncodpersona FROM MaPERSONA WHERE cnombrepersona = '{0}' AND capellidopersona = '{1}' ", nombres[0], nombres[1]), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();
                if (mReader.Read())
                    sCodigoPersona = mReader.GetString(0);

                MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT ncodpaciente FROM TrPACIENTE WHERE ncodpersona = '{0}' ", sCodigoPersona), clasConexion.funConexion());
                MySqlDataReader mReader2 = mComando2.ExecuteReader();
                if (mReader2.Read())
                    sCodigoPaciente = mReader2.GetString(0);
                
                MySqlCommand mComando3 = new MySqlCommand(String.Format("SELECT ncodsucursal FROM MaSUCURSAL WHERE cnombresucursal = '{0}' ", cmbActualizarSucursal.Text), clasConexion.funConexion());
                MySqlDataReader mReader3 = mComando3.ExecuteReader();
                if (mReader3.Read())
                    sCodigoSucursal = mReader3.GetString(0);

                
                MySqlCommand mComando4 = new MySqlCommand(String.Format("SELECT ncodigocita FROM TrCITA WHERE dfechacita = '{0}' AND choracita = '{1}' AND ncodsucursal = '{2}'", dtpActualizarCitas.Text, cmbActualizarHora.Text + ":" + cmbActualizarMinutos.Text, sCodigoSucursal), clasConexion.funConexion());
                MySqlDataReader mReader4 = mComando4.ExecuteReader();
                if (mReader4.Read())
                {
                    MessageBox.Show("Ya se tiene una cita para ese momento o lugar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Seguro que quiere actualizar los datos", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MySqlCommand comando = new MySqlCommand(string.Format("UPDATE TrCITA SET ncodsucursal = '{0}', ncodpaciente = '{1}',  dfechacita = '{2}', choracita = '{3}' WHERE ncodigocita = '{4}'",
                        sCodigoSucursal, sCodigoPaciente, dtpActualizarCitas.Text, cmbActualizarHora.Text + ":" + cmbActualizarMinutos.Text, grdCita.Rows[grdCita.CurrentCell.RowIndex].Cells[0].Value + ""), clasConexion.funConexion());
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Se actualizo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        funActualizar();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que limpia los textbox o combobox
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            funActualizar();
            grpActualizar.Enabled = grpBuscar.Enabled = false;
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que Elimina la fila seleccionada
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seguro que quiere eliminar los datos", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM TrCITA WHERE ncodigocita = '{0}'",
                    grdCita.Rows[grdCita.CurrentCell.RowIndex].Cells[0].Value + ""), clasConexion.funConexion());
                    comando.ExecuteNonQuery();
                    funActualizar();
                    MessageBox.Show("Dato eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    funActualizar();
                    cmbActualizarPaciente.Text = cmbActualizarSucursal.Text = cmbActualizarHora.Text = cmbActualizarMinutos.Text = "";
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbActualizarHora_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
