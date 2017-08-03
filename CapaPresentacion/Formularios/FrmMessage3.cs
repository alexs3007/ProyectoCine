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
    public partial class FrmMessage3 : Form
    {
        public FrmMessage3()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!txtFactura.Text.Equals(""))
            {
                FrmRptFactura frm = new FrmRptFactura();
                frm.id = txtFactura.Text;
                Close();
                frm.ShowDialog();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMessage3_Load(object sender, EventArgs e)
        {

        }
    }
}
