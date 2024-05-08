using System;
namespace ClassLibrary // Adjust this to your project namespace
{
    public class clsCustomer
    {
        // Primary key for the customer
        public int CustomerID { get; set; }

        // Full name of the customer
        public string FullName { get; set; }

        // Email address of the customer
        public string EmailAddress { get; set; }

        // Phone number of the customer
        public string PhoneNumber { get; set; }

        // Shipping address for the customer
        public string ShippingAddress { get; set; }

        // Date when the account was created
        public DateTime AccountCreationDate { get; set; }

        // Boolean indicating if the customer is active
        public bool IsActive { get; set; }
    }
}
