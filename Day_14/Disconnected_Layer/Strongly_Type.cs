using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Disconnected_Layer
{
    internal class Strongly_Type
    {
        private String _connectionstring;
        public Strongly_Type(IConfiguration configuration) 
        {
            _connectionstring = configuration.GetConnectionString("Default");
        }
        SqlConnection GetConnection() 
        {
            return new SqlConnection(_connectionstring);
            
        }
        public DataTable GetList() 
        {
            SqlConnection con= GetConnection();

            DataAdapter dataAdapter = new SqlDataAdapter("Select * from Employee", con);
            DataSet dataSet = new DataSet();
            dataAdapter.FillSchema(dataSet, SchemaType.Source);
            dataAdapter.Fill(dataSet);
            Console.WriteLine(dataSet.GetXml());
            dataSet.Tables[0].TableName = "Employee";
            DataTable dt = dataSet.Tables["Employee"];
            return dt;
        }
        

    }

}
