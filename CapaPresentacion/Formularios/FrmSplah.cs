using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Formularios;

namespace CapaPresentacion
{
    public partial class FrmSplah : Form
    {
        public FrmSplah()
        {
            InitializeComponent();
        }
        
        private void FrmSplah_Load(object sender, EventArgs e)
        {
            tTiempo.Start();
        }
       
        private void tTiempo_Tick(object sender, EventArgs e)
        {
            
            int valor;
            valor = int.Parse(lblt.Text);
            valor += 1;
            lblt.Text =valor.ToString();

            if(valor==5)
            {
                lbltext.Text = "Cargando Componentes";
            }
            if (valor == 8)
            {
                lbltext.Text = "Cargando Componentes .";
            }
            if (valor == 16)
            {
                lbltext.Text = "Cargando Componentes ..";
            }
            if (valor == 24)
            {
                lbltext.Text = "Cargando Componentes ...";
            }
            if (valor == 32)
            {
                lbltext.Text = "El programa cargo los componentes satisfactoriamente";
            }
            if (valor==45)
            {
                FrmLogin frm = new FrmLogin();
                frm.Show();
                Hide();
            }
        }
        
    }
}
