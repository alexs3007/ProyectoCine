using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmRptIngresoMensual : Form
    {
        public FrmRptIngresoMensual()
        {
            InitializeComponent();
        }
        public string Mes; 
        private void FrmRptIngresoMensual_Load(object sender, EventArgs e)
        {
            rptIngresoMensual rpt = new rptIngresoMensual ();
            rpt.SetParameterValue("@Mes",Mes );
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
