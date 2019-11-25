using ConsultorioOdontologico.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioOdontologico.UI.Reportes
{
    public partial class UsuariosReportViewer : Form
    {
        private List<Usuarios> ListaUsuarios;
        public UsuariosReportViewer(List<Usuarios> usuarios)
        {
            this.ListaUsuarios = usuarios;
            InitializeComponent();
        }

        private void UsuariosReportViewer_Load(object sender, EventArgs e)
        {
            UsuariosReporte reporte = new UsuariosReporte();
            reporte.SetDataSource(ListaUsuarios);

            MyCrystalReportViewer.ReportSource = reporte;
            MyCrystalReportViewer.Refresh();
        }
    }
}
