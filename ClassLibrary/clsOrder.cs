﻿using System;

namespace ClassLibrary
{
    public class clsOrder
    {


        // Private data members for the customer properties
        private int mOrderId;
        private int mCustomerId;
        private int mEmployeeId;
        private DateTime mOrderDate;
        private DateTime mRequiredDate;
        private bool mShipped;


        // OrderId public property
        public int OrderId
        {
            get { return mOrderId; }
            set { mOrderId = value; }
        }

        // CustomerId public property
        public int CustomerId
        {
            get { return mCustomerId; }
            set { mCustomerId = value; }
        }

        // EmployeeId public property
        public int EmployeeId
        {
            get { return mEmployeeId; }
            set { mEmployeeId = value; }
        }

        // OrderDate public property
        public DateTime OrderDate
        {
            get { return mOrderDate; }
            set { mOrderDate = value; }
        }

        // RequiredDate public property
        public DateTime RequiredDate
        {
            get { return mRequiredDate; }
            set { mRequiredDate = value; }
        }



        // Shipped public property
        public bool Shipped
        {
            get { return mShipped; }
            set { mShipped = value; }
        }

        // Find method
        public bool Find(int OrderId)
        {
            // For demonstration purposes, let's assume customerID 12 is found
            if (OrderId == 12)
            {
                mOrderId = 12;
                mCustomerId = 12;
                mEmployeeId = 12;
                mOrderDate = new DateTime(2024, 5, 14);
                mRequiredDate = new DateTime(2024, 5, 24);

                mShipped = true;
                return true;
            }
            else
            {
                return false;


            }
        }

       
        }
    }

