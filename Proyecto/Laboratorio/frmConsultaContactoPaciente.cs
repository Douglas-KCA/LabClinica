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
    public partial class frmConsultaContactoPaciente : Form
    {
        //variables para textbox
        String ncodigopersona, ncodigopersona2, sActualizarCodigoTelefono, sActualizarCodigoCorreo, sActualizarCodigoDireccion;
        String sCodigoTelefono, sDesTelefono, sCodigoEmail, sDesEmail, sCodigoDireccion, sDesDireccion;
        public frmConsultaContactoPaciente()
        {
            InitializeComponent();
            btnCancelar.Enabled = true;
        }

        void funActualizar()
        {

            string sCodigo;
            string sTelefono;
            int iContador = 0;
            grdConsultaTelefono.Rows.Clear();


            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT ncodtelefono, ctelefono FROM TrTELEFONO"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sTelefono = mReader.GetString(1);
                    grdConsultaTelefono.Rows.Insert(iContador, sCodigo, sTelefono);
                    sCodigo = "";
                    sTelefono = "";
                    iContador++;
                }
                grdConsultaTelefono.ClearSelection();

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //------------funcion obtener codigo de persona--------------


        String funBuscarCodigoNombre(string nombs)
        {
            bool existe = false;
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                   "SELECT ncodpersona FROM MaPERSONA WHERE  cnombrepersona LIKE '{0}%' ", nombs), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    existe = true;
                    ncodigopersona = mReader.GetString(0);
                    //funBuscarTelefono(ncodigopersona);
                }
                if (existe == false)
                {
                    System.Console.WriteLine("no hay codigo");
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ncodigopersona;
        }


        String funBuscarCodigoApellido(string apes)
        {
            bool existe = false;
            try
            {
                MySqlCommand mComando2 = new MySqlCommand(String.Format(
                  "SELECT ncodpersona FROM MaPERSONA WHERE capellidopersona LIKE'{0}%'", apes), clasConexion.funConexion());
                MySqlDataReader mReader2 = mComando2.ExecuteReader();

                while (mReader2.Read())
                {
                    ncodigopersona2 = mReader2.GetString(0);
                    //funBuscarTelefono(ncodigopersona);
                }
                if (existe == false)
                {
                    System.Console.WriteLine("no hay codigo");
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ncodigopersona2;

        }
        //---------------fin funcion obtener codigo persona--------

        void funCancelar()
        {
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            grpActualizar.Enabled = false;
            grpActualizar2.Enabled = false;
            grpActualizar3.Enabled = false;
            txtActualizarTelefono.Enabled = false;
            txtActualizarCorreo.Enabled = false;
            txtActualizarDireccion.Enabled = false;
            grdConsultaCorreo.Rows.Clear();
            grdConsultaTelefono.Rows.Clear();
            grdConsultaDireccion.Rows.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
        }
        //------funcion para el boton cancelar------------

        void funCheqBoxTelefono()
        {
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCancelar.Enabled = true;
            grpActualizar.Enabled = true;
            txtActualizarTelefono.Enabled = true;
            grdConsultaTelefono.Enabled = true;
            grdConsultaCorreo.Enabled = false;
            grdConsultaDireccion.Enabled = false;

            //-------------bloquear otros-------
            grpActualizar2.Enabled = false;
            txtActualizarDireccion.Enabled = false;
            txtActualizarDireccion.Clear();
            grpActualizar3.Enabled = false;
            txtActualizarDireccion.Enabled = false;
            txtActualizarCorreo.Clear();
        }
        //----programacion para checkbox de telefono------

        void funCheqBoxEmail()
        {
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCancelar.Enabled = true;
            grpActualizar2.Enabled = true;
            txtActualizarCorreo.Enabled = true;
            grdConsultaTelefono.Enabled = false;
            grdConsultaCorreo.Enabled = true;
            grdConsultaDireccion.Enabled = false;

            //---------bloquear otros--------
            grpActualizar.Enabled = false;
            txtActualizarTelefono.Enabled = false;
            txtActualizarTelefono.Clear();
            grpActualizar3.Enabled = false;
            txtActualizarDireccion.Enabled = false;
            txtActualizarDireccion.Clear();
        }
        //----programacion para checkbox de Email----------
        void funCheqBoxDireccion()
        {
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCancelar.Enabled = true;
            grpActualizar3.Enabled = true;
            txtActualizarDireccion.Enabled = true;
            grdConsultaTelefono.Enabled = false;
            grdConsultaCorreo.Enabled = false;
            grdConsultaDireccion.Enabled = true;

            //------bloquear otros-----
            grpActualizar2.Enabled = false;
            txtActualizarCorreo.Enabled = false;

            txtActualizarTelefono.Clear();

            grpActualizar.Enabled = false;
            txtActualizarTelefono.Enabled = false;
            txtActualizarCorreo.Clear();
        }
        //----programacion para checkbox de Direccion-----



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ncodigopersona = "";
            int iContador = 0;
            int iContador2 = 0;
            int iContador3 = 0;
            bool existe = false;
            bool existe2 = false;
            bool existe3 = false;
            grdConsultaTelefono.Rows.Clear();
            grdConsultaCorreo.Rows.Clear();
            grdConsultaDireccion.Rows.Clear();
            //-------------prueba cortador--------------------
            String enviarnombre = txtNombre.Text;



            //............fin prueba cortador--------------------------
            if (txtNombre.Text.Equals("") || txtApellido.Text.Equals(""))
            {
                MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //funActualizar();
                //funCortarNombre();
                //System.Console.WriteLine("corte del nombre-----:  " + sCorteNombre);
                //System.Console.WriteLine("corte del apellido---:  " + sCorteApellido);
            }
            else
            {

                try
                {

                    String sNombrePersona = txtNombre.Text;
                    String sApellidoPersona = txtApellido.Text;
                    //funBuscarCodigo(sNombrePersona, sApellidoPersona);

                    //--------------primera consulta--------------------
                    MySqlCommand _comando = new MySqlCommand(String.Format(
                    "SELECT TrTELEFONO.ncodtelefono,TrTELEFONO.ctelefono from TrTELEFONO,MaPERSONA WHERE MaPERSONA.ncodpersona=TrTELEFONO.ncodpersona AND  MaPERSONA.ncodpersona='" + ncodigopersona + "'"), clasConexion.funConexion());
                    MySqlDataReader _reader = _comando.ExecuteReader();

                    while (_reader.Read())
                    {
                        existe = true;
                        sCodigoTelefono = _reader.GetString(0);
                        sDesTelefono = _reader.GetString(1);
                        grdConsultaTelefono.Rows.Insert(iContador, sCodigoTelefono, sDesTelefono);
                        sCodigoTelefono = "";
                        sDesTelefono = "";
                        iContador++;

                    }
                    //-------------------fin primera consulta-------------------------------

                    //--------------segunda consulta--------------------
                    MySqlCommand _comando2 = new MySqlCommand(String.Format(
                    "SELECT TrEMAIL.ncodemail,TrEMAIL.cemail from TrEMAIL,MaPERSONA WHERE MaPERSONA.ncodpersona=TrEMAIL.ncodpersona AND  MaPERSONA.ncodpersona='" + ncodigopersona + "'"), clasConexion.funConexion());
                    MySqlDataReader _reader2 = _comando2.ExecuteReader();

                    while (_reader2.Read())
                    {
                        existe2 = true;
                        sCodigoEmail = _reader2.GetString(0);
                        sDesEmail = _reader2.GetString(1);
                        //System.Console.WriteLine("prueba:------ " + sCodigoEmail);
                        //System.Console.WriteLine("prueba:------ " + sDesEmail);
                        grdConsultaCorreo.Rows.Insert(iContador2, sCodigoEmail, sDesEmail);
                        sCodigoEmail = "";
                        sDesEmail = "";
                        iContador2++;
                    }
                    //-------------------fin segunda consulta-------------------------------

                    //--------------tercera consulta--------------------
                    MySqlCommand _comando3 = new MySqlCommand(String.Format(
                    "SELECT TrDIRECCION.ncoddireccion,TrDIRECCION.cdireccion from TrDireccion,MaPERSONA WHERE MaPERSONA.ncodpersona=TrDireccion.ncodpersona AND MaPERSONA.ncodpersona='" + ncodigopersona + "'"), clasConexion.funConexion());
                    MySqlDataReader _reader3 = _comando3.ExecuteReader();

                    while (_reader3.Read())
                    {
                        existe3 = true;
                        sCodigoDireccion = _reader3.GetString(0);
                        sDesDireccion = _reader3.GetString(1);
                        //System.Console.WriteLine("prueba:------ " + sCodigoEmail);
                        //System.Console.WriteLine("prueba:------ " + sDesEmail);
                        grdConsultaDireccion.Rows.Insert(iContador3, sCodigoDireccion, sDesDireccion);
                        sCodigoDireccion = "";
                        sDesDireccion = "";
                        iContador3++;
                    }
                    //-------------------fin tercera consulta-------------------------------


                }
                catch
                {
                    MessageBox.Show("Error al buscar datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //funActualizar();
                }

                if (existe == false || existe2 == false || existe3 == false)
                {
                    MessageBox.Show("No se encontraron resultados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //funActualizar();
                    //btnCancelar.Enabled = false;
                    txtNombre.Clear();
                    txtApellido.Clear();
                }

            }

        }

        //------fin funcion par boton buscar---------------

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (rbTelefono.Checked == true)
            {
                String codigotel = sActualizarCodigoTelefono;
                String infotel = txtActualizarTelefono.Text;
                //MessageBox.Show("Telefono", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //System.Console.WriteLine("codigo de telefono" + hola);
                //System.Console.WriteLine("descripcion telefono" + hola2);

                try
                {
                    if (MessageBox.Show("¿Desea modificar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MySqlCommand mComando = new MySqlCommand(string.Format("UPDATE TrTELEFONO SET ctelefono='" + infotel + "' WHERE ncodtelefono='" + codigotel + "'"), clasConexion.funConexion());
                        mComando.ExecuteNonQuery();
                        //funActualizar();
                        MessageBox.Show("Se actualizo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //funCancelar();
                        //funActualizar();
                    }
                }
                catch
                {
                    MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }//----------fin primer if-----------
            else if (rbCorreo.Checked == true)
            {
                //MessageBox.Show("Correo Actualizado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                String codigoEmail = sActualizarCodigoCorreo;
                String infoEmail = txtActualizarCorreo.Text;
                //MessageBox.Show("Telefono", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //System.Console.WriteLine("codigo de telefono" + hola);
                //System.Console.WriteLine("descripcion telefono" + hola2);

                try
                {
                    if (MessageBox.Show("¿Desea modificar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MySqlCommand mComando = new MySqlCommand(string.Format("UPDATE TrEMAIL SET cemail='" + infoEmail + "' WHERE ncodemail='" + codigoEmail + "'"), clasConexion.funConexion());
                        mComando.ExecuteNonQuery();
                        //funActualizar();
                        MessageBox.Show("Se actualizo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //funCancelar();
                        //funActualizar();
                    }
                }
                catch
                {
                    MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }//--------fin segundo if----------
            else if (rbDireccion.Checked == true)
            {
                //MessageBox.Show("direccion Actualizada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                String codigoDireccion = sActualizarCodigoDireccion;
                String infoDireccion = txtActualizarDireccion.Text;
                //MessageBox.Show("Telefono", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //System.Console.WriteLine("codigo de telefono" + hola);
                //System.Console.WriteLine("descripcion telefono" + hola2);

                try
                {
                    if (MessageBox.Show("¿Desea modificar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MySqlCommand mComando = new MySqlCommand(string.Format("UPDATE TrDIRECCION SET cdireccion='" + infoDireccion + "' WHERE ncoddireccion='" + codigoDireccion + "'"), clasConexion.funConexion());
                        mComando.ExecuteNonQuery();
                        //funActualizar();
                        MessageBox.Show("Se actualizo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //funCancelar();
                        //funActualizar();
                    }
                }
                catch
                {
                    MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }//-------------fin tercer if---------
            else if (rbTelefono.Checked == false && rbDireccion.Checked == false && rbCorreo.Checked == false)
            {
                MessageBox.Show("Para Actualizar Seleccione una opcion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }//--------fin cuarto if----------------
        }
        //------fin funcion par boton actualizar---------------

        private void rbTelefono_Click(object sender, EventArgs e)
        {
            funCheqBoxTelefono();


        }

        private void rbCorreo_Click(object sender, EventArgs e)
        {
            funCheqBoxEmail();

        }

        private void rbDireccion_Click(object sender, EventArgs e)
        {
            funCheqBoxDireccion();

        }

        private void grdConsultaTelefono_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = grdConsultaTelefono.CurrentRow;
            sActualizarCodigoTelefono = Convert.ToString(fila.Cells[0].Value);
            txtActualizarTelefono.Text = Convert.ToString(fila.Cells[1].Value);
        }

        private void grdConsultaCorreo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = grdConsultaCorreo.CurrentRow;
            sActualizarCodigoCorreo = Convert.ToString(fila.Cells[0].Value);
            txtActualizarCorreo.Text = Convert.ToString(fila.Cells[1].Value);
        }

        private void grdConsultaDireccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = grdConsultaDireccion.CurrentRow;
            sActualizarCodigoDireccion = Convert.ToString(fila.Cells[0].Value);
            txtActualizarDireccion.Text = Convert.ToString(fila.Cells[1].Value);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            funCancelar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (rbTelefono.Checked == true)
            {
                String codigotel = sActualizarCodigoTelefono;
                //String infotel = txtActualizarTelefono.Text;
                //MessageBox.Show("Telefono", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //System.Console.WriteLine("codigo de telefono" + hola);
                //System.Console.WriteLine("descripcion telefono" + hola2);

                try
                {
                    if (MessageBox.Show("¿Desea Eliminar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MySqlCommand mComando = new MySqlCommand(string.Format("DELETE FROM TrTELEFONO WHERE ncodtelefono='" + codigotel + "'"), clasConexion.funConexion());
                        mComando.ExecuteNonQuery();
                        //funActualizar();
                        MessageBox.Show("Se actualizo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //funCancelar();
                        //funActualizar();
                    }
                }
                catch
                {
                    MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }//----------fin primer if-----------
            else if (rbCorreo.Checked == true)
            {
                //MessageBox.Show("Correo Actualizado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                String codigoEmail = sActualizarCodigoCorreo;
                //String infoEmail = txtActualizarCorreo.Text;
                //MessageBox.Show("Telefono", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //System.Console.WriteLine("codigo de telefono" + hola);
                //System.Console.WriteLine("descripcion telefono" + hola2);

                try
                {
                    if (MessageBox.Show("¿Desea Eliminar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MySqlCommand mComando = new MySqlCommand(string.Format("DELETE FROM TrEMAIL WHERE ncodemail='" + codigoEmail + "'"), clasConexion.funConexion());
                        mComando.ExecuteNonQuery();
                        //funActualizar();
                        MessageBox.Show("Se actualizo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //funCancelar();
                        //funActualizar();
                    }
                }
                catch
                {
                    MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }//--------fin segundo if----------
            else if (rbDireccion.Checked == true)
            {
                //MessageBox.Show("direccion Actualizada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                String codigoDireccion = sActualizarCodigoDireccion;
                String infoDireccion = txtActualizarDireccion.Text;
                //MessageBox.Show("Telefono", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //System.Console.WriteLine("codigo de telefono" + hola);
                //System.Console.WriteLine("descripcion telefono" + hola2);

                try
                {
                    if (MessageBox.Show("¿Decea Eliminar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MySqlCommand mComando = new MySqlCommand(string.Format("DELETE FROM TrDIRECCION WHERE ncoddireccion='" + codigoDireccion + "'"), clasConexion.funConexion());
                        mComando.ExecuteNonQuery();
                        //funActualizar();
                        MessageBox.Show("Se actualizo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //funCancelar();
                        //funActualizar();
                    }
                }
                catch
                {
                    MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }//-------------fin tercer if---------
            else if (rbTelefono.Checked == false && rbDireccion.Checked == false && rbCorreo.Checked == false)
            {
                MessageBox.Show("Para Actualizar Seleccione una opcion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }//--------fin cuarto if----------------
        }
        //------fin funcion par boton eliminar---------------

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        //------fin funcion par boton home---------------

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }



        private void txtActualizarTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        //------------funcion para cuando el usuario suelte la tecla nombre-----------
        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            ncodigopersona = "";


            grdConsultaTelefono.Rows.Clear();
            grdConsultaCorreo.Rows.Clear();
            grdConsultaDireccion.Rows.Clear();

            String sNombrePersona = txtNombre.Text;
            funBuscarCodigoNombre(sNombrePersona);
            //--------------primera consulta--------------------
            int iContador = 0;
            MySqlCommand _comando = new MySqlCommand(String.Format(
            "SELECT TrTELEFONO.ncodtelefono,TrTELEFONO.ctelefono from TrTELEFONO,MaPERSONA WHERE MaPERSONA.ncodpersona=TrTELEFONO.ncodpersona AND  MaPERSONA.ncodpersona='" + ncodigopersona + "'"), clasConexion.funConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {

                sCodigoTelefono = _reader.GetString(0);
                sDesTelefono = _reader.GetString(1);
                grdConsultaTelefono.Rows.Insert(iContador, sCodigoTelefono, sDesTelefono);
                sCodigoTelefono = "";
                sDesTelefono = "";
                iContador++;

            }
            //-------------------fin primera consulta-------------------------------
            //--------------segunda consulta--------------------
            int iContador2 = 0;
            MySqlCommand _comando2 = new MySqlCommand(String.Format(
            "SELECT TrEMAIL.ncodemail,TrEMAIL.cemail from TrEMAIL,MaPERSONA WHERE MaPERSONA.ncodpersona=TrEMAIL.ncodpersona AND  MaPERSONA.ncodpersona='" + ncodigopersona + "'"), clasConexion.funConexion());
            MySqlDataReader _reader2 = _comando2.ExecuteReader();

            while (_reader2.Read())
            {

                sCodigoEmail = _reader2.GetString(0);
                sDesEmail = _reader2.GetString(1);
                //System.Console.WriteLine("prueba:------ " + sCodigoEmail);
                //System.Console.WriteLine("prueba:------ " + sDesEmail);
                grdConsultaCorreo.Rows.Insert(iContador2, sCodigoEmail, sDesEmail);
                sCodigoEmail = "";
                sDesEmail = "";
                iContador2++;
            }
            //-------------------fin segunda consulta-------------------------------
            //--------------tercera consulta--------------------
            int iContador3 = 0;
            MySqlCommand _comando3 = new MySqlCommand(String.Format(
            "SELECT TrDIRECCION.ncoddireccion,TrDIRECCION.cdireccion from TrDireccion,MaPERSONA WHERE MaPERSONA.ncodpersona=TrDireccion.ncodpersona AND MaPERSONA.ncodpersona='" + ncodigopersona + "'"), clasConexion.funConexion());
            MySqlDataReader _reader3 = _comando3.ExecuteReader();

            while (_reader3.Read())
            {
                sCodigoDireccion = _reader3.GetString(0);
                sDesDireccion = _reader3.GetString(1);
                //System.Console.WriteLine("prueba:------ " + sCodigoEmail);
                //System.Console.WriteLine("prueba:------ " + sDesEmail);
                grdConsultaDireccion.Rows.Insert(iContador3, sCodigoDireccion, sDesDireccion);
                sCodigoDireccion = "";
                sDesDireccion = "";
                iContador3++;
            }
            //-------------------fin tercera consulta--------------------------


        }//------------fin de funcion para cuando el usuario suelte la tecla nombre----

        //------------funcion para cuando el usuario suelte la tecla apellido-----------

        private void txtApellido_KeyUp(object sender, KeyEventArgs e)
        {
            ncodigopersona2 = "";
            grdConsultaTelefono.Rows.Clear();
            grdConsultaCorreo.Rows.Clear();
            grdConsultaDireccion.Rows.Clear();
            //-------------prueba cortador--------------------
            // String enviarnombre = txtNombre.Text;
            //String sNombrePersona = txtNombre.Text;
            String sApellidoPersona = txtApellido.Text;
            funBuscarCodigoApellido(sApellidoPersona);
            //-----------primera consulta--------------
            //--------------primera consulta--------------------
            int iContador = 0;
            MySqlCommand _comando = new MySqlCommand(String.Format(
            "SELECT TrTELEFONO.ncodtelefono,TrTELEFONO.ctelefono from TrTELEFONO,MaPERSONA WHERE MaPERSONA.ncodpersona=TrTELEFONO.ncodpersona AND  MaPERSONA.ncodpersona='" + ncodigopersona2 + "'"), clasConexion.funConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {

                sCodigoTelefono = _reader.GetString(0);
                sDesTelefono = _reader.GetString(1);
                grdConsultaTelefono.Rows.Insert(iContador, sCodigoTelefono, sDesTelefono);
                sCodigoTelefono = "";
                sDesTelefono = "";
                iContador++;

            }
            //-------------------fin primera consulta-------------------------------

            //--------------segunda consulta--------------------
            int iContador2 = 0;
            MySqlCommand _comando2 = new MySqlCommand(String.Format(
            "SELECT TrEMAIL.ncodemail,TrEMAIL.cemail from TrEMAIL,MaPERSONA WHERE MaPERSONA.ncodpersona=TrEMAIL.ncodpersona AND  MaPERSONA.ncodpersona='" + ncodigopersona2 + "'"), clasConexion.funConexion());
            MySqlDataReader _reader2 = _comando2.ExecuteReader();

            while (_reader2.Read())
            {

                sCodigoEmail = _reader2.GetString(0);
                sDesEmail = _reader2.GetString(1);
                //System.Console.WriteLine("prueba:------ " + sCodigoEmail);
                //System.Console.WriteLine("prueba:------ " + sDesEmail);
                grdConsultaCorreo.Rows.Insert(iContador2, sCodigoEmail, sDesEmail);
                sCodigoEmail = "";
                sDesEmail = "";
                iContador2++;
            }
            //-------------------fin segunda consulta-------------------------------

            //--------------tercera consulta--------------------
            int iContador3 = 0;
            MySqlCommand _comando3 = new MySqlCommand(String.Format(
            "SELECT TrDIRECCION.ncoddireccion,TrDIRECCION.cdireccion from TrDireccion,MaPERSONA WHERE MaPERSONA.ncodpersona=TrDireccion.ncodpersona AND MaPERSONA.ncodpersona='" + ncodigopersona2 + "'"), clasConexion.funConexion());
            MySqlDataReader _reader3 = _comando3.ExecuteReader();

            while (_reader3.Read())
            {
                sCodigoDireccion = _reader3.GetString(0);
                sDesDireccion = _reader3.GetString(1);
                //System.Console.WriteLine("prueba:------ " + sCodigoEmail);
                //System.Console.WriteLine("prueba:------ " + sDesEmail);
                grdConsultaDireccion.Rows.Insert(iContador3, sCodigoDireccion, sDesDireccion);
                sCodigoDireccion = "";
                sDesDireccion = "";
                iContador3++;
            }
            //-------------------fin tercera consulta--------------------------

        }

        //------------fin de funcion para cuando el usuario suelte la tecla apellido----

    }
}
