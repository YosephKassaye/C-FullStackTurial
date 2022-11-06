using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertiance
{
    public  class Person: Animal
    {
 
        public string SSN { get; set; }
        public string FName { get; set; }
        public string MiddleName { get; set; }
        public string LName { get; set; }
        public string MaritalStatus { get; set; }
        public string EMergencyContact { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
    }
}
