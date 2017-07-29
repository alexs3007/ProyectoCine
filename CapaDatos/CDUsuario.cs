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
    public class CDUsuario : Conexion 
    {
        public int InsertarUsuario(CEUsuario ObjU)
        {
            int resultado = 0;

            try
            {
                SqlCommand cmd = new SqlCommand("Sp_InsertarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar,20).Value=ObjU.NombreUsuario;
                cmd.Parameters.Add("@Contraseña", SqlDbType.NVarChar, 20).Value = ObjU.Contraseña; 
                cmd.Parameters.Add("@CodEmpleado", SqlDbType.NVarChar, 15).Value = ObjU.CodEmpleado; 
                cmd.Parameters.Add("@IdTipoUsuario", SqlDbType.Int).Value = ObjU.IdTipoUsuario;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch
            {
                //throw new Exception("Error al tratar de almacenar", ex);
            }
            finally
            {
                CerrarBD();
            }
            return resultado;
        }

        public int ActualizarUsuario(CEUsuario ObjU)
        {
            int resultado = 0;

            try
            {
                SqlCommand cmd = new SqlCommand("ActualizarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value=ObjU.IdUsuario;
                cmd.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar, 20).Value = ObjU.NombreUsuario;
                cmd.Parameters.Add("@Contraseña", SqlDbType.NVarChar, 20).Value = ObjU.Contraseña;
                cmd.Parameters.Add("@CodEmpleado", SqlDbType.NVarChar, 15).Value = ObjU.CodEmpleado;
                cmd.Parameters.Add("@IdTipoUsuario", SqlDbType.Int).Value = ObjU.IdTipoUsuario;


                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch
            {
                //throw new Exception("Error al tratar de almacenar", ex);
            }
            finally
            {
                CerrarBD();
            }
            return resultado;
        }

        public int EliminarUsuario(CEUsuario ObjU)
        {
            int resultado = 0;

            try
            {
                SqlCommand cmd = new SqlCommand("EliminarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value=ObjU.IdUsuario;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch
            {
                //throw new Exception("Error al tratar de almacenar", ex);
            }
            finally
            {
                CerrarBD();
            }
            return resultado;
        }

        public DataSet ListadoUsuario()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarTodoUsuario", cn);
                da.Fill(ds, "Usuario");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de los usuarios", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }

        }

        public DataSet ListadoUsuarioPorUsuario(CEUsuario ObjU)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarTodoPorUsuario", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar, 20).Value = ObjU.NombreUsuario;
                da.Fill(ds, "NombreUsuario");
                return ds;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de los usuarios", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }

        }
        public DataSet ListadoUsuarioPorEmpleado(CEUsuario ObjU)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("MostrarTodoPorEmpleado", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@NombreEmpleado", SqlDbType.NVarChar, 50).Value = ObjU.NombreEmpleado;
                da.Fill(ds, "NombreEmpleado");
                return ds;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de los usuarios", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }

        }


        public DataSet ListadoEmpleado()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_DecripcionEmpleado", cn);
                da.Fill(ds, "Empleado");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de los empleados", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }

        }
        public DataSet ListadoTipoUsuario()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_DecripcionTipoAcceso", cn);
                da.Fill(ds, "TipoUsuario");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de los tipos de usuarios", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }

        }
    }
}
