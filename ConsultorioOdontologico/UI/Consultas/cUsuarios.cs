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
    public partial class cUsuarios : Form
    {
        private List<Usuarios> ListaUsuarios;
        public cUsuarios()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Usuarios>();
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrarComboBox.SelectedIndex)
                {
                    case 0: //Todo
                        {

                            listado = repositorio.GetList(u => true);
                            break;
                        }

                    case 1: //Id
                        {
                            int id = Convert.ToInt32(CriterioTextBox.Text);
                            listado = repositorio.GetList(u => u.UsuarioId == id);
                            break;
                        }

                    case 2: //Nombres
                        {
                            listado = repositorio.GetList(u => u.Nombre.Contains(CriterioTextBox.Text));
                            break;
                        }
                    case 3: //Tipo
                        {
                            listado = repositorio.GetList(u => u.Tipo.Contains(CriterioTextBox.Text));
                            break;
                        }

                    case 4: //NombreUsuario
                        {
                            listado = repositorio.GetList(u => u.NombreUsuario.Contains(CriterioTextBox.Text));
                            break;
                        }

                }

            }
            else
            {
                listado = repositorio.GetList(p => true);
            }
            ListaUsuarios = listado;
            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            if (ListaUsuarios != null)
            {
                if (ListaUsuarios.Count == 0)
                {
                    MessageBox.Show("No hay datos que imprimir");
                    return;
                }

                UsuariosReportViewer usuariosReportViewer = new UsuariosReportViewer(ListaUsuarios);
                usuariosReportViewer.ShowDialog();
            }
        }
    }
}
