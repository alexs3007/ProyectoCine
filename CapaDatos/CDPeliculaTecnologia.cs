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
    public class CDPeliculaTecnologia : Conexion
    {
        public int InsertarPeliculaTecnologia(CEPeliculaTecnologia ObjPT)
        {
            int resultado=0;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_InsertarPeliculaTecnologia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdPelicula", SqlDbType.Int).Value = ObjPT.IdPelicula;
                cmd.Parameters.Add("@IdTecnologia", SqlDbType.Int).Value = ObjPT.IdTecnologia;
                cmd.Parameters.Add("@Precio", SqlDbType.Money).Value = ObjPT.Precio;


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
        public int ActualizarPeliculaTecnologia(CEPeliculaTecnologia ObjPT)
        {
            int resultado=0;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_ActualizarPeliculaTecnologia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdPelicula", SqlDbType.Int).Value = ObjPT.IdPelicula;
                cmd.Parameters.Add("@IdTecnologia", SqlDbType.Int).Value = ObjPT.IdTecnologia;
                cmd.Parameters.Add("@Precio", SqlDbType.Money).Value = ObjPT.Precio;


                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                //throw new Exception("Error al tratar de Actualizar", ex);
            }
            finally
            {
                CerrarBD();
            }
            return resultado;
        }
        public int EliminarPeliculaTecnologia(CEPeliculaTecnologia ObjPT)
        {
            int resultado=0;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_EliminarPeliculaTecnologia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdPelicula", SqlDbType.Int).Value = ObjPT.IdPelicula;
                cmd.Parameters.Add("@IdTecnologia", SqlDbType.Int).Value = ObjPT.IdTecnologia;

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
        public DataSet ListadoPeliculaTecnologia()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarTodoPeliculaTecnologia", cn);
                da.Fill(ds, "PeliculaTecnologia");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de las Tecnologia de las Peliculas", ex);
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
                throw new Exception("Error al solicitar los datos de las tecnologia", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }
        public DataSet ListadoPeliculaTecnologiaporPelicula(CEPeliculaTecnologia obj)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarPeliculaTecnologiaPorPelicula", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@NombrePelicula", SqlDbType.NVarChar,100).Value = obj.NombrePelicula;
                da.Fill(ds, "PeliculaTecnologiaP");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de la pelicula tecnologia", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }
        public DataSet ListadoPeliculaTecnologiaporTecnologia(CEPeliculaTecnologia obj)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarPeliculaTecnologiaPorTecnologia", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@TipoTecnologia", SqlDbType.NVarChar, 100).Value = obj.TipoTecnologia;
                da.Fill(ds, "PeliculaTecnologiaT");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de la pelicula tecnologia", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }


    }

}
