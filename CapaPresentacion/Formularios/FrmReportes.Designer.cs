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
            this.pnlReporteDiario = new System.Windows.Forms.Panel();
            this.pnlReporteTecnologia = new System.Windows.Forms.Panel();
            this.pnlReporteMensual = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pnlReporteFactura.BackgroundImage = global::CapaPresentacion.Properties.Resources.reporte_factura;
            this.pnlReporteFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlReporteFactura.Location = new System.Drawing.Point(403, 104);
            this.pnlReporteFactura.Name = "pnlReporteFactura";
            this.pnlReporteFactura.Size = new System.Drawing.Size(140, 140);
            this.pnlReporteFactura.TabIndex = 32;
            // 
            // pnlReporteDiario
            // 
            this.pnlReporteDiario.BackColor = System.Drawing.Color.Transparent;
            this.pnlReporteDiario.BackgroundImage = global::CapaPresentacion.Properties.Resources.reporte_diario;
            this.pnlReporteDiario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlReporteDiario.Location = new System.Drawing.Point(578, 104);
            this.pnlReporteDiario.Name = "pnlReporteDiario";
            this.pnlReporteDiario.Size = new System.Drawing.Size(140, 140);
            this.pnlReporteDiario.TabIndex = 33;
            // 
            // pnlReporteTecnologia
            // 
            this.pnlReporteTecnologia.BackColor = System.Drawing.Color.Transparent;
            this.pnlReporteTecnologia.BackgroundImage = global::CapaPresentacion.Properties.Resources.reporte_tecnologia;
            this.pnlReporteTecnologia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlReporteTecnologia.Location = new System.Drawing.Point(578, 250);
            this.pnlReporteTecnologia.Name = "pnlReporteTecnologia";
            this.pnlReporteTecnologia.Size = new System.Drawing.Size(140, 140);
            this.pnlReporteTecnologia.TabIndex = 35;
            // 
            // pnlReporteMensual
            // 
            this.pnlReporteMensual.BackColor = System.Drawing.Color.Transparent;
            this.pnlReporteMensual.BackgroundImage = global::CapaPresentacion.Properties.Resources.reporteMensual;
            this.pnlReporteMensual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlReporteMensual.Location = new System.Drawing.Point(403, 250);
            this.pnlReporteMensual.Name = "pnlReporteMensual";
            this.pnlReporteMensual.Size = new System.Drawing.Size(140, 140);
            this.pnlReporteMensual.TabIndex = 34;
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
            this.Name = "FrmReportes";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlReporteFactura;
        private System.Windows.Forms.Panel pnlReporteDiario;
        private System.Windows.Forms.Panel pnlReporteTecnologia;
        private System.Windows.Forms.Panel pnlReporteMensual;
    }
}