using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Prj_Capa_Entidad;
using Prj_CapaDatos;

namespace Prj_Capa_Datos
{
    public   class BD_Horario : cConexion
    {

      
        public void BD_ActualizarHorario(EN_Horario p)
        {
            Conectar();
            SqlCommand cmd = new SqlCommand("Sp_Update_Horario",Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 20;
            cmd.Parameters.AddWithValue("@Idhor", p.Idhora);
            cmd.Parameters.AddWithValue("@HoEntrada", p.HoEntrada);
            cmd.Parameters.AddWithValue("@HoTolere", p.HoTole);
            cmd.Parameters.AddWithValue("@Holimite", p.HoLimite);
            cmd.Parameters.AddWithValue("@HoraSalida", p.HoSalida);
            cmd.ExecuteNonQuery();
            Desconecta();
        }

        public DataTable BD_CargarHorario()
        {
            Conectar();
            SqlDataAdapter da = new SqlDataAdapter("Sp_Buscar_Todos_Horarios",Conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Desconecta();
            return dt;
        }





    }
}
