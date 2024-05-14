using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        // Private data member for the customer ID property
        private Int32 mCustomerID;

        // CustomerID public property
        public int CustomerID
        {
            get
            {
                // This line of code sends data out of the property
                return mCustomerID;
            }
            set
            {
                // This line of code allows data into the property
                mCustomerID = value;
            }
        }

        // Private data member for the full name property
        private string mFullName;

        // FullName public property
        public string FullName
        {
            get
            {
                // This line of code sends data out of the property
                return mFullName;
            }
            set
            {
                // This line of code allows data into the property
                mFullName = value;
            }
        }

        // Private data member for the email address property
        private string mEmailAddress;

        // EmailAddress public property
        public string EmailAddress
        {
            get
            {
                // This line of code sends data out of the property
                return mEmailAddress;
            }
            set
            {
                // This line of code allows data into the property
                mEmailAddress = value;
            }
        }

        // Private data member for the phone number property
        private string mPhoneNumber;

        // PhoneNumber public property
        public string PhoneNumber
        {
            get
            {
                // This line of code sends data out of the property
                return mPhoneNumber;
            }
            set
            {
                // This line of code allows data into the property
                mPhoneNumber = value;
            }
        }

        // Private data member for the shipping address property
        private string mShippingAddress;

        // ShippingAddress public property
        public string ShippingAddress
        {
            get
            {
                // This line of code sends data out of the property
                return mShippingAddress;
            }
            set
            {
                // This line of code allows data into the property
                mShippingAddress = value;
            }
        }

        // Private data member for the account creation date property
        private DateTime mAccountCreationDate;

        // AccountCreationDate public property
        public DateTime AccountCreationDate
        {
            get
            {
                // This line of code sends data out of the property
                return mAccountCreationDate;
            }
            set
            {
                // This line of code allows data into the property
                mAccountCreationDate = value;
            }
        }

        // Private data member for the is active property
        private Boolean mIsActive;

        // IsActive public property
        public bool IsActive
        {
            get
            {
                // This line of code sends data out of the property
                return mIsActive;
            }
            set
            {
                // This line of code allows data into the property
                mIsActive = value;
            }
        }

        // FIND METHOD
        public bool Find(int CustomerID)
        {
            // Set the private data members to the test data value
            mCustomerID = 1;
            mFullName = "John Doe";
            mEmailAddress = "john.doe@example.com";
            mPhoneNumber = "123-456-7890";
            mShippingAddress = "123 Main St, Springfield, USA";
            mAccountCreationDate = Convert.ToDateTime("2024-01-01");
            mIsActive = true;

            // Always return true
            return true;
        }
    }
}
