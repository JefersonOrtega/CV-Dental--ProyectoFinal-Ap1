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
    public partial class cCitas : Form
    {
        private List<Citas> ListaCitas;
        public cCitas()
        {
            InitializeComponent();
        }

        private void FiltrarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltrarComboBox.SelectedIndex == 2)
            {
                CriterioTextBox.Visible = false;
                EstadoComboBox.Visible = false;
                PacientesComboBox.Visible = true;
                RepositorioBase<Pacientes> repositorioPacientes = new RepositorioBase<Pacientes>();
                var Lista = repositorioPacientes.GetList(p => true);
                PacientesComboBox.ValueMember = "PacienteId";
                PacientesComboBox.DisplayMember = "Nombre";
                PacientesComboBox.DataSource = Lista;
            }
            else
            {
                if(FiltrarComboBox.SelectedIndex == 3)
                {
                    CriterioTextBox.Visible = false;
                    PacientesComboBox.Visible = false;
                    EstadoComboBox.Visible = true;
                    RepositorioBase<Citas> repositorioCitas = new RepositorioBase<Citas>();
                    var Lista = repositorioCitas.GetList(p => true);
                    PacientesComboBox.ValueMember = "CitaId";
                    PacientesComboBox.DisplayMember = "Estado";
                    PacientesComboBox.DataSource = Lista;
                }
                else
                {
                    CriterioTextBox.Visible = true;
                    EstadoComboBox.Visible = false;
                    PacientesComboBox.Visible = false;
                }
            }
            
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Citas>();
            RepositorioBase<Citas> repositorio = new RepositorioBase<Citas>();
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
                            listado = repositorio.GetList(p => p.CitaId == id);
                            break;
                        }
                    case 2: //Paciente
                        {
                            int id = Convert.ToInt32(PacientesComboBox.SelectedValue);
                            listado = repositorio.GetList(p => p.PacienteId == id);
                            break;
                        }

                    case 3: //Estado
                        {
                            string estado = Convert.ToString(EstadoComboBox.SelectedItem);
                            listado = repositorio.GetList(p => p.Estado.Contains(estado));
                            break;
                        }

                }
                listado = listado.Where(c => c.Fecha.Date >= DesdeDateTimePicker.Value.Date && c.Fecha.Date <= HastaDateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = repositorio.GetList(p => true);
            }

            ListaCitas = listado;
            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }

        private void cCitas_Load(object sender, EventArgs e)
        {

        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
          
        }

        private void ImprimirButton_Click_1(object sender, EventArgs e)
        {
            if (ListaCitas.Count == 0)
            {
                MessageBox.Show("No hay datos para imprimir");
                return;
            }

            CitasReportViewer citasReportViewer = new CitasReportViewer(ListaCitas);
            citasReportViewer.ShowDialog();
        }
    }
}
