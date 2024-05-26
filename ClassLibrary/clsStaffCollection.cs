using System;
using System.Collections.Generic;
using System.Data;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        // private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
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

        public List<clsStaff> StaffList
        {
            get { return mStaffList; }
            set { mStaffList = value; }
        }
        public clsStaff ThisStaff { get; set; }
        public int Count
        {
            get { return mStaffList.Count; }
            set { /* We can ignore  */ }
        }
    }
}