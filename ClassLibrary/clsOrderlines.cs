namespace ClassLibrary
{
    public class clsOrderlines
    {
        // Primary key for the product
        public int ProductId { get; set; }

        // Primary key for the order
        public int OrderId { get; set; }

        // Quantity for the order
        public int Quantity { get; set; }

        // Price for the order
        public int Price { get; set; }

        // Location of the customer
        public string Location { get; set; }

        // Order Staus of the order
        public string OrderStatus { get; set; }
    }
}