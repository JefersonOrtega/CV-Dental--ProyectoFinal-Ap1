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
    public partial class cCobros : Form
    {
        private List<Cobros> ListaCobros;
        public cCobros()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Cobros>();
            RepositorioBase<Cobros> repositorio = new RepositorioBase<Cobros>();
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
                            listado = repositorio.GetList(p => p.CobroId == id);
                            break;
                        }

                    case 2: //Abono
                        {

                            int abono = Convert.ToInt32(CriterioTextBox.Text);
                            listado = repositorio.GetList(p => p.Abono == abono); 
                            break;
                        }

                    case 3: //Registrado por
                        {
                            int id = Convert.ToInt32(UsuariosComboBox.SelectedValue);
                            listado = repositorio.GetList(p => p.UsuarioId == id);
                            break;
                        }


                }
                listado = listado.Where(c => c.Fecha.Date >= DesdeDateTimePicker.Value.Date && c.Fecha.Date <= HastaDateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = repositorio.GetList(p => true);
            }
            ListaCobros = listado;
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

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            if (ListaCobros.Count == 0)
            {
                MessageBox.Show("No hay datos que imprimir");
                return;
            }

            CobrosReportViewer cobrosReportViewer = new CobrosReportViewer(ListaCobros);
            cobrosReportViewer.ShowDialog();
        }
    }
}
