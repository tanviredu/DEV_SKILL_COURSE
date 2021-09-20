using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace OOP.ADO.NET.EXAMPLE
{
    public class ADO_OOP
    {
        // open the database connection in the constructor
        // and then use it to apply CRUD
        // 
        String ConnectionString = "data source=DESKTOP-6AH4DVE;Initial Catalog=CSharpB8; Integrated Security=True;";
        SqlConnection connection = new SqlConnection();
        public ADO_OOP()
        {
            connection.ConnectionString = ConnectionString;
        }

        public void READ(string sql)
        {
            connection.Open();
            using SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = sql;
            var reader = command.ExecuteReader();
            while (reader.Read()) {
                Console.WriteLine($"id: {reader["Id"]},Name : {reader["Name"]},DateOfBirth : {reader["DateOfBirth"]},CGPA : {reader["CGPA"]}");
            }
            command.Dispose();
            connection.Close();
            
        }

        public void CREATE(string sql)
        {
            connection.Open();
            using SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = sql;
            command.ExecuteNonQuery();
            Console.WriteLine("Data is Added");
            connection.Close();
            

        }

        public void DELETE(string sql)
        {
            connection.Open();
            using SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = sql;
            command.ExecuteNonQuery();
            Console.WriteLine("Data is Deleted");
            command.Dispose();
            connection.Close();
            
        }
    }
}
