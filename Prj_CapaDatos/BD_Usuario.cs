using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;


namespace Prj_CapaDatos
{
    public class BD_Usuario:cConexion
    {
        public DataTable BD_verificar_Acceso(string usuario, string contrasena)
        {
            Conectar();
            SqlDataAdapter da = new SqlDataAdapter("Sp_Login", Conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.CommandTimeout = 0;
            da.SelectCommand.Parameters.AddWithValue("Usuario", usuario);
            da.SelectCommand.Parameters.AddWithValue("Contraseña", contrasena);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Desconecta();
            return dt;
        }

        public DataTable BD_Leer_Datos_Usuario(string usuario)
        {
            Conectar();
            SqlDataAdapter da = new SqlDataAdapter("Sp_usuario_Login", Conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.CommandTimeout = 0;
            da.SelectCommand.Parameters.AddWithValue("Usuario", usuario);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Desconecta();
            return dt;
        }
    }
}
