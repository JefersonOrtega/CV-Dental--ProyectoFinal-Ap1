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
    public partial class ReciboCobroReportViewer : Form
    {
        private List<Cobros> ListaCobros;
        public ReciboCobroReportViewer(List<Cobros> cobros)
        {
            this.ListaCobros = cobros;
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void ReciboCobroReportViewer_Load(object sender, EventArgs e)
        {
            ReciboCobrosReporte reciboCobrosReporte = new ReciboCobrosReporte();
            reciboCobrosReporte.SetDataSource(ListaCobros);

            MyCrystalReportViewer.ReportSource = reciboCobrosReporte;
            MyCrystalReportViewer.Refresh();
        }
    }
}
