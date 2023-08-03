using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prj_Capa_Entidad;
using System.Data;

namespace Prj_CapaDatos
{
    public class BD_Personal:cConexion
    {
        public void BD_Registrar_Personal(EN_Persona per)
        {
            Conectar();
            SqlCommand cmd = new SqlCommand("Sp_Insert_Personal", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 20;
            cmd.Parameters.AddWithValue("@Id_Person", per.Idpersonal);
            cmd.Parameters.AddWithValue("@dni", per.Dni);
            cmd.Parameters.AddWithValue("@nombreComplto", per.Nombres);
            cmd.Parameters.AddWithValue("@FechaNacmnto", per.anoNacimiento);
            cmd.Parameters.AddWithValue("@Sexo", per.Sexo);
            cmd.Parameters.AddWithValue("@Domicilio", per.Direccion);
            cmd.Parameters.AddWithValue("@Correo", per.Correo);
            cmd.Parameters.AddWithValue("@Celular", per.Celular);
            cmd.Parameters.AddWithValue("@Id_rol", per.IdRol);
            cmd.Parameters.AddWithValue("@Foto", per.xImagen);
            cmd.Parameters.AddWithValue("@Id_Distrito", per.IdDistrito);
  
            cmd.ExecuteNonQuery();
            Desconecta();
        }

        public void BD_Editar_Personal(EN_Persona per)
        {
            Conectar();
            SqlCommand cmd = new SqlCommand("SP_UPDATE_PERSONAL", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 20;
            cmd.Parameters.AddWithValue("@Id_Person", per.Idpersonal);
            cmd.Parameters.AddWithValue("@dni", per.Dni);
            cmd.Parameters.AddWithValue("@nombreComplto", per.Nombres);
            cmd.Parameters.AddWithValue("@FechaNacmnto", per.anoNacimiento);
            cmd.Parameters.AddWithValue("@Sexo", per.Sexo);
            cmd.Parameters.AddWithValue("@Domicilio", per.Direccion);
            cmd.Parameters.AddWithValue("@Correo", per.Correo);
            cmd.Parameters.AddWithValue("@Celular", per.Celular);
            cmd.Parameters.AddWithValue("@Id_rol", per.IdRol);
            cmd.Parameters.AddWithValue("@Foto", per.xImagen);
            cmd.Parameters.AddWithValue("@Id_Distrito", per.IdDistrito);

            cmd.ExecuteNonQuery();
            Desconecta();
        }

        public void BD_Registrar_Huella_Dactilar_Personal(string idPer, object figura)
        {
            Conectar();
            SqlCommand cmd = new SqlCommand("Sp_Actualizar_FinguerPrint", Conectar());
            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdPersona", idPer);
                cmd.Parameters.AddWithValue("FinguerPrint", figura);
                cmd.ExecuteNonQuery();
                Desconecta();
            }
            catch (Exception)
            {

                Desconecta();
                cmd.Dispose();
            }
            
        }

        public DataTable BD_Leer_todoPersonal()
        {
            Conectar();
            SqlDataAdapter da = new SqlDataAdapter("Sp_Listar_Personal",Conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Desconecta();
            return dt;
        }

        public DataTable BD_Buscar_todoPersonal(string texto)
        {
            Conectar();
            SqlDataAdapter da = new SqlDataAdapter("Sp_Cargar_PersonalxDni", Conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Dni", texto);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Desconecta();
            return dt;
        }

        public DataTable verificarDniPersonal(string dni)
        {
            Conectar();
            SqlDataAdapter da = new SqlDataAdapter("sp_validar_dni", Conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Dni", dni);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Desconecta();
            return dt;
        }

        
    }
}
