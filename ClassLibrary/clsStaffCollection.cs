using System;
using System.Collections.Generic;
using System.Data;

namespace ClassLibrary
{
    public class clsStaffCollection
    {

        public clsStaffCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                //create a blank staff object
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record
                // Copy the data from the database to the private data members
                AStaff.EmployeeId = Convert.ToInt32(DB.DataTable.Rows[Index]["EmployeeId"]);
                AStaff.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                AStaff.Role = Convert.ToString(DB.DataTable.Rows[Index]["Role"]);
                AStaff.ContactEmail = Convert.ToString(DB.DataTable.Rows[Index]["ContactEmail"]);
                AStaff.ContactPhone = Convert.ToString(DB.DataTable.Rows[Index]["ContactPhone"]);
                AStaff.Department = Convert.ToString(DB.DataTable.Rows[Index]["Department"]);
                AStaff. IsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }
        }
        // private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        // private member data for ThisStaff
        clsStaff mThisStaff = new clsStaff();
        public List<clsStaff> StaffList
        {
            get { return mStaffList; }
            set { mStaffList = value; }
        }
        // Public property to hold a single staff object
        public clsStaff ThisStaff
        {
            get
            {
                // return the private data
                return mThisStaff;
            }
            set
            {
                // set the private data
                mThisStaff = value;
            }
        }
        public int Count
        {
            get { return mStaffList.Count; }
            set { /* We can ignore  */ }
        }

        public int Add()
        {
            // adds a record to the database based on the values of mThisStaff
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@FullName", mThisStaff.FullName);
            DB.AddParameter("@Role", mThisStaff.Role);
            DB.AddParameter("@ContactEmail", mThisStaff.ContactEmail);
            DB.AddParameter("@ContactPhone", mThisStaff.ContactPhone);
            DB.AddParameter("@Department", mThisStaff.Department);
            DB.AddParameter("@IsActive", mThisStaff.IsActive);
            // execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
           
                // Update an existing record based on the values of mThisStaff
                // Connect to the database
                clsDataConnection DB = new clsDataConnection();

                // Set the parameters for the new stored procedure
                DB.AddParameter("@EmployeeId", mThisStaff.EmployeeId);
                DB.AddParameter("@FullName", mThisStaff.FullName);
                DB.AddParameter("@Role", mThisStaff.Role);
                DB.AddParameter("@ContactPhone", mThisStaff.ContactPhone);
                DB.AddParameter("@ContactEmail", mThisStaff.ContactEmail);
                DB.AddParameter("@Department", mThisStaff.Department);
                DB.AddParameter("@IsActive", mThisStaff.IsActive);

                // Execute the stored procedure
                DB.Execute("sproc_tblStaff_Update");
         

        }
    }
}