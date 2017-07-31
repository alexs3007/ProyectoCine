using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;
using System.IO;

namespace CapaPresentacion
{
    public partial class FrmCartelera : Form
    {
        public FrmCartelera()
        {
            InitializeComponent();
        }

        private void HabilitarControles(bool panel, bool nuevo, bool guardar, bool actualizar, bool cancelar)
        {
            pnlDatos.Enabled = panel;
            btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            btnActualizar.Enabled = actualizar;
            btnCancelar.Enabled = cancelar;
        }

        private void ListadoCartelera()
        {
            CNCartelera objP = new CNCartelera();
            dgvLista.DataSource = objP.ListadoCartelera().Tables["Cartelera"];
        }
        private void FrmCartelera_Load(object sender, EventArgs e)
        {
            HabilitarControles(false, true, false, false, false);
            ListadoCartelera();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarControles(true, false, true, false, true);
            dtpFechaEstreno.Focus();
        }

        private void LimpiarControles()
        {
            txtCartelera.Clear();
            dtpFechaEstreno.Value = DateTime.Now;
            dtpFechaFinal.Value = DateTime.Now;
        }
        private void InsertarPelicula()
        {
            CNCartelera objInsertarCartelera = new CNCartelera();
            CECartelera objCartelera = new CECartelera();
            objCartelera.FechaEstreno = dtpFechaEstreno.Value;
            objCartelera.FechaFinal = dtpFechaFinal.Value;

            if (objInsertarCartelera.NuevaCartelera(objCartelera) > 0)
            {
                MessageBox.Show(null, "Registro almacenado satisfactoriamente", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "Error al almacenar el registro", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarCartelera()
        {
            CNCartelera objActualizarCartelera = new CNCartelera();
            CECartelera objCartelera = new CECartelera();
            objCartelera.IdCartelera = Convert.ToInt32(txtCartelera.Text);
            objCartelera.FechaEstreno = dtpFechaEstreno.Value;
            objCartelera.FechaFinal = dtpFechaFinal.Value;

            if (objActualizarCartelera.ActualizarCartelera(objCartelera) > 0)
            {
                MessageBox.Show(null, "Registro actualizado satisfactoriamente", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "Error al actualizar el registro", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilaSeleccionada();
            HabilitarControles(true, false, false, true, true);
        }
        private void FilaSeleccionada()
        {
            txtCartelera.Text = dgvLista.SelectedRows[0].Cells[0].Value.ToString();
            dtpFechaEstreno.Text = dgvLista.SelectedRows[0].Cells[1].Value.ToString();
            dtpFechaFinal.Text = dgvLista.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            HabilitarControles(false, true, false, false, false);
        }

        private void EliminarCartelera(int idCartelera)
        {
            CNCartelera objEliminarCartelera = new CNCartelera();
            CECartelera objCartelera = new CECartelera();
            objCartelera.IdCartelera = idCartelera;

            if (objEliminarCartelera.EliminarCartelera(objCartelera) > 0)
            {
                MessageBox.Show(null, "Registro eliminado satisfactoriamente", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "Error al eliminar el registro", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idCartelera;
            idCartelera = int.Parse(dgvLista.SelectedRows[0].Cells[0].Value.ToString());
            EliminarCartelera(idCartelera);
            ListadoCartelera();
            LimpiarControles();
            HabilitarControles(false, true, false, false, false);
        }

        private void rdbFechaEstreno_CheckedChanged(object sender, EventArgs e)
        {
            pnlBF.Visible = true;
            pnlBT.Visible = false;
            ListadoCartelera();
        }

        private void rdbCodCartelera_CheckedChanged(object sender, EventArgs e)
        {
            pnlBF.Visible = false;
            pnlBT.Visible = true;
            ListadoCartelera();
        }

        private void BuscarporFecha(DateTime Fecha)
        {
            CNCartelera objP = new CNCartelera();
            CECartelera objCartelera = new CECartelera();
            objCartelera.FechaEstreno = Fecha;
            dgvLista.DataSource = objP.ListadoCarteleraPorFecha(objCartelera).Tables["Cartelera"];
        }

        private void BuscarporCodigo(int Id)
        {
            CNCartelera objP = new CNCartelera();
            CECartelera objCartelera = new CECartelera();
            objCartelera.IdCartelera = Id;
            dgvLista.DataSource = objP.ListadoCarteleraPorCodido(objCartelera).Tables["Cartelera"];
        }
        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            BuscarporFecha(dtpFecha.Value);
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if(txtBusqueda.Text.Equals(""))
            {
                ListadoCartelera();
            }else
            {
                int IdCartelera;
                if(int.TryParse(txtBusqueda.Text, out IdCartelera))
                {
                    BuscarporCodigo(IdCartelera);
                }else
                {
                    MessageBox.Show("Ingrese un valor valido", "CinemaEvolution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

     
        private void btnNuevo_Click_3(object sender, EventArgs e)
        {
            HabilitarControles(true, false, true, false, true);
            dtpFechaEstreno.Focus();
        }

        private void btnGuardar_Click_3(object sender, EventArgs e)
        {
            InsertarPelicula();
            LimpiarControles();
            HabilitarControles(false, true, false, false, false);
            ListadoCartelera();
        }

        private void btnActualizar_Click_2(object sender, EventArgs e)
        {
            ActualizarCartelera();
            LimpiarControles();
            HabilitarControles(false, true, false, false, false);
            ListadoCartelera();
        }

        private void btnCancelar_Click_2(object sender, EventArgs e)
        {
            LimpiarControles();
            HabilitarControles(false, true, false, false, false);
        }
    }
}
