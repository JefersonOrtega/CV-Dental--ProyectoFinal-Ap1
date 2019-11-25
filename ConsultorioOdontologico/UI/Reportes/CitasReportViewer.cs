using ConsultorioOdontologico.BLL;
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
    public partial class CitasReportViewer : Form
    {
        private List<Citas> ListaCitas;
        public CitasReportViewer(List<Citas>citas)
        {
            this.ListaCitas = citas;
            InitializeComponent();
            
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {



        }

        private void ReportesCitas_Load(object sender, EventArgs e)
        {
            
            CitasReporte reporte = new CitasReporte();
            reporte.SetDataSource(ListaCitas);

            MyCrystalReportViewer.ReportSource = reporte;
            MyCrystalReportViewer.Refresh();
        }

        private void MyCrystalReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
