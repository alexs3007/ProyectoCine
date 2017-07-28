using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using CapaEntidades;
namespace CapaNegocio
{
    public class CNLogin
    {
        CDLogin objF = new CDLogin();
        public string[] AccesoUsuario(CELogin objLogin)
        {
            return objF.AccesoUsuario(objLogin);
        }
    }
}
