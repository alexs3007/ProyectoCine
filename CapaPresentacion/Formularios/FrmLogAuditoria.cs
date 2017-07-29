using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion.Formularios
{
    public partial class FrmLogAuditoria : Form
    {
        public FrmLogAuditoria()
        {
            InitializeComponent();
        }

        private void FrmLogAuditoria_Load(object sender, EventArgs e)
        {
            CargarLog();
        }

        private void CargarLog()
        {
            CNLogAuditoria obja = new CNLogAuditoria();
            dgvListado.DataSource = obja.ListadoLogAuditoria().Tables["MostrarLog"];
        }
   
        private void BuscarAlumnoxFecha(DateTime fecha)
        {
            CNLogAuditoria log = new CNLogAuditoria();
            CELogAuditoria objL = new CELogAuditoria();
            objL.Fecha = fecha;
            dgvListado.DataSource = log.MostrarporFecha(objL).Tables["MostrarporFecha"];
        }

        private void BuscarAlumnoxUsuario(string Nombre)
        {
            CNLogAuditoria log = new CNLogAuditoria();
            CELogAuditoria objL = new CELogAuditoria();
            objL.NombreUsuario = Nombre;
            dgvListado.DataSource = log.MostrarporUsuario(objL).Tables["MostrarporUsuario"];
        }
        private void txtBusqueda_TextChanged_1(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == " " || txtBusqueda.Text == "")
            {
                CargarLog();
            }
            else
            {
                if (rdbUsuario.Checked == true)
                {
                    BuscarAlumnoxUsuario(txtBusqueda.Text);
                }
            }
        }

        private void rdbFecha_CheckedChanged_1(object sender, EventArgs e)
        {
            pnlBF.Visible = true;
            pnlBT.Visible = false;
            CargarLog();
        }

        private void rdbUsuario_CheckedChanged_1(object sender, EventArgs e)
        {
            pnlBF.Visible = false;
            pnlBT.Visible = true;
            CargarLog();
        }

        private void dtpFecha_ValueChanged_1(object sender, EventArgs e)
        {
            BuscarAlumnoxFecha(dtpFecha.Value);
        }
    }
}
