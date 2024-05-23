using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace tstCustomerUser
{
    [TestClass]
    public class tstCustomerUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerUser AUser = new clsCustomerUser();
            Assert.IsNotNull(AUser);
        }
        [TestMethod]
        public void UserIdPropertyOK()
        {
            clsCustomerUser AUser = new clsCustomerUser();
            Int32 TestData = 1;
            AUser.UserID = TestData;
            Assert.AreEqual(AUser.UserID, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsCustomerUser AUser = new clsCustomerUser();
            string TestData = "Chihab";
            AUser.UserName = TestData;
            Assert.AreEqual(AUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsCustomerUser AUser = new clsCustomerUser();
            string TestData = "Password3";
            AUser.Password = TestData;
            Assert.AreEqual(AUser.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsCustomerUser AUser = new clsCustomerUser();
            string TestData = "Customer";
            AUser.Department = TestData;
            Assert.AreEqual(AUser.Department, TestData);
        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            clsCustomerUser AUser = new clsCustomerUser();
            Boolean Found = false;
            string UserName = "Chihab";
            string Password = "Password3";
            Found = AUser.FindUser(UserName, Password);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestUserNamePWFound()
        {
            clsCustomerUser AUser = new clsCustomerUser();
            Boolean Found = false;
            Boolean OK = true;
            string UserName = "Chihab";
            string Password = "Password3";
            Found = AUser.FindUser(UserName, Password);
            if (AUser.UserName != UserName && AUser.Password != Password)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
    }
}
