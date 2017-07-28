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
    public class CDCarteleraPelicula : Conexion
        {
            public int InsertarCarteleraPelicula(CECarteleraPelicula objF)
            {
                int resultado=0;
                try
                {
                    SqlCommand cmd = new SqlCommand("Sp_InsertarCarteleraPelicula", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@IdCartelera", SqlDbType.Int).Value = objF.IdCartelera;
                    cmd.Parameters.Add("@IdPelicula", SqlDbType.Int).Value = objF.IdPelicula;

                    ConectarBD();
                    resultado = cmd.ExecuteNonQuery();
                    cmd.Dispose();

                }
                catch (Exception ex)
                {
                    //throw new Exception("Error al tratar de almacenar", ex);
                }
                finally
                {
                CerrarBD();
                }
                return resultado;
            }

        public int ActualizarCarteleraPelicula(CECarteleraPelicula objF)
        {
            int resultado=0;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_ActualizarCarteleraPelicula", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdCartelera", SqlDbType.Int).Value = objF.IdCartelera;
                cmd.Parameters.Add("@IdPelicula", SqlDbType.Int).Value = objF.IdPelicula;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                //throw new Exception("Error al tratar de actualizar", ex);
            }
            finally
            {
                CerrarBD();
            }
            return resultado;
        }

        public int EliminarCarteleraPelicula(CECarteleraPelicula objF)
        {
            int resultado=0;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_EliminarCarteleraPelicula", cn);
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

        public DataSet ListadoCarteleraPelicula()
            {
                 DataSet ds = new DataSet();
                 SqlDataAdapter da;

                try
                {
                    ConectarBD();
                    da = new SqlDataAdapter("Sp_MostraTodoCarteleraPelicula", cn);
                    da.Fill(ds, "Cartelera_Pelicula");
                    return ds;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al solicitar los datos de la cartelera pelicula", ex);
                }
                finally
                {
                    CerrarBD();
                    ds.Dispose();
                }
            }

        public DataSet ListadoCarteleraPeliculaPorFecha(CECarteleraPelicula objF)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarCartelera_PeliculaPorCodigo", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Fecha", SqlDbType.Date).Value = objF.Fecha;
                da.Fill(ds, "Cartelera_Pelicula");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de la Cartelera Pelicula", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }

        public DataSet ListadoCarteleraPeliculaPorPelicula(CECarteleraPelicula objF)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarCarteleraPeliculaPorPelicula", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Pelicula", SqlDbType.NVarChar,100).Value = objF.NombrePelicula;
                da.Fill(ds, "Cartelera_Pelicula");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de la Cartelera Pelicula", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }

        public DataSet ListadoCartelera()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarDescripcionCartelera", cn);
                da.Fill(ds, "Cartelera");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de las carteleras", ex);
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
    }

}
