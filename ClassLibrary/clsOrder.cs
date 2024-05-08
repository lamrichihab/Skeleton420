namespace ClassLibrary
{
    public class clsOrder
    {
        // Primary key for the Order
        public int OrderId { get; set; }

        // Primary key for the Customer
        public int CustomerId { get; set; }

        // Primary key for the Employee
        public int EmployeeId { get; set; }

        // Order date
        public System.DateTime OrderDate { get; set; }

        // Required Order date
        public System.DateTime RequiredDate { get; set; }

        public bool Shipped { get; set; }

      
        
        }
    }
