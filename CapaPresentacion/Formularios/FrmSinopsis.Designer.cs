namespace CapaPresentacion.Formularios
{
    partial class FrmSinopsis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSinopsis));
            this.pcbPelicula = new System.Windows.Forms.PictureBox();
            this.lblSinopsis = new System.Windows.Forms.Label();
            this.pnlcerrar = new System.Windows.Forms.Panel();
            this.link = new System.Windows.Forms.LinkLabel();
            this.lbltitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbPelicula
            // 
            this.pcbPelicula.BackColor = System.Drawing.Color.White;
            this.pcbPelicula.Location = new System.Drawing.Point(84, 106);
            this.pcbPelicula.Name = "pcbPelicula";
            this.pcbPelicula.Size = new System.Drawing.Size(412, 545);
            this.pcbPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPelicula.TabIndex = 0;
            this.pcbPelicula.TabStop = false;
            // 
            // lblSinopsis
            // 
            this.lblSinopsis.BackColor = System.Drawing.Color.Transparent;
            this.lblSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinopsis.Location = new System.Drawing.Point(532, 106);
            this.lblSinopsis.Name = "lblSinopsis";
            this.lblSinopsis.Size = new System.Drawing.Size(687, 378);
            this.lblSinopsis.TabIndex = 1;
            this.lblSinopsis.Text = "label1";
            this.lblSinopsis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlcerrar
            // 
            this.pnlcerrar.BackColor = System.Drawing.Color.Transparent;
            this.pnlcerrar.BackgroundImage = global::CapaPresentacion.Properties.Resources.X;
            this.pnlcerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlcerrar.Location = new System.Drawing.Point(1315, 12);
            this.pnlcerrar.Name = "pnlcerrar";
            this.pnlcerrar.Size = new System.Drawing.Size(35, 35);
            this.pnlcerrar.TabIndex = 7;
            this.pnlcerrar.Click += new System.EventHandler(this.pnlcerrar_Click);
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.BackColor = System.Drawing.Color.Transparent;
            this.link.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link.ForeColor = System.Drawing.Color.White;
            this.link.LinkColor = System.Drawing.Color.White;
            this.link.Location = new System.Drawing.Point(86, 677);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(0, 24);
            this.link.TabIndex = 8;
            this.link.Click += new System.EventHandler(this.link_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.Gold;
            this.lbltitulo.Location = new System.Drawing.Point(81, 46);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(1138, 44);
            this.lbltitulo.TabIndex = 9;
            this.lbltitulo.Text = "................";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSinopsis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.Captura_de_pantalla__69_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.link);
            this.Controls.Add(this.pnlcerrar);
            this.Controls.Add(this.lblSinopsis);
            this.Controls.Add(this.pcbPelicula);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSinopsis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSinopsis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSinopsis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPelicula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlcerrar;
        public System.Windows.Forms.Label lbltitulo;
        public System.Windows.Forms.PictureBox pcbPelicula;
        public System.Windows.Forms.Label lblSinopsis;
        public System.Windows.Forms.LinkLabel link;
    }
}