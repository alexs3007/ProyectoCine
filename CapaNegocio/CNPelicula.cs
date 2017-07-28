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
    public class CNPelicula
    {
        CDPelicula objF = new CDPelicula();

        public int NuevaFactura(CEPelicula objPelicula)
        {
            return objF.InsertarPelicula(objPelicula);
        }
        public int ActualizarPelicula(CEPelicula objPelicula)
        {
            return objF.ActualizarPelicula(objPelicula);
        }
        public int EliminarPelicula(CEPelicula objPelicula)
        {
            return objF.EliminarPelicula(objPelicula);
        }
        public DataSet ListadoPelicula()
        {
            return objF.ListadoPelicula();
        }
        public DataSet ListadoPeliculaPorCodido(CEPelicula objPelicula)
        {
            return objF.ListadoPeliculaPorCodigo(objPelicula);
        }
        public DataSet ListadoPeliculaPorNombrePelicula(CEPelicula objPelicula)
        {
            return objF.ListadoPeliculaPorNombrePelicula(objPelicula);
        }
        public DataSet ListadoGenero()
        {
            return objF.ListadoGenero();
        }
        public DataSet ListadoClasificacion()
        {
            return objF.ListadoClasificacion();
        }
    }
}
