using Microsoft.Data.SqlClient;
using System.Data;

namespace DatabaseDemo
{
    internal class Program
    {
        static SqlConnection cn = new SqlConnection();
        static void Main()
        {
            Connection();
            //Insert();
            DataReader();

        }
        static void Connection()
        {
            try
            {

                cn.ConnectionString = @"Data Source=(localdb)\MSSqlLocalDb;Initial Catalog=KTjune23;Integrated Security=true";
                cn.Open();

                Console.WriteLine("open");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Insert()
        {
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CUSTOMERS VALUES(4,'Swaraj','123 vidhya nagar','swaraj@gmail.com',75489612)";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO CUSTOMERS VALUES(3,'Raj','123 thal nagar','raj@gmail.com',321456987)";
                cmd.ExecuteNonQuery();

                Console.WriteLine("Okay");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            { 
                cn.Close(); 
            }
        }
        static void DataReader()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSqlLocalDb;Initial Catalog=KTjune23;Integrated Security=true";
            cn.Open();

            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from CUSTOMERS";

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine(dr["Name"]);
                    Console.WriteLine(dr["Email"]);
                }

                Console.WriteLine();
                Console.WriteLine();

                /* dr.NextResult();
                 while (dr.Read())
                 {
                     Console.WriteLine(dr["CustID"]);
                 }*/



                dr.Close();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
}