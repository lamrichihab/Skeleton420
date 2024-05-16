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
        // Validation method
        public string Valid(int employeeId, string fullName, string role, string contactPhone, string contactEmail, string department)
        {
            // Variable to store the error message
            string errorMessage = "";

            // Perform validation checks
            if (string.IsNullOrWhiteSpace(fullName))
            {
                errorMessage += "Full name is required.\n";
            }

            if (string.IsNullOrWhiteSpace(role))
            {
                errorMessage += "Role is required.\n";
            }

            // Add more validation checks as needed...

            // Return the error message
            return errorMessage;
        }
    }
}
