using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstSupplierUser
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIdPropertyOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            Int32 TestData = 1;
            AnUser.UserID = TestData;
            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            // Create an instance of the class we want to create
            clsSupplierUser AnUser = new clsSupplierUser();
            // Create some test data to assign to the property
            string TestData = "Mohamed";
            // Assign the data to the property
            AnUser.UserName = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            // Create an instance of the class we want to create
            clsSupplierUser AnUser = new clsSupplierUser();
            // Create some test data to assign to the property
            string TestData = "password2";
            // Assign the data to the property
            AnUser.Password = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            // Create an instance of the class we want to create
            clsSupplierUser AnUser = new clsSupplierUser();
            // Create some test data to assign to the property
            string TestData = "HR";
            // Assign the data to the property
            AnUser.Department = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            Boolean Found = false;
            string UserName = "Mohamed";
            string Password = "Password2";
            Found = AnUser.FindUser(UserName, Password);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            Boolean Found = false;
            Boolean OK = true;
            string UserName = "Mohamed";
            string Password = "Password2";
            Found = AnUser.FindUser(UserName, Password);
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
