using System;

namespace MVC_Endtoend.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime  DOB { get; set; }
        public int DepartmentId { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
    }
}
