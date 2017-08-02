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
    public class CDEmpleado:Conexion
    {
        public int InsertarEmpleado(CEEmpleado objE)
        {
            int resultado;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_InsertarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CodEmpleado", SqlDbType.NVarChar, 15).Value = objE.CodEmpleado;
                cmd.Parameters.Add("@NombreEmpleado", SqlDbType.NVarChar, 50).Value = objE.NombreEmpleado;
                cmd.Parameters.Add("@ApellidoEmpleado", SqlDbType.NVarChar, 50).Value = objE.ApellidosEmpleado;
                cmd.Parameters.Add("@Direccion", SqlDbType.NVarChar, 300).Value = objE.Direccion;
                cmd.Parameters.Add("@Telefono", SqlDbType.Char, 9).Value = objE.Telefono;
                cmd.Parameters.Add("@Correo", SqlDbType.NVarChar, 30).Value = objE.Correo;

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

        public int ActualizarEmpleado(CEEmpleado objE)
        {
            int resultado;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_ActualizarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CodEmpleado", SqlDbType.NVarChar, 15).Value = objE.CodEmpleado;
                cmd.Parameters.Add("@NombreEmpleado", SqlDbType.NVarChar, 50).Value = objE.NombreEmpleado;
                cmd.Parameters.Add("@ApellidoEmpleado", SqlDbType.NVarChar, 50).Value = objE.ApellidosEmpleado;
                cmd.Parameters.Add("@Direccion", SqlDbType.NVarChar, 300).Value = objE.Direccion;
                cmd.Parameters.Add("@Telefono", SqlDbType.Char, 9).Value = objE.Telefono;
                cmd.Parameters.Add("@Correo", SqlDbType.NVarChar, 30).Value = objE.Correo;

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

        public int EliminarEmpleado(CEEmpleado objE)
        {
            int resultado = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_EliminarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CodEmpleado", SqlDbType.NVarChar, 15).Value = objE.CodEmpleado;

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

        public DataSet ListadoEmpleado()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarTodoEmpleado", cn);
                da.Fill(ds, "Empleado");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de los Empleados", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }
        public DataSet ListadoEmpleadoPorNombre(CEEmpleado objE)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarEmpleadoporNombre", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = objE.NombreEmpleado;
                da.Fill(ds, "EmpleadoN");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de los Empleados", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }


        public DataSet ListadoEmpleadoPorCodigo(CEEmpleado objE)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarEmpleadoporCod", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Cod", SqlDbType.NVarChar, 15).Value = objE.CodEmpleado;
                da.Fill(ds, "EmpleadoC");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de los Empleados", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }

    }
}
