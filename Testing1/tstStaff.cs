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
            staff.EmployeeID = testData;

            // Assert
            Assert.AreEqual(staff.EmployeeID, testData);
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
    }
}
