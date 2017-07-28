using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidades;


namespace CapaNegocio
{
   public class CNCarteleraPelicula
    {
        CDCarteleraPelicula objF = new CDCarteleraPelicula();
        public int NuevaCarteleraPelicula(CECarteleraPelicula objCarteleraPelicula)
        {
            return objF.InsertarCarteleraPelicula(objCarteleraPelicula);
        }

        public int ActualizarCarteleraPelicula(CECarteleraPelicula objCarteleraPelicula)
        {
            return objF.ActualizarCarteleraPelicula(objCarteleraPelicula);
        }
        public int EliminarCarteleraPelicula(CECarteleraPelicula objCarteleraPelicula)
        {
            return objF.EliminarCarteleraPelicula(objCarteleraPelicula);
        }
        public DataSet ListadoCarteleraPelicula()
        {
            return objF.ListadoCarteleraPelicula();
        }

        public DataSet ListadoCarteleraPeliculaPorFecha(CECarteleraPelicula objCarteleraPelicula)
        {
            return objF.ListadoCarteleraPeliculaPorFecha(objCarteleraPelicula);
        }

        public DataSet ListadoCarteleraPeliculaPorPelicula(CECarteleraPelicula objCarteleraPelicula)
        {
            return objF.ListadoCarteleraPeliculaPorPelicula(objCarteleraPelicula);
        }

        public DataSet ListadoCartelera()
        {
            return objF.ListadoCartelera();
        }
        public DataSet ListadoPelicula()
        {
            return objF.ListadoPelicula();
        }
    }
}
