using ConsultorioOdontologico.BLL;
using ConsultorioOdontologico.Entidades;
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

namespace ConsultorioOdontologico.UI.Consultas
{
    public partial class cProcedimientos : Form
    {
        private List<Procedimientos> ListaProcedimientos;
        public cProcedimientos()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Procedimientos>();
            RepositorioBase<Procedimientos> repositorio = new RepositorioBase<Procedimientos>();
            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrarComboBox.SelectedIndex)
                {
                    case 0: //Todo
                        {

                            listado = repositorio.GetList(p => true);
                            break;
                        }

                    case 1: //Id
                        {
                            int id = Convert.ToInt32(CriterioTextBox.Text);
                            listado = repositorio.GetList(p => p.ProcedimientoId == id);
                            break;
                        }

                    case 2: //Paciente
                        {
                            int id = Convert.ToInt32(PacientesComboBox.SelectedValue);
                            listado = repositorio.GetList(p => p.PacienteId == id);
                            break;
                        }

                    case 3: //Tipo de Procedimiento
                        {
                            string tipoProcedimiento = Convert.ToString(TipoProcedimientoComboBox.SelectedItem);
                            listado = repositorio.GetList(p => p.Estado.Contains(tipoProcedimiento));
                            break;
                        }

                    case 4: //Monto
                        {
                            decimal monto = Convert.ToDecimal(CriterioTextBox.Text);
                            listado = repositorio.GetList(p => p.Monto == monto);
                            break;
                        }
                    case 5: //Cobrados
                        {
                            listado = repositorio.GetList(p => p.Cobrado == true);
                            break;
                        }
                    case 6: //No Cobradas
                        {
                            listado = repositorio.GetList(p => p.Cobrado == false);
                            break;
                        }

                }
            }
            else
            {
                listado = repositorio.GetList(p => true);
            }
            ListaProcedimientos = listado;
            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }

        private void FiltrarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltrarComboBox.SelectedIndex == 2)
            {
                CriterioTextBox.Visible = false;
                PacientesComboBox.Visible = true;
                RepositorioBase<Pacientes> repositorioPacientes = new RepositorioBase<Pacientes>();
                var Lista = repositorioPacientes.GetList(p => true);
                PacientesComboBox.ValueMember = "PacienteId";
                PacientesComboBox.DisplayMember = "Nombre";
                PacientesComboBox.DataSource = Lista;
            }
            else
            {
                if (FiltrarComboBox.SelectedIndex == 3)
                {
                    TipoProcedimientoComboBox.Visible = true;
                    RepositorioBase<TiposProcedimientos> repositorioCitas = new RepositorioBase<TiposProcedimientos>();
                    var Lista = repositorioCitas.GetList(p => true);
                    PacientesComboBox.ValueMember = "TipoProcedimientoId";
                    PacientesComboBox.DisplayMember = "NombreProcedimiento";
                    PacientesComboBox.DataSource = Lista;
                }
                else
                {
                    CriterioTextBox.Visible = true;
                    TipoProcedimientoComboBox.Visible = false;
                }
            }
        }


        private void cProcedimientos_Load(object sender, EventArgs e)
        {
            if (FiltrarComboBox.SelectedIndex == 4)
            {
                CriterioTextBox.Visible = false;
                PacientesComboBox.Visible = true;
                RepositorioBase<Pacientes> repositorioPacientes = new RepositorioBase<Pacientes>();
                var Lista = repositorioPacientes.GetList(p => true);
                PacientesComboBox.ValueMember = "PacienteId";
                PacientesComboBox.DisplayMember = "Nombre";
                PacientesComboBox.DataSource = Lista;
            }
            else
            {
                CriterioTextBox.Visible = true;
            }
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            if (ListaProcedimientos.Count == 0)
            {
                MessageBox.Show("No hay datos que imprimir");
                return;
            }

            ProcedimientosReportViewer procedimientosReportViewer = new ProcedimientosReportViewer(ListaProcedimientos);
            procedimientosReportViewer.ShowDialog();
        }
    }
}

    