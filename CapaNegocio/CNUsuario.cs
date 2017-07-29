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
    public class CNUsuario
    {
        CDUsuario ObjU = new CDUsuario();


        public int InsertarUsuario(CEUsuario ObjUsuario)
        {
            return ObjU.InsertarUsuario(ObjUsuario);
        }

        public int ActualizararUsuario(CEUsuario ObjUsuario)
        {
            return ObjU.ActualizarUsuario(ObjUsuario);
        }

        public int EliminarUsuario(CEUsuario ObjUsuario)
        {
            return ObjU.EliminarUsuario(ObjUsuario);
        }

        public DataSet ListadoUsuario()
        {
            return ObjU.ListadoUsuario();
        }

        public DataSet ListadoEmpleado()
        {
            return ObjU.ListadoEmpleado();
        }

        public DataSet ListadoTipoUsuario()
        {
            return ObjU.ListadoTipoUsuario();
        }

        public DataSet ListadoUsuarioPorUsuario(CEUsuario objUsuario)
        {
            return ObjU.ListadoUsuarioPorUsuario(objUsuario);
        }

        public DataSet ListadoUsuarioPorEmpleado(CEUsuario objUsuario)
        {
            return ObjU.ListadoUsuarioPorEmpleado(objUsuario);
        }

    }
}
