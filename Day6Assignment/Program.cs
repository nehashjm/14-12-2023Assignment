//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Day6Assignment
//{
//    internal class Program
//    {
//        static SqlConnection con;
//        static SqlCommand cmd;
//        static SqlDataReader reader;
//        static string constr = "server=DESKTOP-0GDER0O;database=ProductInventoryDb;trusted_connection=true;";
//        static void Main(string[] args)
//        {
//            try
//            {
//                con = new SqlConnection(constr);
//                cmd = new SqlCommand
//                {
//                    Connection = con,
//                    CommandText = "select * from Products"
//                };
//                con.Open();
//                reader = cmd.ExecuteReader();
//                Console.WriteLine("Id \t Name \t Price \t Quantity \t mfgdate \t expdate");
//                while (reader.Read())
//                {
//                    Console.Write(reader[0] + "\t");
//                    Console.Write(reader[1] + "\t");
//                    Console.Write(reader[2] + "\t");
//                    Console.Write(reader[3] + "\t");
//                    Console.Write(reader[4] + "\t");
//                    Console.Write(reader[5] + "\t");
//                }
//            }
//            catch (Exception ex) 
//            {
//                Console.WriteLine("error"+ex.Message);
//            }
//            finally 
//            {
//                con.Close();
//                Console.ReadKey();
//            }
//        }
//    }
//}

// Add new Product
//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Day6Assignment
//{
//    internal class Program
//    {
//        static SqlConnection con;
//        static SqlCommand cmd;

//        static string constr = "server=DESKTOP-0GDER0O;database=ProductInventoryDb;trusted_connection=true;";
//        static void Main(string[] args)
//        {
//            try
//            {
//                con = new SqlConnection(constr);
//                cmd = new SqlCommand
//                {
//                    Connection = con,
//                    CommandText = "insert into Products(ProductID,ProductName,Price,Quantity,MfgDate,ExpDate) values (@id,@name,@price,@qty,@mfgdate,@expdate)"
//                };
//                Console.WriteLine("enter Product id");
//                cmd.Parameters.AddWithValue("@id", int.Parse(Console.ReadLine()));
//                Console.WriteLine("enter product name");
//                cmd.Parameters.AddWithValue("@name", Console.ReadLine());
//                Console.WriteLine("enter Product price");
//                cmd.Parameters.AddWithValue("@price", int.Parse(Console.ReadLine()));
//                Console.WriteLine("enter Product quantity");
//                cmd.Parameters.AddWithValue("@qty", int.Parse(Console.ReadLine()));
//                Console.WriteLine("enter manufacturing date");
//                cmd.Parameters.AddWithValue("@mfgdate", DateTime.Parse(Console.ReadLine()));
//                Console.WriteLine("enter expiry date");
//                cmd.Parameters.AddWithValue("@expdate", DateTime.Parse(Console.ReadLine()));
//                con.Open();
//                cmd.ExecuteNonQuery();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("error" + ex.Message);
//            }
//            finally
//            {
//                con.Close();
//                Console.ReadKey();
//            }
//        }
//    }
//}
//update a product

//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Day6Assignment
//{
//    internal class Program
//    {
//        static SqlConnection con;
//        static SqlCommand cmd;

//        static string constr = "server=DESKTOP-0GDER0O;database=ProductInventoryDb;trusted_connection=true;";
//        static void Main(string[] args)
//        {
//            try
//            {
//                con = new SqlConnection(constr);
//                cmd = new SqlCommand
//                {
//                    Connection = con,
//                    CommandText = "update Products set ProductName=@name,Price=@price,Quantity=@qty,MfgDate=@mfgdate,ExpDate=@expdate where ProductID=@id"
//                   // CommandText = "insert into Products(ProductID,ProductName,Price,Quantity,MfgDate,ExpDate) values (@id,@name,@price,@qty,@mfgdate,@expdate)"
//                };
//                Console.WriteLine("enter Product id");
//                cmd.Parameters.AddWithValue("@id", int.Parse(Console.ReadLine()));
//                Console.WriteLine("enter product name");
//                cmd.Parameters.AddWithValue("@name", Console.ReadLine());
//                Console.WriteLine("enter Product price");
//                cmd.Parameters.AddWithValue("@price", int.Parse(Console.ReadLine()));
//                Console.WriteLine("enter Product quantity");
//                cmd.Parameters.AddWithValue("@qty", int.Parse(Console.ReadLine()));
//                Console.WriteLine("enter manufacturing date");
//                cmd.Parameters.AddWithValue("@mfgdate", DateTime.Parse(Console.ReadLine()));
//                Console.WriteLine("enter expiry date");
//                cmd.Parameters.AddWithValue("@expdate", DateTime.Parse(Console.ReadLine()));
//                con.Open();
//                int noe = cmd.ExecuteNonQuery();
//                if(noe > 0)
//                {
//                    Console.WriteLine("record updated");
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("error" + ex.Message);
//            }
//            finally
//            {
//                con.Close();
//                Console.ReadKey();
//            }
//        }
//    }
//}
//Deleting the element
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment
{
    internal class Program
    {
        static SqlConnection con;
        static SqlCommand cmd;

        static string constr = "server=DESKTOP-0GDER0O;database=ProductInventoryDb;trusted_connection=true;";
        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection(constr);
                cmd = new SqlCommand
                {
                    Connection = con,
                    CommandText = "delete from Products where ProductID=@id"
                };
                Console.WriteLine("enter Product id");
                cmd.Parameters.AddWithValue("@id", int.Parse(Console.ReadLine()));
                con.Open();
                int noe = cmd.ExecuteNonQuery();
                if(noe>0)
                {
                    Console.WriteLine("record deleted");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex.Message);
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }
    }
}