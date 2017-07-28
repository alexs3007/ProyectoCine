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
   public class CDPeliculaHorario:Conexion
    {
        public int InsertarPeliculaHorario(CEPeliculaHorario objPH)
        {
            int resultado=0;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_InsertarPeliculaHorario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdPelicula", SqlDbType.Int).Value = objPH.IdPelicula;
                cmd.Parameters.Add("@IdHorario", SqlDbType.Int).Value = objPH.IdHorario;
                
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
        public int ActualizarPeliculaHorario(CEPeliculaHorario objPH)
        {
            int resultado=0;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_ActualizarPeliculaHorario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdPelicula", SqlDbType.Int).Value = objPH.IdPelicula;
                cmd.Parameters.Add("@IdHorario", SqlDbType.Int).Value = objPH.IdHorario;

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
        public int EliminarPeliculaHorario(CEPeliculaHorario objPH)
        {
            int resultado = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_EliminarPeliculaHorario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdPelicula", SqlDbType.Int).Value = objPH.IdPelicula;
                cmd.Parameters.Add("@IdHorario", SqlDbType.Int).Value = objPH.IdHorario;

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
        public DataSet ListadoPeliculaHorario()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarTodoPeliculaHorario", cn);
                da.Fill(ds, "PeliculaHorario");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de los horario de las peliculas", ex);
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
        public DataSet ListadoHorario()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_DescripcionHorario", cn);
                da.Fill(ds, "Horario");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de los horarios", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }

        public DataSet ListadoPeliculaHorarioPorPelicula(CEPeliculaHorario objPH)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarPeliculaHorarioporPelicula", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Pelicula", SqlDbType.NVarChar,100).Value = objPH.Pelicula;
                da.Fill(ds, "PeliculaHorarioP");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de los horario de las peliculas", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }
        public DataSet ListadoPeliculaHorarioPorHorario(CEPeliculaHorario objPH)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarPeliculaHorarioporHorario", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Horario", SqlDbType.NVarChar, 100).Value = objPH.Horario;
                da.Fill(ds, "PeliculaHorarioH");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de los horario de las peliculas", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }

        
    }
}
