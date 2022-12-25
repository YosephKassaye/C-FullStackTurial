using System.ComponentModel.DataAnnotations;

namespace MVC_Endtoend.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
