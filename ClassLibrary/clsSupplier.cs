using System;
using System.Net;

namespace ClassLibrary
{

    public class clsSupplier
    {
        // Private data members for the supplier properties
        private int mSupplierID;
        private string mSupplierName;
        private string mContactName;
        private string mContactEmail;
        private string mContactPhone;
        private string mSupplierAddress;
        private bool mIsActive;

        // SupplierID public property
        public int SupplierID
        {
            get { return mSupplierID; }
            set { mSupplierID = value; }
        }

        // SupplierName public property
        public string SupplierName
        {
            get { return mSupplierName; }
            set { mSupplierName = value; }
        }

        // ContactName public property
        public string ContactName
        {
            get { return mContactName; }
            set { mContactName = value; }
        }

        // ContactEmail public property
        public string ContactEmail
        {
            get { return mContactEmail; }
            set { mContactEmail = value; }
        }

        // ContactPhone public property
        public string ContactPhone
        {
            get { return mContactPhone; }
            set { mContactPhone = value; }
        }

        // SupplierAddress public property
        public string SupplierAddress
        {
            get { return mSupplierAddress; }
            set { mSupplierAddress = value; }
        }

        // IsActive public property
        public bool IsActive
        {
            get { return mIsActive; }
            set { mIsActive = value; }
        }

        // Find method
        public bool Find(int SupplierID)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the supplier ID to search for
            DB.AddParameter("@SupplierID", SupplierID);
            // Execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterBySupplierID");
            // If one record is found (there should be one or zero)
            if (DB.Count == 1)
            {
                // Copy the data from the database to the private data members
                mSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mContactName = Convert.ToString(DB.DataTable.Rows[0]["ContactName"]);
                mContactPhone = Convert.ToString(DB.DataTable.Rows[0]["ContactPhone"]);
                mSupplierAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mContactEmail = Convert.ToString(DB.DataTable.Rows[0]["ContactEmail"]);
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
        // Validation method
        public string Valid(string supplierName, string supplierContactName, string supplierContactEmail, string supplierContactPhone, string supplierAddress)
        {
            string error = "";

            // Validate Supplier Name
            if (string.IsNullOrWhiteSpace(supplierName))
            {
                error += "Supplier Name cannot be blank. ";
            }
            if (supplierName.Length > 50)
            {
                error += "Supplier Name must be less than 50 characters. ";
            }

            // Validate Supplier Contact Email
            if (supplierContactEmail.Length < 11)
            {
                error += "Supplier Contact Email is too short ";
            }
            if (supplierContactEmail.Length > 50)
            {
                error += "Supplier Contact Email must be less than 50 characters. ";
            }

            // Validate Supplier Contact Phone
            if (supplierContactPhone.Length < 2)
            {
                error += "Supplier Contact Phone is too short. ";
            }
            if (supplierContactPhone.Length > 16)
            {
                error += "Supplier Contact Phone is too long. ";
            }

            // Validate Supplier Address
            if (string.IsNullOrWhiteSpace(supplierAddress))
            {
                error += "Supplier Address cannot be blank. ";
            }
            if (supplierAddress.Length > 100)
            {
                error += "Supplier Address must be less than 100 characters. ";
            }

            // Validate Supplier Contact Name
            if (string.IsNullOrWhiteSpace(supplierContactName))
            {
                error += "Supplier Contact Name cannot be blank. ";
            }
            if (supplierContactName.Length > 50)
            {
                error += "Supplier Contact Name must be less than 50 characters. ";
            }

            return error;
        }
    }
}
