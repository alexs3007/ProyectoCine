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
  public class CNEmpledos
    {
        CDEmpleado CDE = new CDEmpleado();

        public int InsertarEmpleado(CEEmpleado CEE)
        {
            return CDE.InsertarEmpleado(CEE);
        }
        public int ActualizarEmpleado(CEEmpleado CEE)
        {
            return CDE.ActualizarEmpleado(CEE);
        }
        public int EliminarEmpleado(CEEmpleado CEE)
        {
            return CDE.EliminarEmpleado(CEE); ;
        }

        public DataSet ListadoEmpleado()
        {
            return CDE.ListadoEmpleado();
        }

        public DataSet ListadoEmpleadoporNombre(CEEmpleado CEE)
        {
            return CDE.ListadoEmpleadoPorNombre(CEE);
        }

        public DataSet ListadoEmpleadoporCodigo(CEEmpleado CEE)
        {
            return CDE.ListadoEmpleadoPorCodigo(CEE);
        }

    }
}
