using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing6
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void StaffInstanceOK()
        {
            // Arrange
            clsStaff staff = new clsStaff();

            // Act - Nothing to act upon, just creating an instance

            // Assert
            Assert.IsNotNull(staff);
        }

        [TestMethod]
        public void StaffEmployeeIDPropertyOK()
        {
            // Arrange
            clsStaff staff = new clsStaff();
            int testData = 123;

            // Act
            staff.EmployeeId = testData;

            // Assert
            Assert.AreEqual(staff.EmployeeId, testData);
        }

        [TestMethod]
        public void StaffRolePropertyOK()
        {
            // Arrange
            clsStaff staff = new clsStaff();
            string testData = "Manager";

            // Act
            staff.Role = testData;

            // Assert
            Assert.AreEqual(staff.Role, testData);
        }

        [TestMethod]
        public void StaffContactEmailPropertyOK()
        {
            // Arrange
            clsStaff staff = new clsStaff();
            string testData = "example@example.com";

            // Act
            staff.ContactEmail = testData;

            // Assert
            Assert.AreEqual(staff.ContactEmail, testData);
        }

        [TestMethod]
        public void StaffFullNamePropertyOK()
        {
            // Arrange
            clsStaff staff = new clsStaff();
            string testData = "John Doe";

            // Act
            staff.FullName = testData;

            // Assert
            Assert.AreEqual(staff.FullName, testData);
        }

        [TestMethod]
        public void StaffContactPhonePropertyOK()
        {
            // Arrange
            clsStaff staff = new clsStaff();
            string testData = "1234567890";

            // Act
            staff.ContactPhone = testData;

            // Assert
            Assert.AreEqual(staff.ContactPhone, testData);
        }

        [TestMethod]
        public void StaffDepartmentPropertyOK()
        {
            // Arrange
            clsStaff staff = new clsStaff();
            string testData = "Sales";

            // Act
            staff.Department = testData;

            // Assert
            Assert.AreEqual(staff.Department, testData);
        }

        [TestMethod]
        public void StaffIsActivePropertyOK()
        {
            // Arrange
            clsStaff staff = new clsStaff();
            bool testData = true;

            // Act
            staff.IsActive = testData;

            // Assert
            Assert.AreEqual(staff.IsActive, testData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            // Create an instance of the class we want to test
            clsStaff staff = new clsStaff();

            // Create a Boolean variable to store the results of the validation
            bool found = false;

            // Create some test data to use with the method
            int employeeId = 123; // Assuming employee with ID 123 exists

            // Invoke the method
            found = staff.Find(employeeId);

            // Test to see if the result is true
            Assert.IsTrue(found);
        }
        [TestMethod]
        public void TestStaffIsIdFound()
        {
            // Create an instance of the class we want to test
            clsStaff staff = new clsStaff();

            // Create a Boolean variable to store the result of the search
            bool found = false;

            // Create a Boolean variable to record if the data is OK (assume it is)
            bool ok = true;

            // Create some test data to use with the method
            int employeeId = 12345; // Assuming staff with ID 12345 exists

            // Invoke the method
            found = staff.Find(employeeId);

            // Check the employee ID
            if (staff.EmployeeId != 12345)
            {
                ok = false;
            }

            // Test to see that the result is correct
            Assert.IsTrue(ok);
        }
        [TestMethod]
        public void TestFullNameFound()
        {
            // Create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            // Create a Boolean variable to store the result of the search
            bool found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            bool ok = true;
            // Create some test data to use with the method
            int employeeID = 12345;
            // Invoke the method
            found = staff.Find(employeeID);
            // Check the FullName property
            if (staff.FullName != "John Smith")
            {
                ok = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestRoleFound()
        {
            // Create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            // Create a Boolean variable to store the result of the search
            bool found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            bool ok = true;
            // Create some test data to use with the method
            int employeeID = 12345;
            // Invoke the method
            found = staff.Find(employeeID);
            // Check the Role property
            if (staff.Role != "Manager")
            {
                ok = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestContactPhoneFound()
        {
            // Create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            // Create a Boolean variable to store the result of the search
            bool found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            bool ok = true;
            // Create some test data to use with the method
            int employeeID = 12345;
            // Invoke the method
            found = staff.Find(employeeID);
            // Check the ContactPhone property
            if (staff.ContactPhone != "123-456-7890")
            {
                ok = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestContactEmailFound()
        {
            // Create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            // Create a Boolean variable to store the result of the search
            bool found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            bool ok = true;
            // Create some test data to use with the method
            int employeeID = 12345;
            // Invoke the method
            found = staff.Find(employeeID);
            // Check the ContactEmail property
            if (staff.ContactEmail != "test@example.com")
            {
                ok = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestDepartmentFound()
        {
            // Create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            // Create a Boolean variable to store the result of the search
            bool found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            bool ok = true;
            // Create some test data to use with the method
            int employeeID = 12345;
            // Invoke the method
            found = staff.Find(employeeID);
            // Check the Department property
            if (staff.Department != "HR")
            {
                ok = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestIsActiveFound()
        {
            // Create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            // Create a Boolean variable to store the result of the search
            bool found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            bool ok = true;
            // Create some test data to use with the method
            int employeeID = 12345;
            // Invoke the method
            found = staff.Find(employeeID);
            // Check the IsActive property
            if (staff.IsActive != true)
            {
                ok = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(ok);
        }

    }
}
