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
    public class CDPelicula : Conexion
    {

        public int InsertarPelicula(CEPelicula objP)
        {
            int resultado;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_InsertarPelicula", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NombrePelicula", SqlDbType.NVarChar,50).Value = objP.NombrePelicula;
                cmd.Parameters.Add("@Sinopsis", SqlDbType.NVarChar,400).Value = objP.Sinopsis;
                cmd.Parameters.Add("@Lanzamiento", SqlDbType.NVarChar,50).Value = objP.Lanzamiento;
                cmd.Parameters.Add("@Duracion", SqlDbType.NVarChar,50).Value = objP.Duracion;
                cmd.Parameters.Add("@IdGenero", SqlDbType.Int).Value = objP.IdGenero;
                cmd.Parameters.Add("@IdClasificacion", SqlDbType.Int).Value = objP.IdClasificacion;
                cmd.Parameters.Add("@Imagen", SqlDbType.Image).Value = objP.Imagen;
                cmd.Parameters.Add("@URL", SqlDbType.NVarChar,300).Value = objP.URL;
                cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = objP.IdUsuario;
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

        public int ActualizarPelicula(CEPelicula objP)
        {
            int resultado;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_ActualizarPelicula", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdPelicula", SqlDbType.Int).Value = objP.IdPelicula;
                cmd.Parameters.Add("@NombrePelicula", SqlDbType.NVarChar, 50).Value = objP.NombrePelicula;
                cmd.Parameters.Add("@Sinopsis", SqlDbType.NVarChar, 400).Value = objP.Sinopsis;
                cmd.Parameters.Add("@Lanzamiento", SqlDbType.NVarChar, 50).Value = objP.Lanzamiento;
                cmd.Parameters.Add("@Duracion", SqlDbType.NVarChar, 50).Value = objP.Duracion;
                cmd.Parameters.Add("@IdGenero", SqlDbType.Int).Value = objP.IdGenero;
                cmd.Parameters.Add("@IdClasificacion", SqlDbType.Int).Value = objP.IdClasificacion;
                cmd.Parameters.Add("@Imagen", SqlDbType.Image).Value = objP.Imagen;
                cmd.Parameters.Add("@URL", SqlDbType.NVarChar, 300).Value = objP.URL;
                cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = objP.IdUsuario;

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
        public int EliminarPelicula(CEPelicula objP)
        {
            int resultado=0;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_EliminarPelicula", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdPelicula", SqlDbType.Int).Value = objP.IdPelicula;
           
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
        public DataSet ListadoPelicula()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarTodoPelicula", cn);
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
        public DataSet ListadoGenero()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarDescripcionGenero", cn);
                da.Fill(ds, "Genero");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de los generos", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }
        public DataSet ListadoClasificacion()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarDescripcionClasificacion", cn);
                da.Fill(ds, "Clasificacion");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de las clasificaciones", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }

        public DataSet ListadoPeliculaPorCodigo(CEPelicula objF)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarPeliculaPorCodigo", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@IdPelicula", SqlDbType.Int).Value = objF.IdPelicula;
                da.Fill(ds, "Pelicula");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de la pelicula", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }

        public DataSet ListadoPeliculaPorNombrePelicula(CEPelicula objF)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarPeliculaPorNombrePelicula", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@NombrePelicula", SqlDbType.NVarChar, 50).Value = objF.NombrePelicula;
                da.Fill(ds, "Pelicula");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de la pelicula", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }

    }
}
