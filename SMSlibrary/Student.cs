using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSlibrary
{
   public   class Student 
    {
        public Student()
        {

        }
        // field, property, varaiable 
        public int StudentId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        private string SSN;


        public string GetStudentInfo()
        {
            string connstring = "Data Source=.; Initial Catalog=SMS_NEW;  Trusted_Connection=True;";
            string query = "Select * from Student where Gender='F'";
            SqlDataReader dataReader;
            string output = "";
          using (SqlConnection conn= new SqlConnection(connstring))
            {
              SqlCommand comm = new SqlCommand(query, conn);
                comm.Connection.Open();

                dataReader = comm.ExecuteReader();

                while (dataReader.Read())
                {
                    output = output + dataReader.GetValue(1) + " " + dataReader.GetValue(2) + "\n";
                }
                
            }

            return output;

        }
         
        public int GetAge()
        {
            var dobyear = DOB.Year;
            var cyear = DateTime.Now.Year;

            return cyear - dobyear;

        }

    }
}
