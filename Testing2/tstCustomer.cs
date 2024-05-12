using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

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
        public void FindMethodOK()
        {
            // Create an instance of the class we want to test
            clsCustomer newCustomer = new clsCustomer();

            // Create some test data to use with the method
            int CustomerID = 1;

            // Invoke the method
            bool Found = newCustomer.Find(CustomerID);

            // Test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCustomerIDFound()
        {
            // Create an instance of the class we want to create
            clsCustomer newCustomer = new clsCustomer();

            // Create some test data to use with the method
            int CustomerID = 1;

            // Invoke the method
            newCustomer.Find(CustomerID);

            // Test to see if the result is correct
            Assert.AreEqual(newCustomer.CustomerID, CustomerID);
        }

        [TestMethod]
        public void TestFullNameFound()
        {
            // Create an instance of the class we want to create
            clsCustomer newCustomer = new clsCustomer();

            // Create some test data to use with the method
            int CustomerID = 1;

            // Invoke the method
            newCustomer.Find(CustomerID);

            // Test to see if the result is correct
            Assert.AreEqual(newCustomer.FullName, "John Doe");
        }

        [TestMethod]
        public void TestEmailAddressFound()
        {
            // Create an instance of the class we want to create
            clsCustomer newCustomer = new clsCustomer();

            // Create some test data to use with the method
            int CustomerID = 1;

            // Invoke the method
            newCustomer.Find(CustomerID);

            // Test to see if the result is correct
            Assert.AreEqual(newCustomer.EmailAddress, "john.doe@example.com");
        }

        [TestMethod]
        public void TestPhoneNumberFound()
        {
            // Create an instance of the class we want to create
            clsCustomer newCustomer = new clsCustomer();

            // Create some test data to use with the method
            int CustomerID = 1;

            // Invoke the method
            newCustomer.Find(CustomerID);

            // Test to see if the result is correct
            Assert.AreEqual(newCustomer.PhoneNumber, "123-456-789");
        }

        [TestMethod]
        public void TestShippingAddressFound()
        {
            // Create an instance of the class we want to create
            clsCustomer newCustomer = new clsCustomer();

            // Create some test data to use with the method
            int CustomerID = 1;

            // Invoke the method
            newCustomer.Find(CustomerID);

            // Test to see if the result is correct
            Assert.AreEqual(newCustomer.ShippingAddress, "123 Main St, City, Country");
        }

        [TestMethod]
        public void TestAccountCreationDateFound()
        {
            // Create an instance of the class we want to create
            clsCustomer newCustomer = new clsCustomer();

            // Create some test data to use with the method
            int CustomerID = 1;

            // Invoke the method
            newCustomer.Find(CustomerID);

            // Test to see if the result is correct
            Assert.AreEqual(newCustomer.AccountCreationDate, Convert.ToDateTime("2022-05-08"));
        }

        [TestMethod]
        public void TestIsActiveFound()
        {
            // Create an instance of the class we want to create
            clsCustomer newCustomer = new clsCustomer();

            // Create some test data to use with the method
            int CustomerID = 1;

            // Invoke the method
            newCustomer.Find(CustomerID);

            // Test to see if the
        }
    }
}
