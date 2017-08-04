using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class FrmRptTecnologiaTipo : Form
    {
        public FrmRptTecnologiaTipo()
        {
            InitializeComponent();
        }

        private void FrmRptTecnologiaTipo_Load(object sender, EventArgs e)
        {
            Reportes.RptTecnologiaTipo rptTipo = new Reportes.RptTecnologiaTipo();
            crystalReportViewer1.ReportSource = rptTipo;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
