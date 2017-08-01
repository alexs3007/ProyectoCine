namespace CapaPresentacion.Formularios
{
    partial class FrmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlReporteFactura = new System.Windows.Forms.Panel();
            this.lblFacturaTICKET = new System.Windows.Forms.Label();
            this.pnlReporteDiario = new System.Windows.Forms.Panel();
            this.lblMensual = new System.Windows.Forms.Label();
            this.pnlReporteTecnologia = new System.Windows.Forms.Panel();
            this.lblReporteTecnologia = new System.Windows.Forms.Label();
            this.pnlReporteMensual = new System.Windows.Forms.Panel();
            this.lblDiario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlReporteFactura.SuspendLayout();
            this.pnlReporteDiario.SuspendLayout();
            this.pnlReporteTecnologia.SuspendLayout();
            this.pnlReporteMensual.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(494, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 48);
            this.label4.TabIndex = 31;
            this.label4.Text = "Reportes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CapaPresentacion.Properties.Resources.estrella;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(398, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 80);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // pnlReporteFactura
            // 
            this.pnlReporteFactura.BackColor = System.Drawing.Color.Transparent;
            this.pnlReporteFactura.BackgroundImage = global::CapaPresentacion.Properties.Resources.reporte_factura1;
            this.pnlReporteFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlReporteFactura.Controls.Add(this.lblFacturaTICKET);
            this.pnlReporteFactura.Location = new System.Drawing.Point(403, 104);
            this.pnlReporteFactura.Name = "pnlReporteFactura";
            this.pnlReporteFactura.Size = new System.Drawing.Size(140, 140);
            this.pnlReporteFactura.TabIndex = 32;
            this.pnlReporteFactura.MouseLeave += new System.EventHandler(this.pnlReporteFactura_MouseLeave);
            this.pnlReporteFactura.MouseHover += new System.EventHandler(this.pnlReporteFactura_MouseHover);
            // 
            // lblFacturaTICKET
            // 
            this.lblFacturaTICKET.AutoSize = true;
            this.lblFacturaTICKET.BackColor = System.Drawing.Color.Transparent;
            this.lblFacturaTICKET.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturaTICKET.ForeColor = System.Drawing.Color.Black;
            this.lblFacturaTICKET.Location = new System.Drawing.Point(7, 129);
            this.lblFacturaTICKET.Name = "lblFacturaTICKET";
            this.lblFacturaTICKET.Size = new System.Drawing.Size(127, 14);
            this.lblFacturaTICKET.TabIndex = 36;
            this.lblFacturaTICKET.Text = "FACTURA DE TICKET";
            this.lblFacturaTICKET.Visible = false;
            // 
            // pnlReporteDiario
            // 
            this.pnlReporteDiario.BackColor = System.Drawing.Color.Transparent;
            this.pnlReporteDiario.BackgroundImage = global::CapaPresentacion.Properties.Resources.reporte_diario;
            this.pnlReporteDiario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlReporteDiario.Controls.Add(this.lblMensual);
            this.pnlReporteDiario.Location = new System.Drawing.Point(578, 104);
            this.pnlReporteDiario.Name = "pnlReporteDiario";
            this.pnlReporteDiario.Size = new System.Drawing.Size(140, 140);
            this.pnlReporteDiario.TabIndex = 33;
            this.pnlReporteDiario.MouseLeave += new System.EventHandler(this.pnlReporteDiario_MouseLeave);
            this.pnlReporteDiario.MouseHover += new System.EventHandler(this.pnlReporteDiario_MouseHover);
            // 
            // lblMensual
            // 
            this.lblMensual.AutoSize = true;
            this.lblMensual.BackColor = System.Drawing.Color.Transparent;
            this.lblMensual.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMensual.Location = new System.Drawing.Point(36, 129);
            this.lblMensual.Name = "lblMensual";
            this.lblMensual.Size = new System.Drawing.Size(51, 14);
            this.lblMensual.TabIndex = 37;
            this.lblMensual.Text = "DIARIO";
            this.lblMensual.Visible = false;
            // 
            // pnlReporteTecnologia
            // 
            this.pnlReporteTecnologia.BackColor = System.Drawing.Color.Transparent;
            this.pnlReporteTecnologia.BackgroundImage = global::CapaPresentacion.Properties.Resources.reporte_tecnologia1;
            this.pnlReporteTecnologia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlReporteTecnologia.Controls.Add(this.lblReporteTecnologia);
            this.pnlReporteTecnologia.Location = new System.Drawing.Point(578, 261);
            this.pnlReporteTecnologia.Name = "pnlReporteTecnologia";
            this.pnlReporteTecnologia.Size = new System.Drawing.Size(140, 140);
            this.pnlReporteTecnologia.TabIndex = 35;
            this.pnlReporteTecnologia.MouseLeave += new System.EventHandler(this.pnlReporteTecnologia_MouseLeave);
            this.pnlReporteTecnologia.MouseHover += new System.EventHandler(this.pnlReporteTecnologia_MouseHover);
            // 
            // lblReporteTecnologia
            // 
            this.lblReporteTecnologia.AutoSize = true;
            this.lblReporteTecnologia.BackColor = System.Drawing.Color.Transparent;
            this.lblReporteTecnologia.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporteTecnologia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReporteTecnologia.Location = new System.Drawing.Point(25, 126);
            this.lblReporteTecnologia.Name = "lblReporteTecnologia";
            this.lblReporteTecnologia.Size = new System.Drawing.Size(86, 14);
            this.lblReporteTecnologia.TabIndex = 39;
            this.lblReporteTecnologia.Text = "TECNOLOGIA";
            this.lblReporteTecnologia.Visible = false;
            // 
            // pnlReporteMensual
            // 
            this.pnlReporteMensual.BackColor = System.Drawing.Color.Transparent;
            this.pnlReporteMensual.BackgroundImage = global::CapaPresentacion.Properties.Resources.reporteMensual;
            this.pnlReporteMensual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlReporteMensual.Controls.Add(this.lblDiario);
            this.pnlReporteMensual.Location = new System.Drawing.Point(403, 261);
            this.pnlReporteMensual.Name = "pnlReporteMensual";
            this.pnlReporteMensual.Size = new System.Drawing.Size(140, 140);
            this.pnlReporteMensual.TabIndex = 34;
            this.pnlReporteMensual.MouseLeave += new System.EventHandler(this.pnlReporteMensual_MouseLeave);
            this.pnlReporteMensual.MouseHover += new System.EventHandler(this.pnlReporteMensual_MouseHover);
            // 
            // lblDiario
            // 
            this.lblDiario.AutoSize = true;
            this.lblDiario.BackColor = System.Drawing.Color.Transparent;
            this.lblDiario.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDiario.Location = new System.Drawing.Point(31, 126);
            this.lblDiario.Name = "lblDiario";
            this.lblDiario.Size = new System.Drawing.Size(62, 14);
            this.lblDiario.TabIndex = 38;
            this.lblDiario.Text = "MENSUAL";
            this.lblDiario.Visible = false;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.fondoReporte;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(737, 460);
            this.Controls.Add(this.pnlReporteTecnologia);
            this.Controls.Add(this.pnlReporteMensual);
            this.Controls.Add(this.pnlReporteDiario);
            this.Controls.Add(this.pnlReporteFactura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReportes";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlReporteFactura.ResumeLayout(false);
            this.pnlReporteFactura.PerformLayout();
            this.pnlReporteDiario.ResumeLayout(false);
            this.pnlReporteDiario.PerformLayout();
            this.pnlReporteTecnologia.ResumeLayout(false);
            this.pnlReporteTecnologia.PerformLayout();
            this.pnlReporteMensual.ResumeLayout(false);
            this.pnlReporteMensual.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlReporteFactura;
        private System.Windows.Forms.Panel pnlReporteDiario;
        private System.Windows.Forms.Panel pnlReporteTecnologia;
        private System.Windows.Forms.Panel pnlReporteMensual;
        private System.Windows.Forms.Label lblFacturaTICKET;
        private System.Windows.Forms.Label lblMensual;
        private System.Windows.Forms.Label lblReporteTecnologia;
        private System.Windows.Forms.Label lblDiario;
    }
}