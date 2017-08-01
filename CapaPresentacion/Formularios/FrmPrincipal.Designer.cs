namespace CapaPresentacion.Formularios
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlcerrar = new System.Windows.Forms.Panel();
            this.pnlCambioUsuario = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblusuario = new System.Windows.Forms.Label();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.lblHorario = new System.Windows.Forms.Label();
            this.pnlPeliculaHorario = new System.Windows.Forms.Panel();
            this.lblReportes = new System.Windows.Forms.Label();
            this.pnlReporte = new System.Windows.Forms.Panel();
            this.lblMostrarCartelera = new System.Windows.Forms.Label();
            this.pnlMostrarCartelera = new System.Windows.Forms.Panel();
            this.lblTecnologia = new System.Windows.Forms.Label();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblFactura = new System.Windows.Forms.Label();
            this.pnlEmpleado = new System.Windows.Forms.Panel();
            this.lblCartelera = new System.Windows.Forms.Label();
            this.pnlTecnologia = new System.Windows.Forms.Panel();
            this.pnlPelicula = new System.Windows.Forms.Panel();
            this.pnlFactura = new System.Windows.Forms.Panel();
            this.pnlCarteleraS = new System.Windows.Forms.Panel();
            this.pnlCartelera = new System.Windows.Forms.Panel();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 719);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1362, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // pnlcerrar
            // 
            this.pnlcerrar.BackColor = System.Drawing.Color.Transparent;
            this.pnlcerrar.BackgroundImage = global::CapaPresentacion.Properties.Resources.X;
            this.pnlcerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlcerrar.Location = new System.Drawing.Point(1315, 8);
            this.pnlcerrar.Name = "pnlcerrar";
            this.pnlcerrar.Size = new System.Drawing.Size(42, 42);
            this.pnlcerrar.TabIndex = 4;
            this.pnlcerrar.Click += new System.EventHandler(this.pnlcerrar_Click);
            // 
            // pnlCambioUsuario
            // 
            this.pnlCambioUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pnlCambioUsuario.BackgroundImage = global::CapaPresentacion.Properties.Resources.logout_icon_150x150;
            this.pnlCambioUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCambioUsuario.Location = new System.Drawing.Point(1267, 8);
            this.pnlCambioUsuario.Name = "pnlCambioUsuario";
            this.pnlCambioUsuario.Size = new System.Drawing.Size(42, 42);
            this.pnlCambioUsuario.TabIndex = 5;
            this.pnlCambioUsuario.Click += new System.EventHandler(this.pnlCambioUsuario_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImage = global::CapaPresentacion.Properties.Resources.bordesuperior;
            this.panel1.Controls.Add(this.lblusuario);
            this.panel1.Controls.Add(this.pnlUsuario);
            this.panel1.Controls.Add(this.lblHorario);
            this.panel1.Controls.Add(this.pnlPeliculaHorario);
            this.panel1.Controls.Add(this.lblReportes);
            this.panel1.Controls.Add(this.pnlReporte);
            this.panel1.Controls.Add(this.lblMostrarCartelera);
            this.panel1.Controls.Add(this.pnlMostrarCartelera);
            this.panel1.Controls.Add(this.lblTecnologia);
            this.panel1.Controls.Add(this.lblPelicula);
            this.panel1.Controls.Add(this.lblEmpleado);
            this.panel1.Controls.Add(this.lblFactura);
            this.panel1.Controls.Add(this.pnlEmpleado);
            this.panel1.Controls.Add(this.lblCartelera);
            this.panel1.Controls.Add(this.pnlTecnologia);
            this.panel1.Controls.Add(this.pnlPelicula);
            this.panel1.Controls.Add(this.pnlFactura);
            this.panel1.Controls.Add(this.pnlCarteleraS);
            this.panel1.Controls.Add(this.pnlcerrar);
            this.panel1.Controls.Add(this.pnlCambioUsuario);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 87);
            this.panel1.TabIndex = 7;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblusuario.Location = new System.Drawing.Point(758, 63);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(64, 14);
            this.lblusuario.TabIndex = 24;
            this.lblusuario.Text = "USUARIO";
            this.lblusuario.Visible = false;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackgroundImage = global::CapaPresentacion.Properties.Resources.UsuarioCirculo;
            this.pnlUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlUsuario.Location = new System.Drawing.Point(771, 8);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(50, 50);
            this.pnlUsuario.TabIndex = 23;
            this.pnlUsuario.Click += new System.EventHandler(this.pnlUsuario_Click);
            this.pnlUsuario.MouseLeave += new System.EventHandler(this.pnlUsuario_MouseLeave);
            this.pnlUsuario.MouseHover += new System.EventHandler(this.pnlUsuario_MouseHover);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.Color.Transparent;
            this.lblHorario.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHorario.Location = new System.Drawing.Point(490, 63);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(66, 14);
            this.lblHorario.TabIndex = 22;
            this.lblHorario.Text = "HORARIO";
            this.lblHorario.Visible = false;
            // 
            // pnlPeliculaHorario
            // 
            this.pnlPeliculaHorario.BackgroundImage = global::CapaPresentacion.Properties.Resources.pelicula_HorarioCirculo;
            this.pnlPeliculaHorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPeliculaHorario.Location = new System.Drawing.Point(498, 8);
            this.pnlPeliculaHorario.Name = "pnlPeliculaHorario";
            this.pnlPeliculaHorario.Size = new System.Drawing.Size(50, 50);
            this.pnlPeliculaHorario.TabIndex = 21;
            this.pnlPeliculaHorario.Click += new System.EventHandler(this.pnlPeliculaHorario_Click);
            this.pnlPeliculaHorario.MouseLeave += new System.EventHandler(this.pnlPeliculaHorario_MouseLeave);
            this.pnlPeliculaHorario.MouseHover += new System.EventHandler(this.pnlPeliculaHorario_MouseHover);
            // 
            // lblReportes
            // 
            this.lblReportes.AutoSize = true;
            this.lblReportes.BackColor = System.Drawing.Color.Transparent;
            this.lblReportes.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReportes.Location = new System.Drawing.Point(669, 63);
            this.lblReportes.Name = "lblReportes";
            this.lblReportes.Size = new System.Drawing.Size(74, 14);
            this.lblReportes.TabIndex = 20;
            this.lblReportes.Text = "REPORTES";
            this.lblReportes.Visible = false;
            // 
            // pnlReporte
            // 
            this.pnlReporte.BackgroundImage = global::CapaPresentacion.Properties.Resources.reporteCirculo;
            this.pnlReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlReporte.Location = new System.Drawing.Point(682, 4);
            this.pnlReporte.Name = "pnlReporte";
            this.pnlReporte.Size = new System.Drawing.Size(50, 50);
            this.pnlReporte.TabIndex = 19;
            this.pnlReporte.Click += new System.EventHandler(this.pnlReporte_Click);
            this.pnlReporte.MouseLeave += new System.EventHandler(this.pnlReporte_MouseLeave);
            this.pnlReporte.MouseHover += new System.EventHandler(this.pnlReporte_MouseHover);
            // 
            // lblMostrarCartelera
            // 
            this.lblMostrarCartelera.BackColor = System.Drawing.Color.Transparent;
            this.lblMostrarCartelera.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarCartelera.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMostrarCartelera.Location = new System.Drawing.Point(3, 53);
            this.lblMostrarCartelera.Name = "lblMostrarCartelera";
            this.lblMostrarCartelera.Size = new System.Drawing.Size(87, 29);
            this.lblMostrarCartelera.TabIndex = 18;
            this.lblMostrarCartelera.Text = "MOSTRAR CARTELERA";
            this.lblMostrarCartelera.Visible = false;
            // 
            // pnlMostrarCartelera
            // 
            this.pnlMostrarCartelera.BackgroundImage = global::CapaPresentacion.Properties.Resources.Mostrar_CarteleraCirculo;
            this.pnlMostrarCartelera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMostrarCartelera.Location = new System.Drawing.Point(13, 5);
            this.pnlMostrarCartelera.Name = "pnlMostrarCartelera";
            this.pnlMostrarCartelera.Size = new System.Drawing.Size(50, 50);
            this.pnlMostrarCartelera.TabIndex = 17;
            this.pnlMostrarCartelera.Click += new System.EventHandler(this.pnlMostrarCartelera_Click);
            this.pnlMostrarCartelera.MouseLeave += new System.EventHandler(this.pnlMostrarCartelera_MouseLeave);
            this.pnlMostrarCartelera.MouseHover += new System.EventHandler(this.pnlMostrarCartelera_MouseHover);
            // 
            // lblTecnologia
            // 
            this.lblTecnologia.AutoSize = true;
            this.lblTecnologia.BackColor = System.Drawing.Color.Transparent;
            this.lblTecnologia.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTecnologia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTecnologia.Location = new System.Drawing.Point(314, 63);
            this.lblTecnologia.Name = "lblTecnologia";
            this.lblTecnologia.Size = new System.Drawing.Size(87, 14);
            this.lblTecnologia.TabIndex = 16;
            this.lblTecnologia.Text = "TECNOLOGIA";
            this.lblTecnologia.Visible = false;
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.BackColor = System.Drawing.Color.Transparent;
            this.lblPelicula.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelicula.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPelicula.Location = new System.Drawing.Point(239, 63);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(71, 14);
            this.lblPelicula.TabIndex = 15;
            this.lblPelicula.Text = "PELICULA";
            this.lblPelicula.Visible = false;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpleado.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmpleado.Location = new System.Drawing.Point(407, 63);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(77, 14);
            this.lblEmpleado.TabIndex = 16;
            this.lblEmpleado.Text = "EMPLEADO";
            this.lblEmpleado.Visible = false;
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.BackColor = System.Drawing.Color.Transparent;
            this.lblFactura.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFactura.Location = new System.Drawing.Point(153, 63);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(66, 14);
            this.lblFactura.TabIndex = 14;
            this.lblFactura.Text = "FACTURA";
            this.lblFactura.Visible = false;
            // 
            // pnlEmpleado
            // 
            this.pnlEmpleado.BackgroundImage = global::CapaPresentacion.Properties.Resources.empleadocirculo;
            this.pnlEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEmpleado.Location = new System.Drawing.Point(421, 5);
            this.pnlEmpleado.Name = "pnlEmpleado";
            this.pnlEmpleado.Size = new System.Drawing.Size(50, 50);
            this.pnlEmpleado.TabIndex = 13;
            this.pnlEmpleado.Click += new System.EventHandler(this.pnlEmpleado_Click);
            this.pnlEmpleado.MouseLeave += new System.EventHandler(this.pnlEmpleado_MouseLeave);
            this.pnlEmpleado.MouseHover += new System.EventHandler(this.pnlEmpleado_MouseHover);
            // 
            // lblCartelera
            // 
            this.lblCartelera.AutoSize = true;
            this.lblCartelera.BackColor = System.Drawing.Color.Transparent;
            this.lblCartelera.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartelera.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCartelera.Location = new System.Drawing.Point(63, 63);
            this.lblCartelera.Name = "lblCartelera";
            this.lblCartelera.Size = new System.Drawing.Size(84, 14);
            this.lblCartelera.TabIndex = 9;
            this.lblCartelera.Text = "CARTELERA";
            this.lblCartelera.Visible = false;
            // 
            // pnlTecnologia
            // 
            this.pnlTecnologia.BackgroundImage = global::CapaPresentacion.Properties.Resources.tecnologia;
            this.pnlTecnologia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTecnologia.Location = new System.Drawing.Point(331, 4);
            this.pnlTecnologia.Name = "pnlTecnologia";
            this.pnlTecnologia.Size = new System.Drawing.Size(50, 50);
            this.pnlTecnologia.TabIndex = 12;
            this.pnlTecnologia.Click += new System.EventHandler(this.pnlTecnologia_Click);
            this.pnlTecnologia.MouseLeave += new System.EventHandler(this.pnlTecnologia_MouseLeave);
            this.pnlTecnologia.MouseHover += new System.EventHandler(this.pnlTecnologia_MouseHover);
            // 
            // pnlPelicula
            // 
            this.pnlPelicula.BackgroundImage = global::CapaPresentacion.Properties.Resources.pelicula;
            this.pnlPelicula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPelicula.Location = new System.Drawing.Point(247, 5);
            this.pnlPelicula.Name = "pnlPelicula";
            this.pnlPelicula.Size = new System.Drawing.Size(50, 50);
            this.pnlPelicula.TabIndex = 11;
            this.pnlPelicula.Click += new System.EventHandler(this.pnlPelicula_Click);
            this.pnlPelicula.MouseLeave += new System.EventHandler(this.pnlPelicula_MouseLeave);
            this.pnlPelicula.MouseHover += new System.EventHandler(this.pnlPelicula_MouseHover);
            // 
            // pnlFactura
            // 
            this.pnlFactura.BackgroundImage = global::CapaPresentacion.Properties.Resources.factura;
            this.pnlFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFactura.Location = new System.Drawing.Point(162, 4);
            this.pnlFactura.Name = "pnlFactura";
            this.pnlFactura.Size = new System.Drawing.Size(50, 50);
            this.pnlFactura.TabIndex = 10;
            this.pnlFactura.Click += new System.EventHandler(this.pnlFactura_Click);
            this.pnlFactura.MouseLeave += new System.EventHandler(this.pnlFactura_MouseLeave);
            this.pnlFactura.MouseHover += new System.EventHandler(this.pnlFactura_MouseHover);
            // 
            // pnlCarteleraS
            // 
            this.pnlCarteleraS.BackColor = System.Drawing.Color.Transparent;
            this.pnlCarteleraS.BackgroundImage = global::CapaPresentacion.Properties.Resources.carterleracirculo;
            this.pnlCarteleraS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCarteleraS.Location = new System.Drawing.Point(78, 4);
            this.pnlCarteleraS.Name = "pnlCarteleraS";
            this.pnlCarteleraS.Size = new System.Drawing.Size(50, 50);
            this.pnlCarteleraS.TabIndex = 9;
            this.pnlCarteleraS.Click += new System.EventHandler(this.pnlCarteleraS_Click);
            this.pnlCarteleraS.MouseLeave += new System.EventHandler(this.pnlCarteleraS_MouseLeave);
            this.pnlCarteleraS.MouseHover += new System.EventHandler(this.pnlCarteleraS_MouseHover);
            // 
            // pnlCartelera
            // 
            this.pnlCartelera.Location = new System.Drawing.Point(42, 194);
            this.pnlCartelera.Name = "pnlCartelera";
            this.pnlCartelera.Size = new System.Drawing.Size(0, 0);
            this.pnlCartelera.TabIndex = 0;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.Imagen1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.pnlCartelera);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.Text = "Cinema Evolution";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel pnlcerrar;
        private System.Windows.Forms.Panel pnlCambioUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlCartelera;
        private System.Windows.Forms.Panel pnlCarteleraS;
        private System.Windows.Forms.Panel pnlFactura;
        private System.Windows.Forms.Panel pnlPelicula;
        private System.Windows.Forms.Panel pnlTecnologia;
        private System.Windows.Forms.Panel pnlEmpleado;
        private System.Windows.Forms.Label lblCartelera;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblTecnologia;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Panel pnlMostrarCartelera;
        private System.Windows.Forms.Label lblMostrarCartelera;
        private System.Windows.Forms.Panel pnlReporte;
        private System.Windows.Forms.Label lblReportes;
        private System.Windows.Forms.Panel pnlPeliculaHorario;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Label lblusuario;
    }
}



