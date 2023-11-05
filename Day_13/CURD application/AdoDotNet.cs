using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CURD_application
{
    internal class AdoDotNet
    {
        private String _connetionstring;
        public AdoDotNet(IConfiguration connetionstrings) 
        {
            _connetionstring=connetionstrings.GetConnectionString("Default");
        }
        public SqlConnection GetConnetion() 
        {
            SqlConnection sql = new SqlConnection(_connetionstring);
                return sql;
            
        }
         
        public void Insert_Products(Customer e) 
        {
            
            try
            {
                SqlConnection sql = GetConnetion();
                SqlCommand cmd = new SqlCommand("@Insert", sql);
                cmd.CommandType = CommandType.StoredProcedure;

                
                cmd.Parameters.Add("@pname", SqlDbType.NVarChar).Value = e.Name;
                cmd.Parameters.AddWithValue("@paddress", SqlDbType.NVarChar).Value = e.Address;
                cmd.Parameters.Add("@pmobileNumber", SqlDbType.NVarChar).Value = e.MobileNumber;

                sql.Open();
                Console.WriteLine("Connected");
                int record = cmd.ExecuteNonQuery();
                Console.WriteLine("Rows  Affected = " + record);
            }
            catch (SqlException se)
            { Console.WriteLine(se.Message); }

        }
        public void Products() 
        {
            try
            {
                SqlConnection sql = GetConnetion();
                SqlCommand cmd = new SqlCommand("Select * From Customer", sql); sql.Open();

                Console.WriteLine("connected");
                SqlDataReader rdr = cmd.ExecuteReader(); //returns object of sqldatareder
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        Console.WriteLine("{0} {1} {2} {3}", rdr["Id"], rdr["Name"], rdr["Address"], rdr["MobileNumber"]);
                    }
                }
            }



            catch (SqlException se)
            { Console.WriteLine(se.Message); }
        }
        public List<Customer> Show_Data() 
        {
            List<Customer> elist=new List<Customer>();
            try
            {
                SqlConnection con = GetConnetion();
                SqlCommand cmd = new SqlCommand("@ShowData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                Console.WriteLine("Connected");
                SqlDataReader rdr=cmd.ExecuteReader();
                if (rdr.HasRows) 
                {
                        while (rdr.Read()) 
                        {
                        elist.Add(new Customer
                        {
                            Name = Convert.ToString(rdr["Name"]),
                            Address = Convert.ToString(rdr["Address"]),
                            Id = Convert.ToInt32(rdr["Id"]),
                            MobileNumber = rdr["MobileNumber"].ToString(),
                        });
                        }
                }
                

            }
            catch (Exception e) 
            {
                Console.WriteLine(e);
            }
            return elist;
        }

        public void Delete_Record(int id) 
        {
            try 
            {
                SqlConnection con = GetConnetion();
                SqlCommand cmd = new SqlCommand("DELETE FROM Customer WHERE Id=@pid", con);
                cmd.Parameters.AddWithValue("@pid", id);
                con.Open();
                Console.WriteLine("Connected");
                int Record = cmd.ExecuteNonQuery();
                Console.WriteLine("Rows Affected = "+Record);
            }
            catch(Exception e) 
            {
                Console.WriteLine(e);
            }
        }
        public void Update_Data(Customer e, int id) 
        {
            try 
            {
                SqlConnection con = GetConnetion();
                SqlCommand cmd = new SqlCommand("UPDATE Customer SET Name=@pname WHERE Id=@pid", con);
                cmd.Parameters.AddWithValue("@pname", e.Name);
                cmd.Parameters.AddWithValue("@pid", id);
                con.Open();
                Console.WriteLine("Connected");
                int record = cmd.ExecuteNonQuery();
                Console.WriteLine("Rows Affected = " + record);
            }
            catch
            (Exception ex) 
            {
                Console.WriteLine(ex);
            }
        }
        public List<Customer> Search(int id) {
            List<Customer> elist = new List<Customer>();
            try
            {
                SqlConnection con = GetConnetion();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer Where Id=@pid", con);
                cmd.Parameters.AddWithValue("@pid", id);
                con.Open();
                Console.WriteLine("Connected");
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    Console.WriteLine("Search Found");
                    while (rdr.Read())
                    {
                        
                        elist.Add(new Customer
                        {
                            Name = Convert.ToString(rdr["Name"]),
                            Address = Convert.ToString(rdr["Address"]),
                            Id = Convert.ToInt32(rdr["Id"]),
                            MobileNumber = rdr["MobileNumber"].ToString(),
                        });
                        break;
                    }
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return elist;
        }
        public List<Customer> Search(String Name,String Mob) 
        {
            List<Customer> elist = new List<Customer>();
            try
            {
                SqlConnection con = GetConnetion();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer Where Name=@name AND MobileNumber=@mob", con);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@mob", Mob);
                con.Open();
                Console.WriteLine("Connected");
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    Console.WriteLine("Search Found");
                    while (rdr.Read())
                    {
                        
                        elist.Add(new Customer
                        {
                            Name = Convert.ToString(rdr["Name"]),
                            Address = Convert.ToString(rdr["Address"]),
                            Id = Convert.ToInt32(rdr["Id"]),
                            MobileNumber = rdr["MobileNumber"].ToString(),
                        });

                        
                    }
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return elist;

        }



    }
            

}

  
