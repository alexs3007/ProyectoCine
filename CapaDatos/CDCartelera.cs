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
    public class CDCartelera: Conexion
    {
        public int InsertarCartelera(CECartelera objF)
        {
            int resultado;
                try
            {
                SqlCommand cmd = new SqlCommand("Sp_InsertarCartelera", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdCartelera", SqlDbType.Int).Value = objF.IdCartelera;
                cmd.Parameters.Add("@FechaEstreno", SqlDbType.Date).Value = objF.FechaEstreno;
                cmd.Parameters.Add("@FechaFinal", SqlDbType.Date).Value = objF.FechaFinal;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de almacenar", ex);
            }
            finally
            {
                CerrarBD();
            }
            return resultado;
        }

        public int ActualizarCartelera(CECartelera objF)
        {
            int resultado;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_ActualizarCartelera", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdCartelera", SqlDbType.Int).Value = objF.IdCartelera;
                cmd.Parameters.Add("@FechaEstreno", SqlDbType.Date).Value = objF.FechaEstreno;
                cmd.Parameters.Add("@FechaFinal", SqlDbType.Date).Value = objF.FechaFinal;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de Actualizar", ex);
            }
            finally
            {
                CerrarBD();
            }
            return resultado;
        }

        public int EliminarCartelera(CECartelera objF)
        {
            int resultado=0;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_EliminarCartelera", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdCartelera", SqlDbType.Int).Value = objF.IdCartelera;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                //throw new Exception("Error al tratar de eliminar", ex);
            }
            finally
            {
                CerrarBD();
            }
            return resultado;
        }
        public DataSet ListadoCartelera()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostraTodoCartelera", cn);
                da.Fill(ds, "Cartelera");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de la Cartelera", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }

        public DataSet ListadoCarteleraPorCodigo(CECartelera objF)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarCarteleraPorCodigo", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@IdCartelera", SqlDbType.Int).Value = objF.IdCartelera;
                da.Fill(ds, "Cartelera");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de la cartelera", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }

        public DataSet ListadoCarteleraPorFecha(CECartelera objF)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarCarteleraPorFecha", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Fecha", SqlDbType.Date).Value = objF.FechaEstreno;
                da.Fill(ds, "Cartelera");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de la cartelera", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }
    }
}
