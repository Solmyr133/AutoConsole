using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoConsole
{
    internal class Program
    {
        public static List<Cars> carList = new List<Cars>();
        static Connection conn = new Connection();

        public static void Feladat1()
        {
            conn.connection.Open();

            string sql = "SELECT * FROM cars;";
            MySqlCommand cmd = new MySqlCommand(sql, conn.connection);

            MySqlDataReader dr = cmd.ExecuteReader();

            dr.Read();

            do
            {
                Cars cars = new Cars();

                cars.Id = dr.GetInt32(0);
                cars.Brand = dr.GetString(1);
                cars.Type = dr.GetString(2);
                cars.License = dr.GetString(3);
                cars.Date = dr.GetDateTime(4);

                carList.Add(cars);
            } while (dr.Read());

            conn.connection.Close();

            foreach (var item in carList)
            {
                Console.WriteLine($"Márka: {item.Brand}, Azonosító: {item.Id}");
            }
        }

        static void Main()
        {
            Feladat1();
        }
    }
}