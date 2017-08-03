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
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void pnlReporteFactura_MouseHover(object sender, EventArgs e)
        {
            lblFacturaTICKET.Visible = true;
        }

        private void pnlReporteFactura_MouseLeave(object sender, EventArgs e)
        {
            lblFacturaTICKET.Visible = false;
        }

        private void pnlReporteDiario_MouseHover(object sender, EventArgs e)
        {
            lblMensual.Visible = true;
        }

        private void pnlReporteDiario_MouseLeave(object sender, EventArgs e)
        {
            lblMensual.Visible = false;
        }

        private void pnlReporteMensual_MouseHover(object sender, EventArgs e)
        {
            lblDiario.Visible = true;
        }

        private void pnlReporteMensual_MouseLeave(object sender, EventArgs e)
        {
            lblDiario.Visible = false;
        }

        private void pnlReporteTecnologia_MouseHover(object sender, EventArgs e)
        {
            lblReporteTecnologia.Visible = true;
        }

        private void pnlReporteTecnologia_MouseLeave(object sender, EventArgs e)
        {
            lblReporteTecnologia.Visible = false;
        }

        private void pnlReporteFactura_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void pnlReporteFactura_Click(object sender, EventArgs e)
        {
            FrmMessage3 frm = new FrmMessage3();
            frm.ShowDialog();
        }

        private void pnlReporteMensual_Click(object sender, EventArgs e)
        {
            FrmMessage frm = new FrmMessage();
            frm.Show();
            
        }

        private void pnlReporteDiario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlReporteDiario_Click(object sender, EventArgs e)
        {
            FrmMessage2 frm = new FrmMessage2();
            frm.Show();
        }

        private void pnlReporteTecnologia_Click(object sender, EventArgs e)
        {
            FrmRptTecnologia frm = new FrmRptTecnologia();
            frm.ShowDialog();
        }
    }
}
