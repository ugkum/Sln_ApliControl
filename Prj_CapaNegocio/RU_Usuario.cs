using Prj_CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_CapaNegocio
{
    public class RU_Usuario
    {
        public DataTable BD_verificar_Acceso(string usuario, string contrasena)
        {
            BD_Usuario objUsuario = new BD_Usuario();
            return objUsuario.BD_verificar_Acceso(usuario,contrasena);
        }
        public DataTable BD_Leer_Datos_Usuario(string usuario)
        {
            BD_Usuario objUsuario = new BD_Usuario();
            return objUsuario.BD_Leer_Datos_Usuario(usuario);
        }
    }
}
