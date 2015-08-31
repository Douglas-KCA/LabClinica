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

namespace Laboratorio
{
/*---------------------------------------------------------------------------------------------------------------------------------
  Programador y Analista: Josue Revolorio
* Fecha de asignacion: 03/08/2015
* Fecha de entrega: 06/08/2015
---------------------------------------------------------------------------------------------------------------------------------*/
    public partial class frmConsultaCita : Form
    {
        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que carga los componentes iniciales del form
        ---------------------------------------------------------------------------------------------------------------------------------*/
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
            String sPaciente;
            String sEmpleado;
            try{
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT cnombresucursal FROM MaSUCURSAL"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();
                while (mReader.Read())                {
                    sNombre = mReader.GetString(0);
                    cmbActualizarSucursal.Items.Add(sNombre);
                }
            }
            catch{
                MessageBox.Show("Se produjo un error en combo sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try{
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona IN (SELECT ncodpersona FROM TrPACIENTE)"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();
                while (mReader.Read()){
                    sPaciente = mReader.GetString(0) + " " + mReader.GetString(1);
                    cmbActualizarPaciente.Items.Add(sPaciente);
                }
            }
            catch{
                MessageBox.Show("Se produjo un error en combo paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try{
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona IN (SELECT ncodpersona FROM TrEMPLEADO)"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();
                while (mReader.Read()){
                    sEmpleado = mReader.GetString(0) + " " + mReader.GetString(1);
                    cmbAcutalizarEmpleado.Items.Add(sEmpleado);
                }
            }
            catch{
                MessageBox.Show("Se produjo un error en combo empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que toma los valores de la fila seleccionada en el grid para mostrarlos en los campos de texto de edicion
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void grdCita_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            grpActualizar.Enabled = true;
            grpBuscar.Enabled = false;
            btnActualizar.Enabled = true;

            dtpActualizarCitas.Text = grdCita.Rows[grdCita.CurrentCell.RowIndex].Cells[1].Value + "";
            
            String[] sTiempo = (grdCita.Rows[grdCita.CurrentCell.RowIndex].Cells[2].Value + "").Split(':');
            cmbActualizarHora.Text = sTiempo[0];
            cmbActualizarMinutos.Text = sTiempo[1];
            
            cmbEstado.Text = grdCita.Rows[grdCita.CurrentCell.RowIndex].Cells[3].Value + "";

            cmbActualizarPaciente.Text = grdCita.Rows[grdCita.CurrentCell.RowIndex].Cells[4].Value + "";

            cmbActualizarSucursal.Text = grdCita.Rows[grdCita.CurrentCell.RowIndex].Cells[5].Value + "";

            cmbAcutalizarEmpleado.Text = grdCita.Rows[grdCita.CurrentCell.RowIndex].Cells[6].Value + "";


            btnActualizar.Enabled = true;
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que pobla el grid con los datos de la BD
        ---------------------------------------------------------------------------------------------------------------------------------*/
        void funActualizar()
        {
            string sSucursal, sPaciente, sCodigo, sFecha, sTiempo, sEstado, sEmpleado;
            int iContador = 0;
            grdCita.Rows.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT * FROM TrCITA WHERE dfechacita >= CURRENT_DATE()"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sFecha = mReader.GetString(1);
                    sTiempo = mReader.GetString(2);
                    sEstado = mReader.GetString(3);
                    sPaciente = mReader.GetString(4);
                    sSucursal = mReader.GetString(5);
                    sEmpleado = mReader.GetString(6);

                    try {
                        MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona = (SELECT ncodpersona FROM TrPACIENTE WHERE ncodpaciente = '{0}')", sPaciente), clasConexion.funConexion());
                        MySqlDataReader mReader2 = mComando2.ExecuteReader();
                        if (mReader2.Read())
                            sPaciente = mReader2.GetString(0) + " " + mReader2.GetString(1);
                    }
                    catch{
                        MessageBox.Show("Se produjo un error al actualizar tabla paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    try
                    {
                        MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona = (SELECT ncodpersona FROM TrEMPLEADO WHERE ncodempleado = '{0}')", sEmpleado), clasConexion.funConexion());
                        MySqlDataReader mReader2 = mComando2.ExecuteReader();
                        if (mReader2.Read())
                            sEmpleado = mReader2.GetString(0) + " " + mReader2.GetString(1); ;
                    }
                    catch
                    {
                        MessageBox.Show("Se produjo un error al actualizar tabla empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    try
                    {
                        MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cnombresucursal FROM MaSUCURSAL WHERE ncodsucursal = '{0}'", sSucursal), clasConexion.funConexion());
                        MySqlDataReader mReader2 = mComando2.ExecuteReader();
                        if (mReader2.Read())
                            sSucursal = mReader2.GetString(0);
                    }
                    catch
                    {
                        MessageBox.Show("Se produjo un error al actualizar tabla sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    String[] sFechaSola = sFecha.Split(' ');

                    grdCita.Rows.Insert(iContador, sCodigo, sFechaSola[0], sTiempo, sEstado, sPaciente, sSucursal, sEmpleado);
                    sCodigo = sSucursal = sPaciente = sFecha = sTiempo = sEmpleado = sEstado ="";
                    iContador++;
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error al actualizar la tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que filtra el grid a partir del parametro que se indica en el textbox
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            grpBuscar.Enabled = true;
            grpActualizar.Enabled = false;
            btnActualizar.Enabled = false;
            btnBuscar.Enabled = false;
            txtNomPaciente.Enabled = txtApePaciente.Enabled = txtApeEmpleado.Enabled = txtNomEmpleado.Enabled = txtSucursal.Enabled = false;
            cmbActualizarHora.Text = cmbActualizarMinutos.Text = cmbActualizarPaciente.Text = cmbAcutalizarEmpleado.Text = cmbActualizarSucursal.Text = cmbEstado.Text = "";
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que toma los datos del grid y los actualiza en la base de datos en caso exista un cambio
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            String sPaciente = "", sEmpleado = "", sSucursal = "";
            String[] nombresPaciente = cmbActualizarPaciente.Text.Split(' ');
            String[] nombresEmpleado = cmbAcutalizarEmpleado.Text.Split(' ');
            
            try{
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT ncodpaciente FROM TrPACIENTE WHERE ncodpersona = (SELECT ncodpersona FROM MaPERSONA WHERE cnombrepersona = '{0}' AND capellidopersona = '{1}')", nombresPaciente[0], nombresPaciente[1]), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();
                if (mReader.Read())
                    sPaciente = mReader.GetString(0);
            }
            catch{
                MessageBox.Show("error al obtener datos para actualizar paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try{
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT ncodempleado FROM TrEMPLEADO WHERE ncodpersona = (SELECT ncodpersona FROM MaPERSONA WHERE cnombrepersona = '{0}' AND capellidopersona = '{1}')", nombresEmpleado[0], nombresEmpleado[1]), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();
                if (mReader.Read())
                    sEmpleado = mReader.GetString(0);
            }
            catch{
                MessageBox.Show("error al obtener datos para actualizar empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
            try{
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT ncodsucursal FROM MaSUCURSAL WHERE cnombresucursal = '{0}' ", cmbActualizarSucursal.Text), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();
                if (mReader.Read())
                    sSucursal = mReader.GetString(0);
            }
            catch{
                MessageBox.Show("error al obtener datos para actualizar sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT ncodigocita FROM TrCITA WHERE ncodempleado = '{0}' AND dfechacita = '{1}' AND choracita = '{2}' AND cestado = 'Activa' AND ncodigocita != '{3}'", sEmpleado, dtpActualizarCitas.Text, cmbActualizarHora.Text + ":" + cmbActualizarMinutos.Text, grdCita.Rows[grdCita.CurrentCell.RowIndex].Cells[0].Value + ""), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();
                if (mReader.Read())
                {
                    MessageBox.Show("Ya se tiene una cita para ese momento o lugar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT ncodigocita FROM TrCITA WHERE ncodsucursal = '{0}' AND dfechacita = '{1}' AND choracita = '{2}' AND cestado = 'Activa' AND ncodigocita != '{3}'", sSucursal, dtpActualizarCitas.Text, cmbActualizarHora.Text + ":" + cmbActualizarMinutos.Text, grdCita.Rows[grdCita.CurrentCell.RowIndex].Cells[0].Value + ""), clasConexion.funConexion());
                    MySqlDataReader mReader2 = mComando2.ExecuteReader();
                    if (mReader2.Read())
                    {
                        MessageBox.Show("Ya se tiene una cita en esa sucursal en ese momento o lugar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (mReader2.Read())
                        {
                            MessageBox.Show("Ya se tiene una cita para ese momento o lugar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (MessageBox.Show("Seguro que quiere actualizar los datos", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                MySqlCommand comando = new MySqlCommand(string.Format("UPDATE TrCITA SET ncodsucursal = '{0}', ncodpaciente = '{1}',  dfechacita = '{2}', choracita = '{3}', ncodempleado = '{4}', cestado = '{5}' WHERE ncodigocita = '{6}'",
                                sSucursal, sPaciente, dtpActualizarCitas.Text, cmbActualizarHora.Text + ":" + cmbActualizarMinutos.Text, sEmpleado, cmbEstado.Text, grdCita.Rows[grdCita.CurrentCell.RowIndex].Cells[0].Value + ""), clasConexion.funConexion());
                                comando.ExecuteNonQuery();
                                MessageBox.Show("Se actualizo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                funActualizar();
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error al ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que limpia los textbox o combobox
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            funActualizar();
            grpActualizar.Enabled = grpBuscar.Enabled = false;
            cmbActualizarHora.Text = cmbActualizarMinutos.Text = cmbActualizarPaciente.Text = cmbAcutalizarEmpleado.Text = cmbActualizarSucursal.Text = cmbEstado.Text ="";
            btnBuscar.Enabled = true;
            btnActualizar.Enabled = false;
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
                    cmbActualizarHora.Text = cmbActualizarMinutos.Text = cmbActualizarPaciente.Text = cmbAcutalizarEmpleado.Text = cmbActualizarSucursal.Text = cmbEstado.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que Regresa al menu principal
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que havilita la seccion de busqueda por sucursal y deshabilita el resto
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void rbtnSucursal_CheckedChanged(object sender, EventArgs e)
        {
            txtSucursal.Enabled = true;
            txtNomEmpleado.Enabled = txtApePaciente.Enabled = txtApeEmpleado.Enabled = txtNomPaciente.Enabled = false;
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que havilita la seccion de busqueda por paciente y deshabilita el resto
        ---------------------------------------------------------------------------------------------------------------------------------*/        
        private void rbtnPaciente_CheckedChanged(object sender, EventArgs e)
        {
            txtNomPaciente.Enabled = txtApePaciente.Enabled = true;
            txtNomEmpleado.Enabled = txtApeEmpleado.Enabled = txtSucursal.Enabled = false;
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que havilita la seccion de busqueda por empleado y deshabilita el resto
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void rbtnEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            txtNomEmpleado.Enabled = txtApeEmpleado.Enabled = true;
            txtNomPaciente.Enabled = txtApePaciente.Enabled = txtSucursal.Enabled = false;
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que filtra los datos de la tabla en base a lo que se escribe en el textbox de sucursal, 
          se actualiza cada vez que se suelta una tecla
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void txtSucursal_KeyUp(object sender, KeyEventArgs e)
        {
            string sCodigo, sFecha, sTiempo, sEstado, sPaciente, sSucursal, sEmpleado;
            int iContador = 0;
            grdCita.Rows.Clear();
            try{
                if (String.IsNullOrEmpty(txtSucursal.Text)){
                    funActualizar();
                }
                else{
                    MySqlCommand mComando = new MySqlCommand(String.Format(
                    "SELECT * FROM TrCITA WHERE ncodsucursal = (SELECT ncodsucursal FROM MaSUCURSAL WHERE cnombresucursal LIKE '{0}%') AND dfechacita >= CURRENT_DATE()", txtSucursal.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read()){
                        sCodigo = mReader.GetString(0);
                        sFecha = mReader.GetString(1);
                        sTiempo = mReader.GetString(2);
                        sEstado = mReader.GetString(3);
                        sPaciente = mReader.GetString(4);
                        sSucursal = mReader.GetString(5);
                        sEmpleado = mReader.GetString(6);
                        String[] sFechaSola = sFecha.Split(' ');

                        try
                        {
                            MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona = (SELECT ncodpersona FROM TrPACIENTE WHERE ncodpaciente = '{0}')", sPaciente), clasConexion.funConexion());
                            MySqlDataReader mReader2 = mComando2.ExecuteReader();
                            if (mReader2.Read())
                                sPaciente = mReader2.GetString(0) + " " + mReader2.GetString(1);
                        }
                        catch
                        {
                            MessageBox.Show("Se produjo un error al actualizar tabla paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        try
                        {
                            MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona = (SELECT ncodpersona FROM TrEMPLEADO WHERE ncodempleado = '{0}')", sEmpleado), clasConexion.funConexion());
                            MySqlDataReader mReader2 = mComando2.ExecuteReader();
                            if (mReader2.Read())
                                sEmpleado = mReader2.GetString(0) + " " + mReader2.GetString(1); ;
                        }
                        catch
                        {
                            MessageBox.Show("Se produjo un error al actualizar tabla empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        try
                        {
                            MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cnombresucursal FROM MaSUCURSAL WHERE ncodsucursal = '{0}'", sSucursal), clasConexion.funConexion());
                            MySqlDataReader mReader2 = mComando2.ExecuteReader();
                            if (mReader2.Read())
                                sSucursal = mReader2.GetString(0);
                        }
                        catch
                        {
                            MessageBox.Show("Se produjo un error al actualizar tabla sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        grdCita.Rows.Insert(iContador, sCodigo, sFechaSola[0], sTiempo, sEstado, sPaciente, sSucursal, sEmpleado);
                        sCodigo = sSucursal = sPaciente = sFecha = sTiempo = sEmpleado = sEstado = "";
                        iContador++;
                    }
                }
            }
            catch{
                MessageBox.Show("Se produjo un error buscando sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que filtra los datos de la tabla en base a lo que se escribe en el textbox de nombre paciente, 
          se actualiza cada vez que se suelta una tecla
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void txtNomPaciente_KeyUp(object sender, KeyEventArgs e)
        {
            string sCodigo, sFecha, sTiempo, sEstado, sPaciente, sSucursal, sEmpleado;
            int iContador = 0;
            grdCita.Rows.Clear();
            try
            {
                if (String.IsNullOrEmpty(txtNomPaciente.Text))
                {
                    funActualizar();
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format("SELECT * FROM TrCITA WHERE ncodpaciente IN (SELECT ncodpaciente FROM TrPACIENTE WHERE ncodpersona IN (SELECT ncodpersona FROM MaPERSONA WHERE cnombrepersona LIKE '{0}%')) AND dfechacita >= CURRENT_DATE()", txtNomPaciente.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        sCodigo = mReader.GetString(0);
                        sFecha = mReader.GetString(1);
                        sTiempo = mReader.GetString(2);
                        sEstado = mReader.GetString(3);
                        sPaciente = mReader.GetString(4);
                        sSucursal = mReader.GetString(5);
                        sEmpleado = mReader.GetString(6);
                        String[] sFechaSola = sFecha.Split(' ');

                        try
                        {
                            MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona = (SELECT ncodpersona FROM TrPACIENTE WHERE ncodpaciente = '{0}')", sPaciente), clasConexion.funConexion());
                            MySqlDataReader mReader2 = mComando2.ExecuteReader();
                            if (mReader2.Read())
                                sPaciente = mReader2.GetString(0) + " " + mReader2.GetString(1);
                        }
                        catch
                        {
                            MessageBox.Show("Se produjo un error al actualizar tabla paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        try
                        {
                            MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona = (SELECT ncodpersona FROM TrEMPLEADO WHERE ncodempleado = '{0}')", sEmpleado), clasConexion.funConexion());
                            MySqlDataReader mReader2 = mComando2.ExecuteReader();
                            if (mReader2.Read())
                                sEmpleado = mReader2.GetString(0) + " " + mReader2.GetString(1); ;
                        }
                        catch
                        {
                            MessageBox.Show("Se produjo un error al actualizar tabla empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        try
                        {
                            MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cnombresucursal FROM MaSUCURSAL WHERE ncodsucursal = '{0}'", sSucursal), clasConexion.funConexion());
                            MySqlDataReader mReader2 = mComando2.ExecuteReader();
                            if (mReader2.Read())
                                sSucursal = mReader2.GetString(0);
                        }
                        catch
                        {
                            MessageBox.Show("Se produjo un error al actualizar tabla sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        grdCita.Rows.Insert(iContador, sCodigo, sFechaSola[0], sTiempo, sEstado, sPaciente, sSucursal, sEmpleado);
                        sCodigo = sSucursal = sPaciente = sFecha = sTiempo = sEmpleado = sEstado = "";
                        iContador++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error buscando paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que filtra los datos de la tabla en base a lo que se escribe en el textbox de apellido paciente, 
          se actualiza cada vez que se suelta una tecla
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void txtApePaciente_KeyUp(object sender, KeyEventArgs e)
        {
            string sCodigo, sFecha, sTiempo, sEstado, sPaciente, sSucursal, sEmpleado;
            int iContador = 0;
            grdCita.Rows.Clear();
            try
            {
                if (String.IsNullOrEmpty(txtApePaciente.Text))
                {
                    funActualizar();
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format("SELECT * FROM TrCITA WHERE ncodpaciente IN (SELECT ncodpaciente FROM TrPACIENTE WHERE ncodpersona IN (SELECT ncodpersona FROM MaPERSONA WHERE capellidopersona LIKE '{0}%')) AND dfechacita >= CURRENT_DATE()", txtApePaciente.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        sCodigo = mReader.GetString(0);
                        sFecha = mReader.GetString(1);
                        sTiempo = mReader.GetString(2);
                        sEstado = mReader.GetString(3);
                        sPaciente = mReader.GetString(4);
                        sSucursal = mReader.GetString(5);
                        sEmpleado = mReader.GetString(6);
                        String[] sFechaSola = sFecha.Split(' ');

                        try
                        {
                            MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona = (SELECT ncodpersona FROM TrPACIENTE WHERE ncodpaciente = '{0}')", sPaciente), clasConexion.funConexion());
                            MySqlDataReader mReader2 = mComando2.ExecuteReader();
                            if (mReader2.Read())
                                sPaciente = mReader2.GetString(0) + " " + mReader2.GetString(1);
                        }
                        catch
                        {
                            MessageBox.Show("Se produjo un error al actualizar tabla paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        try
                        {
                            MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona = (SELECT ncodpersona FROM TrEMPLEADO WHERE ncodempleado = '{0}')", sEmpleado), clasConexion.funConexion());
                            MySqlDataReader mReader2 = mComando2.ExecuteReader();
                            if (mReader2.Read())
                                sEmpleado = mReader2.GetString(0) + " " + mReader2.GetString(1); ;
                        }
                        catch
                        {
                            MessageBox.Show("Se produjo un error al actualizar tabla empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        try
                        {
                            MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cnombresucursal FROM MaSUCURSAL WHERE ncodsucursal = '{0}'", sSucursal), clasConexion.funConexion());
                            MySqlDataReader mReader2 = mComando2.ExecuteReader();
                            if (mReader2.Read())
                                sSucursal = mReader2.GetString(0);
                        }
                        catch
                        {
                            MessageBox.Show("Se produjo un error al actualizar tabla sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        grdCita.Rows.Insert(iContador, sCodigo, sFechaSola[0], sTiempo, sEstado, sPaciente, sSucursal, sEmpleado);
                        sCodigo = sSucursal = sPaciente = sFecha = sTiempo = sEmpleado = sEstado = "";
                        iContador++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error buscando paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que filtra los datos de la tabla en base a lo que se escribe en el textbox de nombre empleado, 
          se actualiza cada vez que se suelta una tecla
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void txtNomEmpleado_KeyUp(object sender, KeyEventArgs e)
        {
            string sCodigo, sFecha, sTiempo, sEstado, sPaciente, sSucursal, sEmpleado;
            int iContador = 0;
            grdCita.Rows.Clear();
            try
            {
                if (String.IsNullOrEmpty(txtNomEmpleado.Text))
                {
                    funActualizar();
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format("SELECT * FROM TrCITA WHERE ncodempleado IN (SELECT ncodempleado FROM TrEMPLEADO WHERE ncodpersona IN (SELECT ncodpersona FROM MaPERSONA WHERE cnombrepersona LIKE '{0}%')) AND dfechacita >= CURRENT_DATE() ", txtNomEmpleado.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        sCodigo = mReader.GetString(0);
                        sFecha = mReader.GetString(1);
                        sTiempo = mReader.GetString(2);
                        sEstado = mReader.GetString(3);
                        sPaciente = mReader.GetString(4);
                        sSucursal = mReader.GetString(5);
                        sEmpleado = mReader.GetString(6);
                        String[] sFechaSola = sFecha.Split(' ');

                        try
                        {
                            MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona = (SELECT ncodpersona FROM TrPACIENTE WHERE ncodpaciente = '{0}')", sPaciente), clasConexion.funConexion());
                            MySqlDataReader mReader2 = mComando2.ExecuteReader();
                            if (mReader2.Read())
                                sPaciente = mReader2.GetString(0) + " " + mReader2.GetString(1);
                        }
                        catch
                        {
                            MessageBox.Show("Se produjo un error al actualizar tabla paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        try
                        {
                            MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona = (SELECT ncodpersona FROM TrEMPLEADO WHERE ncodempleado = '{0}')", sEmpleado), clasConexion.funConexion());
                            MySqlDataReader mReader2 = mComando2.ExecuteReader();
                            if (mReader2.Read())
                                sEmpleado = mReader2.GetString(0) + " " + mReader2.GetString(1); ;
                        }
                        catch
                        {
                            MessageBox.Show("Se produjo un error al actualizar tabla empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        try
                        {
                            MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cnombresucursal FROM MaSUCURSAL WHERE ncodsucursal = '{0}'", sSucursal), clasConexion.funConexion());
                            MySqlDataReader mReader2 = mComando2.ExecuteReader();
                            if (mReader2.Read())
                                sSucursal = mReader2.GetString(0);
                        }
                        catch
                        {
                            MessageBox.Show("Se produjo un error al actualizar tabla sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        grdCita.Rows.Insert(iContador, sCodigo, sFechaSola[0], sTiempo, sEstado, sPaciente, sSucursal, sEmpleado);
                        sCodigo = sSucursal = sPaciente = sFecha = sTiempo = sEmpleado = sEstado = "";
                        iContador++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error buscando empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que filtra los datos de la tabla en base a lo que se escribe en el textbox de apellido empleado, 
          se actualiza cada vez que se suelta una tecla
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void txtApeEmpleado_KeyUp(object sender, KeyEventArgs e)
        {
            string sCodigo, sFecha, sTiempo, sEstado, sPaciente, sSucursal, sEmpleado;
            int iContador = 0;
            grdCita.Rows.Clear();
            try
            {
                if (String.IsNullOrEmpty(txtApeEmpleado.Text))
                {
                    funActualizar();
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format("SELECT * FROM TrCITA WHERE ncodempleado IN (SELECT ncodempleado FROM TrEMPLEADO WHERE ncodpersona IN (SELECT ncodpersona FROM MaPERSONA WHERE capellidopersona LIKE '{0}%')) AND dfechacita >= CURRENT_DATE() ", txtApeEmpleado.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        sCodigo = mReader.GetString(0);
                        sFecha = mReader.GetString(1);
                        sTiempo = mReader.GetString(2);
                        sEstado = mReader.GetString(3);
                        sPaciente = mReader.GetString(4);
                        sSucursal = mReader.GetString(5);
                        sEmpleado = mReader.GetString(6);
                        String[] sFechaSola = sFecha.Split(' ');

                        try
                        {
                            MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona = (SELECT ncodpersona FROM TrPACIENTE WHERE ncodpaciente = '{0}')", sPaciente), clasConexion.funConexion());
                            MySqlDataReader mReader2 = mComando2.ExecuteReader();
                            if (mReader2.Read())
                                sPaciente = mReader2.GetString(0) + " " + mReader2.GetString(1);
                        }
                        catch
                        {
                            MessageBox.Show("Se produjo un error al actualizar tabla paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        try
                        {
                            MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona = (SELECT ncodpersona FROM TrEMPLEADO WHERE ncodempleado = '{0}')", sEmpleado), clasConexion.funConexion());
                            MySqlDataReader mReader2 = mComando2.ExecuteReader();
                            if (mReader2.Read())
                                sEmpleado = mReader2.GetString(0) + " " + mReader2.GetString(1); ;
                        }
                        catch
                        {
                            MessageBox.Show("Se produjo un error al actualizar tabla empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        try
                        {
                            MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cnombresucursal FROM MaSUCURSAL WHERE ncodsucursal = '{0}'", sSucursal), clasConexion.funConexion());
                            MySqlDataReader mReader2 = mComando2.ExecuteReader();
                            if (mReader2.Read())
                                sSucursal = mReader2.GetString(0);
                        }
                        catch
                        {
                            MessageBox.Show("Se produjo un error al actualizar tabla sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        grdCita.Rows.Insert(iContador, sCodigo, sFechaSola[0], sTiempo, sEstado, sPaciente, sSucursal, sEmpleado);
                        sCodigo = sSucursal = sPaciente = sFecha = sTiempo = sEmpleado = sEstado = "";
                        iContador++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error buscando empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que abre un form para busqueda del empleado de una manera mas eficiente
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void button3_Click(object sender, EventArgs e)
        {
            frmBuscarEmpleado ver = new frmBuscarEmpleado("frmConsultaCita", cmbActualizarSucursal.Text, cmbActualizarPaciente.Text,
                cmbAcutalizarEmpleado.Text, dtpActualizarCitas.Text, cmbActualizarHora.Text, cmbActualizarMinutos.Text, cmbEstado.Text);
            ver.MdiParent = this.MdiParent;
            ver.Show();
            this.Close();
            
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que abre un form para busqueda del paciente de una manera mas eficiente
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void button2_Click(object sender, EventArgs e)
        {
            frmBuscarPaciente ver = new frmBuscarPaciente("frmConsultaCita", cmbActualizarSucursal.Text,cmbActualizarPaciente.Text, cmbAcutalizarEmpleado.Text, 
                dtpActualizarCitas.Text, cmbActualizarHora.Text, cmbActualizarMinutos.Text, cmbEstado.Text);
            ver.MdiParent = this.MdiParent;
            ver.Show();
            this.Close();
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que abre un form para busqueda de la sucursal de una manera mas eficiente
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void button1_Click(object sender, EventArgs e)
        {
            frmBuscarSucursal ver = new frmBuscarSucursal("frmConsultaCita", cmbActualizarSucursal.Text,cmbAcutalizarEmpleado.Text, cmbActualizarPaciente.Text,
                dtpActualizarCitas.Text, cmbActualizarHora.Text, cmbActualizarMinutos.Text, cmbEstado.Text);
            ver.MdiParent = this.MdiParent;
            ver.Show();
            this.Close();
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que previene la escritura de numeros y simbolos en el textbox de nombre paciente
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void txtNomPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que previene la escritura de numeros y simbolos en el textbox de apellido paciente
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void txtApePaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que previene la escritura de numeros y simbolos en el textbox de nombre empleado
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void txtNomEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que previene la escritura de numeros y simbolos en el textbox de apellido empleado
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void txtApeEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

    }
}
