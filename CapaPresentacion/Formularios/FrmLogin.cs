﻿using System;
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
using System.Data.SqlClient;

namespace CapaPresentacion.Formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(!txtUsuario.Text.Equals("") && !txtContraseña.Text.Equals(""))
            {
                CNLogin objAccesoUsuario = new CNLogin();
                CELogin objLogin = new CELogin();
                objLogin.NombreUsuario = txtUsuario.Text.Trim();
                objLogin.Contrasena = txtContraseña.Text.Trim();

                if (objAccesoUsuario.AccesoUsuario(objLogin)[0] != "")
                {
                    FrmPrincipal.id = objAccesoUsuario.AccesoUsuario(objLogin)[0];
                    FrmPrincipal.tipoUsuario = objAccesoUsuario.AccesoUsuario(objLogin)[1];
                    FrmPrincipal.nombreUsuario = objAccesoUsuario.AccesoUsuario(objLogin)[2];
                    FrmPrincipal frm = new FrmPrincipal();
                    frm.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show(null, "Usuario o contraseña incorrecto", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(null, "Ingrese el usuario y contraseña", "Cinema Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void pnlcerrar_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnAceptar.PerformClick();
            }
        }
    }
}
