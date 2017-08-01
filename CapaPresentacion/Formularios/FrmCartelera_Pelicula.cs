using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion.Formularios
{
    public partial class FrmCartelera_Pelicula : Form
    {
        public FrmCartelera_Pelicula()
        {
            InitializeComponent();
        }


        private void CargarComboBoxPelicula()
        {
            CNCarteleraPelicula objCP = new CNCarteleraPelicula();
            cboPelicula.DataSource = objCP.ListadoPelicula().Tables["Pelicula"];
            cboPelicula.DisplayMember = "NombrePelicula";
            cboPelicula.ValueMember = "IdPelicula";
        }

        private void CargarComboBoxCartelera()
        {
            CNCarteleraPelicula objCP = new CNCarteleraPelicula();
            cboCartelera.DataSource = objCP.ListadoCartelera().Tables["Cartelera"];
            cboCartelera.DisplayMember = "FechaEstreno";
            cboCartelera.ValueMember = "IdCartelera";
        }
        private void HabilitarControles(bool panel, bool nuevo, bool guardar, bool actualizar, bool cancelar)
        {
            pnlDatos.Enabled = panel;
            btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            btnActualizar.Enabled = actualizar;
            btnCancelar.Enabled = cancelar;
        }

        private void FrmCartelera_Pelicula_Load(object sender, EventArgs e)
        {
          
            HabilitarControles(false, true, false, false, false);
            ListadoCarteleraPelicula();
        }
        private void ListadoCarteleraPelicula()
        {
            CNCarteleraPelicula objCP = new CNCarteleraPelicula();
            dgvLista.DataSource = objCP.ListadoCarteleraPelicula().Tables["Cartelera_Pelicula"];
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarControles(true, false, true, false, true);
            cboCartelera.Focus();
            CargarComboBoxCartelera();
            CargarComboBoxPelicula();
        }

        private void GuardarCarteleraPelicula()
        {
            CNCarteleraPelicula objNCarteleraPelicula = new CNCarteleraPelicula();
            CECarteleraPelicula objCarteleraPelicula = new CECarteleraPelicula();
            objCarteleraPelicula.IdCartelera= Convert.ToInt32(cboCartelera.SelectedValue);
            objCarteleraPelicula.IdPelicula = Convert.ToInt32(cboPelicula.SelectedValue);

            if (objNCarteleraPelicula.NuevaCarteleraPelicula(objCarteleraPelicula) > 0)
            {
                MessageBox.Show(null, "Registro almacenado satisfactoriamente", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "Error al almacenar el registro", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarCarteleraPelicula()
        {
            CNCarteleraPelicula objNCarteleraPelicula = new CNCarteleraPelicula();
            CECarteleraPelicula objCarteleraPelicula = new CECarteleraPelicula();
            objCarteleraPelicula.IdCartelera = Convert.ToInt32(cboCartelera.SelectedValue);
            objCarteleraPelicula.IdPelicula = Convert.ToInt32(cboPelicula.SelectedValue);

            if (objNCarteleraPelicula.ActualizarCarteleraPelicula(objCarteleraPelicula) > 0)
            {
                MessageBox.Show(null, "Registro actualizado satisfactoriamente", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "Error al actualizar el registro", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarCarteleraPelicula(int idCartelera)
        {
            CNCarteleraPelicula objNCarteleraPelicula = new CNCarteleraPelicula();
            CECarteleraPelicula objCarteleraPelicula = new CECarteleraPelicula();
            objCarteleraPelicula.IdCartelera = idCartelera;


            if (objNCarteleraPelicula.EliminarCarteleraPelicula(objCarteleraPelicula) > 0)
            {
                MessageBox.Show(null, "Registro eliminado satisfactoriamente", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "Error al eliminar el registro", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboCartelera.Text == null)
            {
                MessageBox.Show(null, "Seleccione la Cartelera", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboPelicula.Text == null)
            {
                MessageBox.Show(null, "Seleccione la Pelicula", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GuardarCarteleraPelicula();
            HabilitarControles(false, true, false, false, false);
            LimpiarControles();
            ListadoCarteleraPelicula();

        }
        private void LimpiarControles()
        {
            cboCartelera.DataSource = null;
            cboPelicula.DataSource=null;
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilaSeleccionada();
            HabilitarControles(true, false, false, true, true);
        }

        private void FilaSeleccionada()
        {
            CargarComboBoxCartelera();
            cboCartelera.Text = dgvLista.SelectedRows[0].Cells[1].FormattedValue.ToString();
            CargarComboBoxPelicula();
            cboPelicula.Text = dgvLista.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idCP;
            idCP = int.Parse(dgvLista.SelectedRows[0].Cells[0].Value.ToString());
            EliminarCarteleraPelicula(idCP);
            ListadoCarteleraPelicula();
            LimpiarControles();
            HabilitarControles(false, true, false, false, false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            HabilitarControles(false, true, false, false, false);
        }

        private void rdbFechaEstreno_CheckedChanged(object sender, EventArgs e)
        {
            pnlBF.Visible = true;
            pnlBT.Visible = false;
            ListadoCarteleraPelicula();
        }

        private void rdbPelicula_CheckedChanged(object sender, EventArgs e)
        {
            pnlBF.Visible = false;
            pnlBT.Visible = true;
            ListadoCarteleraPelicula();
        }

        private void ListadoCPporFecha(DateTime Fecha)
        {
            CNCarteleraPelicula objPC = new CNCarteleraPelicula();
            CECarteleraPelicula objEPC = new CECarteleraPelicula();
            objEPC.Fecha = Fecha;
            dgvLista.DataSource = objPC.ListadoCarteleraPeliculaPorFecha(objEPC).Tables["Cartelera_Pelicula"];
        }

        private void ListadoCPporNombre(string Nombre)
        {
            CNCarteleraPelicula objPC = new CNCarteleraPelicula();
            CECarteleraPelicula objEPC = new CECarteleraPelicula();
            objEPC.NombrePelicula = Nombre;
            dgvLista.DataSource = objPC.ListadoCarteleraPeliculaPorPelicula(objEPC).Tables["Cartelera_Pelicula"];
        }
        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            ListadoCPporFecha(dtpFecha.Value);
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if(txtBusqueda.Text.Equals(""))
            {
                ListadoCarteleraPelicula();
            }
            else
            {
                ListadoCPporNombre(txtBusqueda.Text);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarCarteleraPelicula();
            HabilitarControles(false, true, false, false, false);
            LimpiarControles();
            ListadoCarteleraPelicula();

        }

        private void btnNuevo_MouseHover(object sender, EventArgs e)
        {
            lblNuevo.Visible = true;
        }

        private void btnGuardar_MouseHover(object sender, EventArgs e)
        {
            lblGuardar.Visible = true;
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            lblGuardar.Visible = false;
        }

        private void btnActualizar_MouseHover(object sender, EventArgs e)
        {
            lblActualizar.Visible = true;
        }

        private void btnActualizar_MouseLeave(object sender, EventArgs e)
        {
            lblActualizar.Visible = false;
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            lblCancelar.Visible = true;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            lblCancelar.Visible = false;
        }

        private void btnNuevo_MouseLeave(object sender, EventArgs e)
        {
            lblNuevo.Visible = false;
        }
    }
}
