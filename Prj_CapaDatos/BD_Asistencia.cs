using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_CapaDatos
{
    public class BD_Asistencia:cConexion
    {

        public DataTable cargarTodosAsistencia()
        {
            Conectar();
            SqlDataAdapter da = new SqlDataAdapter("Sp_Cargar_Todas_Asistencias", Conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.CommandTimeout = 0;
            //da.SelectCommand.Parameters.AddWithValue("@fecha",xDia);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Desconecta();
            return dt;
        }

        public DataTable cargarTodosAsistencia_delDia(DateTime xDia)
        {
            Conectar();
            SqlDataAdapter da = new SqlDataAdapter("Sp_Cargar_Asistencia_deldia", Conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.CommandTimeout = 0;
            da.SelectCommand.Parameters.AddWithValue("@fecha",xDia);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Desconecta();
            return dt;
        }

        public DataTable cargarTodosAsistencia_delMes(DateTime xFecha)
        {
            Conectar();
            SqlDataAdapter da = new SqlDataAdapter("Sp_Cargar_Asistencia_xFecha", Conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.CommandTimeout = 0;
            da.SelectCommand.Parameters.AddWithValue("@fecha", xFecha);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Desconecta();
            return dt;
        }

        public DataTable BuscarAsistenciaParaExplorador(string xValor)
        {
            Conectar();
            SqlDataAdapter da = new SqlDataAdapter("Sp_Buscar_Asistencia_paraExplorador", Conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.CommandTimeout = 0;
            da.SelectCommand.Parameters.AddWithValue("@Id_Asis", xValor);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Desconecta();
            return dt;
        }


        //Registro de asistencia

        public void BD_RegistrarEntradaPersonal(string idAsis, string idPersonal,string HoIngreso, double tarde, int totalHora , string justificacion)
        {
            Conectar();
            SqlCommand cmd = new SqlCommand("Sp_Registrar_Entrada",Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 20;
            cmd.Parameters.AddWithValue("@IdAsis", idAsis);
            cmd.Parameters.AddWithValue("@Id_Persol", idPersonal);
            cmd.Parameters.AddWithValue("@Hoingre", HoIngreso);
            cmd.Parameters.AddWithValue("@tardanza", tarde);
            cmd.Parameters.AddWithValue("@TotalHora", totalHora);
            cmd.Parameters.AddWithValue("@justificado", justificacion);
            cmd.ExecuteNonQuery();
            Desconecta();
        }

        public void BD_RegistrarSalidaPersonal(string idAsis, string idPersonal, string HoSalida, int totalHora)
        {
            Conectar();
            SqlCommand cmd = new SqlCommand("Sp_Registrar_Salida", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 20;
            cmd.Parameters.AddWithValue("@IdAsis", idAsis);
            cmd.Parameters.AddWithValue("@Id_Personal", idPersonal);
            cmd.Parameters.AddWithValue("@HoSalida", HoSalida);
            cmd.Parameters.AddWithValue("@TotalHora", totalHora);
            cmd.ExecuteNonQuery();
            Desconecta();
        }

        public DataTable BD_Verificaciones_si_ya_paso_Asistencia(string idPersonal)
        {
            Conectar();
            SqlDataAdapter da = new SqlDataAdapter("Sp_Validar_RegistroAsistencia", Conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.CommandTimeout = 0;
            da.SelectCommand.Parameters.AddWithValue("@Id_Personal", idPersonal);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Desconecta();
            return dt;
        }

        public DataTable BD_Verificaciones_si_ya_paso_Asistencia_Entrada(string idPersonal)
        {
            Conectar();
            SqlDataAdapter da = new SqlDataAdapter("Sp_verificar_IngresoAsis", Conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.CommandTimeout = 0;
            da.SelectCommand.Parameters.AddWithValue("@Id_Personal", idPersonal);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Desconecta();
            return dt;
        }

        public DataTable BD_Verificaciones_JustificacionAprobada(string idPersonal)
        {
            Conectar();
            SqlDataAdapter da = new SqlDataAdapter("SP_VerificarJustificacion_Aprobada", Conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.CommandTimeout = 0;
            da.SelectCommand.Parameters.AddWithValue("@Id_Personal", idPersonal);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Desconecta();
            return dt;
        }

        public DataTable BD_BuscarAsistenciEntrada(string idPersonal)
        {
            Conectar();
            SqlDataAdapter da = new SqlDataAdapter("Sp_Leer_asistencia_reciente", Conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.CommandTimeout = 0;
            da.SelectCommand.Parameters.AddWithValue("@Id_Per", idPersonal);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Desconecta();
            return dt;
        }

        public DataTable BD_Chekar_Si_PersonalTieneAsistenciaRegistrada(string idPersonal)
        {
            Conectar();
            SqlDataAdapter da = new SqlDataAdapter("Sp_Ver_sihay_Registro", Conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.CommandTimeout = 0;
            da.SelectCommand.Parameters.AddWithValue("@Id_Personal", idPersonal);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Desconecta();
            return dt;
        }

        public DataTable BD_Chekar_Si_ya_Marco_Falta(string idPersonal)
        {
            Conectar();
            SqlDataAdapter da = new SqlDataAdapter("Sp_Verificar_siMarco_Falta", Conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.CommandTimeout = 0;
            da.SelectCommand.Parameters.AddWithValue("@Id_Personal", idPersonal);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Desconecta();
            return dt;
        }

        public void BD_Registrar_Falta_Personal( string idPersonal, string justificacion)
        {
            Conectar();
            SqlCommand cmd = new SqlCommand("Sp_Registrar_Falta", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 20;
            //cmd.Parameters.AddWithValue("@IdAsis", idAsis);
            cmd.Parameters.AddWithValue("@Id_Personal", idPersonal);
            cmd.Parameters.AddWithValue("@justificacion", justificacion);
          
            cmd.ExecuteNonQuery();
            Desconecta();
        }

    }
}
