using Prj_Capa_Entidad;
using Prj_CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Prj_CapaNegocio
{
    public class RN_Personal
    {
        public void RN_Registrar_Personal(EN_Persona per)
        {
            BD_Personal objPersonal = new BD_Personal();
            objPersonal.BD_Registrar_Personal(per);
        }
        public void RN_Editar_Personal(EN_Persona per)
        {
            BD_Personal objPersonal = new BD_Personal();
            objPersonal.BD_Editar_Personal(per);
        }
        public void RN_Registrar_Huella_Dactilar_Personal(string idPer, object figura)
        {
            BD_Personal objPersonal = new BD_Personal();
            objPersonal.BD_Registrar_Huella_Dactilar_Personal(idPer, figura);
        }

        public DataTable RN_Leer_todoPersonal()
        {
            BD_Personal objPersonal = new BD_Personal();
            return objPersonal.BD_Leer_todoPersonal();
        }
        public DataTable RN_Buscar_todoPersonal(string texto)
        {
            BD_Personal objPersonal = new BD_Personal();
            return objPersonal.BD_Buscar_todoPersonal(texto);
        }
        public DataTable verificarDniPersonal(string dni)
        {
            BD_Personal objPersonal = new BD_Personal();
            return objPersonal.verificarDniPersonal(dni);
        }

    }
}
