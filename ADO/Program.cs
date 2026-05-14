//#define SELECT
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Diagnostics;
namespace ADO
{
    internal class Program
    {
        static SqlConnection connection;
        static void Main(string[] args)
        {
            string connetion_string = "Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=Movies;" +
                "Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;" +
                "TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;" +
                "MultiSubnetFailover=False;";
            Console.WriteLine(connetion_string);
            connection = new SqlConnection(connetion_string);


#if SELECT
            string cmd = "SELECT first_name, last_name FROM Directors";
            Select(cmd);
            Console.WriteLine($"Кол-во записей: {Scalar("SELECT COUNT(*) FROM Directors")}");
            Console.WriteLine("\n---------------------------------\n");

            //Select("SELECT title,release_date,first_name, last_name FROM Movies JOIN Directors ON (director = director_id)");
            Select("title, release_date,first_name,last_name","Movies,Directors","director=director_id");
            Console.WriteLine($"Кол-во записей: {Scalar("SELECT COUNT(*) FROM Movies")}");


#endif
            ////Insert($"INSERT Directors(director_id, first_name,last_name) VALUES ({GetNextPrimaryKey("Directors")}, N'Gray', N'Scott')");
            //Insert("Directors", "director_id,first_name,last_name", $"{GetNextPrimaryKey("Directors")},N'Sheldon',N'Letich'");
            //Select("*", "Directors");
            //Console.WriteLine(GetPrimeryKeyColumnName("Movies"));
            //Console.WriteLine(GetLastPrimaryKey("Movies"));
            //Console.WriteLine(GetNextPrimaryKey("Movies"));
            Insert
            (
                "Movies", "movied_id, title,release_date,director", $"{GetNextPrimaryKey("Movies")}, N'Avatar',N'2009-12-17',1"
            );
            Select("movied_id,title,release_date,first_name,last_name", 
                
                "Movies,Directors", 
                "director = director_id");
        }
        static string GetPrimeryKeyColumnName(string table)
        {
            //@raw = строкаё
            string cmd = $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE WHERE INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE.CONSTRAINT_NAME = (SELECT CONSTRAINT_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE CONSTRAINT_TYPE = N'PRIMARY KEY' AND TABLE_NAME = N'{table}')";
            return Scalar(cmd).ToString();
        }
        static object GetLastPrimaryKey(string table)
        {
            string cmd = $"SELECT MAX({GetPrimeryKeyColumnName(table)}) From {table}";
            return Scalar(cmd);
        }
        static object GetNextPrimaryKey(string table)
        {
            return (int)GetLastPrimaryKey(table) + 1;
        }
        static void Insert(string table, string fields, string values)
        {
            string pk = GetPrimeryKeyColumnName(table);
            string[] s_fields = fields.Split(',');
            string[] s_values = values.Split(',');
            if (s_fields.Length != s_values.Length) return;
            string condition = "";
            
            for(int i = 0; i< s_fields.Length;i++)
            {
                if (s_fields[i].ToLower() == pk.ToLower()) continue;
                condition += $"{s_fields[i]} = {s_values[i]}";
                if (i != s_fields.Length - 1) condition += " AND ";
            }
            if (Scalar($"SELECT {GetPrimeryKeyColumnName(table)} FROM {table} WHERE {condition}") == null)
            Insert($"INSERT {table}({fields}) VALUES({values})");
        }
        static void Insert(string cmd)
        {
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        static object Scalar(string cmd)
        {
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            object value = command.ExecuteScalar();
            connection.Close();
            return value;
        }
        static void Select(string fiels, string tables, string condition = "")
        {
            string cmd = $"SELECT {fiels} FROM {tables} ";
            if (condition != "" && condition != " ") cmd += $" WHERE {condition}";
            Select(cmd);
        }
        static void Select(string cmd)
        { 
           
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            for(int i=0; i<reader.FieldCount;i++)
                Console.Write(reader.GetName(i));
            Console.WriteLine();
            while(reader.Read())
            {
                //Console.WriteLine($"{reader[0]}\t{reader[1]}\t{reader[2]}");
                for (int i = 0; i < reader.FieldCount; i++)
                    Console.Write(reader[i] + "\t");
                Console.WriteLine();
            }
            reader.Close();
            connection.Close();

        }
    }
}
