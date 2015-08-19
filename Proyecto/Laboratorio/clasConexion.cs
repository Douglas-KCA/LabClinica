using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace Laboratorio
{
    class clasConexion
    {
        public static MySqlConnection funConexion()
        {
            
            MySqlConnection Conexion = new MySqlConnection("server =192.168.15.1; userid =Laboratorio; password =laboratorio2015; database =LABORATORIO");
            Conexion.Open();
            return Conexion;
        }
        
    }
}
