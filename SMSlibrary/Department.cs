using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSlibrary
{
    public class Department
    {
       
     
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public string GetDepartmentInfo()
        {
            string connstring = "Data Source=.; Initial Catalog=SMS_NEW;  Trusted_Connection=True;";
            string query = "Select * from Department";
            SqlDataReader dataReader;
            string output = "";
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                SqlCommand comm = new SqlCommand(query, conn);
                comm.Connection.Open();

                dataReader = comm.ExecuteReader();

                while (dataReader.Read())
                {
                    output = output + dataReader.GetValue(1) + "\n";
                }

            }

            return output;

        }
    }
}
