using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using MySql.Data.MySqlClient;


namespace Data
{
    public class Conexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=estanciainfantil; Uid=root; pwd=Baldo_Uno_1;");
            conectar.Open();
            return conectar;
        }

        public class Conex
        {

            public static MySqlConnection ObtenerConex()
            {
                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; Uid=root; pwd=Baldo_Uno_1;");
                conectar.Open();
                return conectar;
            }

        }
    }
}
