using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void pnlcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlCambioUsuario_Click(object sender, EventArgs e)
        {
            
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }

        //private void pnlCartelera_MouseHover(object sender, EventArgs e)
        //{
        //    pnlCartelera.BackgroundImage = CapaPresentacion.Properties.Resources.cartelera1;
        //}

        //private void pnlCartelera_MouseLeave(object sender, EventArgs e)
        //{
        //    pnlCartelera.BackgroundImage = CapaPresentacion.Properties.Resources.cartelera;
        //}

        //private void pnlCartelera_Click(object sender, EventArgs e)
        //{
        //    FrmCartelera frm = new FrmCartelera();
        //    frm.Show();
        //}

        private void pnlCartelera_MouseClick(object sender, MouseEventArgs e)
        {
            FrmCartelera frm = new FrmCartelera();
            frm.Show();
        }

        private void pnlCarteleraS_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            FrmCartelera frm = new FrmCartelera();
            frm.MdiParent = this;
            frm.Show();
            frm.Location = new Point(200, 200);
        }

        private void pnlFactura_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            FrmFactura frm = new FrmFactura();
            frm.MdiParent = this;
            frm.Show();
            frm.Location = new Point(320, 180);
        }

        private void pnlPelicula_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            FrmPelicula frm = new FrmPelicula();
            frm.MdiParent = this;
            frm.Show();
            frm.Location = new Point(100, 100);
        }

        private void pnlTecnologia_Click(object sender, EventArgs e)
        {
            FrmPelicula_Tecnologia frm = new FrmPelicula_Tecnologia();
            frm.MdiParent = this;
            frm.Show();
            frm.Location = new Point(200, 180);
        }

        private void pnlEmpleado_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            FrmEmpleado frm = new FrmEmpleado();
            frm.MdiParent = this;
            frm.Show();
            frm.Location = new Point(180, 180);
        }

        private void pnlCarteleraS_MouseHover(object sender, EventArgs e)
        {
            lblCartelera.Visible = true;
        }

        private void pnlCarteleraS_MouseLeave(object sender, EventArgs e)
        {
            lblCartelera.Visible = false;
        }

        private void pnlFactura_MouseHover(object sender, EventArgs e)
        {
            lblFactura.Visible = true;
        }

        private void pnlFactura_MouseLeave(object sender, EventArgs e)
        {
            lblFactura.Visible = false;
        }

        private void pnlPelicula_MouseHover(object sender, EventArgs e)
        {
            lblPelicula.Visible = true;
        }

        private void pnlPelicula_MouseLeave(object sender, EventArgs e)
        {
            lblPelicula.Visible = false;
        }

        private void pnlTecnologia_MouseHover(object sender, EventArgs e)
        {
            lblTecnologia.Visible = true;
        }

        private void pnlTecnologia_MouseLeave(object sender, EventArgs e)
        {
            lblTecnologia.Visible = false;
        }

        private void pnlEmpleado_MouseHover(object sender, EventArgs e)
        {
            lblEmpleado.Visible = true;
        }

        private void pnlEmpleado_MouseLeave(object sender, EventArgs e)
        {
            lblEmpleado.Visible = false;
        }
    }
}
