using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary.;
using ClassLibrary; // Adjust the namespace to where clsCustomer is located

namespace Testing6
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            // Test to see if the object is not null
            Assert.IsNotNull(ACustomer, "The clsCustomer instance should not be null.");
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            // Test for Customer ID property
            clsCustomer ACustomer = new clsCustomer();
            int TestData = 123;
            ACustomer.CustomerID = TestData;
            Assert.AreEqual(TestData, ACustomer.CustomerID, "Customer ID should match the assigned value.");
        }

        [TestMethod]
        public void FullNamePropertyOK()
        {
            // Test for Full Name property
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "John Doe";
            ACustomer.FullName = TestData;
            Assert.AreEqual(TestData, ACustomer.FullName, "Full Name should match the assigned value.");
        }

        [TestMethod]
        public void EmailAddressPropertyOK()
        {
            // Test for Email Address property
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "johndoe@example.com";
            ACustomer.EmailAddress = TestData;
            Assert.AreEqual(TestData, ACustomer.EmailAddress, "Email Address should match the assigned value.");
        }

        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            // Test for Phone Number property
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "123-456-7890";
            ACustomer.PhoneNumber = TestData;
            Assert.AreEqual(TestData, ACustomer.PhoneNumber, "Phone Number should match the assigned value.");
        }

        [TestMethod]
        public void ShippingAddressPropertyOK()
        {
            // Test for Shipping Address property
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "123 Main St, Springfield";
            ACustomer.ShippingAddress = TestData;
            Assert.AreEqual(TestData, ACustomer.ShippingAddress, "Shipping Address should match the assigned value.");
        }

        [TestMethod]
        public void AccountCreationDatePropertyOK()
        {
            // Test for Account Creation Date property
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = new DateTime(2022, 1, 1);
            ACustomer.AccountCreationDate = TestData;
            Assert.AreEqual(TestData, ACustomer.AccountCreationDate, "Account Creation Date should match the assigned value.");
        }

        [TestMethod]
        public void IsActivePropertyOK()
        {
            // Test for Is Active property
            clsCustomer ACustomer = new clsCustomer();
            bool TestData = true;
            ACustomer.IsActive = TestData;
            Assert.AreEqual(TestData, ACustomer.IsActive, "Is Active should match the assigned value.");
        }
    }
}
