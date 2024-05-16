using System;
using System.Data.OleDb;

namespace ClassLibrary
{
    public class clsCustomer
    {
        // Private data members for the properties
        private int mCustomerID;
        private string mFullName;
        private string mEmailAddress;
        private string mPhoneNumber;
        private string mShippingAddress;
        private DateTime mAccountCreationDate;
        private bool mIsActive;

        // CustomerID property
        public int CustomerID
        {
            get { return mCustomerID; }
            set { mCustomerID = value; }
        }

        // FullName property
        public string FullName
        {
            get { return mFullName; }
            set { mFullName = value; }
        }

        // EmailAddress property
        public string EmailAddress
        {
            get { return mEmailAddress; }
            set { mEmailAddress = value; }
        }

        // PhoneNumber property
        public string PhoneNumber
        {
            get { return mPhoneNumber; }
            set { mPhoneNumber = value; }
        }

        // ShippingAddress property
        public string ShippingAddress
        {
            get { return mShippingAddress; }
            set { mShippingAddress = value; }
        }

        // AccountCreationDate property
        public DateTime AccountCreationDate
        {
            get { return mAccountCreationDate; }
            set { mAccountCreationDate = value; }
        }

        // IsActive property
        public bool IsActive
        {
            get { return mIsActive; }
            set { mIsActive = value; }
        }
        // Valid method
        public string Valid()
        {
            // String variable to store any error message
            string error = "";

            // Check if full name is provided
            if (string.IsNullOrWhiteSpace(FullName))
            {
                error = "Full name is required.";
            }

            // Check if email address is provided
            if (string.IsNullOrWhiteSpace(EmailAddress))
            {
                error = "Email address is required.";
            }

            // Check if phone number is provided
            if (string.IsNullOrWhiteSpace(PhoneNumber))
            {
                error = "Phone number is required.";
            }

            // Check if shipping address is provided
            if (string.IsNullOrWhiteSpace(ShippingAddress))
            {
                error = "Shipping address is required.";
            }

            // You can add more validation rules as needed...

            return error;
        }
        // Find method
        public bool Find(int CustomerID)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the customer ID to search for
            DB.AddParameter("@CustomerID", CustomerID);
            // Execute the stored procedure or query to retrieve data
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");

            // If one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                // Copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mShippingAddress = Convert.ToString(DB.DataTable.Rows[0]["ShippingAddress"]);
                mAccountCreationDate = Convert.ToDateTime(DB.DataTable.Rows[0]["AccountCreationDate"]);
                mIsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["IsActive"]);

                // Return that everything worked OK
                return true;
            }
            // If no record was found
            else
            {
                // Return false indicating there is a problem
                return false;
            }
        }
    }
}
