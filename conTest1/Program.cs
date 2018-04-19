using System;

namespace conTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try { testDA(); }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //Console.ReadLine();
        }

        static void testDA()
        {
            var mysqlConStr = "server=127.0.0.1;port=3306;database=test;uid=root;pwd=gedy_007";
            // var mysqlConStr = "Server=www.dytwljs.com; Port=3306;Database=cAuth; Uid=root; Pwd=Gedy_007;SslMode=None;";

            using (var conn = new MySql.Data.MySqlClient.MySqlConnection(mysqlConStr))
            {
                var comm = new MySql.Data.MySqlClient.MySqlCommand("delete from g_test;");
                comm.Connection = conn;
                conn.Open();
                int a = comm.ExecuteNonQuery();
            }
        }
    }
}
