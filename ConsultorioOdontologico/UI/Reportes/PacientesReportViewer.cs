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
    public partial class PacientesReportViewer : Form
    {
        private List<Pacientes> ListaPacientes;
        public PacientesReportViewer(List<Pacientes> pacientes)
        {
            this.ListaPacientes = pacientes;
            InitializeComponent();
        }

        private void MyCrystalReportViewer_Load(object sender, EventArgs e)
        {
            
        }

        private void PacientesReportViewer_Load(object sender, EventArgs e)
        {
            PacientesReporte reporte = new PacientesReporte();
            reporte.SetDataSource(ListaPacientes);

            MyCrystalReportViewer.ReportSource = reporte;
            MyCrystalReportViewer.Refresh();
        }
    }
}
