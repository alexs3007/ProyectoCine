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
    public partial class FrmSinopsis : Form
    {
        public FrmSinopsis()
        {
            InitializeComponent();
        }
        public  string url;

        private void pnlcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSinopsis_Load(object sender, EventArgs e)
        {
           
        }

        private void link_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(url);
        }
    }
}
