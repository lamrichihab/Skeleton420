using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public int CustomerID { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string ShippingAddress { get; set; }
        public DateTime AccountCreationDate { get; set; }
        public bool IsActive { get; set; }
    }

}
