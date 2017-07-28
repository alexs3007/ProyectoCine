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
    public class CNFactura
    {
        CDFactura objF = new CDFactura();

        public int NuevaFactura(CEFactura objFactura)
        {
            return objF.InsertarFactura(objFactura);
        }
        public int ActualizarFactura(CEFactura objFactura)
        {
            return objF.ActualizarFactura(objFactura);
        }
        public int EliminarFactura(CEFactura objFactura)
        {
            return objF.EliminarFactura(objFactura);
        }
        public DataSet ListadoFactura()
        {
            return objF.ListadoFactura();
        }
        public DataSet ListadoFacturaPorCodido(CEFactura objFactura)
        {
            return objF.ListadoFacturaPorCodigo(objFactura);
        }
        public DataSet ListadoFacturaPorPelicula(CEFactura objFactura)
        {
            return objF.ListadoFacturaPorPelicula(objFactura);
        }
        public DataSet ListadoPelicula()
        {
            return objF.ListadoPelicula();
        }
        public DataSet ListadoTecnologia()
        {
            return objF.ListadoTecnologia();
        }
    }
}
