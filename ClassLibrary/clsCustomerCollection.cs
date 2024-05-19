using System;
using System.Collections.Generic;
using System.Data;
using ClassLibrary; // Assuming clsDataConnection and clsCustomer are in this namespace

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();

        public clsCustomerCollection()
        {
            LoadCustomersFromDatabase();
        }

        // Load customers from the database
        private void LoadCustomersFromDatabase()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                ACustomer.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                ACustomer.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                ACustomer.ShippingAddress = Convert.ToString(DB.DataTable.Rows[Index]["ShippingAddress"]);
                // Check for DBNull before converting to DateTime
                if (DB.DataTable.Rows[Index]["AccountCreationDate"] != DBNull.Value)
                {
                    ACustomer.AccountCreationDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["AccountCreationDate"]);
                }
                else
                {
                    // Handle DBNull case appropriately, maybe assign a default value or handle it differently
                    ACustomer.AccountCreationDate = DateTime.MinValue; // For example, assign a default value
                }
                ACustomer.IsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);
                mCustomerList.Add(ACustomer);
                Index++;
            }
        }

        public List<clsCustomer> CustomerList
        {
            get { return mCustomerList; }
            set { mCustomerList = value; }
        }

        public int Count
        {
            get { return mCustomerList.Count; }
            // No need to define a set accessor here
        }

        public clsCustomer ThisCustomer
        {
            get { return mThisCustomer; }
            set { mThisCustomer = value; }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FullName", mThisCustomer.FullName);
            DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            DB.AddParameter("@ShippingAddress", mThisCustomer.ShippingAddress);
            DB.AddParameter("@AccountCreationDate", mThisCustomer.AccountCreationDate);
            DB.AddParameter("@IsActive", mThisCustomer.IsActive);
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@FullName", mThisCustomer.FullName);
            DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            DB.AddParameter("@ShippingAddress", mThisCustomer.ShippingAddress);
            DB.AddParameter("@AccountCreationDate", mThisCustomer.AccountCreationDate);
            DB.AddParameter("@IsActive", mThisCustomer.IsActive);
            DB.Execute("sproc_tblCustomer_Update");
        }
    }
}
