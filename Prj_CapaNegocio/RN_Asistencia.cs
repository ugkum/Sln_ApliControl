using Prj_CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_CapaNegocio
{
    public class RN_Asistencia
    {
        public DataTable cargarTodosAsistencia()
        {
            BD_Asistencia objA = new BD_Asistencia();
            return objA.cargarTodosAsistencia();
        }

        public DataTable cargarTodosAsistencia_delDia(DateTime xDia)
        {
            BD_Asistencia objA = new BD_Asistencia();
            return objA.cargarTodosAsistencia_delDia(xDia);
        }
        public DataTable cargarTodosAsistencia_delMes(DateTime xFecha)
        {
            BD_Asistencia objA = new BD_Asistencia();
            return objA.cargarTodosAsistencia_delMes(xFecha);
        }

        public DataTable BuscarAsistenciaParaExplorador(string xValor)
        {
            BD_Asistencia objA = new BD_Asistencia();
            return objA.BuscarAsistenciaParaExplorador(xValor);
        }

        public void RN_RegistrarEntradaPersonal(string idAsis, string idPersonal, string HoIngreso, double tarde, int totalHora, string justificacion)
        {
            BD_Asistencia objA = new BD_Asistencia();
            objA.BD_RegistrarEntradaPersonal(idAsis, idPersonal, HoIngreso, tarde, totalHora, justificacion);
        }
        public void RN_RegistrarSalidaPersonal(string idAsis, string idPersonal, string HoSalida, int totalHora)
        {
            BD_Asistencia objA = new BD_Asistencia();
            objA.BD_RegistrarSalidaPersonal(idAsis, idPersonal, HoSalida, totalHora);
        }
        public DataTable RN_Verificaciones_si_ya_paso_Asistencia(string idPersonal)
        {
            BD_Asistencia objA = new BD_Asistencia();
            return objA.BD_Verificaciones_si_ya_paso_Asistencia(idPersonal);
        }
        public DataTable RN_Verificaciones_si_ya_paso_Asistencia_Entrada(string idPersonal)
        {
            BD_Asistencia objA = new BD_Asistencia();
            return objA.BD_Verificaciones_si_ya_paso_Asistencia_Entrada(idPersonal);
        }
        public DataTable RN_Verificaciones_JustificacionAprobada(string idPersonal)
        {
            BD_Asistencia objA = new BD_Asistencia();
            return objA.BD_Verificaciones_JustificacionAprobada(idPersonal);
        }

        public DataTable BD_BuscarAsistenciEntrada(string idPersonal)
        {
            BD_Asistencia objA = new BD_Asistencia();
            return objA.BD_BuscarAsistenciEntrada(idPersonal);
        }

        public DataTable BD_Chekar_Si_PersonalTieneAsistenciaRegistrada(string idPersonal)
        {
            BD_Asistencia objA = new BD_Asistencia();
            return objA.BD_Chekar_Si_PersonalTieneAsistenciaRegistrada(idPersonal);
        }
        public DataTable BD_Chekar_Si_ya_Marco_Falta(string idPersonal)
        {
            BD_Asistencia objA = new BD_Asistencia();
            return objA.BD_Chekar_Si_ya_Marco_Falta(idPersonal);
        }

        public void BD_Registrar_Falta_Personal( string idPersonal, string justificacion)
        {
            BD_Asistencia objA = new BD_Asistencia();
            objA.BD_Registrar_Falta_Personal( idPersonal, justificacion);
        }
    }
}
