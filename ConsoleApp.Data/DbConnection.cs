using System.Data.SqlClient;

namespace ConsoleApp.Data
{
    public static class DbConnection
    {
        private static readonly string connection = "Data Source=DESKTOP-PT71T7O\\SQLCHANDAN;Initial Catalog=Console.DbCon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static void GetAll()
        {
            string query = "select * from personinfo";
            runQueries(query, true);
        }

        private static void runQueries(string query, bool reader = false)
        {
            //connection object
            SqlConnection con = new SqlConnection(connection);
            //command object
            SqlCommand cmd = new SqlCommand(query, con);
            //connection open
            con.Open();
            if (reader)
            {
                //execute command
                var readerStream = cmd.ExecuteReader();
                //do work
                while (readerStream.Read())
                {
                    Console.WriteLine($"Id = {readerStream.GetInt32(0)}");
                    Console.WriteLine($"Name = {readerStream.GetString(1)}");
                    Console.WriteLine($"Email = {readerStream.GetString(2)}");
                    Console.WriteLine($"Phone = {readerStream.GetString(3)}");
                    Console.WriteLine("===========================================");
                }
            }
            else
            {
                //execute command
                cmd.ExecuteNonQuery();
            }
            //connection close
            con.Close();
        }

        public static void GetById()
        {
            Console.WriteLine("Enter the ID");
            var id = Console.ReadLine();

            string query = $"select * from personinfo where id={id}";
            runQueries(query, true);
        }

        public static void Create()
        {
            Console.WriteLine("Enter the name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter the email");
            var email = Console.ReadLine();
            Console.WriteLine("Enter the phone");
            var phone = Console.ReadLine();

            string query = $"insert into personinfo values ('{name}','{email}','{phone}')";
            runQueries(query);
        }

        public static void Edit()
        {
            Console.WriteLine("Enter the ID");
            var id = Console.ReadLine();
            Console.WriteLine("Enter the name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter the email");
            var email = Console.ReadLine();
            Console.WriteLine("Enter the phone");
            var phone = Console.ReadLine();

            string query = $"update personinfo set name='{name}',email='{email}',phone='{phone}' where id ={id}";
            runQueries(query);
        }

        public static void Delete()
        {
            Console.WriteLine("Enter the ID");
            var id = Console.ReadLine();

            string query = $"delete from personinfo where id={id}";
            runQueries(query);
        }
    }
}