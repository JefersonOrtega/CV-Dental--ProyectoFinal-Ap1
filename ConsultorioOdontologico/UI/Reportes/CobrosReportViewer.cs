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
    public partial class CobrosReportViewer : Form
    {
        private List<Cobros> ListaCobros;
        public CobrosReportViewer(List<Cobros> cobros)
        {
            this.ListaCobros = cobros;
            InitializeComponent();
        }

        private void MyCrystalReportViewer_Load(object sender, EventArgs e)
        {

        }

        private void CobrosReportViewer_Load(object sender, EventArgs e)
        {
            CobrosReporte reporte = new CobrosReporte();
            reporte.SetDataSource(ListaCobros);

            MyCrystalReportViewer.ReportSource = reporte;
            MyCrystalReportViewer.Refresh();
        }
    }
}
