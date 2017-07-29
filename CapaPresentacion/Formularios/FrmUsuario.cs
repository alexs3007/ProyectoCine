﻿using System;
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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            HabilitarControles(false, true, false, false, false);
            ListadoUsuario();
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
            txtBusqueda.Clear();
            txtCodUSuario.Clear();
            txtContraseña.Clear();
            txtNombre.Clear();
            cboEmpleado.Text = "";
            cboTipoUsuario.Text = "";

        }

        private void CargarComboBoxTipoUsuario()
        {
            CNUsuario objUsuario = new CNUsuario();
            cboTipoUsuario.DataSource = objUsuario.ListadoUsuario().Tables["TipoUsuario"];
            cboTipoUsuario.DisplayMember = "TipoUsuario";
            cboTipoUsuario.ValueMember = "IdTipoUsuario";
        }


        private void InsertarUsuario()
        {
            CNUsuario objInsertarUsuario = new CNUsuario();
            CEUsuario objUsuario = new CEUsuario();

            objUsuario.NombreUsuario = txtNombre.Text.Trim();
            objUsuario.Contraseña = txtContraseña.Text.Trim();
            objUsuario.CodEmpleado = cboEmpleado.SelectedValue.ToString();
            objUsuario.IdTipoUsuario = Convert.ToInt32(cboTipoUsuario.SelectedValue);


            if (objInsertarUsuario.InsertarUsuario(objUsuario) > 0)
            {
                MessageBox.Show(null, "Registro almacenado satisfactoriamente", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "Error al almacenar el registro", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ActualizarUsuario()
        {
            CNUsuario objActualizarUsuario = new CNUsuario();
            CEUsuario objUsuario = new CEUsuario();

            objUsuario.IdUsuario = Convert.ToInt32(txtCodUSuario.Text.Trim());
            objUsuario.NombreUsuario = txtNombre.Text.Trim();
            objUsuario.Contraseña = txtContraseña.Text.Trim();
            objUsuario.CodEmpleado = cboEmpleado.SelectedValue.ToString();
            objUsuario.IdTipoUsuario = Convert.ToInt32(cboTipoUsuario.SelectedValue);


            if (objActualizarUsuario.ActualizararUsuario(objUsuario) > 0)
            {
                MessageBox.Show(null, "Registro actualizado satisfactoriamente", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "Error al almacenar el registro", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarUsuario(int idUsuario)
        {
            CNUsuario objEliminarUsuario = new CNUsuario();
            CEUsuario objUsuario = new CEUsuario();

            objUsuario.IdUsuario = idUsuario;

            if (objEliminarUsuario.EliminarUsuario(objUsuario) > 0)
            {
                MessageBox.Show(null, "Registro eliminado satisfactoriamente", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "Error al eliminar el registro", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ListadoUsuario()
        {
            CNUsuario objP = new CNUsuario();
            dgvLista.DataSource = objP.ListadoUsuario().Tables["Usuario"];
            dgvLista.Columns[7].Visible = false;
            dgvLista.Columns[9].Visible = false;
        }


        private void ListadoUsuarioPorUsuario(string NombreUsuario)
        {
            CNUsuario objU = new CNUsuario();
            CEUsuario objUsuario = new CEUsuario();
            objUsuario.NombreUsuario = NombreUsuario;
            dgvLista.DataSource = objU.ListadoUsuarioPorUsuario(objUsuario).Tables["Usuario"];
            dgvLista.Columns[7].Visible = false;
            dgvLista.Columns[9].Visible = false;
        }

        private void ListadoUsuarioPorEmpleado(string CodEmpleado)
        {
            CNUsuario objU = new CNUsuario();
            CEUsuario objUsuario = new CEUsuario();
            objUsuario.CodEmpleado = CodEmpleado;
            dgvLista.DataSource = objU.ListadoUsuarioPorEmpleado(objUsuario).Tables["Usuario"];
            dgvLista.Columns[7].Visible = false;
            dgvLista.Columns[9].Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show(null, "Ingrese el nombre del Usuario", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtContraseña.Text.Equals(""))
            {
                MessageBox.Show(null, "Ingrese la contraseña del usuario", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboEmpleado.Text.Equals(""))
            {
                MessageBox.Show(null, "Seleccione el nombre del empleado", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboTipoUsuario.Text.Equals(""))
            {
                MessageBox.Show(null, "Seleccione el Tipo de Usuario", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            InsertarUsuario();
            Limpiar();
            HabilitarControles(false, true, false, false, false);
            ListadoUsuario();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show(null, "Ingrese el nombre del Usuario", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtContraseña.Text.Equals(""))
            {
                MessageBox.Show(null, "Ingrese la contraseña del usuario", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboEmpleado.Text.Equals(""))
            {
                MessageBox.Show(null, "Seleccione el nombre del empleado", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboTipoUsuario.Text.Equals(""))
            {
                MessageBox.Show(null, "Seleccione el Tipo de Usuario", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            ActualizarUsuario();
            Limpiar();
            HabilitarControles(false, true, false, false, false);
            ListadoUsuario();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCodUSuario.Focus();
            CargarComboBoxTipoUsuario();
            HabilitarControles(true, false, true, false, true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            HabilitarControles(false, true, false, false, false);
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilaSeleccionada();
            HabilitarControles(true, false, false, true, true);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idUsuario;
            idUsuario = int.Parse(dgvLista.SelectedRows[0].Cells[0].Value.ToString());
            EliminarUsuario(idUsuario);
            ListadoUsuario();
            Limpiar();
            HabilitarControles(false, true, false, false, false);
        }

        private void FilaSeleccionada()
        {
            txtCodUSuario.Text = dgvLista.SelectedRows[0].Cells[0].Value.ToString();
            txtNombre.Text = dgvLista.SelectedRows[0].Cells[1].FormattedValue.ToString();
            txtContraseña.Text = dgvLista.SelectedRows[0].Cells[2].FormattedValue.ToString();
            cboEmpleado.Text = dgvLista.SelectedRows[0].Cells[3].Value.ToString();
            cboTipoUsuario.Text = dgvLista.SelectedRows[0].Cells[4].Value.ToString();

        }
    }
}