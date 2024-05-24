using System;
using System.Text.RegularExpressions;

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

        // Valid method
        public string Valid(string fullName, string emailAddress, string phoneNumber, string shippingAddress, DateTime accountCreationDate, bool isActive)
        {
            // String variable to store any error message
            string error = "";

            // Check if full name is provided
            if (string.IsNullOrWhiteSpace(fullName))
            {
                error = "Full name is required.";
            }
            else if (fullName.Length > 50) // Assuming maximum length is 50 characters
            {
                error = "Full name cannot exceed 50 characters.";
            }

            // Check if email address is provided
            if (string.IsNullOrWhiteSpace(emailAddress))
            {
                error = "Email address is required.";
            }
            else if (emailAddress.Length > 245) // Assuming maximum length is 245 characters
            {
                error = "Email address cannot exceed 250 characters.";
            }

            // Check if phone number is provided
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                error = "Phone number is required.";
            }
            else if (phoneNumber.Length > 40) // Assuming maximum length is 15 characters
            {
                error = "Phone number cannot exceed 40 characters.";
            }

            // Check if shipping address is provided
            if (string.IsNullOrWhiteSpace(shippingAddress))
            {
                error = "Shipping address is required.";
            }
            else if (shippingAddress.Length > 100) // Assuming maximum length is 100 characters
            {
                error = "Shipping address cannot exceed 100 characters.";
            }

            // You can add more validation rules as needed...

            return error;
        }

    }
}
