using System;
using System.Data.OleDb;

namespace ClassLibrary
{
    public class clsStaff
    {
        // Private data members
        private int mEmployeeId;
        private string mFullName;
        private string mRole;
        private string mContactPhone;
        private string mContactEmail;
        private string mDepartment;
        private bool mIsActive;

        // EmployeeID public property
        public int EmployeeId
        {
            get { return mEmployeeId; }
            set { mEmployeeId = value; }
        }

        // FullName public property
        public string FullName
        {
            get { return mFullName; }
            set { mFullName = value; }
        }

        // Role public property
        public string Role
        {
            get { return mRole; }
            set { mRole = value; }
        }

        // ContactPhone public property
        public string ContactPhone
        {
            get { return mContactPhone; }
            set { mContactPhone = value; }
        }

        // ContactEmail public property
        public string ContactEmail
        {
            get { return mContactEmail; }
            set { mContactEmail = value; }
        }

        // Department public property
        public string Department
        {
            get { return mDepartment; }
            set { mDepartment = value; }
        }

        // IsActive public property
        public bool IsActive
        {
            get { return mIsActive; }
            set { mIsActive = value; }
        }

        // FIND METHOD
        public bool Find(int EmployeeId)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the employee id to search for
            DB.AddParameter("@EmployeeId", EmployeeId);
            // Execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByEmployeeID");
            // If one record is found (there should be one or zero)
            if (DB.Count == 1)
            {
                // Copy the data from the database to the private data members
                mEmployeeId = Convert.ToInt32(DB.DataTable.Rows[0]["EmployeeId"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mRole = Convert.ToString(DB.DataTable.Rows[0]["Role"]);
                mContactEmail = Convert.ToString(DB.DataTable.Rows[0]["ContactEmail"]);
                mContactPhone = Convert.ToString(DB.DataTable.Rows[0]["ContactPhone"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
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

        public string Valid(string fullname, string contactemail, string contactphone, string department, string role)
        {
            String Error = "";
            //If the fullname is blank
            if (fullname.Length == 0)
            {
                Error = Error + "The Fullname may not be blank : ";
            }
            if (fullname.Length > 50)
            {
                Error = Error + "The Fullname must be less than 50 characters : ";
            }
            //if the email is blank
            if (contactemail.Length < 10)
            {
                Error = Error + "The Contact email may not be blank : ";
            }
            if (contactemail.Length > 50)
            {
                Error = Error + "The Contact email must be less than 50 characters : ";
            }
            //if the phone is blank
            if (contactphone.Length < 2)
            {
                Error = Error + "the phone number is too short";
            }
            if (contactphone.Length > 16)
            {
                Error = Error + "The phone number is too long";
            }

            //if the role is blank
            if (role.Length == 0)
            {
                Error = Error + "the role may not be blank";
            }
            if (role.Length > 50)
            {
                Error = Error + "The role must be less than 50 characters : ";
            }
            //if the department is blank
            if (department.Length == 0)
            {
                Error = Error + "the department may not be blank";
            }
            if (department.Length > 50)
            {
                Error = Error + "The department must be less than 50 characters : ";
            }
            return Error;
        }
    }
}