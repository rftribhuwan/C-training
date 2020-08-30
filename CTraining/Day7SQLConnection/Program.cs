using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Day7SQLConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source = ctraining.database.windows.net; Initial Catalog = myDB; User ID = reuben; Password = Pass@1234";
            var connection = new SqlConnection(connectionString);
            string commandString = "Insert into Persons values(2,'Kumar','Neeraj','Aundh','Pune')";
            string commandString1 = "Select * from Persons";
            string commandString2 = "Update Persons set Address = 'Pimple Saudagar' where PersonID=1";
            var command = new SqlCommand(commandString1, connection);
            var adapter = new SqlDataAdapter();
            //var adapter1 = new SqlDataAdapter();
            adapter.InsertCommand = new SqlCommand(commandString, connection);
            adapter.UpdateCommand = new SqlCommand(commandString2, connection);
            connection.Open();
            Console.WriteLine("Database open");
            adapter.InsertCommand.ExecuteNonQuery();
            adapter.InsertCommand.Dispose();
            Console.WriteLine("Insert query completed!");
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.Write($"{reader[0].ToString()}\t");
                Console.Write($"{reader[1].ToString()}\t");
                Console.Write($"{reader[2].ToString()}\t");
                Console.Write($"{reader[3].ToString()}\t");
                Console.Write($"{reader[4].ToString()}\n");
            }
            Console.WriteLine("Select query completed!");
            reader.Close();
            command.Dispose();
            adapter.UpdateCommand.ExecuteNonQuery();
            var reader1 = command.ExecuteReader();
            while (reader1.Read())
            {
                Console.Write($"{reader1[0].ToString()}\t");
                Console.Write($"{reader1[1].ToString()}\t");
                Console.Write($"{reader1[2].ToString()}\t");
                Console.Write($"{reader1[3].ToString()}\t");
                Console.Write($"{reader1[4].ToString()}\n");
            }
            reader1.Close();
            command.Dispose();
            Console.WriteLine("Select query completed!");
            Console.WriteLine("Database closed!");
            connection.Close();
            

        }
    }
}
