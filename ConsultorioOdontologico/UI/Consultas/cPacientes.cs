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
    public partial class cPacientes : Form
    {
        private List<Pacientes> ListaPacientes;
        public cPacientes()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Pacientes>();
            RepositorioBase<Pacientes> repositorio = new RepositorioBase<Pacientes>();
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
                            listado = repositorio.GetList(p => p.PacienteId == id);
                            break;
                        }

                    case 2: //Nombres
                        {
                            listado = repositorio.GetList(p => p.Nombres.Contains(CriterioTextBox.Text));
                            break;
                        }

                    case 3: //Apellidos
                        {
                            listado = repositorio.GetList(p => p.Apellidos.Contains(CriterioTextBox.Text));
                            break;
                        }

                    case 4: //Registrado por
                        {
                            int id = Convert.ToInt32(UsuariosComboBox.SelectedValue);
                            listado = repositorio.GetList(p => p.UsuarioId==id);
                            break;
                        }

                    
                }
                listado = listado.Where(c => c.FechaRegistro.Date >= DesdeDateTimePicker.Value.Date && c.FechaRegistro.Date <= HastaDateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = repositorio.GetList(p => true);
            }
            ListaPacientes = listado;
            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }

        private void FiltrarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltrarComboBox.SelectedIndex == 4)
            {
                CriterioTextBox.Visible = false;
                UsuariosComboBox.Visible = true;
                RepositorioBase<Usuarios> repositorioUsuarios = new RepositorioBase<Usuarios>();
                var Lista = repositorioUsuarios.GetList(p => true);
                UsuariosComboBox.ValueMember = "UsuarioId";
                UsuariosComboBox.DisplayMember = "Nombre";
                UsuariosComboBox.DataSource = Lista;
            }
            else
            {
                CriterioTextBox.Visible = true;
            }
        }

        private void FiltrarComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void cPacientes_Load(object sender, EventArgs e)
        {

        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            if (ListaPacientes.Count == 0)
            {
                MessageBox.Show("No hay datos que imprimir");
                return;
            }

            PacientesReportViewer pacientesReportViewer = new PacientesReportViewer(ListaPacientes);
            pacientesReportViewer.ShowDialog();
        }
    }
}
