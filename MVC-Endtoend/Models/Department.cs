using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC_Endtoend.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int FacultyId { get; set; }
      
    }
}
