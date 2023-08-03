using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Prj_CapaDatos;
using System.Data.SqlClient;
using Prj_Capa_Datos;

namespace Prj_Capa_Negocio
{
  public   class RN_Distrito
    {

        public DataTable RN_Buscar_Todos_Distrito()
        {
            BD_Distrito objDistrito = new BD_Distrito();
           return objDistrito.BD_Buscar_Todos_Distrito();
        }

    }
}
