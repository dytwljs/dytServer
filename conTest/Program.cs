using System;
using MySql.Data;
//using MySql.Data.MySqlClient;

namespace conTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try { testDA(); }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
            //Console.ReadLine();
        }
        
        static void testDA(){
            //140.143.224.214
            var mysqlConStr = "server=140.143.224.214;port=3306;database=test;uid=root;pwd=Gedy_007";

            //var mysqlConStr = "server=127.0.0.1;port=3306;database=test;uid=root;pwd=gedy_007";
            //           var mysqlConStr = "Server=www.dytwljs.com; Port=3306;Database=cAuth; Uid=root; Pwd=Gedy_007;SslMode=None;";

            using (var conn = new MySql.Data.MySqlClient.MySqlConnection(mysqlConStr))
            {
                var comm = new MySql.Data.MySqlClient.MySqlCommand("delete from g_test;");
                comm.Connection = conn;
                conn.Open();
                int a= comm.ExecuteNonQuery();


            }
        }
    }
}
