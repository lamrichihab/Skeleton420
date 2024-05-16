using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing6
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void CustomerInstanceOK()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();

            // Act - Nothing to act upon, just creating an instance

            // Assert
            Assert.IsNotNull(customer);
        }

        [TestMethod]
        public void CustomerCustomerIDPropertyOK()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            int testData = 123;

            // Act
            customer.CustomerID = testData;

            // Assert
            Assert.AreEqual(testData, customer.CustomerID);
        }

        [TestMethod]
        public void CustomerFullNamePropertyOK()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string testData = "John Doe";

            // Act
            customer.FullName = testData;

            // Assert
            Assert.AreEqual(testData, customer.FullName);
        }

        [TestMethod]
        public void CustomerEmailAddressPropertyOK()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string testData = "johndoe@example.com";

            // Act
            customer.EmailAddress = testData;

            // Assert
            Assert.AreEqual(testData, customer.EmailAddress);
        }

        [TestMethod]
        public void CustomerPhoneNumberPropertyOK()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string testData = "123-456-7890";

            // Act
            customer.PhoneNumber = testData;

            // Assert
            Assert.AreEqual(testData, customer.PhoneNumber);
        }

        [TestMethod]
        public void CustomerShippingAddressPropertyOK()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string testData = "123 Main St, Springfield";

            // Act
            customer.ShippingAddress = testData;

            // Assert
            Assert.AreEqual(testData, customer.ShippingAddress);
        }

        [TestMethod]
        public void CustomerAccountCreationDatePropertyOK()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            DateTime testData = new DateTime(2022, 1, 1);

            // Act
            customer.AccountCreationDate = testData;

            // Assert
            Assert.AreEqual(testData, customer.AccountCreationDate);
        }

        [TestMethod]
        public void CustomerIsActivePropertyOK()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            bool testData = true;

            // Act
            customer.IsActive = testData;

            // Assert
            Assert.AreEqual(testData, customer.IsActive);
        }

        [TestMethod]
        public void CustomerFindMethodOK()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();

            // Create some test data to use with the method
            int customerId = 1;

            // Invoke the method
            bool found = customer.Find(customerId);

            // Test to see if the result is true
            Assert.IsTrue(found);
        }
        [TestMethod]
        public void ValidMethodMissingEmailAddress()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            customer.FullName = "John Doe";
            customer.EmailAddress = ""; // Empty email address
            customer.PhoneNumber = "123-456-7890";
            customer.ShippingAddress = "123 Main St, Springfield";
            // Set other properties as needed...

            // Act
            string error = customer.Valid();

            // Assert
            Assert.AreEqual("Email address is required.", error, "Validation should fail if email address is not provided.");
        }

        [TestMethod]
        public void ValidMethodMissingPhoneNumber()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            customer.FullName = "John Doe";
            customer.EmailAddress = "johndoe@example.com";
            customer.PhoneNumber = ""; // Empty phone number
            customer.ShippingAddress = "123 Main St, Springfield";
            // Set other properties as needed...

            // Act
            string error = customer.Valid();

            // Assert
            Assert.AreEqual("Phone number is required.", error, "Validation should fail if phone number is not provided.");
        }

        [TestMethod]
        public void ValidMethodMissingShippingAddress()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            customer.FullName = "John Doe";
            customer.EmailAddress = "johndoe@example.com";
            customer.PhoneNumber = "123-456-7890";
            customer.ShippingAddress = ""; // Empty shipping address
                                           // Set other properties as needed...

            // Act
            string error = customer.Valid();

            // Assert
            Assert.AreEqual("Shipping address is required.", error, "Validation should fail if shipping address is not provided.");
        }
    }
}
