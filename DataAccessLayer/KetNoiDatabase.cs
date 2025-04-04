using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class KetNoiDatabase
    {   // Ket noi database
        public static MySqlConnection Connection() {
            string strcon = "Server=localhost;Database=qlcafe;User ID=buingoctien;Password=Tien2362003#";


            MySqlConnection conn = new MySqlConnection(strcon);
            return conn;

        }
    }
}
