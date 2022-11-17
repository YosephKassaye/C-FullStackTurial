

using System.ComponentModel.DataAnnotations;

namespace MVC_Endtoend.Models
{
    public class Course
    {

        [Key]
        public string cono { get; set; }
        public string Cotitle { get; set; }
        public int CrHr { get; set; }
    }
}
