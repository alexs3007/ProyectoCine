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
    public partial class FrmMessage : Form
    {
        public FrmMessage()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           int mes;
           mes= cboMes.SelectedIndex + 1;
            FrmRptIngresoMensual frm = new FrmRptIngresoMensual();
            frm.Mes = mes.ToString();
            Close();
            frm.ShowDialog();
          
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
