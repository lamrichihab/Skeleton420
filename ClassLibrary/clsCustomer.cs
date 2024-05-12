using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCustomer
    {
        // Private data members for the customer properties
        private int mCustomerID;
        private string mFullName;
        private string mEmailAddress;
        private string mPhoneNumber;
        private string mShippingAddress;
        private DateTime mAccountCreationDate;
        private bool mIsActive;

        // CustomerID public property
        public int CustomerID
        {
            get { return mCustomerID; }
            set { mCustomerID = value; }
        }

        // FullName public property
        public string FullName
        {
            get { return mFullName; }
            set { mFullName = value; }
        }

        // EmailAddress public property
        public string EmailAddress
        {
            get { return mEmailAddress; }
            set { mEmailAddress = value; }
        }

        // PhoneNumber public property
        public string PhoneNumber
        {
            get { return mPhoneNumber; }
            set { mPhoneNumber = value; }
        }

        // ShippingAddress public property
        public string ShippingAddress
        {
            get { return mShippingAddress; }
            set { mShippingAddress = value; }
        }

        // AccountCreationDate public property
        public DateTime AccountCreationDate
        {
            get { return mAccountCreationDate; }
            set { mAccountCreationDate = value; }
        }

        // IsActive public property
        public bool IsActive
        {
            get { return mIsActive; }
            set { mIsActive = value; }
        }

        // Find method
        public bool Find(int customerID)
        {
            // For demonstration purposes, let's assume customerID 1 is found
            if (customerID == 1)
            {
                mCustomerID = 1;
                mFullName = "John Doe";
                mEmailAddress = "john.doe@example.com";
                mPhoneNumber = "123-456-789";
                mShippingAddress = "123 Main St, City, Country";
                mAccountCreationDate = new DateTime(2022, 5, 8);
                mIsActive = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
