using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewInsertInto
{
    public class InsertInto
    {
        static void Main(string[] args)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=ORDINATEUR-KISU\\SQLEXPRESS;Database=C#_Project;Trusted_Connection=true";
                conn.Open();
                Console.WriteLine("INSERT INTO command");

                // Create the command, to insert the data into the Table!
                // this is a simple INSERT INTO command!

                SqlCommand insertCommand = new SqlCommand("INSERT INTO Customer (Name, Waiting, Reservation) VALUES (@0, @1, @2)", conn);

                // In the command, there are some parameters denoted by @, you can 
                // change their value on a condition, in my code they're hardcoded.

                insertCommand.Parameters.Add(new SqlParameter("0", "Jean Michel"));
                insertCommand.Parameters.Add(new SqlParameter("1", "60"));
                insertCommand.Parameters.Add(new SqlParameter("2", "0"));
                // Execute the command, and print the values of the columns affected through
                // the command executed.

                Console.WriteLine("Commands executed! Total rows affected are " + insertCommand.ExecuteNonQuery());
                Console.WriteLine("Done! Press enter to move to the next step");
                Console.ReadLine();
                Console.Clear();
            }
        }

    }

}
