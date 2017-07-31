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
    public partial class FrmPelicula : Form
    {
        public FrmPelicula()
        {
            InitializeComponent();
        }

        private void FrmPelicula_Load(object sender, EventArgs e)
        {
            HabilitarControles(false, true, false, false, false);
            ListadoPelicula();
        }

        private void Limpiar()
        {
            txtCodPelicula.Clear();
            txtNombrePelicula.Clear();
            txtSinopsis.Clear();
            txtLanzamiento.Clear();
            txtDuracion.Clear();
            cboGenero.DataSource = null;
            cboClasificacion.DataSource = null;
            txtURL.Clear();
            pbPelicula.Image = null;
            txtUsuario.Clear();
            
        }

        private void HabilitarControles(bool panel, bool nuevo, bool guardar, bool actualizar, bool cancelar)
        {
            pnlDatos.Enabled = panel;
            btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            btnActualizar.Enabled = actualizar;
            btnCancelar.Enabled = cancelar;
        }
        private void FilaSeleccionada()
        {
            txtCodPelicula.Text = dgvLista.SelectedRows[0].Cells[0].Value.ToString();
            txtNombrePelicula.Text = dgvLista.SelectedRows[0].Cells[1].FormattedValue.ToString();
            txtSinopsis.Text = dgvLista.SelectedRows[0].Cells[2].FormattedValue.ToString();
            txtLanzamiento.Text = dgvLista.SelectedRows[0].Cells[3].FormattedValue.ToString();
            txtDuracion.Text = dgvLista.SelectedRows[0].Cells[4].FormattedValue.ToString();
            CargarComboBoxGenero();
            cboGenero.Text = dgvLista.SelectedRows[0].Cells[5].Value.ToString();
            CargarComboBoxClasificacion();
            cboClasificacion.Text = dgvLista.SelectedRows[0].Cells[6].Value.ToString();
            MemoryStream ms = new MemoryStream((byte[])dgvLista.CurrentRow.Cells[7].Value);
            pbPelicula.Image = Image.FromStream(ms);      
            txtURL.Text = dgvLista.SelectedRows[0].Cells[8].Value.ToString();
            txtUsuario.Text = dgvLista.SelectedRows[0].Cells[9].Value.ToString();
         }

        private void CargarComboBoxGenero()
        {
            CNPelicula objPelicula = new CNPelicula();
            cboGenero.DataSource = objPelicula.ListadoGenero().Tables["Genero"];
            cboGenero.DisplayMember = "GeneroPelicula";
            cboGenero.ValueMember = "IdGenero";
        }
        private void CargarComboBoxClasificacion()
        {
            CNPelicula objPelicula = new CNPelicula();
            cboClasificacion.DataSource = objPelicula.ListadoClasificacion().Tables["Clasificacion"];
            cboClasificacion.DisplayMember = "Clasificacion";
            cboClasificacion.ValueMember = "IdClasificacion";
        }

        private void InsertarPelicula()
        {
            CNPelicula objInsertarPelicula = new CNPelicula();
            CEPelicula objPelicula = new CEPelicula();
            objPelicula.NombrePelicula = txtNombrePelicula.Text.Trim();
            objPelicula.Sinopsis = txtSinopsis.Text.Trim();
            objPelicula.Lanzamiento = txtLanzamiento.Text.Trim();
            objPelicula.Duracion = txtDuracion.Text.Trim();
            objPelicula.IdGenero = Convert.ToInt32(cboGenero.SelectedValue);
            objPelicula.IdClasificacion = Convert.ToInt32(cboClasificacion.SelectedValue);

            MemoryStream ms = new MemoryStream();
            if (pbPelicula.Image != null)
            {
                pbPelicula.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            else
            {
                pbPelicula.Image = Properties.Resources.Movie;
                pbPelicula.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                objPelicula.Imagen = ms.GetBuffer();
                objPelicula.URL = txtURL.Text.Trim();
                objPelicula.IdUsuario = Convert.ToInt32(txtUsuario.Text);



                if (objInsertarPelicula.NuevaFactura(objPelicula) > 0)
                {
                    MessageBox.Show(null, "Registro almacenado satisfactoriamente", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(null, "Error al almacenar el registro", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ActualizarPelicula()
        {
            CNPelicula objActualizarPelicula = new CNPelicula();
            CEPelicula objPelicula = new CEPelicula();
            objPelicula.IdPelicula = int.Parse(txtCodPelicula.Text);
            objPelicula.NombrePelicula = txtNombrePelicula.Text.Trim();
            objPelicula.Sinopsis = txtSinopsis.Text.Trim();
            objPelicula.Lanzamiento = txtLanzamiento.Text.Trim();
            objPelicula.Duracion = txtDuracion.Text.Trim();
            objPelicula.IdGenero = Convert.ToInt32(cboGenero.SelectedValue);
            objPelicula.IdClasificacion = Convert.ToInt32(cboClasificacion.SelectedValue);

            MemoryStream ms = new MemoryStream();
            if (pbPelicula.Image != null)
            {
                pbPelicula.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            else
            {
                pbPelicula.Image = Properties.Resources.Movie;
                pbPelicula.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            objPelicula.Imagen = ms.GetBuffer();
            objPelicula.URL = txtURL.Text.Trim();
            objPelicula.IdUsuario = Convert.ToInt32(txtUsuario.Text);
            if (objActualizarPelicula.ActualizarPelicula(objPelicula) > 0)
            {
                MessageBox.Show(null, "Registro actualizado satisfactoriamente", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "Error al actualizar el registro", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EliminarPelicula(int idPelicula)
        {
            CNPelicula objEliminarPelicula = new CNPelicula();
            CEPelicula objPelicula = new CEPelicula();
            objPelicula.IdPelicula = idPelicula;
           
            if (objEliminarPelicula.EliminarPelicula(objPelicula) > 0)
            {
                MessageBox.Show(null, "Registro eliminado satisfactoriamente", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "Error al eliminar el registro", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListadoPelicula()
        {
            CNPelicula objP = new CNPelicula();
            dgvLista.DataSource = objP.ListadoPelicula().Tables["Pelicula"];
            dgvLista.Columns[7].Visible = false;
            dgvLista.Columns[9].Visible = false;
        }

        private void ListadoPeliculaPorCodigo(int idPelicula)
        {
            CNPelicula objP = new CNPelicula();
            CEPelicula objPelicula = new CEPelicula();
            objPelicula.IdPelicula = idPelicula;
            dgvLista.DataSource = objP.ListadoPeliculaPorCodido(objPelicula).Tables["Pelicula"];
            dgvLista.Columns[7].Visible = false;
            dgvLista.Columns[9].Visible = false;
        }

        private void ListadoPeliculaPorNombrePelicula(string nombrePelicula)
        {
            CNPelicula objP = new CNPelicula();
            CEPelicula objPelicula = new CEPelicula();
            objPelicula.NombrePelicula = nombrePelicula ;
            dgvLista.DataSource = objP.ListadoPeliculaPorNombrePelicula(objPelicula).Tables["Pelicula"];
            dgvLista.Columns[7].Visible = false;
            dgvLista.Columns[9].Visible = false;
        }

        private void BtnAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
          
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                pbPelicula.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void BtnEliminarImagen_Click(object sender, EventArgs e)
        {
            pbPelicula.Image = null;
        }

      
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilaSeleccionada();
            HabilitarControles(true, false, false, true, true);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idPelicula;
            idPelicula = int.Parse(dgvLista.SelectedRows[0].Cells[0].Value.ToString());
            EliminarPelicula(idPelicula);
            ListadoPelicula();
            Limpiar();
            HabilitarControles(false, true, false, false, false);
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (!txtBusqueda.Text.Equals(""))
            {
                if (rdbCodPelicula.Checked == true)
                {
                    int idFactura;
                    if (int.TryParse(txtBusqueda.Text, out idFactura))
                    {
                        ListadoPeliculaPorCodigo(idFactura);
                    }
                    else
                    {
                        dgvLista.DataSource = null;
                    }
                }
                else
                {
                    ListadoPeliculaPorNombrePelicula(txtBusqueda.Text);
                }
            }
            else
            {
                ListadoPelicula();
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            HabilitarControles(true, false, true, false, true);
            txtCodPelicula.Focus();
            CargarComboBoxGenero();
            CargarComboBoxClasificacion();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtNombrePelicula.Text.Equals(""))
            {
                MessageBox.Show(null, "Ingrese el nombre la Pelicula", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtSinopsis.Text.Equals(""))
            {
                MessageBox.Show(null, "Ingrese la sinopsis la Pelicula", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtLanzamiento.Text.Equals(""))
            {
                MessageBox.Show(null, "Ingrese la fecha de lanzamiento la Pelicula", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboGenero.Text == null)
            {
                MessageBox.Show(null, "Seleccione el genero de la Pelicula", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboClasificacion.Text == null)
            {
                MessageBox.Show(null, "Seleccione la clasificación de la Pelicula", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtURL.Text.Equals(""))
            {
                MessageBox.Show(null, "Ingrese el URL de la Pelicula", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InsertarPelicula();
            Limpiar();
            HabilitarControles(false, true, false, false, false);
            ListadoPelicula();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (txtNombrePelicula.Text.Equals(""))
            {
                MessageBox.Show(null, "Ingrese el nombre la Pelicula", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtSinopsis.Text.Equals(""))
            {
                MessageBox.Show(null, "Ingrese la sinopsis la Pelicula", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtLanzamiento.Text.Equals(""))
            {
                MessageBox.Show(null, "Ingrese la fecha de lanzamiento la Pelicula", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboGenero.Text == null)
            {
                MessageBox.Show(null, "Seleccione el genero de la Pelicula", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboClasificacion.Text == null)
            {
                MessageBox.Show(null, "Seleccione la clasificación de la Pelicula", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtURL.Text.Equals(""))
            {
                MessageBox.Show(null, "Ingrese el URL de la Pelicula", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ActualizarPelicula();
            Limpiar();
            HabilitarControles(false, true, false, false, false);
            ListadoPelicula();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            HabilitarControles(false, true, false, false, false);
        }
    }
}
