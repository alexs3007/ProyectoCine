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
    public class CDLogin : Conexion
    {
        public string[] AccesoUsuario(CELogin objF)
        {
            SqlDataReader dr;
           
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Login", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar,20).Value = objF.NombreUsuario;
                cmd.Parameters.Add("@Contraseña", SqlDbType.NVarChar,20).Value = objF.Contrasena;
              
                ConectarBD();
                dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    string[] resultado = {dr.GetInt32(0).ToString(),dr.GetString(1),dr.GetString(2)};
                    return resultado;
                }
                else
                {
                    string[] resultado = {""};
                    return resultado;
                }
                
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
            
            
        }
    }
}
