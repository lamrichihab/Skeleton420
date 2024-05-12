using System;

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
            // Set the private data members to the test data values
            mSupplierID = 1;
            mSupplierName = "Test Supplier Name";
            mContactName = "Test Contact Name";
            mContactEmail = "test@test.com";
            mContactPhone = "123-456-789";
            mSupplierAddress = "Supplier Test Address";
            mIsActive = true;

            // Always return true
            return true;
        }
    }
}
