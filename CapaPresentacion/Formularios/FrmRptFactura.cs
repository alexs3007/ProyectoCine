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
    public partial class FrmRptFactura : Form
    {
        public FrmRptFactura()
        {
            InitializeComponent();
        }
        public string id;

        private void FrmRptFactura_Load(object sender, EventArgs e)
        {
            rptFactura rpt = new rptFactura();
            rpt.SetParameterValue("@IdFactura", id);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
