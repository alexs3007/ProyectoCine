using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class CNLogAuditoria
    {
        CDLogAuditoria obj = new CDLogAuditoria();

        public DataSet ListadoLogAuditoria()
        {
            return obj.ListarLogAuditoria();
        }
        public DataSet MostrarporFecha(CELogAuditoria obja)
        {
            return obj.BuscarporFecha(obja);
        }
        public DataSet MostrarporUsuario(CELogAuditoria obja)
        {
            return obj.BuscarporUsuario(obja);
        }

    }
}
