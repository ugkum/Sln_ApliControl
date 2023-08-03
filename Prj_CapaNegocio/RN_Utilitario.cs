using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Prj_Capa_Datos;
using Prj_CapaDatos;

namespace Prj_Capa_Negocio
{
  public   class RN_Utilitario
    {

        public string BD_nroDoc(int idTipo)
        {
            BD_Utilitario iobj = new BD_Utilitario();
           return  iobj.BD_nroDoc(idTipo);
        }

        public void BD_ActualizaTipoDoc(int idTipo)
        {
            BD_Utilitario iobj = new BD_Utilitario();
            iobj.BD_ActualizaTipoDoc(idTipo);
        }

        public string BD_ListarTipoFalta(int idTipo)
        {
            BD_Utilitario iobj = new BD_Utilitario();
            return iobj.BD_ListarTipoFalta(idTipo);
        }

        public void BD_ActualizarRobotFalta(int idTipo, string valor)
        {
            BD_Utilitario iobj = new BD_Utilitario();
             iobj.BD_ActualizarRobotFalta(idTipo, valor);
        }
  }

}
