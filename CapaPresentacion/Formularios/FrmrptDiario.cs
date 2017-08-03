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
    public partial class FrmrptDiario : Form
    {
        public FrmrptDiario()
        {
            InitializeComponent();
        }
        public string Fecha;

        private void FrmrptDiario_Load(object sender, EventArgs e)
        {
            rptReporteDiario rpt = new rptReporteDiario();
            rpt.SetParameterValue("@Fecha", Fecha);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
