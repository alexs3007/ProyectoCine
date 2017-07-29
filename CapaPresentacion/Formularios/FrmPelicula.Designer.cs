﻿namespace CapaPresentacion.Formularios
{
    partial class FrmPelicula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.rdbCodPelicula = new System.Windows.Forms.RadioButton();
            this.rdbNombrePelicula = new System.Windows.Forms.RadioButton();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.cmsOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlDatos = new System.Windows.Forms.GroupBox();
            this.txtLanzamiento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pbPelicula = new System.Windows.Forms.PictureBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.BtnEliminarImagen = new System.Windows.Forms.Button();
            this.BtnAgregarImagen = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboClasificacion = new System.Windows.Forms.ComboBox();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.txtNombrePelicula = new System.Windows.Forms.TextBox();
            this.txtCodPelicula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.cmsOpciones.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPelicula)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.dgvLista);
            this.groupBox3.Location = new System.Drawing.Point(477, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(635, 475);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBusqueda);
            this.groupBox4.Controls.Add(this.rdbCodPelicula);
            this.groupBox4.Controls.Add(this.rdbNombrePelicula);
            this.groupBox4.Location = new System.Drawing.Point(12, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(617, 56);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Búsqueda por:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(197, 23);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(393, 20);
            this.txtBusqueda.TabIndex = 16;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // rdbCodPelicula
            // 
            this.rdbCodPelicula.AutoSize = true;
            this.rdbCodPelicula.Checked = true;
            this.rdbCodPelicula.Location = new System.Drawing.Point(5, 24);
            this.rdbCodPelicula.Name = "rdbCodPelicula";
            this.rdbCodPelicula.Size = new System.Drawing.Size(89, 17);
            this.rdbCodPelicula.TabIndex = 14;
            this.rdbCodPelicula.TabStop = true;
            this.rdbCodPelicula.Text = "Cod. Película";
            this.rdbCodPelicula.UseVisualStyleBackColor = true;
            // 
            // rdbNombrePelicula
            // 
            this.rdbNombrePelicula.AutoSize = true;
            this.rdbNombrePelicula.Location = new System.Drawing.Point(101, 24);
            this.rdbNombrePelicula.Name = "rdbNombrePelicula";
            this.rdbNombrePelicula.Size = new System.Drawing.Size(62, 17);
            this.rdbNombrePelicula.TabIndex = 15;
            this.rdbNombrePelicula.Text = "Nombre";
            this.rdbNombrePelicula.UseVisualStyleBackColor = true;
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.ContextMenuStrip = this.cmsOpciones;
            this.dgvLista.Location = new System.Drawing.Point(12, 89);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(609, 373);
            this.dgvLista.TabIndex = 13;
            // 
            // cmsOpciones
            // 
            this.cmsOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.cmsOpciones.Name = "cmsOpciones";
            this.cmsOpciones.Size = new System.Drawing.Size(118, 48);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnActualizar);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Location = new System.Drawing.Point(5, 429);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 75);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(245, 31);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(33, 31);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(352, 31);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(140, 31);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.txtUsuario);
            this.pnlDatos.Controls.Add(this.label9);
            this.pnlDatos.Controls.Add(this.txtLanzamiento);
            this.pnlDatos.Controls.Add(this.label8);
            this.pnlDatos.Controls.Add(this.pbPelicula);
            this.pnlDatos.Controls.Add(this.Panel1);
            this.pnlDatos.Controls.Add(this.txtURL);
            this.pnlDatos.Controls.Add(this.label7);
            this.pnlDatos.Controls.Add(this.cboClasificacion);
            this.pnlDatos.Controls.Add(this.cboGenero);
            this.pnlDatos.Controls.Add(this.label6);
            this.pnlDatos.Controls.Add(this.label5);
            this.pnlDatos.Controls.Add(this.txtDuracion);
            this.pnlDatos.Controls.Add(this.label4);
            this.pnlDatos.Controls.Add(this.txtSinopsis);
            this.pnlDatos.Controls.Add(this.txtNombrePelicula);
            this.pnlDatos.Controls.Add(this.txtCodPelicula);
            this.pnlDatos.Controls.Add(this.label1);
            this.pnlDatos.Controls.Add(this.label2);
            this.pnlDatos.Controls.Add(this.label3);
            this.pnlDatos.Location = new System.Drawing.Point(5, 33);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(466, 390);
            this.pnlDatos.TabIndex = 23;
            this.pnlDatos.TabStop = false;
            // 
            // txtLanzamiento
            // 
            this.txtLanzamiento.Location = new System.Drawing.Point(98, 192);
            this.txtLanzamiento.Name = "txtLanzamiento";
            this.txtLanzamiento.Size = new System.Drawing.Size(220, 20);
            this.txtLanzamiento.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Lanzamiento";
            // 
            // pbPelicula
            // 
            this.pbPelicula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPelicula.Location = new System.Drawing.Point(326, 19);
            this.pbPelicula.Name = "pbPelicula";
            this.pbPelicula.Size = new System.Drawing.Size(130, 176);
            this.pbPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPelicula.TabIndex = 48;
            this.pbPelicula.TabStop = false;
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.BtnEliminarImagen);
            this.Panel1.Controls.Add(this.BtnAgregarImagen);
            this.Panel1.Location = new System.Drawing.Point(326, 194);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(130, 39);
            this.Panel1.TabIndex = 49;
            // 
            // BtnEliminarImagen
            // 
            this.BtnEliminarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminarImagen.Location = new System.Drawing.Point(76, 4);
            this.BtnEliminarImagen.Name = "BtnEliminarImagen";
            this.BtnEliminarImagen.Size = new System.Drawing.Size(30, 30);
            this.BtnEliminarImagen.TabIndex = 46;
            this.BtnEliminarImagen.UseVisualStyleBackColor = true;
            this.BtnEliminarImagen.Click += new System.EventHandler(this.BtnEliminarImagen_Click);
            // 
            // BtnAgregarImagen
            // 
            this.BtnAgregarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregarImagen.Location = new System.Drawing.Point(23, 4);
            this.BtnAgregarImagen.Name = "BtnAgregarImagen";
            this.BtnAgregarImagen.Size = new System.Drawing.Size(30, 30);
            this.BtnAgregarImagen.TabIndex = 45;
            this.BtnAgregarImagen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAgregarImagen.UseVisualStyleBackColor = true;
            this.BtnAgregarImagen.Click += new System.EventHandler(this.BtnAgregarImagen_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(98, 324);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(358, 20);
            this.txtURL.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "URL Trailer";
            // 
            // cboClasificacion
            // 
            this.cboClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClasificacion.FormattingEnabled = true;
            this.cboClasificacion.Location = new System.Drawing.Point(98, 290);
            this.cboClasificacion.Name = "cboClasificacion";
            this.cboClasificacion.Size = new System.Drawing.Size(121, 21);
            this.cboClasificacion.TabIndex = 17;
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(98, 257);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(121, 21);
            this.cboGenero.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Clasificación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Género";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(98, 223);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(132, 20);
            this.txtDuracion.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Duración";
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.Location = new System.Drawing.Point(98, 90);
            this.txtSinopsis.Multiline = true;
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(220, 90);
            this.txtSinopsis.TabIndex = 11;
            // 
            // txtNombrePelicula
            // 
            this.txtNombrePelicula.Location = new System.Drawing.Point(98, 53);
            this.txtNombrePelicula.Name = "txtNombrePelicula";
            this.txtNombrePelicula.Size = new System.Drawing.Size(220, 20);
            this.txtNombrePelicula.TabIndex = 10;
            // 
            // txtCodPelicula
            // 
            this.txtCodPelicula.Enabled = false;
            this.txtCodPelicula.Location = new System.Drawing.Point(98, 19);
            this.txtCodPelicula.Name = "txtCodPelicula";
            this.txtCodPelicula.Size = new System.Drawing.Size(73, 20);
            this.txtCodPelicula.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre Película";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sinopsis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Código Película";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(98, 352);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(220, 20);
            this.txtUsuario.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Usuario";
            // 
            // FrmPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 506);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pnlDatos);
            this.Name = "FrmPelicula";
            this.Text = "Gestión de Película";
            this.Load += new System.EventHandler(this.FrmPelicula_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.cmsOpciones.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPelicula)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.RadioButton rdbCodPelicula;
        private System.Windows.Forms.RadioButton rdbNombrePelicula;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox pnlDatos;
        internal System.Windows.Forms.PictureBox pbPelicula;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button BtnEliminarImagen;
        internal System.Windows.Forms.Button BtnAgregarImagen;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboClasificacion;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSinopsis;
        private System.Windows.Forms.TextBox txtNombrePelicula;
        private System.Windows.Forms.TextBox txtCodPelicula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip cmsOpciones;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.TextBox txtLanzamiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label9;
    }
}