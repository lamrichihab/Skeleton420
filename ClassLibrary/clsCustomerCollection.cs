using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ClassLibrary; 

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();

        public List<clsCustomer> CustomerList
        {
            get { return mCustomerList; }
            set { mCustomerList = value; }
        }

        public int Count
        {
            get { return mCustomerList.Count; }
            set{}
        }

        public clsCustomer ThisCustomer
        {
            get { return mThisCustomer; }
            set { mThisCustomer = value; }
        }



        public clsCustomerCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            PopulateArray(DB);
        }

        // Load customers from the database
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mCustomerList = new List<clsCustomer>();
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
                    // Handle DBNull case appropriately
                    ACustomer.AccountCreationDate = DateTime.MinValue; 
                }
                ACustomer.IsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);
                mCustomerList.Add(ACustomer);
                Index++;
            }
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

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.Execute("sproc_tblCustomer_Delete"); 
        }

        public void ReportByFullName(string FullName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FullName", FullName);
            DB.Execute("sproc_tblCustomer_FilterByFullName");
            PopulateArray(DB);
        }
    }
}
