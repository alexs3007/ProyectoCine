namespace CapaPresentacion
{
    partial class FrmSplah
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplah));
            this.tTiempo = new System.Windows.Forms.Timer(this.components);
            this.lblt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblt
            // 
            this.lblt.AutoSize = true;
            this.lblt.Location = new System.Drawing.Point(13, 13);
            this.lblt.Name = "lblt";
            this.lblt.Size = new System.Drawing.Size(0, 13);
            this.lblt.TabIndex = 0;
            // 
            // FrmSplah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.splah;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1010, 371);
            this.Controls.Add(this.lblt);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSplah";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmSplah_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tTiempo;
        private System.Windows.Forms.Label lblt;
    }
}

