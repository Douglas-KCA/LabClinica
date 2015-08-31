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
* Fecha de asignacion: 07/08/2015
* Fecha de entrega: 10/08/2015
---------------------------------------------------------------------------------------------------------------------------------*/
    public partial class frmLogIn : Form
    {

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que carga los componentes iniciales del form
        ---------------------------------------------------------------------------------------------------------------------------------*/
        public frmLogIn()
        {
            InitializeComponent();
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
           Funcion que obtiene el tipo de usuario que se ingresa y envia un parametro al form del menu principal para bloquear o
           avilitar opciones del menu principal
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            String sTipo, sCodigo;
            if (String.IsNullOrEmpty(txtUsuario.Text) || String.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Por favor llene nombre de usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format("SELECT ctipousuario, ncodusuario FROM TrUSUARIO WHERE cnombreusuario = '{0}' AND cpasswordusuario = '{1}' ", txtUsuario.Text, txtPass.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();
                    if (mReader.Read())
                    {
                        sTipo = mReader.GetString(0);
                        sCodigo = mReader.GetString(1);
                        frmMenuPrincipal ver = new frmMenuPrincipal(sTipo);
                        ver.lblCodigoUsuario.Text = sCodigo;
                        ver.lblNombreUsuario.Text = txtUsuario.Text;
                        ver.Show();
                        this.Hide();
                    }
                    else {
                        MessageBox.Show("Passwor o Usuario incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(MySqlException ex) {
                    MessageBox.Show("Se produjo un error "+ ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
