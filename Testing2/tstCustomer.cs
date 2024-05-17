using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace TestingCustomer
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
            string error = customer.Valid(customer.FullName, customer.EmailAddress, customer.PhoneNumber, customer.ShippingAddress, DateTime.Now, true);

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
            string error = customer.Valid(customer.FullName, customer.EmailAddress, customer.PhoneNumber, customer.ShippingAddress, DateTime.Now, true);

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
            string error = customer.Valid(customer.FullName, customer.EmailAddress, customer.PhoneNumber, customer.ShippingAddress, DateTime.Now, true);

            // Assert
            Assert.AreEqual("Shipping address is required.", error, "Validation should fail if shipping address is not provided.");
        }

        [TestMethod]
        public void FullNameMin()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string fullName = "A"; // Min length test
            error = customer.Valid(fullName, "test@example.com", "1234567890", "123 Main St", DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void FullNameMinPlusOne()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string fullName = "AA"; // Min length + 1
            error = customer.Valid(fullName, "test@example.com", "1234567890", "123 Main St", DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void FullNameMaxLessOne()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string fullName = new string('A', 49); // Max length - 1 (assuming max length is 50)
            error = customer.Valid(fullName, "test@example.com", "1234567890", "123 Main St", DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void FullNameMax()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string fullName = new string('A', 50); // Max length (assuming max length is 50)
            error = customer.Valid(fullName, "test@example.com", "1234567890", "123 Main St", DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string fullName = new string('A', 51); // Max length + 1 (assuming max length is 50)

            // Act
            error = customer.Valid(fullName, "test@example.com", "1234567890", "123 Main St", DateTime.Now, true);

            // Assert
            Assert.AreNotEqual("", error, "Validation should fail if full name exceeds the maximum length.");
        }


        [TestMethod]
        public void EmailAddressMin()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string emailAddress = "a@b.co"; // Min length valid email
            error = customer.Valid("John Doe", emailAddress, "1234567890", "123 Main St", DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string emailAddress = "ab@b.co"; // Min length valid email
            error = customer.Valid("John Doe", emailAddress, "1234567890", "123 Main St", DateTime.Now, true);
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void EmailAddressMaxLessOne()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            // Create an email address with a length of 244 (maximum length - 1)
            string emailAddress = new string('a', 244) ;
            // Act
            error = customer.Valid("John Doe", emailAddress, "1234567890", "123 Main St", DateTime.Now, true);
            // Assert
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void EmailAddressMax()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            // Create a string with exactly 245 'a' characters
            string emailAddress = new string('a', 245) ; // Max length
            // Call the Valid method with the generated email address
            error = customer.Valid("John Doe", emailAddress, "1234567890", "123 Main St", DateTime.Now, true);
            // Assert that the error message returned by the Valid method is empty
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string emailAddress = new string('a', 246) + "@example.com"; // Max length + 1 (assuming max length is 245)

            // Act
            error = customer.Valid("John Doe", emailAddress, "1234567890", "123 Main St", DateTime.Now, true);

            // Assert
            Assert.AreNotEqual("", error, "Validation should fail if email address exceeds the maximum length.");
        }
        [TestMethod]
        public void PhoneNumberMin()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string phoneNumber = "123"; // Min length
            error = customer.Valid("John Doe", "test@example.com", phoneNumber, "123 Main St", DateTime.Now, true);
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string phoneNumber = "1234"; // Min length + 1
            error = customer.Valid("John Doe", "test@example.com", phoneNumber, "123 Main St", DateTime.Now, true);
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            // Create a phone number with a length of 15 (maximum length - 1)
            string phoneNumber = new string('1', 14);
            error = customer.Valid("John Doe", "test@example.com", phoneNumber, "123 Main St", DateTime.Now, true);
            // Assert
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void PhoneNumberMax()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            // Create a phone number with the maximum allowed length
            string phoneNumber = new string('1', 15);
            error = customer.Valid("John Doe", "test@example.com", phoneNumber, "123 Main St", DateTime.Now, true);
            // Assert
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string phoneNumber = new string('1', 16); // Max length + 1 (assuming max length is 15)

            // Act
            error = customer.Valid("John Doe", "test@example.com", phoneNumber, "123 Main St", DateTime.Now, true);

            // Assert
            Assert.AreNotEqual("", error, "Validation should fail if phone number exceeds the maximum length.");
        }

        [TestMethod]
        public void ShippingAddressMin()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string shippingAddress = "1"; // Min length
            error = customer.Valid("John Doe", "test@example.com", "1234567890", shippingAddress, DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ShippingAddressMinPlusOne()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string shippingAddress = "12"; // Min length + 1
            error = customer.Valid("John Doe", "test@example.com", "1234567890", shippingAddress, DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ShippingAddressMaxLessOne()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string shippingAddress = new string('1', 99); // Max length - 1
            error = customer.Valid("John Doe", "test@example.com", "1234567890", shippingAddress, DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ShippingAddressMax()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string shippingAddress = new string('1', 100); // Max length
            error = customer.Valid("John Doe", "test@example.com", "1234567890", shippingAddress, DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ShippingAddressMaxPlusOne()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string shippingAddress = new string('A', 101); // Max length + 1 (assuming max length is 100)

            // Act
            error = customer.Valid("John Doe", "test@example.com", "1234567890", shippingAddress, DateTime.Now, true);

            // Assert
            Assert.AreNotEqual("", error, "Validation should fail if shipping address exceeds the maximum length.");
        }
    }
}

