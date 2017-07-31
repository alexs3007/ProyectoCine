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
    public partial class FrmFactura : Form
    {
        public FrmFactura()
        {
            InitializeComponent();
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            HabilitarControles(false, true, false, false, false);
            ListadoFactura();
        }

        private void Limpiar()
        {
            txtIdFactura.Clear();
            dtpFecha.ResetText();
            cboPelicula.DataSource = null;
            cboTecnologia.DataSource = null;
            txtCantidad.Clear();
            txtPrecio.Clear();
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
            txtIdFactura.Text = dgvLista.SelectedRows[0].Cells[0].Value.ToString();
            dtpFecha.Text = dgvLista.SelectedRows[0].Cells[1].FormattedValue.ToString();
            CargarComboBoxPelicula();
            cboPelicula.Text = dgvLista.SelectedRows[0].Cells[2].Value.ToString();
            CargarComboBoxTecnologia();
            cboTecnologia.Text = dgvLista.SelectedRows[0].Cells[3].Value.ToString();
            txtCantidad.Text = dgvLista.SelectedRows[0].Cells[4].Value.ToString();
            txtPrecio.Text = dgvLista.SelectedRows[0].Cells[5].Value.ToString();
            
        }

        private void CargarComboBoxPelicula()
        {
            CNFactura objFactura = new CNFactura();
            cboPelicula.DataSource = objFactura.ListadoPelicula().Tables["Pelicula"];
            cboPelicula.DisplayMember = "NombrePelicula";
            cboPelicula.ValueMember = "IdPelicula";
        }
        private void CargarComboBoxTecnologia()
        {
            CNFactura objFactura = new CNFactura();
            cboTecnologia.DataSource = objFactura.ListadoTecnologia().Tables["Tecnologia"];
            cboTecnologia.DisplayMember = "TipoTecnologia";
            cboTecnologia.ValueMember = "IdTecnologia";
        }

        private void InsertarFactura()
        {
            CNFactura objInsertarFactura = new CNFactura();
            CEFactura objFactura = new CEFactura();
            objFactura.Fecha = dtpFecha.Value;
            objFactura.IdPelicula = Convert.ToInt32(cboPelicula.SelectedValue);
            objFactura.IdTecnologia = Convert.ToInt32(cboTecnologia.SelectedValue);
            objFactura.CantidadBoleto = int.Parse(txtCantidad.Text);
            objFactura.PrecioBoleto = double.Parse(txtPrecio.Text);
            objFactura.IdUsuario = int.Parse(txtIdUsuario.Text);

            if(objInsertarFactura.NuevaFactura(objFactura) > 0)
            {
                MessageBox.Show(null, "Registro almacenado satisfactoriamente", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "Error al almacenar el registro", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarFactura()
        {
            CNFactura objActualizarFactura = new CNFactura();
            CEFactura objFactura = new CEFactura();
            objFactura.IdFactura = int.Parse(txtIdFactura.Text);
            objFactura.Fecha = dtpFecha.Value;
            objFactura.IdPelicula = Convert.ToInt32(cboPelicula.SelectedValue);
            objFactura.IdTecnologia = Convert.ToInt32(cboTecnologia.SelectedValue);
            objFactura.CantidadBoleto = int.Parse(txtCantidad.Text);
            objFactura.PrecioBoleto = double.Parse(txtPrecio.Text);
            objFactura.IdUsuario = int.Parse(txtIdUsuario.Text);

            if (objActualizarFactura.ActualizarFactura(objFactura) > 0)
            {
                MessageBox.Show(null, "Registro actualizado satisfactoriamente", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "Error al actualizar el registro", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EliminarFactura(int idFactura)
        {
            CNFactura objEliminarFactura = new CNFactura();
            CEFactura objFactura = new CEFactura();
            objFactura.IdFactura = idFactura;
         

            if (objEliminarFactura.EliminarFactura(objFactura) > 0)
            {
                MessageBox.Show(null, "Registro eliminado satisfactoriamente", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "Error al eliminar el registro", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListadoFactura()
        {
            CNFactura objF = new CNFactura();
            dgvLista.DataSource = objF.ListadoFactura().Tables["Factura"];
        }
        
        private void ListadoFacturaPorCodigo(int idFactura)
        {
            CNFactura objF = new CNFactura();
            CEFactura objFactura = new CEFactura();
            objFactura.IdFactura = idFactura;
            dgvLista.DataSource = objF.ListadoFacturaPorCodido(objFactura).Tables["Factura"];
        }

        private void ListadoFacturaPorPelicula(string Pelicula)
        {
            CNFactura objF = new CNFactura();
            CEFactura objFactura = new CEFactura();
            objFactura.NombrePelicula = Pelicula;
            dgvLista.DataSource = objF.ListadoFacturaPorPelicula(objFactura).Tables["Factura"];
        }
 

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilaSeleccionada();
            HabilitarControles(true, false, false, true, true);
            tbcFactura.SelectedTab = tbpDatosFactura;
        }

        private void elliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idFactura;
            idFactura =int.Parse( dgvLista.SelectedRows[0].Cells[0].Value.ToString());
            EliminarFactura(idFactura);
            ListadoFactura();
            Limpiar();
            HabilitarControles(false, true, false, false, false);
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (!txtBusqueda.Text.Equals(""))
            {
                if (rdbCodFactura.Checked == true)
                {
                    int idFactura;
                    if (int.TryParse(txtBusqueda.Text, out idFactura))
                    {
                        ListadoFacturaPorCodigo(idFactura);
                    }
                    else
                    {
                        dgvLista.DataSource = null;
                    }
                }
                else
                {
                    ListadoFacturaPorPelicula(txtBusqueda.Text);
                }
            }
            else
            {
                ListadoFactura();
            }
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            HabilitarControles(true, false, true, false, true);
            txtIdFactura.Focus();
            CargarComboBoxPelicula();
            CargarComboBoxTecnologia();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (cboPelicula.Text == null)
            {
                MessageBox.Show(null, "Seleccione la Pelicula", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboTecnologia.Text == null)
            {
                MessageBox.Show(null, "Seleccione la Tecnologia", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int cantidadBoletos;
            if (!int.TryParse(txtCantidad.Text, out cantidadBoletos))
            {
                MessageBox.Show(null, "Ingrese la cantidad de boletos correcta", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double precioBoletos;
            if (!double.TryParse(txtPrecio.Text, out precioBoletos))
            {
                MessageBox.Show(null, "Ingrese el precio  de boletos correcto", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InsertarFactura();
            Limpiar();
            HabilitarControles(false, true, false, false, false);
            ListadoFactura();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (cboPelicula.Text == null)
            {
                MessageBox.Show(null, "Seleccione la Pelicula", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboTecnologia.Text == null)
            {
                MessageBox.Show(null, "Seleccione la Tecnologia", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int cantidadBoletos;
            if (!int.TryParse(txtCantidad.Text, out cantidadBoletos))
            {
                MessageBox.Show(null, "Ingrese la cantidad de boletos correcta", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double precioBoletos;
            if (!double.TryParse(txtPrecio.Text, out precioBoletos))
            {
                MessageBox.Show(null, "Ingrese el precio  de boletos correcto", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ActualizarFactura();
            Limpiar();
            HabilitarControles(false, true, false, false, false);
            ListadoFactura();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            HabilitarControles(false, true, false, false, false);
        }
    }
}
