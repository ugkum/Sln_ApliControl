using Prj_Capa_Datos;
using Prj_Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_CapaNegocio
{
    public class RN_Horario
    {
        public void RN_ActualizarHorario(EN_Horario p)
        {
            BD_Horario objHorario = new BD_Horario();
            objHorario.BD_ActualizarHorario(p);
        }

        public DataTable RN_CargarHorario()
        {
            BD_Horario objHorario = new BD_Horario();
           return objHorario.BD_CargarHorario();
        }
    }
}
