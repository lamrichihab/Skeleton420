using System;

namespace ClassLibrary
{
    public class clsOrderlines
    {


        // Private data members for the customer properties
        private int mProductId;
        private int mOrderId;
        private int mQuantity;
        private int mPrice;
        private string mLocation;
        private string mOrderStatus;


        // ProductId public property
        public int ProductId
        {
            get { return mProductId; }
            set { mProductId = value; }
        }

        // OrderId public property
        public int OrderId
        {
            get { return mOrderId; }
            set { mOrderId = value; }
        }

        // Quantity public property
        public int Quantity
        {
            get { return mQuantity; }
            set { mQuantity = value; }
        }

        // OrderDate public property
        public int Price
        {
            get { return mPrice; }
            set { mPrice = value; }
        }

        // RequiredDate public property
        public string Location
        {
            get { return mLocation; }
            set { mLocation = value; }
        }



        // Shipped public property
        public string OrderStatus
        {
            get { return mOrderStatus; }
            set { mOrderStatus = value; }
        }

        // Find method
        public bool Find(int ProductId)
        {
            // For demonstration purposes, let's assume ProductID 12 is found
            if (ProductId == 12)
            {
                mProductId = 12;
                mOrderId = 12;
                mQuantity = 12;
                mPrice = 12;
                mLocation = "Test Location";
                mOrderStatus = "Test OrderStatus";
                return true;
            }
            else
            {
                return false;


            }
        }


    }
}
