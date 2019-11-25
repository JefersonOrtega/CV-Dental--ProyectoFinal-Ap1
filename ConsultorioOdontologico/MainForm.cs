using ConsultorioOdontologico.UI;
using ConsultorioOdontologico.UI.Consultas;
using ConsultorioOdontologico.UI.Registros;
using ConsultorioOdontologico.UI.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioOdontologico
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void historialDeCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProcedimientos rHistorialCitas = new rProcedimientos();
            rHistorialCitas.MdiParent = this;
            rHistorialCitas.Show();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rPaciente rPaciente = new rPaciente();
            rPaciente.MdiParent = this;
            rPaciente.Show();
        }

        

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCitas rCitas = new rCitas();
            rCitas.MdiParent = this;
            rCitas.Show();
        }

        private void procedimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProcedimientos rProcedimientos = new rProcedimientos();
            rProcedimientos.MdiParent=this;
            rProcedimientos.Show();
        }

        private void tiposDeProcedimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTiposProcedimientos rTiposProcedimientos = new rTiposProcedimientos();
            rTiposProcedimientos.MdiParent = this;
            rTiposProcedimientos.Show();
        }

        private void cobrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCobros rCobros = new rCobros();
            rCobros.MdiParent = this;
            rCobros.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UsuarioLabel.Text = Login.UsuarioActivo.Nombre;
            if (UsuarioLabel.Text == "Administrador")
            {
                usuariosToolStripMenuItem1.Visible = true;
                usuariosToolStripMenuItem2.Visible = true;
            }
            else
            {
                usuariosToolStripMenuItem1.Visible = false;
                usuariosToolStripMenuItem2.Visible = false;
            }


            
        }

        private void editarInformaciónDeInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pacientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cPacientes cPacientes = new cPacientes();
            cPacientes.MdiParent = this;
            cPacientes.Show();
        }

       

        private void citasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cCitas cCitas = new cCitas();
            cCitas.MdiParent = this;
            cCitas.Show();
        }

        private void tiposDeProcedimientosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cTiposProcedimientos cTiposProcedimientos = new cTiposProcedimientos();
            cTiposProcedimientos.MdiParent = this;
            cTiposProcedimientos.Show();
        }

        private void procedimientosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cProcedimientos cProcedimiento = new cProcedimientos();
            cProcedimiento.MdiParent = this;
            cProcedimiento.Show();
        }

        private void reporteDeCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* CitasReportViewer ReportesCitas = new CitasReportViewer(CitasReportViewer.ListaCitas);
            ReportesCitas.MdiParent = this;
            ReportesCitas.Show();*/
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void cobrisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cCobros cCobros = new cCobros();
            cCobros.MdiParent = this;
            cCobros.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cUsuarios cUsuarios = new cUsuarios();
            cUsuarios.MdiParent = this;
            cUsuarios.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            Dispose();

            login.ShowDialog();
        }

        private void usuariosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            rUsuarios rUsuarios = new rUsuarios();
            rUsuarios.MdiParent = this;
            rUsuarios.Show();
        }
    }
}
