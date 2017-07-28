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
   public class CNCartelera
    {
        CDCartelera objF = new CDCartelera();

        public int NuevaCartelera(CECartelera objCartelera)
        {
            return objF.InsertarCartelera(objCartelera);
        }

        public int ActualizarCartelera(CECartelera objCartelera)
        {
            return objF.ActualizarCartelera(objCartelera);
        }

        public int EliminarCartelera(CECartelera objCartelera)
        {
            return objF.EliminarCartelera(objCartelera);
        }
        public DataSet ListadoCartelera()
        {
            return objF.ListadoCartelera();
        }
        public DataSet ListadoCarteleraPorCodido(CECartelera objCartelera)
        {
            return objF.ListadoCarteleraPorCodigo(objCartelera);
        }
        public DataSet ListadoCarteleraPorFecha(CECartelera objCartelera)
        {
            return objF.ListadoCarteleraPorFecha(objCartelera);
        }
    }
}
