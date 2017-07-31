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
    public partial class FrmPelicula_Tecnologia : Form
    {
        public FrmPelicula_Tecnologia()
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

       
        private void FrmPelicula_Tecnologia_Load(object sender, EventArgs e)
        {
            HabilitarControles(false, true, false, false, false);
            ListadoPeliculaTecnologia();
        }
        private void ListadoPeliculaTecnologia()
        {
            CNPeliculaTecnologia objPT = new CNPeliculaTecnologia();
            dgvLista.DataSource = objPT.ListadoPeliculaTecnologia().Tables["PeliculaTecnologia"];
            dgvLista.Columns[0].Visible = false;
            dgvLista.Columns[1].Visible = false;
        }

        private void CargarComboBoxPelicula()
        {
            CNPeliculaTecnologia objPT = new CNPeliculaTecnologia();
            cboPelicula.DataSource = objPT.ListadoPelicula().Tables["Pelicula"];
            cboPelicula.DisplayMember = "NombrePelicula";
            cboPelicula.ValueMember = "IdPelicula";
        }
        private void CargarComboBoxTecnologia()
        {
            CNPeliculaTecnologia objPT = new CNPeliculaTecnologia();
            cboTecnología.DataSource = objPT.ListadoTecnologia().Tables["Tecnologia"];
            cboTecnología.DisplayMember = "TipoTecnologia";
            cboTecnología.ValueMember = "IdTecnologia";
        }

       

        private void GuardarCarteleraPelicula()
        {
            CNPeliculaTecnologia objPT = new CNPeliculaTecnologia();
            CEPeliculaTecnologia objPeT = new CEPeliculaTecnologia();
            objPeT.IdPelicula = Convert.ToInt32(cboPelicula.SelectedValue);
            objPeT.IdTecnologia = Convert.ToInt32(cboTecnología.SelectedValue);
            objPeT.Precio = Convert.ToDouble(txtPrecio.Text);

            if (objPT.NuevaPeliculaTecnologia(objPeT) > 0)
            {
                MessageBox.Show(null, "Registro almacenado satisfactoriamente", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "Error al almacenar el registro", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void LimpiarControles()
        {
            txtPrecio.Clear();
            cboPelicula.DataSource = null;
            cboTecnología.DataSource = null;
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelecionarFila();
            HabilitarControles(true, false, false, true, true);
        }

        private void SelecionarFila()
        {
            CargarComboBoxPelicula();
            cboPelicula.Text = dgvLista.SelectedRows[0].Cells[2].Value.ToString();
            CargarComboBoxTecnologia();
            cboTecnología.Text = dgvLista.SelectedRows[0].Cells[3].Value.ToString();
            txtPrecio.Text = dgvLista.SelectedRows[0].Cells[4].Value.ToString();
        }

     

        private void ActualizarPeliculaTecnologia()
        {
            CNPeliculaTecnologia objPT = new CNPeliculaTecnologia();
            CEPeliculaTecnologia objPeT = new CEPeliculaTecnologia();
            objPeT.IdPelicula = Convert.ToInt32(cboPelicula.SelectedValue);
            objPeT.IdTecnologia = Convert.ToInt32(cboTecnología.SelectedValue);
            objPeT.Precio = Convert.ToDouble(txtPrecio.Text);

            if (objPT.ActualizarPeliculaTecnologia(objPeT) > 0)
            {
                MessageBox.Show(null, "Registro actualizado satisfactoriamente", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "Error al actualizar el registro", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarPeliculaTecnologia(int idPelicula,int IdTecnologia)
        {
            CNPeliculaTecnologia objEPT = new CNPeliculaTecnologia();
            CEPeliculaTecnologia objPT = new CEPeliculaTecnologia();
            objPT.IdPelicula = idPelicula;
            objPT.IdTecnologia = IdTecnologia;


            if (objEPT.EliminarPeliculaTecnologia(objPT) > 0)
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
            int idPelicula,idTecnologia;
            idPelicula = int.Parse(dgvLista.SelectedRows[0].Cells[0].Value.ToString());
            idTecnologia = int.Parse(dgvLista.SelectedRows[0].Cells[1].Value.ToString());
            EliminarPeliculaTecnologia(idPelicula,idTecnologia);
            ListadoPeliculaTecnologia();
            LimpiarControles();
            HabilitarControles(false, true, false, false, false);
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if(txtBusqueda.Text.Equals(""))
            {
                ListadoPeliculaTecnologia();
            }
            else
            {
                if(rdbPelicula.Checked==true)
                {
                    ListadoPeliculaTecnologiaPorPelicula(txtBusqueda.Text);
                }
                else
                {
                    ListadoPeliculaTecnologiaPorTecnologia(txtBusqueda.Text);
                }
            }
        }

        private void ListadoPeliculaTecnologiaPorPelicula(string Pelicula)
        {
            CNPeliculaTecnologia objPT = new CNPeliculaTecnologia();
            CEPeliculaTecnologia objPeT = new CEPeliculaTecnologia();
            objPeT.NombrePelicula = Pelicula;
            dgvLista.DataSource = objPT.ListadoPeliculaTecnologiaporPelicula(objPeT).Tables["PeliculaTecnologiaP"];
            dgvLista.Columns[0].Visible = false;
            dgvLista.Columns[1].Visible = false;
        }

        private void ListadoPeliculaTecnologiaPorTecnologia(string Tecnologia)
        {
            CNPeliculaTecnologia objPT = new CNPeliculaTecnologia();
            CEPeliculaTecnologia objPeT = new CEPeliculaTecnologia();
            objPeT.TipoTecnologia = Tecnologia;
            dgvLista.DataSource = objPT.ListadoPeliculaTecnologiaporTecnologia(objPeT).Tables["PeliculaTecnologiaT"];
            dgvLista.Columns[0].Visible = false;
            dgvLista.Columns[1].Visible = false;
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            HabilitarControles(true, false, true, false, true);
            cboPelicula.Focus();
            CargarComboBoxPelicula();
            CargarComboBoxTecnologia();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtPrecio.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el precio correspondiente", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return;
            }
            else
            {
                GuardarCarteleraPelicula();
                ListadoPeliculaTecnologia();
                LimpiarControles();
                HabilitarControles(false, true, false, false, false);
            }

        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            ActualizarPeliculaTecnologia();
            LimpiarControles();
            HabilitarControles(false, true, false, false, false);
            ListadoPeliculaTecnologia();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            LimpiarControles();
            HabilitarControles(false, true, false, false, false);
        }
    }
}
