using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal(String tipo)
        {
            InitializeComponent();
            if(tipo == "secre"){
                mOtros.Enabled = false;
            }else if (tipo == "doc")
            {
                mPaciente.Enabled = false;
                mEmpleado.Enabled = false;
                mCitas.Enabled = false;
                //mCotizacion.Enabled = false;
                mAnalisis.Enabled = false;
                mOtros.Enabled = false;
            }
        }

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void ingresarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaciente ver = new frmPaciente();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("¿Desea cerrar sesion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmLogIn ver = new frmLogIn();
                ver.Show();
                this.Close();
            }  
            
        }

        private void mCotizacion_Click(object sender, EventArgs e)
        {

        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAseguradora ver = new frmAseguradora();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sbmModificarPaciente_Click(object sender, EventArgs e)
        {
            frmConsultaPacientes ver = new frmConsultaPacientes();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void sbmIngresarCitas_Click(object sender, EventArgs e)
        {
            frmIngresoCita ver = new frmIngresoCita();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void sbmModificarCitas_Click(object sender, EventArgs e)
        {
            frmConsultaCita ver = new frmConsultaCita();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void sbmCrearEtiqueta_Click(object sender, EventArgs e)
        {
            frmEtiqueta muestra = new frmEtiqueta();
            muestra.MdiParent = this;
            pictureBox1.Visible = false;
            muestra.Show();
        }

        private void sbmIngresarExamenes_Click(object sender, EventArgs e)
        {
            frmTipoExamen muestra = new frmTipoExamen();
            muestra.MdiParent = this;
            pictureBox1.Visible = false;
            muestra.Show();
        }

        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAseguradora ver = new frmAseguradora();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void consultarYModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaAseguradora ver = new frmConsultaAseguradora();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void ingresarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSucursal ver = new frmSucursal();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void consultarYModificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaSucursal ver = new frmConsultaSucursal();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPuesto ver = new frmPuesto();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void consultarYModificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultarPuesto ver = new frmConsultarPuesto();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void ingresoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTarifaSeguro ver = new frmTarifaSeguro();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void consultarYModificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmConsultarTarifa ver = new frmConsultarTarifa();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void msbmIngresar_Click(object sender, EventArgs e)
        {
            frmMembresia ver = new frmMembresia();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void msbmConsultaryModificar_Click(object sender, EventArgs e)
        {
            frmConsultaMembresia ver = new frmConsultaMembresia();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void consultaYModificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaSeguro ver = new frmConsultaSeguro();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void ingresoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmSeguro ver = new frmSeguro();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }
        private void sbmConsultaMuestra_Click(object sender, EventArgs e)
        {
            frmConsultaMuestra ver = new frmConsultaMuestra();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void sbmIngresarMuestra_Click(object sender, EventArgs e)
        {
            frmMuestra muestra = new frmMuestra();
            muestra.MdiParent = this;
            pictureBox1.Visible = false;
            muestra.Show();
        }
        private void sbmIngresarEmpleado_Click(object sender, EventArgs e)
        {
            frmEmpleados ver = new frmEmpleados();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void sbmModificarEmpleado_Click(object sender, EventArgs e)
        {
            frmConsultaEmpleados ver = new frmConsultaEmpleados();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void sbmConsultaryModifExamenes_Click(object sender, EventArgs e)
        {
            frmConsultaTipoExamen ver = new frmConsultaTipoExamen();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void smGenerarFactura_Click(object sender, EventArgs e)
        {
            frmFactura ver = new frmFactura();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void ingresarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAnalisis ver = new frmAnalisis();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void consultarYModificarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmConsultaAnalisis ver = new frmConsultaAnalisis();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void ingresarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmUsuario ver = new frmUsuario();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void consultarYModificarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmConultaUsuario ver = new frmConultaUsuario();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.Topic, "Manual de usuario");
        }

        private void realizarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRealizarPago ver = new frmRealizarPago();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void modificarContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaContactoPaciente ver = new frmConsultaContactoPaciente();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void modificarContactoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaContactoEmpleado ver = new frmConsultaContactoEmpleado();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void ultimaVisitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteUltimaVisita ver = new frmReporteUltimaVisita();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void correoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnviarReporte ver = new frmEnviarReporte();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void examenToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void tiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteTipoExamen ver = new frmReporteTipoExamen();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void disponibilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteDisponibilidad ver = new frmReporteDisponibilidad();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void registroClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteRegistroClientes ver = new frmReporteRegistroClientes();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void fechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteFechaHora ver = new frmReporteFechaHora();
            ver.MdiParent = this;
            pictureBox1.Visible = false;
            ver.Show();
        }

        private void sbmCotizacion_Click(object sender, EventArgs e)
        {
            frmCotizacion ver = new frmCotizacion();
            ver.Show();
        }
    }
}
