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
  public class CNPeliculaHorario
    {
        CDPeliculaHorario objF = new CDPeliculaHorario();

        public int InsertarPeliculaHorario(CEPeliculaHorario objPH)
        {
            return objF.InsertarPeliculaHorario(objPH);
        }
        public int ActualizarPeliculaHorario(CEPeliculaHorario objPH)
        {
            return objF.ActualizarPeliculaHorario(objPH);
        }
        public int EliminarPeliculaHorario(CEPeliculaHorario objPH)
        {
            return objF.EliminarPeliculaHorario(objPH);
        }
        public DataSet ListadoPelicula()
        {
            return objF.ListadoPelicula();
        }
        public DataSet ListadoPeliculaHorario()
        {
            return objF.ListadoPeliculaHorario();
        }
        public DataSet ListadoPeliculaHorarioPorNombre(CEPeliculaHorario objPH)
        {
            return objF.ListadoPeliculaHorarioPorPelicula(objPH);
        }
        public DataSet ListadoPeliculaHorarioPorHorario(CEPeliculaHorario objPH)
        {
            return objF.ListadoPeliculaHorarioPorHorario(objPH);
        }
        public DataSet ListadoHorario()
        {
            return objF.ListadoHorario();
        }


    }
}
