using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CapaPresentacion.Formularios
{
    public partial class FrmMostrarCartelera : Form 
    {
        public FrmMostrarCartelera()
        {
            InitializeComponent();
        }

        private void pnlcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMostrarCartelera_Load(object sender, EventArgs e)
        {
            MostrarPeliculas();
        }
        private void MostrarPeliculas()
        {
            
            Conexion cn = new Conexion();
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            try
            {
                cn.ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarCarteleraActual", cn.cn);
                da.Fill(ds, "Peliculas");

                if (ds.Tables[0].Rows.Count != 0)
                {
                    if(ds.Tables[0].Rows.Count == 1)
                    {
                        byte[] imageBuffer = (byte[])ds.Tables[0].Rows[0][0];
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                        pcbPelicula1.Image = Image.FromStream(ms);
                        lblPelicula1.Text = ds.Tables[0].Rows[0][1].ToString();
                        lblId1.Text = ds.Tables[0].Rows[0][6].ToString();
                        lblFechaFinal1.Text = ds.Tables[0].Rows[0][3].ToString();
                        lblGenero1.Text = ds.Tables[0].Rows[0][4].ToString();
                        lblClasificacion1.Text = ds.Tables[0].Rows[0][5].ToString();

                        label1.Text = ds.Tables[0].Rows[0][2].ToString();
                       
                    }

                    if (ds.Tables[0].Rows.Count == 2)
                    {
                        byte[] imageBuffer = (byte[])ds.Tables[0].Rows[0][0];
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                        pcbPelicula1.Image = Image.FromStream(ms);
                        byte[] imageBuffe2 = (byte[])ds.Tables[0].Rows[1][0];
                        System.IO.MemoryStream ms2 = new System.IO.MemoryStream(imageBuffe2);
                        pcbPelicula2.Image = Image.FromStream(ms2);
                        lblPelicula1.Text = ds.Tables[0].Rows[0][1].ToString();
                        lblId1.Text = ds.Tables[0].Rows[0][6].ToString();
                        lblFechaFinal1.Text = ds.Tables[0].Rows[0][3].ToString();
                        lblGenero1.Text = ds.Tables[0].Rows[0][4].ToString();
                        lblClasificacion1.Text = ds.Tables[0].Rows[0][5].ToString();
                        lblPelicula2.Text = ds.Tables[0].Rows[1][1].ToString();
                        lblId2.Text = ds.Tables[0].Rows[1][6].ToString();
                        lblFechaFinal2.Text = ds.Tables[0].Rows[1][3].ToString();
                        lblGenero2.Text = ds.Tables[0].Rows[1][4].ToString();
                        lblClasificacion2.Text = ds.Tables[0].Rows[1][5].ToString();


                        label1.Text = ds.Tables[0].Rows[0][2].ToString();
                        label2.Text = ds.Tables[0].Rows[1][2].ToString();
                      
                    }

                    if (ds.Tables[0].Rows.Count == 3)
                    {
                        byte[] imageBuffer3 = (byte[])ds.Tables[0].Rows[2][0];
                        System.IO.MemoryStream ms3 = new System.IO.MemoryStream(imageBuffer3);
                        pcbPelicula3.Image = Image.FromStream(ms3);
                        byte[] imageBuffer = (byte[])ds.Tables[0].Rows[0][0];
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                        pcbPelicula1.Image = Image.FromStream(ms);
                        byte[] imageBuffe2 = (byte[])ds.Tables[0].Rows[1][0];
                        System.IO.MemoryStream ms2 = new System.IO.MemoryStream(imageBuffe2);
                        pcbPelicula2.Image = Image.FromStream(ms2);

                        lblPelicula1.Text = ds.Tables[0].Rows[0][1].ToString();
                        label1.Text = ds.Tables[0].Rows[0][2].ToString();
                        lblId1.Text = ds.Tables[0].Rows[0][6].ToString();
                        lblFechaFinal1.Text = ds.Tables[0].Rows[0][3].ToString();
                        lblGenero1.Text = ds.Tables[0].Rows[0][4].ToString();
                        lblClasificacion1.Text = ds.Tables[0].Rows[0][5].ToString();
                        lblPelicula2.Text = ds.Tables[0].Rows[1][1].ToString();
                        lblId2.Text = ds.Tables[0].Rows[1][6].ToString();
                        lblFechaFinal2.Text = ds.Tables[0].Rows[1][3].ToString();
                        lblGenero2.Text = ds.Tables[0].Rows[1][4].ToString();
                        lblClasificacion2.Text = ds.Tables[0].Rows[1][5].ToString();
                        lblPelicula3.Text = ds.Tables[0].Rows[2][1].ToString();
                        lblId3.Text = ds.Tables[0].Rows[2][6].ToString();
                        lblFechaFinal3.Text = ds.Tables[0].Rows[2][3].ToString();
                        lblGenero3.Text = ds.Tables[0].Rows[2][4].ToString();
                        lblClasificacion3.Text = ds.Tables[0].Rows[2][5].ToString();

                        label1.Text = ds.Tables[0].Rows[0][2].ToString();
                        label2.Text = ds.Tables[0].Rows[1][2].ToString();
                        label3.Text = ds.Tables[0].Rows[2][2].ToString();
                    }


                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de los horario de las peliculas", ex);
            }
            finally
            {
                cn.CerrarBD();
                ds.Dispose();
            }

        }

        private void pcbPelicula1_Click(object sender, EventArgs e)
        {
            if(!lblId1.Text.Equals("SIN DATOS"))
            {
                FrmSinopsis frm = new FrmSinopsis();
                frm.lbltitulo.Text = lblPelicula1.Text;
                frm.lblSinopsis.Text = label1.Text;
                frm.link.Text = "Mostrar el trailer de " + lblPelicula1.Text;
                frm.url = lblId1.Text;
                frm.lbltitulo.Text = lblPelicula1.Text;
                frm.pcbPelicula.Image = pcbPelicula1.Image;
                frm.ShowDialog();
                
            }
        }

        private void pcbPelicula2_Click(object sender, EventArgs e)
        {
            if (!lblId2.Text.Equals("SIN DATOS"))
            {
                FrmSinopsis frm = new FrmSinopsis();
                frm.lbltitulo.Text = lblPelicula2.Text;
                frm.lblSinopsis.Text = label2.Text;
                frm.link.Text = "Mostrar el trailer de " + lblPelicula2.Text;
                frm.url = lblId2.Text;
                frm.lbltitulo.Text = lblPelicula2.Text;
                frm.pcbPelicula.Image = pcbPelicula2.Image;
                frm.ShowDialog();

            }
        }

        private void pcbPelicula3_Click(object sender, EventArgs e)
        {
            if (!lblId3.Text.Equals("SIN DATOS"))
            {
                FrmSinopsis frm = new FrmSinopsis();
                frm.lbltitulo.Text = lblPelicula3.Text;
                frm.lblSinopsis.Text = label3.Text;
                frm.link.Text = "Mostrar el trailer de " + lblPelicula3.Text;
                frm.url = lblId3.Text;
                frm.lbltitulo.Text = lblPelicula3.Text;
                frm.pcbPelicula.Image = pcbPelicula3.Image;
                frm.ShowDialog();

            }
        }
    }
}
