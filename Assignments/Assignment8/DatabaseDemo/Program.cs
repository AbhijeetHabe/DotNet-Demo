using Microsoft.Data.SqlClient;

namespace DatabaseDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = "Data Source=NameOfSqlServer;Initial Catalog=DatabaseName;User Id=sa;Password=pwd";
            //cn.ConnectionString = "Data Source=NameOfSqlServer;Initial Catalog=DatabaseName;Integrated Security=true";
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=KTjune23;Integrated Security=True;Connect Timeout=30;
            cn.ConnectionString = @"Data Source=(localdb)\MSSqlLocalDb;Initial Catalog=KTjune23;Integrated Security=true";
            cn.Open();

            Console.WriteLine("open");

            cn.Close();
        }
    }
}