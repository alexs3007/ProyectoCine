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
   public class CNPeliculaTecnologia
    {
        CDPeliculaTecnologia objPte = new CDPeliculaTecnologia();

        public int NuevaPeliculaTecnologia(CEPeliculaTecnologia objPT)
        {
            return objPte.InsertarPeliculaTecnologia(objPT);
        }
        public int ActualizarPeliculaTecnologia(CEPeliculaTecnologia objPT)
        {
            return objPte.ActualizarPeliculaTecnologia(objPT);
        }
        public int EliminarPeliculaTecnologia(CEPeliculaTecnologia objPT)
        {
            return objPte.EliminarPeliculaTecnologia(objPT);
        }
        public DataSet ListadoPeliculaTecnologia()
        {
            return objPte.ListadoPeliculaTecnologia();
        }

        public DataSet ListadoPeliculaTecnologiaporPelicula(CEPeliculaTecnologia objPT)
        {
            return objPte.ListadoPeliculaTecnologiaporPelicula(objPT);
        }

        public DataSet ListadoPeliculaTecnologiaporTecnologia(CEPeliculaTecnologia objPT)
        {
            return objPte.ListadoPeliculaTecnologiaporTecnologia(objPT);
        }
        public DataSet ListadoPelicula()
        {
            return objPte.ListadoPelicula();
        }

        public DataSet ListadoTecnologia()
        {
            return objPte.ListadoTecnologia();
        }
    }
}
