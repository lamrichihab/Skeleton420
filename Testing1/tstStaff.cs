using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;
using System.IO;

namespace Testing6
{
    [TestClass]
    public class tstStaff
    {
        //goodtestdata
        //create some test data to pass the valid methode
        string fullname = "Mohamed Mekhalfi";
        string contactemail = "mohamedmekhalfi@gmail.com";
        string contactphone = "123456789";
        string department = "HR";
        string role = "manager";

        [TestMethod]
        public void StaffInstanceOK()
        {
            // Arrange
            clsStaff Allstaff = new clsStaff();

            // Act - Nothing to act upon, just creating an instance

            // Assert
            Assert.IsNotNull(Allstaff);
        }

        [TestMethod]
        public void StaffEmployeeIDPropertyOK()
        {
            // Arrange
            clsStaff Allstaff = new clsStaff();
            int testData = 12345;

            // Act
            Allstaff.EmployeeId = testData;

            // Assert
            Assert.AreEqual(testData, Allstaff.EmployeeId);
        }

        [TestMethod]
        public void StaffRolePropertyOK()
        {
            // Arrange
            clsStaff Allstaff = new clsStaff();
            string testData = "Manager";

            // Act
            Allstaff.Role = testData;

            // Assert
            Assert.AreEqual(testData, Allstaff.Role);
        }

        [TestMethod]
        public void StaffContactEmailPropertyOK()
        {
            // Arrange
            clsStaff Allstaff = new clsStaff();
            string testData = "example@example.com";

            // Act
            Allstaff.ContactEmail = testData;

            // Assert
            Assert.AreEqual(testData, Allstaff.ContactEmail);
        }

        [TestMethod]
        public void StaffFullNamePropertyOK()
        {
            // Arrange
            clsStaff Allstaff = new clsStaff();
            string testData = "John Doe";

            // Act
            Allstaff.FullName = testData;

            // Assert
            Assert.AreEqual(testData, Allstaff.FullName);
        }

        [TestMethod]
        public void StaffContactPhonePropertyOK()
        {
            // Arrange
            clsStaff Allstaff = new clsStaff();
            string testData = "1234567890";

            // Act
            Allstaff.ContactPhone = testData;

            // Assert
            Assert.AreEqual(testData, Allstaff.ContactPhone);
        }

        [TestMethod]
        public void StaffDepartmentPropertyOK()
        {
            // Arrange
            clsStaff Allstaff = new clsStaff();
            string testData = "Sales";

            // Act
            Allstaff.Department = testData;

            // Assert
            Assert.AreEqual(testData, Allstaff.Department);
        }

        [TestMethod]
        public void StaffIsActivePropertyOK()
        {
            // Arrange
            clsStaff Allstaff = new clsStaff();
            bool testData = true;

            // Act
            Allstaff.IsActive = testData;

            // Assert
            Assert.AreEqual(testData, Allstaff.IsActive);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            // Create an instance of the class we want to test
            clsStaff Allstaff = new clsStaff();

            // Create a Boolean variable to store the results of the validation
            bool found = false;

            // Create some test data to use with the method
            int EmployeeId = 12345; // Assuming employee with ID 123 exists

            // Invoke the method
            found = Allstaff.Find(EmployeeId);

            // Test to see if the result is true
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestStaffIsIdFound()
        {
            // Create an instance of the class we want to test
            clsStaff Allstaff = new clsStaff();

            // Create a Boolean variable to store the result of the search
            bool found = false;

            // Create a Boolean variable to record if the data is OK (assume it is)
            bool ok = true;

            // Create some test data to use with the method
            int EmployeeId = 12345; // Assuming staff with ID 12345 exists

            // Invoke the method
            found = Allstaff.Find(EmployeeId);

            // Check the employee ID
            if (Allstaff.EmployeeId != 12345)
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
            clsStaff Allstaff = new clsStaff();
            // Create a Boolean variable to store the result of the search
            bool found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            bool ok = true;
            // Create some test data to use with the method
            int EmployeeID = 12345;
            // Invoke the method
            found = Allstaff.Find(EmployeeID);
            // Check the FullName property
            if (Allstaff.FullName != "John Smith")
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
            clsStaff Allstaff = new clsStaff();
            // Create a Boolean variable to store the result of the search
            bool found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            bool ok = true;
            // Create some test data to use with the method
            int EmployeeID = 12345;
            // Invoke the method
            found = Allstaff.Find(EmployeeID);
            // Check the Role property
            if (Allstaff.Role != "Manager")
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
            clsStaff Allstaff = new clsStaff();
            // Create a Boolean variable to store the result of the search
            bool found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            bool ok = true;
            // Create some test data to use with the method
            int EmployeeID = 12345;
            // Invoke the method
            found = Allstaff.Find(EmployeeID);
            // Check the ContactPhone property
            if (Allstaff.ContactPhone != "1234567890")
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
            clsStaff Allstaff = new clsStaff();
            // Create a Boolean variable to store the result of the search
            bool found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            bool ok = true;
            // Create some test data to use with the method
            int EmployeeID = 12345;
            // Invoke the method
            found = Allstaff.Find(EmployeeID);
            // Check the ContactEmail property
            if (Allstaff.ContactEmail != "test@example.com")
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
            clsStaff Allstaff = new clsStaff();
            // Create a Boolean variable to store the result of the search
            bool found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            bool ok = true;
            // Create some test data to use with the method
            int EmployeeID = 12345;
            // Invoke the method
            found = Allstaff.Find(EmployeeID);
            // Check the Department property
            if (Allstaff.Department != "HR")
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
            clsStaff Allstaff = new clsStaff();
            // Create a Boolean variable to store the result of the search
            bool found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            bool ok = true;
            // Create some test data to use with the method
            int EmployeeID = 12345;
            // Invoke the method
            found = Allstaff.Find(EmployeeID);
            // Check the IsActive property
            if (Allstaff.IsActive != true)
            {
                ok = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void fullnameMinLessOne()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string fullname = "";
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void fullnameMin()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string fullname = "a";
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void fullnameMinPlusOne()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string fullname = "aa";
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void fullnameMaxLessOne()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string fullname = "aaaaaaa";
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void fullnameMax()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string fullname = "";
            fullname = fullname.PadRight(50, 'a');
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void fullnameMaxPlusOne()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string fullname = "";
            fullname = fullname.PadRight(51, 'a');
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void fullnameExtremeMax()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string fullname = "";
            fullname = fullname.PadRight(500, 'a');
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ContactEmailMinLessOne()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string contactemail = "gmail.com";
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void ContactEmailMin()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string contactemail = "a@gmail.com";
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void ContactEmailMinPlusOne()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string contactemail = "aa@gmail.com";
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void ContactEmailMaxLessOne()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string contactemail = "";
            contactemail = contactemail.PadRight(49, 'a');
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void ContactEmailMax()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string contactemail = "";
            contactemail = contactemail.PadRight(50, 'a');
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void ContactEmailMaxPlusOne()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string contactemail = "";
            contactemail = contactemail.PadRight(51, 'a');
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void ContactEmailExtremeMax()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string contactemail = "";
            contactemail = contactemail.PadRight(500, 'a');
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ContactPhoneMinLessOne()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string contactphone = "1";
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void ContactPhoneMin()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string contactphone = "12";
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void ContactPhoneMinPlusOne()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string contactphone = "123";
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void ContactPhoneMaxLessOne()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string contactphone = "";
            contactphone = contactphone.PadRight(15, 'a');
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void ContactPhoneMax()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string contactphone = "";
            contactphone = contactphone.PadRight(16, 'a');
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void ContactPhoneMaxPlusOne()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string contactphone = "";
            contactphone = contactphone.PadRight(17, 'a');
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void ContactPhoneExtremeMax()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string contactphone = "";
            contactphone = contactphone.PadRight(100, 'a');
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void ContactPhoneInvalidData()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string contactphone = "this is not a phone number";
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void RoleMinLessOne()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string role = "";
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void RoleMin()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string role = "a";
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void RoleMinPlusOne()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string role = "aa";
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void RoleMaxLessOne()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string role = "";
            role = role.PadRight(49, 'a');
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void RoleMax()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string role = "";
            role = role.PadRight(50, 'a');
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void RoleMaxPlusOne()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string role = "";
            role = role.PadRight(51, 'a');
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void RoleExtremeMax()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string role = "";
            role = role.PadRight(500, 'a');
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void DepartmentMinLessOne()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string department = "";
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void DepartmentMin()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string department = "a";
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void DepartmentMinPlusOne()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string department = "aa";
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void DepartmentMaxLessOne()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string department = "";
            department = department.PadRight(49, 'a');
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void DepartmentMax()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string department = "";
            department = department.PadRight(50, 'a');
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void DepartmentMaxPlusOne()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string department = "";
            department = department.PadRight(51, 'a');
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void DepartmentExtremeMax()
        {
            clsStaff Allstaff = new clsStaff();
            string Error = "";
            string department = "";
            department = department.PadRight(500, 'a');
            Error = Allstaff.Valid(fullname, contactemail, contactphone, department, role);
            Assert.AreNotEqual("", Error);
        }
    }
}
