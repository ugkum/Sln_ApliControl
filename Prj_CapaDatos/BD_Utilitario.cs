using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Diagnostics.CodeAnalysis;

namespace Prj_CapaDatos
{
    public class BD_Utilitario : cConexion
    {

        public string BD_nroDoc(int idTipo)
        {
            Conectar();
            SqlCommand cmd = new SqlCommand("Sp_Listado_Tipo",Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 20;
            cmd.Parameters.AddWithValue("@Id_Tipo", idTipo);
            string NroDoc;
            NroDoc = Convert.ToString(cmd.ExecuteScalar());
            Desconecta();
            return NroDoc;
        }

        public void BD_ActualizaTipoDoc(int idTipo)
        {
            Conectar();
            SqlCommand cmd = new SqlCommand("Sp_Actualizar_Tipo_Doc", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 20;
            cmd.Parameters.AddWithValue("@Id_Tipo", idTipo);
            cmd.ExecuteNonQuery();
            Desconecta();
         
        }

        public string BD_ListarTipoFalta(int idTipo)
        {
            Conectar();
            SqlCommand cmd = new SqlCommand("Sp_Listado_TipoFalta", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 20;
            cmd.Parameters.AddWithValue("@Id_Tipo", idTipo);
            string res=Convert.ToString( cmd.ExecuteScalar());
            Desconecta();
            return res;
        }

        public void BD_ActualizarRobotFalta(int idTipo, string valor)
        {
            Conectar();
            SqlCommand cmd = new SqlCommand("Sp_Activar_Desac_RobotFalta", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 20;
            cmd.Parameters.AddWithValue("@IdTipo", idTipo);
            cmd.Parameters.AddWithValue("@serie", valor);
            cmd.ExecuteNonQuery();
            Desconecta();

        }
    }
}
