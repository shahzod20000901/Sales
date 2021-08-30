using System;
using MySql.Data.MySqlClient;

namespace SalesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CONN_STR = "Server=http://mysql60.hostland.ru/;Database=host1323541_sbd03;Uid=host1323541_itstep;Pwd=269f43dc;";
            var db = new MySqlConnection(CONN_STR);
            db.Open();
        }
    }
}