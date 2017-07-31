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
using System.Text.RegularExpressions;

namespace CapaPresentacion.Formularios
{
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
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

        private void Limpiar()
        {
            txtCodEmpleado.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

        private void ListadoEmpleadoporNombre(string Nombre)
        {
            CNEmpledos CNE = new CNEmpledos();
            CEEmpleado CEE = new CEEmpleado();
            CEE.NombreEmpleado = Nombre;
            dgvLista.DataSource = CNE.ListadoEmpleadoporNombre(CEE).Tables["EmpleadoN"];
        }

        private void ListadoEmpleadoporCodigo(string Cod)
        {
            CNEmpledos CNE = new CNEmpledos();
            CEEmpleado CEE = new CEEmpleado();
            CEE.CodEmpleado = Cod;
            dgvLista.DataSource = CNE.ListadoEmpleadoporCodigo(CEE).Tables["EmpleadoC"];
        }

        private void FilaSelccionada()
        {
            txtCodEmpleado.Text = dgvLista.SelectedRows[0].Cells[0].Value.ToString();
            txtNombre.Text = dgvLista.SelectedRows[0].Cells[1].Value.ToString();
            txtApellido.Text = dgvLista.SelectedRows[0].Cells[2].Value.ToString();
            txtDireccion.Text = dgvLista.SelectedRows[0].Cells[3].Value.ToString();
            txtTelefono.Text = dgvLista.SelectedRows[0].Cells[4].Value.ToString();
            txtCorreo.Text = dgvLista.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void InsertarEmpleado()
        {
            CNEmpledos CNE = new CNEmpledos();
            CEEmpleado CEE = new CEEmpleado();
            CEE.CodEmpleado = txtCodEmpleado.Text.Trim();
            CEE.NombreEmpleado = txtNombre.Text.Trim();
            CEE.ApellidosEmpleado = txtApellido.Text.Trim();
            CEE.Direccion = txtDireccion.Text.Trim();
            CEE.Telefono = txtTelefono.Text.Trim();
            CEE.Correo = txtCorreo.Text.Trim();

            if (CNE.InsertarEmpleado(CEE) > 0)
            {
                MessageBox.Show(null, "Registro almacenado satisfactoriamente", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "Error al almacenar el registro", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarEmpleado()
        {
            CNEmpledos CNE = new CNEmpledos();
            CEEmpleado CEE = new CEEmpleado();
            CEE.CodEmpleado = txtCodEmpleado.Text.Trim();
            CEE.NombreEmpleado = txtNombre.Text.Trim();
            CEE.ApellidosEmpleado = txtApellido.Text.Trim();
            CEE.Direccion = txtDireccion.Text.Trim();
            CEE.Telefono = txtTelefono.Text.Trim();
            CEE.Correo = txtCorreo.Text.Trim();

            if (CNE.InsertarEmpleado(CEE) > 0)
            {
                MessageBox.Show(null, "Registro actualizado satisfactoriamente", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "Error al actualizar el registro", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EliminarEmpleado(string CodEmpleado)
        {
            CNEmpledos CNE = new CNEmpledos();
            CEEmpleado CEE = new CEEmpleado();
            CEE.CodEmpleado = CodEmpleado;

            if (CNE.EliminarEmpleado(CEE) > 0)
            {
                MessageBox.Show(null, "Registro eliminado satisfactoriamente", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "Error al eliminar el registro", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListadoEmpleado()
        {
            CNEmpledos objE = new CNEmpledos();
            dgvLista.DataSource = objE.ListadoEmpleado().Tables["Empleado"];
        }

        private bool ComprobarFormatoEmail(string email)
        {
            string sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, sFormato))
            {
                if (Regex.Replace(email, sFormato, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        

       

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilaSelccionada();
            HabilitarControles(true, false, false, true, true);
        }

       

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string CodiEmpleado;
            CodiEmpleado = (dgvLista.SelectedRows[0].Cells[0].Value.ToString());
            EliminarEmpleado(CodiEmpleado);
            ListadoEmpleado();
            Limpiar();
            HabilitarControles(false, true, false, false, false);
        }
    
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (!txtBusqueda.Text.Equals(""))
            {
                if (rdbCodEmpleado.Checked == true)
                {
                    ListadoEmpleadoporCodigo(txtBusqueda.Text);
                }
                else
                {
                    ListadoEmpleadoporNombre(txtBusqueda.Text);
                }
            }
            else
            {
                ListadoEmpleado();
            }

        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            HabilitarControles(false, true, false, false, false);
            ListadoEmpleado();

        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (txtCodEmpleado.Text.Equals(""))
            {
                MessageBox.Show(null, "Ingrese el Código del Empleado", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show(null, "Ingrese el Nombre del Empleado", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtApellido.Text.Equals(""))
            {
                MessageBox.Show(null, "Ingrese el Apellido del Empleado", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtDireccion.Text.Equals(""))
            {
                MessageBox.Show(null, "Ingrese la dirección del Empleado", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtCorreo.Text != "")
            {
                if (ComprobarFormatoEmail(txtCorreo.Text) == false)
                {
                    MessageBox.Show(null, "Ingrese un correo correpto", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCorreo.Focus();
                    return;
                }
            }
            ActualizarEmpleado();
            Limpiar();
            HabilitarControles(false, true, false, false, false);
            ListadoEmpleado();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            HabilitarControles(true, false, true, false, true);
            txtCodEmpleado.Focus();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtCodEmpleado.Text.Equals(""))
            {
                MessageBox.Show(null, "Ingrese el Código del Empleado", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show(null, "Ingrese el Nombre del Empleado", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtApellido.Text.Equals(""))
            {
                MessageBox.Show(null, "Ingrese el Apellido del Empleado", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtDireccion.Text.Equals(""))
            {
                MessageBox.Show(null, "Ingrese la dirección del Empleado", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtCorreo.Text != "")
            {
                if (ComprobarFormatoEmail(txtCorreo.Text) == false)
                {
                    MessageBox.Show(null, "Ingrese un correo correpto", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCorreo.Focus();
                    return;
                }
            }
            InsertarEmpleado();
            Limpiar();
            HabilitarControles(false, true, false, false, false);
            ListadoEmpleado();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            HabilitarControles(false, true, false, false, false);
        }
    }
}
