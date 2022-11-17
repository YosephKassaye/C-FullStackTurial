using System.ComponentModel.DataAnnotations;

namespace MVC_Endtoend.Models
{
    public class Faculty
    {
        [Key]
        public int FacultyId { get; set; }
        public string FacultyName { get; set; }
    }
}
