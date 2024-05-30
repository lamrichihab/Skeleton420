using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        // Private data members for the supplier list and single supplier
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        clsSupplier mThisSupplier = new clsSupplier();

        // Public property for the supplier list
        public List<clsSupplier> SupplierList
        {
            get { return mSupplierList; }
            set { mSupplierList = value; }
        }

        // Public property for the count of suppliers
        public int Count
        {
            get { return mSupplierList.Count; }
            set { }
        }

        // Public property for the single supplier
        public clsSupplier ThisSupplier
        {
            get { return mThisSupplier; }
            set { mThisSupplier = value; }
        }

        // Constructor for the class
        public clsSupplierCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblSupplier_SelectAll");
            PopulateArray(DB);
        }

        // Method to populate the array from the data table
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mSupplierList = new List<clsSupplier>();
            while (Index < RecordCount)
            {
                clsSupplier ASupplier = new clsSupplier();
                ASupplier.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);
                ASupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                ASupplier.ContactName = Convert.ToString(DB.DataTable.Rows[Index]["ContactName"]);
                ASupplier.ContactEmail = Convert.ToString(DB.DataTable.Rows[Index]["ContactEmail"]);
                ASupplier.ContactPhone = Convert.ToString(DB.DataTable.Rows[Index]["ContactPhone"]);
                ASupplier.SupplierAddress = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                ASupplier.IsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);
                mSupplierList.Add(ASupplier);
                Index++;
            }
        }

        // Method to add a new supplier record
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@ContactName", mThisSupplier.ContactName);
            DB.AddParameter("@ContactEmail", mThisSupplier.ContactEmail);
            DB.AddParameter("@ContactPhone", mThisSupplier.ContactPhone);
            DB.AddParameter("@Address", mThisSupplier.SupplierAddress);
            DB.AddParameter("@IsActive", mThisSupplier.IsActive);
            return DB.Execute("sproc_tblSupplier_Insert");
        }

        // Method to update an existing supplier record
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", mThisSupplier.SupplierID);
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@ContactName", mThisSupplier.ContactName);
            DB.AddParameter("@ContactEmail", mThisSupplier.ContactEmail);
            DB.AddParameter("@ContactPhone", mThisSupplier.ContactPhone);
            DB.AddParameter("@Address", mThisSupplier.SupplierAddress);
            DB.AddParameter("@IsActive", mThisSupplier.IsActive);
            DB.Execute("sproc_tblSupplier_Update");
        }

        // Method to delete a supplier record
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", mThisSupplier.SupplierID);
            DB.Execute("sproc_tblSupplier_Delete");
        }

        // Method to filter suppliers by name
        public void ReportByContactName(string ContactName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ContactName", ContactName);
            DB.Execute("sproc_tblSupplier_FilterByContactName");
            PopulateArray(DB);
        }
    }
}
