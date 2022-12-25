using System.ComponentModel.DataAnnotations;
namespace MVC_Endtoend.Models
{
    public class Payment
    {

        [Key]
        public int PaymentId { get; set; }
        public int StudentId { get; set; }
        public float AmountDue { get; set; }
        public float AmountPaid { get; set; }
        public bool PaidInFull { get; set; }

    }
}
