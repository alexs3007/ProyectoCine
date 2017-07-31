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

namespace CapaPresentacion.Formularios
{
    public partial class FrmPelicula_Horario : Form
    {
        public FrmPelicula_Horario()
        {
            InitializeComponent();
        }
        private void FilaSelecionada()
        {
            CargarComboBoxPelicula();
            CargarComboBoxHorario();
            cboHorario.Text = dgvLista.SelectedRows[0].Cells[3].Value.ToString();
            cboPelicula.Text = dgvLista.SelectedRows[0].Cells[2].Value.ToString();
        }
        private void HabilitarControles(bool panel, bool nuevo, bool guardar, bool actualizar, bool cancelar)
        {
            pnlDatos.Enabled = panel;
            btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            btnActualizar.Enabled = actualizar;
            btnCancelar.Enabled = cancelar;
        }
        private void ListadoPeliculaHorario()
        {
            CNPeliculaHorario objE = new CNPeliculaHorario();
            dgvLista.DataSource = objE.ListadoPeliculaHorario().Tables["PeliculaHorario"];
            dgvLista.Columns[0].Visible = false;
            dgvLista.Columns[1].Visible = false;
        }
        private void LimpiarControles()
        {
            cboHorario.DataSource = null;
            cboPelicula.DataSource = null;
        }

        private void CargarComboBoxPelicula()
        {
            CNPeliculaHorario objPH = new CNPeliculaHorario();
            cboPelicula.DataSource = objPH.ListadoPelicula().Tables["Pelicula"];
            cboPelicula.DisplayMember = "NombrePelicula";
            cboPelicula.ValueMember = "IdPelicula";
        }

        private void CargarComboBoxHorario()
        {
            CNPeliculaHorario objPH = new CNPeliculaHorario();
            cboHorario.DataSource = objPH.ListadoHorario().Tables["Horario"];
            cboHorario.DisplayMember = "HorarioPelicula";
            cboHorario.ValueMember = "IdHorario";
        }
        private void InsertarPeliculaHorario()
        {
            CNPeliculaHorario CNPH = new CNPeliculaHorario();
            CEPeliculaHorario CEPH = new CEPeliculaHorario();
            CEPH.IdHorario = Convert.ToInt32(cboHorario.SelectedValue);
            CEPH.IdPelicula = Convert.ToInt32(cboPelicula.SelectedValue);

            if (CNPH.InsertarPeliculaHorario(CEPH) > 0)
            {
                MessageBox.Show(null, "Registro almacenado satisfactoriamente", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "Error al almacenar el registro", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarPeliculaHorario()
        {
            CNPeliculaHorario CNPH = new CNPeliculaHorario();
            CEPeliculaHorario CEPH = new CEPeliculaHorario();
            CEPH.IdHorario = Convert.ToInt32(cboHorario.SelectedValue);
            CEPH.IdPelicula = Convert.ToInt32(cboPelicula.SelectedValue);

            if (CNPH.ActualizarPeliculaHorario(CEPH) > 0)
            {
                MessageBox.Show(null, "Registro actualizado satisfactoriamente", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "Error al actualizar el registro", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarPeliculaHorario(int idPelicula, int IdHorario)
        {
            CNPeliculaHorario CNPH = new CNPeliculaHorario();
            CEPeliculaHorario CEPH = new CEPeliculaHorario();
            CEPH.IdPelicula = idPelicula;
            CEPH.IdHorario = IdHorario;
            if (CNPH.EliminarPeliculaHorario(CEPH) > 0)
            {
                MessageBox.Show(null, "Registro eliminado satisfactoriamente", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "Error al eliminar el registro", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListadoPeliculaPorNombrePelicula(string Pelicula)
        {
            CNPeliculaHorario CNPH = new CNPeliculaHorario();
            CEPeliculaHorario CEPH = new CEPeliculaHorario();
            CEPH.Pelicula = Pelicula;
            dgvLista.DataSource = CNPH.ListadoPeliculaHorarioPorNombre(CEPH).Tables["PeliculaHorarioP"];
            dgvLista.Columns[0].Visible = false;
            dgvLista.Columns[1].Visible = false;
        }

        private void ListadoPeliculaHorarioPorHorario(string Horario)
        {
            CNPeliculaHorario CNPH = new CNPeliculaHorario();
            CEPeliculaHorario CEPH = new CEPeliculaHorario();
            CEPH.Horario = Horario;
            dgvLista.DataSource = CNPH.ListadoPeliculaHorarioPorHorario(CEPH).Tables["PeliculaHorarioH"];
            dgvLista.Columns[0].Visible = false;
            dgvLista.Columns[1].Visible = false;
        }

        private void FrmPelicula_Horario_Load(object sender, EventArgs e)
        {
            HabilitarControles(false, true, false, false, false);
            ListadoPeliculaHorario();

        }

       

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilaSelecionada();
            HabilitarControles(true, false, false, true, true);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idPelicula, IdHorario;
            idPelicula = int.Parse(dgvLista.SelectedRows[0].Cells[0].Value.ToString());
            IdHorario = int.Parse(dgvLista.SelectedRows[0].Cells[1].Value.ToString());
            EliminarPeliculaHorario(idPelicula, IdHorario);
            ListadoPeliculaHorario();
            LimpiarControles();
            HabilitarControles(false, true, false, false, false);

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (!txtBusqueda.Text.Equals(""))
            {
                if (rdbPelicula.Checked == true)
                {
                    ListadoPeliculaPorNombrePelicula(txtBusqueda.Text);
                }
                else
                {
                    ListadoPeliculaHorarioPorHorario(txtBusqueda.Text);
                }
            }
            else
            {
                ListadoPeliculaHorario();
            }

        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            HabilitarControles(true, false, true, false, true);
            CargarComboBoxHorario();
            CargarComboBoxPelicula();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            InsertarPeliculaHorario();
            LimpiarControles();
            HabilitarControles(false, true, false, false, false);
            ListadoPeliculaHorario();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            ActualizarPeliculaHorario();
            LimpiarControles();
            HabilitarControles(false, true, false, false, false);
            ListadoPeliculaHorario();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            LimpiarControles();
            HabilitarControles(false, true, false, false, false);
        }
    }
}
