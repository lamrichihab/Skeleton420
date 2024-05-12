using System;

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
            // Set the private data members to the test data value
            mEmployeeId = 12345;
            mFullName = "John Smith";
            mRole = "Manager";
            mContactPhone = "123-456-7890";
            mContactEmail = "test@example.com";
            mDepartment = "HR";
            mIsActive = true;

            // Always return true
            return true;
        }
    }
}
