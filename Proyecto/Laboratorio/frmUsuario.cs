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
     * Fecha de entrega: 07/08/2015
    ---------------------------------------------------------------------------------------------------------------------------------*/

    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
            funCargarCombos();
        }

        private void funCargarCombos()
        {
            String sNombre;
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM MaPERSONA WHERE ncodpersona IN (SELECT ncodpersona FROM TrEMPLEADO)"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();
                while (mReader.Read())
                {
                    sNombre = mReader.GetString(0) + " " + mReader.GetString(1);
                    cmbEmpleado.Items.Add(sNombre);
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String sEmpleado = "";
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtPass.Text) || String.IsNullOrEmpty(cmbEmpleado.Text) || String.IsNullOrEmpty(cmbTipo.Text))
            {
                MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format("SELECT ncodusuario FROM TrUSUARIO WHERE cnombreusuario = '{0}'", txtNombre.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();
                    if (mReader.Read())
                    {
                        MessageBox.Show("Ese nombre de usuario ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string[] Nombres = cmbEmpleado.Text.Split(' ');
                        MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT ncodempleado FROM TrEMPLEADO WHERE ncodpersona = (SELECT ncodpersona FROM MaPERSONA WHERE cnombrepersona = '{0}' AND capellidopersona = '{1}')", Nombres[0], Nombres[1]), clasConexion.funConexion());
                        MySqlDataReader mReader2 = mComando2.ExecuteReader();
                        if (mReader2.Read())
                            sEmpleado = mReader2.GetString(0);


                        MySqlCommand comando4 = new MySqlCommand(string.Format("Insert into TrUSUARIO(cnombreusuario, ctipousuario, cpasswordusuario, ncodempleado)  values ('{0}','{1}','{2}','{3}')", txtNombre.Text, cmbTipo.Text, txtPass.Text, sEmpleado), clasConexion.funConexion());
                        comando4.ExecuteNonQuery();
                        MessageBox.Show("Usuario Creado con Exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombre.Text = txtPass.Text = cmbEmpleado.Text = cmbTipo.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = txtPass.Text = cmbEmpleado.Text = cmbTipo.Text = "";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
