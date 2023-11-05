using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;

namespace HRDatabaseEmployeeTable
{
    internal class StronglyType
    {
        private String _connetctionstring;
        public StronglyType(IConfiguration _iconfiguration)
        {
            _connetctionstring = _iconfiguration.GetConnectionString("Default");
        }
        SqlConnection GetConnection()
        {
            return new SqlConnection(_connetctionstring);
        }
        public void Insert_Employee(Employee e)
        {
            try
            {
                SqlConnection con = GetConnection();
                SqlCommand cmd = new SqlCommand("@Insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@pid", SqlDbType.Int).Value = e.Id;
                cmd.Parameters.Add("@psalary", SqlDbType.Float).Value = e.Salary;
                cmd.Parameters.Add("@pgender", SqlDbType.Char).Value = e.Gender;
                cmd.Parameters.Add("@paddress", SqlDbType.NVarChar).Value = e.Address;
                cmd.Parameters.Add("@pname", SqlDbType.NVarChar).Value = e.Name;
                con.Open();
                Console.WriteLine("Connected");
                int record = cmd.ExecuteNonQuery();
                Console.WriteLine("Insert Command executed and Affected Rows = " + record);
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void Delete(int id)
        {
            try
            {
                SqlConnection con = GetConnection();
                SqlCommand cmd = new SqlCommand("@Delete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@pid", SqlDbType.Int).Value = id;
                con.Open();
                Console.WriteLine("Connected");
                int record = cmd.ExecuteNonQuery();
                Console.WriteLine(" Delete Command executed and Affected Rows = " + record);
                con.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void Show_Table()
        {
            try
            {
                SqlConnection con = GetConnection();
                SqlCommand cmd = new SqlCommand("@ShowData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                Console.WriteLine("connected");
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0} {1} {2} {3} {4}",
                        reader["Id"], reader["Name"], reader["Salary"], reader["Gender"], reader["Address"]);
                    }
                    //Console.WriteLine("End Of Table"); 

                }
                Console.WriteLine("End Of Table");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void Update_Employee(Employee e, int id)
        {
            try
            {
                SqlConnection con = GetConnection();
                SqlCommand cmd = new SqlCommand("@Update", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@pid", SqlDbType.Int).Value = e.Id;
                cmd.Parameters.Add("@psalary", SqlDbType.Float).Value = e.Salary;
                cmd.Parameters.Add("@pgender", SqlDbType.Char).Value = e.Gender;
                cmd.Parameters.Add("@paddress", SqlDbType.NVarChar).Value = e.Address;
                cmd.Parameters.Add("@pname", SqlDbType.NVarChar).Value = e.Name;
                cmd.Parameters.Add("@PCID", SqlDbType.Int).Value = id;
                con.Open();
                Console.WriteLine("Connected");
                int record = cmd.ExecuteNonQuery();
                Console.WriteLine("Update Command executed and Affected Rows = " + record);
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public List<Employee> GetEmployees()
        {
            var elist = new List<Employee>();
            try
            {

                SqlConnection con = GetConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee", con);
                con.Open();
                Console.WriteLine("Connected");
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        Employee emp = new Employee();
                        emp.Id = Convert.ToInt32(rdr["Id"]);
                        emp.Salary = Convert.ToSingle(rdr["Salary"]);
                        emp.Name = Convert.ToString(rdr["Name"]);
                        emp.Address = Convert.ToString(rdr["Address"]);
                        emp.Gender = Convert.ToString(rdr["Gender"]);
                        elist.Add(emp);
                    }
                    Console.WriteLine("list updated");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return elist;
        }
        public List<Employee> GetOneRecord(int id)
        {
            List<Employee> elist = new List<Employee>();
            try
            {
                SqlConnection con = GetConnection();
                SqlCommand cmd = new SqlCommand("Select * from Employee where Id=@pid", con);
                cmd.Parameters.AddWithValue("@pid", id).Value=id;
                con.Open();
                Console.WriteLine("Connected");
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        elist.Add(new Employee
                        {
                            Id = id,
                            Name = rdr["Name"].ToString(),
                            Salary = Convert.ToInt32(rdr["Salary"]),
                            Address = rdr["Address"].ToString(),
                            Gender = rdr["Gender"].ToString()
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
    }
}
        
        


  