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
    public partial class FrmRptTecnologia : Form
    {
        public FrmRptTecnologia()
        {
            InitializeComponent();
        }

        private void FrmRptTecnologia_Load(object sender, EventArgs e)
        {
            rptTecnologia rpt = new rptTecnologia();
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
