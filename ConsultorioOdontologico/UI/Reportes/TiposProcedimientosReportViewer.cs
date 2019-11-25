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
    public partial class TiposProcedimientosReportViewer : Form
    {
        private List<TiposProcedimientos> ListaTiposProcedimientos;
        public TiposProcedimientosReportViewer(List<TiposProcedimientos> tiposProcedimientos)
        {
            this.ListaTiposProcedimientos = tiposProcedimientos;
            InitializeComponent();
        }

        private void TiposProcedimientosReportViewer_Load(object sender, EventArgs e)
        {
            TiposProcedimientosReporte reporte = new TiposProcedimientosReporte();
            reporte.SetDataSource(ListaTiposProcedimientos);

            MyCrystalReportViewer.ReportSource = reporte;
            MyCrystalReportViewer.Refresh();
        }
    }
}
