using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Prj_CapaDatos
{
    public class cConexion
    {
        SqlConnection con;
        public SqlConnection Conectar()
        {
            try
            {
                con = new SqlConnection("SERVER=DESKTOP-ICB9S84;DATABASE=MicroSisPlani;INTEGRATED SECURITY=SSPI");
                con.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            return con;
        }

        public void Desconecta()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
