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
    public partial class FrmMessage2 : Form
    {
        public FrmMessage2()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string Fecha;
            Fecha = dtpFecha.Text;
            FrmrptDiario frm = new FrmrptDiario();
            frm.Fecha = Fecha.ToString();
            Close();
            frm.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
