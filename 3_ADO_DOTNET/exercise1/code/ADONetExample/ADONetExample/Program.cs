using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ADONetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *
            <connectionStrings>
		        <add name="dbcs" connectionString="Data Source=DESKTOP-4BMDG8B;Initial Catalog=CSharpBarhch8; Integrated Security=True;" providerName="System.Data.SqlClient"/>
        	</connectionStrings>
             * 
             */

            /*using SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "data source=DESKTOP-6AH4DVE;Initial Catalog=CSharpB8; Integrated Security=True;";
            if (connection.State != System.Data.ConnectionState.Open) {
                connection.Open();

            }
            using SqlCommand command_i = new SqlCommand();
            command_i.Connection = connection;
            command_i.CommandText = "INSERT INTO Students(Name,DateOfBirth,CGPA) VALUES('mukit','2010-12-3',3.62)";
            command_i.ExecuteNonQuery();*/
            /*command.Dispose();
            if(connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            } */

            // create the 
            // creating function 


            // using custom function
            var ConnectionString = "data source=DESKTOP-6AH4DVE;Initial Catalog=CSharpB8; Integrated Security=True;";
            //var insert_query1 = "INSERT INTO Students(Name,DateOfBirth,CGPA) VALUES('Tanvir','2021-10-29',3.00)";
            //var insert_query2 = "INSERT INTO Students(Name,DateOfBirth,CGPA) VALUES('Tanvir Rahman','2021-3-29',3.02)";
            //var insert_query3 = "INSERT INTO Students(Name,DateOfBirth,CGPA) VALUES('Ornob Rahman','2021-10-23',3.03)";

            //ExecuteNonQuery(ConnectionString, insert_query1);
            //ExecuteNonQuery(ConnectionString, insert_query2);
            //ExecuteNonQuery(ConnectionString, insert_query3);
            //var delete_query1 = "DELETE FROM Students WHERE name='Tanvir'";
            //ExecuteNonQuery(ConnectionString, delete_query1);
            //Console.WriteLine("DELETE WORKED");

            var query1 = "SELECT * FROM Students";
            ExecuteQuery(ConnectionString, query1);







        }


        public static void ExecuteNonQuery(string connection_string, string query) {

            // setting up the connection
            using SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connection_string;
            if (connection.State != System.Data.ConnectionState.Open) {
                connection.Open();
            }

            //This is thr query block
            using SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = query;
            command.ExecuteNonQuery();
            Console.WriteLine("Work Done");

                
        
        }

        public static List<Student> ExecuteQuery(string connection_string, string query) {
        
                // get the connection
            using SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connection_string;
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = query;
            var reader = command.ExecuteReader();
            var students = new List<Student>();
            while (reader.Read()) {
                var id   = (int)       reader["Id"];
                var Name = (String)    reader["Name"];
                var dob  = (DateTime)  reader[2];
                var CGPA = (Decimal)   reader[3];
                var student = new Student
                {
                    id = id,
                    Name = Name,
                    DateOfBirth = dob,
                    CGPA = CGPA,
                };
                students.Add(student);

            }

            //  print in the console

            foreach(var student in students)
            {
                Console.WriteLine($"Id: {student.id} ,Name: {student.Name}, DOB: {student.DateOfBirth},CGPA: {student.CGPA}");
            }
            Console.ReadLine();



            
            return students;



                
        }

    }
}
