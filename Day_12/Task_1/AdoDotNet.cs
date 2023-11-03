using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Task_1
{
    internal class AdoDotNet
    {
        private string _connectionString;
        public AdoDotNet(IConfiguration _iconfiguration) 
        {
            _connectionString = _iconfiguration.GetConnectionString("Default"); 
        }
        public void Products() 
        {
            using (SqlConnection con = new SqlConnection(_connectionString)) 
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee",con);
                con.Open();
                Console.WriteLine("Connected");
                SqlDataReader rdr =cmd.ExecuteReader();
                if (rdr.HasRows) 
                {
                    while(rdr.Read())
                    {
                        Console.WriteLine("{0} {1} {2}", rdr["Id"], rdr["Name"], rdr["Salary"]);
                    }
                }

            }
        }
    }
}
