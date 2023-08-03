using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prj_Capa_Entidad;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Serialization;
using Prj_CapaDatos;

namespace Prj_Capa_Datos
{
  public   class BD_Rol : cConexion 
    {

        public DataTable BD_Buscar_Todos_Roles()
        {
           
            try
            {
                Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Load_All_rol", Conectar());
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
