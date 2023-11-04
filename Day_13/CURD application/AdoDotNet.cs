using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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


                            }
            

        }

  
