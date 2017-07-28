using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class CDLogAuditoria:Conexion
    {
        public DataSet ListarLogAuditoria()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            try
            {
                da = new SqlDataAdapter("Sp_MostrarLog", cn);
                ConectarBD();
                da.Fill(ds, "MostrarLog");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo mostrar los datos ", ex);

            }
            finally
            {
                ds.Dispose();
            }
        }

        public DataSet BuscarporFecha(CELogAuditoria objA)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarporFecha", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Fecha", SqlDbType.Date).Value = objA.Fecha;
                da.Fill(ds, "MostrarporFecha");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo realizar la Consulta", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }

        public DataSet BuscarporUsuario(CELogAuditoria objA)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarporUsuario", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar).Value = objA.NombreUsuario;
                da.Fill(ds, "MostrarporUsuario");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo realizar la Consulta", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }
    
    }
}
