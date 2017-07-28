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
    public class CDFactura : Conexion
    {
        public int InsertarFactura(CEFactura objF)
        {
            int resultado;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_InsertarFactura", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Fecha", SqlDbType.Date).Value = objF.Fecha;
                cmd.Parameters.Add("@IdPelicula", SqlDbType.Int).Value = objF.IdPelicula;
                cmd.Parameters.Add("@IdTecnologia", SqlDbType.Int).Value = objF.IdTecnologia;
                cmd.Parameters.Add("@CantidadBoleto", SqlDbType.Int).Value = objF.CantidadBoleto;
                cmd.Parameters.Add("@PrecioBoleto", SqlDbType.Money).Value = objF.PrecioBoleto;
                cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = objF.IdUsuario;

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
        public int ActualizarFactura(CEFactura objF)
        {
            int resultado;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_ActualizarFactura", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdFactura", SqlDbType.Int).Value = objF.IdFactura;
                cmd.Parameters.Add("@Fecha", SqlDbType.Date).Value = objF.Fecha;
                cmd.Parameters.Add("@IdPelicula", SqlDbType.Int).Value = objF.IdPelicula;
                cmd.Parameters.Add("@IdTecnologia", SqlDbType.Int).Value = objF.IdTecnologia;
                cmd.Parameters.Add("@CantidadBoleto", SqlDbType.Int).Value = objF.CantidadBoleto;
                cmd.Parameters.Add("@PrecioBoleto", SqlDbType.Money).Value = objF.PrecioBoleto;
                cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = objF.IdUsuario;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de actualizar", ex);
            }
            finally
            {
                CerrarBD();
            }
            return resultado;
        }
        public int EliminarFactura(CEFactura objF)
        {
            int resultado=0;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_EliminarFactura", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdFactura", SqlDbType.Int).Value = objF.IdFactura;
              
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

        public DataSet ListadoFactura()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarTodoFactura", cn);
                da.Fill(ds, "Factura");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de las facturas", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }
        public DataSet ListadoPelicula()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarDescripcionPelicula", cn);
                da.Fill(ds, "Pelicula");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de las peliculas", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }
        public DataSet ListadoTecnologia()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarDescripcionTecnologia", cn);
                da.Fill(ds, "Tecnologia");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de las tecnologias", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }

        public DataSet ListadoFacturaPorCodigo(CEFactura objF)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da= new SqlDataAdapter("Sp_MostrarFacturaPorCodigo", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@IdFactura", SqlDbType.Int).Value = objF.IdFactura;         
                da.Fill(ds, "Factura");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de la factura", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }

        public DataSet ListadoFacturaPorPelicula(CEFactura objF)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarFacturaPorPelicula", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@NombrePelicula", SqlDbType.NVarChar,50).Value = objF.NombrePelicula;        
                da.Fill(ds, "Factura");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de las facturas", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }


    }
}
