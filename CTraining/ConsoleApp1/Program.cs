using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static List<string> seat12 = new List<string>();
        static string[] xyz;
        static string readerElements;
        static void Main(string[] args)
        {
            
            string connectionString = $"Data Source=IL013413\\MSSQLSERVER2; Initial Catalog = myDB; Integrated Security=true";
            var connection = new SqlConnection(connectionString);
            string commandString = $"select SeatNos from BusBooking where Destination='Delhi'";
            var command = new SqlCommand(commandString, connection);
            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                readerElements = reader[0].ToString();
                xyz = readerElements.Split(',');
                foreach(var i in xyz)
                    seat12.Add(i);
                
            }
            connection.Close();
           // Console.WriteLine(readerElements);
            foreach (var item in seat12)
                Console.WriteLine(item);


            // foreach(var item in seat12)

        }
    }
}
