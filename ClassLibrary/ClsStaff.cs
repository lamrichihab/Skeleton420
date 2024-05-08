using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        // Properties
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string Department { get; set; }
        public bool IsActive { get; set; }

        // Constructor
        public clsStaff()
        {
            // Default constructor
        }
    }
}
