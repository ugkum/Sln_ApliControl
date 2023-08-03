using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Prj_Capa_Entidad;
using System.Data.SqlClient;
using System.Net.Configuration;
using Prj_CapaDatos;

namespace Prj_Capa_Datos
{
  public   class BD_Distrito : cConexion 
    {

        public static bool savedx = false;

        public DataTable BD_Buscar_Todos_Distrito()
        {
           
            try
            {
                Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Ver_Todo_Distrito", Conectar());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable Dato = new DataTable();
                da.Fill(Dato);
                da = null;
                return Dato;

            }
            catch (Exception ex)
            {

                Desconecta();

            }
            return null;
        }

    }
}
