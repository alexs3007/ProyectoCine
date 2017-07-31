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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlcerrar = new System.Windows.Forms.Panel();
            this.pnlCambioUsuario = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlEmpleado = new System.Windows.Forms.Panel();
            this.pnlTecnologia = new System.Windows.Forms.Panel();
            this.pnlPelicula = new System.Windows.Forms.Panel();
            this.pnlFactura = new System.Windows.Forms.Panel();
            this.pnlCarteleraS = new System.Windows.Forms.Panel();
            this.pnlCartelera = new System.Windows.Forms.Panel();
            this.lblCartelera = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFactura = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.lblTecnologia = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Controls.Add(this.pnlEmpleado);
            this.panel1.Controls.Add(this.pnlTecnologia);
            this.panel1.Controls.Add(this.pnlPelicula);
            this.panel1.Controls.Add(this.pnlFactura);
            this.panel1.Controls.Add(this.pnlCarteleraS);
            this.panel1.Controls.Add(this.pnlcerrar);
            this.panel1.Controls.Add(this.pnlCambioUsuario);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 58);
            this.panel1.TabIndex = 7;
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
            // lblCartelera
            // 
            this.lblCartelera.AutoSize = true;
            this.lblCartelera.BackColor = System.Drawing.Color.Transparent;
            this.lblCartelera.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartelera.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCartelera.Location = new System.Drawing.Point(61, 4);
            this.lblCartelera.Name = "lblCartelera";
            this.lblCartelera.Size = new System.Drawing.Size(84, 14);
            this.lblCartelera.TabIndex = 9;
            this.lblCartelera.Text = "CARTELERA";
            this.lblCartelera.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::CapaPresentacion.Properties.Resources.Imagen1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lblEmpleado);
            this.panel2.Controls.Add(this.lblTecnologia);
            this.panel2.Controls.Add(this.lblPelicula);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblFactura);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblCartelera);
            this.panel2.Location = new System.Drawing.Point(1, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1361, 659);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(638, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "CARTELERA";
            this.label1.Visible = false;
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.BackColor = System.Drawing.Color.Transparent;
            this.lblFactura.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFactura.Location = new System.Drawing.Point(151, 4);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(66, 14);
            this.lblFactura.TabIndex = 14;
            this.lblFactura.Text = "FACTURA";
            this.lblFactura.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(646, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 14);
            this.label2.TabIndex = 15;
            this.label2.Text = "CARTELERA";
            this.label2.Visible = false;
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.BackColor = System.Drawing.Color.Transparent;
            this.lblPelicula.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelicula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPelicula.Location = new System.Drawing.Point(237, 4);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(71, 14);
            this.lblPelicula.TabIndex = 15;
            this.lblPelicula.Text = "PELICULA";
            this.lblPelicula.Visible = false;
            // 
            // lblTecnologia
            // 
            this.lblTecnologia.AutoSize = true;
            this.lblTecnologia.BackColor = System.Drawing.Color.Transparent;
            this.lblTecnologia.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTecnologia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTecnologia.Location = new System.Drawing.Point(312, 4);
            this.lblTecnologia.Name = "lblTecnologia";
            this.lblTecnologia.Size = new System.Drawing.Size(87, 14);
            this.lblTecnologia.TabIndex = 16;
            this.lblTecnologia.Text = "TECNOLOGIA";
            this.lblTecnologia.Visible = false;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpleado.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmpleado.Location = new System.Drawing.Point(405, 4);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(77, 14);
            this.lblEmpleado.TabIndex = 16;
            this.lblEmpleado.Text = "EMPLEADO";
            this.lblEmpleado.Visible = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.Imagen1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlCartelera);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.Text = "Cinema Evolution";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblTecnologia;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Label label1;
    }
}



