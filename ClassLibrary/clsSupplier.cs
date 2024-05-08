using System;

namespace ClassLibrary
{

    public class clsSupplier
    {
        // Properties
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }

        // Constructor
        public clsSupplier()
        {
            // Default constructor
        }
    }
}
