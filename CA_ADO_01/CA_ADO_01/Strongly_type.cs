using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ADO_01
{
    internal class Strongly_type
    {
        private string _connectionString;
        public Strongly_type(IConfiguration iconfiguration)
        {
            _connectionString = iconfiguration.GetConnectionString("Default");
        }
        public SqlConnection getconnection()
        {
            SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString = _connectionString;
            return sqlconn;
        }

        public int AddData(Employee e)
        {
            SqlConnection sqlconn = null;
            SqlCommand sqlcmd;
            int record = 0;
            try
            {
                sqlconn = getconnection();
                sqlcmd = new SqlCommand("storedata", sqlconn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
              
                sqlcmd.Parameters.Add("@pname", SqlDbType.NVarChar).Value = e.Name;
                sqlcmd.Parameters.AddWithValue("@psalary", SqlDbType.Float).Value = e.Salary;
                sqlconn.Open();
                record = sqlcmd.ExecuteNonQuery();
            }
            catch (SqlException se)
            { Console.WriteLine(se.Message); }
            finally
            {
                sqlconn.Close();
                 }
            return record;

        }
        public Employee search(int id)
        {
            SqlConnection sqlconn = null;
            SqlCommand sqlcmd;
           Employee p = null;
            try
            {
                sqlconn = getconnection();
                sqlconn.Open();
                sqlcmd = new SqlCommand("select * from Employee where id=@pid", sqlconn);
                sqlcmd.Parameters.AddWithValue("@pid", id);
                SqlDataReader rd = sqlcmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        // int.TryParse("rd[Id"]", out r) ;
                        p = new Employee();
                        p.Id = Convert.ToInt32(rd["Id"]);
                        p.Name = rd["Name"].ToString();
                        p.Salary = Convert.ToSingle(rd["Salary"]);
                        break;
                    }
                }
            }
            catch (SqlException se)
            { Console.WriteLine(se.Message); }
            finally
            {
                sqlconn.Close();
            }

            return p;
        }
        public List<Employee> search(string name)
        {
            SqlConnection sqlconn = null;
            SqlCommand sqlcmd;
            List<Employee> pl = null;
            try
            {

                sqlconn = getconnection();
                sqlconn.Open();
                sqlcmd = new SqlCommand("select * from Employee where name=@pid", sqlconn);
                sqlcmd.Parameters.AddWithValue("@pid", name);
                SqlDataReader rd = sqlcmd.ExecuteReader();
                if (rd.HasRows)
                {
                    pl = new List<Employee>();
                    while (rd.Read())
                    {
                        Employee p = new Employee();
                        p.Id = Convert.ToInt32(rd["Id"]);
                        p.Name = rd["Name"].ToString();
                        p.Salary = Convert.ToSingle(rd["Salary"]);
                        pl.Add(p);
                    }
                }
            }
            catch (SqlException se)
            { Console.WriteLine(se.Message); }
            finally
            {
                sqlconn.Close();

            }

            return pl;
        }
        public int Del(int id)
        {
            SqlConnection sqlconn = null;
            SqlCommand sqlcmd;
            int no = 0;

            using (sqlconn = getconnection())
            {
                try
                {
                    sqlconn.Open();
                    sqlcmd = new SqlCommand("delete from Employee where id=@pid", sqlconn);
                    sqlcmd.Parameters.AddWithValue("@pid", id);
                    no = sqlcmd.ExecuteNonQuery();
                }
                catch (SqlException se)
                { Console.WriteLine(se.Message); }
            }


            return no;
        }
        public List<Employee> GetList()
        {
            var listEmployee = new List<Employee>();
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SP_emp_GET_LIST", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        listEmployee.Add(new Employee
                        {
                            Id = Convert.ToInt32(rdr["Id"]),
                            Name = rdr["Name"].ToString(),
                            Salary = Convert.ToSingle(rdr["Salary"])
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listEmployee;
        }
    }
}


