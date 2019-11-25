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
    public partial class ProcedimientosReportViewer : Form
    {
        private List<Procedimientos> ListaProcedimientos;
        public ProcedimientosReportViewer(List<Procedimientos> procedimientos)
        {
            this.ListaProcedimientos = procedimientos;
            InitializeComponent();
        }

        private void ProcedimientosReportViewer_Load(object sender, EventArgs e)
        {
            ProcedimientosReporte procedimientos = new ProcedimientosReporte();
            procedimientos.SetDataSource(ListaProcedimientos);

            MyCrystalReportViewer.ReportSource = procedimientos;
            MyCrystalReportViewer.Refresh();
        }

        private void MyCrystalReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
