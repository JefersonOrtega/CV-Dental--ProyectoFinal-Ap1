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
    public partial class cTiposProcedimientos : Form
    {
        private List<TiposProcedimientos> ListaTiposProcedimientos;
        public cTiposProcedimientos()
        {
            InitializeComponent();
        }

        private void cTiposProcedimientos_Load(object sender, EventArgs e)
        {

        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<TiposProcedimientos>();
            RepositorioBase<TiposProcedimientos> repositorio = new RepositorioBase<TiposProcedimientos>();
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
                            listado = repositorio.GetList(p => p.TipoProcedimientoId == id);
                            break;
                        }

                    case 2: //Nombre
                        {
                            listado = repositorio.GetList(p => p.NombreProcedimiento.Contains(CriterioTextBox.Text));
                            break;
                        }
                    case 3: //Precio
                        {
                            decimal precio = Convert.ToDecimal(CriterioTextBox.Text);
                            listado = repositorio.GetList(p => p.Precio == precio);
                            break;
                        }
     
                }

            }
            else
            {
                listado = repositorio.GetList(p => true);
            }
            ListaTiposProcedimientos = listado;
            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            if (ListaTiposProcedimientos != null)
            {
                 if (ListaTiposProcedimientos.Count == 0)
            {
                MessageBox.Show("No hay datos que imprimir");
                return;
            }

            TiposProcedimientosReportViewer tiposProcedimientosReportViewer = new TiposProcedimientosReportViewer(ListaTiposProcedimientos);
            tiposProcedimientosReportViewer.ShowDialog();
            }
           
        }
    }
}
