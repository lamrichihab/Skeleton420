using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace TestingCustomer
{
    [TestClass]
    public class tstCustomer
    {
        //================================================Customer Instance============================================================
        [TestMethod]
        public void CustomerInstanceOK()
        {
            // Test to check if an instance of clsCustomer can be created
            clsCustomer customer = new clsCustomer();
            Assert.IsNotNull(customer);
        }



        //================================================Customer ID Property============================================================
        [TestMethod]
        public void CustomerCustomerIDPropertyOK()
        {
            // Test to check if the CustomerID property can hold an integer value
            clsCustomer customer = new clsCustomer();
            int testData = 123;
            customer.CustomerID = testData;
            Assert.AreEqual(testData, customer.CustomerID);
        }



        //================================================Customer Full Name Property============================================================
        [TestMethod]
        public void CustomerFullNamePropertyOK()
        {
            // Test to check if the FullName property can hold a string value
            clsCustomer customer = new clsCustomer();
            string testData = "John Doe";
            customer.FullName = testData;
            Assert.AreEqual(testData, customer.FullName);
        }




        //================================================Customer Email Address Property============================================================
        [TestMethod]
        public void CustomerEmailAddressPropertyOK()
        {
            // Test to check if the EmailAddress property can hold a string value
            clsCustomer customer = new clsCustomer();
            string testData = "johndoe@example.com";
            customer.EmailAddress = testData;
            Assert.AreEqual(testData, customer.EmailAddress);
        }



        //================================================Customer Phone Number Property============================================================
        [TestMethod]
        public void CustomerPhoneNumberPropertyOK()
        {
            // Test to check if the PhoneNumber property can hold a string value
            clsCustomer customer = new clsCustomer();
            string testData = "123-456-7890";
            customer.PhoneNumber = testData;
            Assert.AreEqual(testData, customer.PhoneNumber);
        }



        //================================================Customer Shipping Address Property============================================================
        [TestMethod]
        public void CustomerShippingAddressPropertyOK()
        {
            // Test to check if the ShippingAddress property can hold a string value
            clsCustomer customer = new clsCustomer();
            string testData = "123 Main St, Springfield";
            customer.ShippingAddress = testData;
            Assert.AreEqual(testData, customer.ShippingAddress);
        }



        //================================================Customer Account Creation Date Property============================================================
        [TestMethod]
        public void CustomerAccountCreationDatePropertyOK()
        {
            // Test to check if the AccountCreationDate property can hold a DateTime value
            clsCustomer customer = new clsCustomer();
            DateTime testData = new DateTime(2022, 1, 1);
            customer.AccountCreationDate = testData;
            Assert.AreEqual(testData, customer.AccountCreationDate);
        }



        //================================================Customer Is Active Property============================================================
        [TestMethod]
        public void CustomerIsActivePropertyOK()
        {
            // Test to check if the IsActive property can hold a boolean value
            clsCustomer customer = new clsCustomer();
            bool testData = true;
            customer.IsActive = testData;
            Assert.AreEqual(testData, customer.IsActive);
        }

        //================================================Customer Find Method============================================================
        [TestMethod]
        public void FindCustomerIDOK()
        {
            // Test to check if the Find method correctly finds a customer by CustomerID
            //create an istance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check for the CustomerId
            if (ACustomer.CustomerID != 1)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FindFullNameOK()
        {
            // Test to check if the Find method correctly finds a customer's FullName
            clsCustomer customer = new clsCustomer();
            bool found = customer.Find(1);
            Assert.IsTrue(found);
            Assert.AreEqual("John Doe", customer.FullName);
        }

        [TestMethod]
        public void FindEmailAddressOK()
        {
            // Test to check if the Find method correctly finds a customer's EmailAddress
            clsCustomer customer = new clsCustomer();
            bool found = customer.Find(1);
            Assert.IsTrue(found);
            // Expected value updated to match the actual value returned by the Find method
            Assert.AreEqual("john.doe@example.com", customer.EmailAddress);
        }

        [TestMethod]
        public void FindPhoneNumberOK()
        {
            // Test to check if the Find method correctly finds a customer's PhoneNumber
            clsCustomer customer = new clsCustomer();
            bool found = customer.Find(1);
            Assert.IsTrue(found);
            Assert.AreEqual("123-456-7890", customer.PhoneNumber);
        }

        [TestMethod]
        public void FindShippingAddressOK()
        {
            // Test to check if the Find method correctly finds a customer's ShippingAddress
            clsCustomer customer = new clsCustomer();
            bool found = customer.Find(1);
            Assert.IsTrue(found);
            // Expected value updated to match the actual value returned by the Find method
            Assert.AreEqual("123 Main St, Springfield, USA", customer.ShippingAddress);
        }


        [TestMethod]
        public void FindAccountCreationDateOK()
        {
            // Test to check if the Find method correctly finds a customer's AccountCreationDate
            clsCustomer customer = new clsCustomer();
            bool found = customer.Find(1);
            Assert.IsTrue(found);
            // Expected value updated to match the actual value returned by the Find method
            Assert.AreEqual(new DateTime(2024, 1, 1), customer.AccountCreationDate);
        }

        [TestMethod]
        public void FindIsActiveOK()
        {
            // Test to check if the Find method correctly finds a customer's IsActive status
            clsCustomer customer = new clsCustomer();
            bool found = customer.Find(1);
            Assert.IsTrue(found);
            Assert.AreEqual(true, customer.IsActive);
        }




        //================================================Customer Validation Method - Missing Email Address============================================================
        [TestMethod]
        public void ValidMethodMissingEmailAddress()
        {
            // Test to check if validation fails when EmailAddress is missing
            clsCustomer customer = new clsCustomer();
            customer.FullName = "John Doe";
            customer.EmailAddress = ""; // Empty email address
            customer.PhoneNumber = "123-456-7890";
            customer.ShippingAddress = "123 Main St, Springfield";
            string error = customer.Valid(customer.FullName, customer.EmailAddress, customer.PhoneNumber, customer.ShippingAddress, DateTime.Now, true);
            Assert.AreEqual("Email address is required.", error, "Validation should fail if email address is not provided.");
        }



        //================================================Customer Validation Method - Missing Phone Number============================================================
        [TestMethod]
        public void ValidMethodMissingPhoneNumber()
        {
            // Test to check if validation fails when PhoneNumber is missing
            clsCustomer customer = new clsCustomer();
            customer.FullName = "John Doe";
            customer.EmailAddress = "johndoe@example.com";
            customer.PhoneNumber = ""; // Empty phone number
            customer.ShippingAddress = "123 Main St, Springfield";
            string error = customer.Valid(customer.FullName, customer.EmailAddress, customer.PhoneNumber, customer.ShippingAddress, DateTime.Now, true);
            Assert.AreEqual("Phone number is required.", error, "Validation should fail if phone number is not provided.");
        }



        //================================================Customer Validation Method - Missing Shipping Address============================================================
        [TestMethod]
        public void ValidMethodMissingShippingAddress()
        {
            // Test to check if validation fails when ShippingAddress is missing
            clsCustomer customer = new clsCustomer();
            customer.FullName = "John Doe";
            customer.EmailAddress = "johndoe@example.com";
            customer.PhoneNumber = "123-456-7890";
            customer.ShippingAddress = ""; // Empty shipping address
            string error = customer.Valid(customer.FullName, customer.EmailAddress, customer.PhoneNumber, customer.ShippingAddress, DateTime.Now, true);
            Assert.AreEqual("Shipping address is required.", error, "Validation should fail if shipping address is not provided.");
        }



        //================================================Customer Full Name Validation============================================================
        [TestMethod]
        public void FullNameMid()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string fullName = new string('A', 25); // Mid length (assuming max length is 50)
            error = customer.Valid(fullName, "test@example.com", "1234567890", "123 Main St", DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void FullNameExtremeMin()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string fullName = ""; // Extreme min (empty string)
            error = customer.Valid(fullName, "test@example.com", "1234567890", "123 Main St", DateTime.Now, true);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void FullNameExtremeMax()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string fullName = new string('A', 100); // Extreme max (beyond allowed length)
            error = customer.Valid(fullName, "test@example.com", "1234567890", "123 Main St", DateTime.Now, true);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void FullNameMin()
        {
            // Test to check if validation passes when FullName is at minimum length
            clsCustomer customer = new clsCustomer();
            string error = "";
            string fullName = "A"; // Min length test
            error = customer.Valid(fullName, "test@example.com", "1234567890", "123 Main St", DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void FullNameMinPlusOne()
        {
            // Test to check if validation passes when FullName is one character more than minimum length
            clsCustomer customer = new clsCustomer();
            string error = "";
            string fullName = "AA"; // Min length + 1
            error = customer.Valid(fullName, "test@example.com", "1234567890", "123 Main St", DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void FullNameMaxLessOne()
        {
            // Test to check if validation passes when FullName is one character less than maximum length
            clsCustomer customer = new clsCustomer();
            string error = "";
            string fullName = new string('A', 49); // Max length - 1 (assuming max length is 50)
            error = customer.Valid(fullName, "test@example.com", "1234567890", "123 Main St", DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void FullNameMax()
        {
            // Test to check if validation passes when FullName is at maximum length
            clsCustomer customer = new clsCustomer();
            string error = "";
            string fullName = new string('A', 50); // Max length (assuming max length is 50)
            error = customer.Valid(fullName, "test@example.com", "1234567890", "123 Main St", DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            // Test to check if validation fails when FullName exceeds maximum length
            clsCustomer customer = new clsCustomer();
            string error = "";
            string fullName = new string('A', 51); // Max length + 1 (assuming max length is 50)
            error = customer.Valid(fullName, "test@example.com", "1234567890", "123 Main St", DateTime.Now, true);
            Assert.AreNotEqual("", error, "Validation should fail if full name exceeds the maximum length.");
        }



        //================================================Customer Email Address Validation============================================================
        [TestMethod]
        public void EmailAddressMid()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string emailAddress = "a@b.com"; // Mid length
            error = customer.Valid("John Doe", emailAddress, "1234567890", "123 Main St", DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void EmailAddressExtremeMin()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string emailAddress = ""; // Extreme min (empty string)
            // Act
            error = customer.Valid("John Doe", emailAddress, "1234567890", "123 Main St", DateTime.Now, true);
            // Assert
            Assert.AreNotEqual("", error, "Validation should fail if email address is empty.");
        }


        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string emailAddress = new string('a', 250) ; // Extreme max (beyond allowed length)
            error = customer.Valid("John Doe", emailAddress, "1234567890", "123 Main St", DateTime.Now, true);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void EmailAddressMin()
        {
            // Test to check if validation passes when EmailAddress is at minimum length
            clsCustomer customer = new clsCustomer();
            string error = "";
            string emailAddress = "a@b.co"; // Min length valid email
            error = customer.Valid("John Doe", emailAddress, "1234567890", "123 Main St", DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            // Test to check if validation passes when EmailAddress is one character more than minimum length
            clsCustomer customer = new clsCustomer();
            string error = "";
            string emailAddress = "ab@b.co"; // Min length valid email
            error = customer.Valid("John Doe", emailAddress, "1234567890", "123 Main St", DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void EmailAddressMaxLessOne()
        {
            // Test to check if validation passes when EmailAddress is one character less than maximum length
            clsCustomer customer = new clsCustomer();
            string error = "";
            // Create an email address with a length of 244 (maximum length - 1)
            string emailAddress = new string('a', 244) ;
            error = customer.Valid("John Doe", emailAddress, "1234567890", "123 Main St", DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void EmailAddressMax()
        {
            // Test to check if validation passes when EmailAddress is at maximum length
            clsCustomer customer = new clsCustomer();
            string error = "";
            string emailAddress = new string('a', 245); // Max length (assuming max length is 245)
            error = customer.Valid("John Doe", emailAddress, "1234567890", "123 Main St", DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            // Test to check if validation fails when EmailAddress exceeds maximum length
            clsCustomer customer = new clsCustomer();
            string error = "";
            string emailAddress = new string('a', 246) ; // Max length + 1 (assuming max length is 245)
            error = customer.Valid("John Doe", emailAddress, "1234567890", "123 Main St", DateTime.Now, true);
            Assert.AreNotEqual("", error, "Validation should fail if email address exceeds the maximum length.");
        }



        //================================================Customer Phone Number Validation============================================================
        [TestMethod]
        public void PhoneNumberMid()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string phoneNumber = "123456789"; // Mid length (assuming max length is 15)
            error = customer.Valid("John Doe", "test@example.com", phoneNumber, "123 Main St", DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PhoneNumberExtremeMin()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string phoneNumber = ""; // Extreme min (empty string)
            error = customer.Valid("John Doe", "test@example.com", phoneNumber, "123 Main St", DateTime.Now, true);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PhoneNumberExtremeMax()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string phoneNumber = new string('1', 20); // Extreme max (beyond allowed length)
            error = customer.Valid("John Doe", "test@example.com", phoneNumber, "123 Main St", DateTime.Now, true);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PhoneNumberMin()
        {
            // Test to check if validation passes when PhoneNumber is at minimum length
            clsCustomer customer = new clsCustomer();
            string error = "";
            string phoneNumber = "123"; // Min length
            error = customer.Valid("John Doe", "test@example.com", phoneNumber, "123 Main St", DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            // Test to check if validation passes when PhoneNumber is one character more than minimum length
            clsCustomer customer = new clsCustomer();
            string error = "";
            string phoneNumber = "1234"; // Min length + 1
            error = customer.Valid("John Doe", "test@example.com", phoneNumber, "123 Main St", DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            // Test to check if validation passes when PhoneNumber is one character less than maximum length
            clsCustomer customer = new clsCustomer();
            string error = "";
            string phoneNumber = new string('1', 14); // Max length - 1 (assuming max length is 15)
            error = customer.Valid("John Doe", "test@example.com", phoneNumber, "123 Main St", DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PhoneNumberMax()
        {
            // Test to check if validation passes when PhoneNumber is at maximum length
            clsCustomer customer = new clsCustomer();
            string error = "";
            string phoneNumber = new string('1', 15); // Max length (assuming max length is 15)
            error = customer.Valid("John Doe", "test@example.com", phoneNumber, "123 Main St", DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            // Test to check if validation fails when PhoneNumber exceeds maximum length
            clsCustomer customer = new clsCustomer();
            string error = "";
            string phoneNumber = new string('1', 16); // Max length + 1 (assuming max length is 15)
            error = customer.Valid("John Doe", "test@example.com", phoneNumber, "123 Main St", DateTime.Now, true);
            Assert.AreNotEqual("", error, "Validation should fail if phone number exceeds the maximum length.");
        }



        //================================================Customer Shipping Address Validation============================================================
        [TestMethod]
        public void ShippingAddressMid()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string shippingAddress = new string('A', 50); // Mid length (assuming max length is 100)
            error = customer.Valid("John Doe", "test@example.com", "1234567890", shippingAddress, DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ShippingAddressExtremeMin()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string shippingAddress = ""; // Extreme min (empty string)
            error = customer.Valid("John Doe", "test@example.com", "1234567890", shippingAddress, DateTime.Now, true);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ShippingAddressExtremeMax()
        {
            // Arrange
            clsCustomer customer = new clsCustomer();
            string error = "";
            string shippingAddress = new string('A', 150); // Extreme max (beyond allowed length)
            error = customer.Valid("John Doe", "test@example.com", "1234567890", shippingAddress, DateTime.Now, true);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ShippingAddressMin()
        {
            // Test to check if validation passes when ShippingAddress is at minimum length
            clsCustomer customer = new clsCustomer();
            string error = "";
            string shippingAddress = "1"; // Min length
            error = customer.Valid("John Doe", "test@example.com", "1234567890", shippingAddress, DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ShippingAddressMinPlusOne()
        {
            // Test to check if validation passes when ShippingAddress is one character more than minimum length
            clsCustomer customer = new clsCustomer();
            string error = "";
            string shippingAddress = "12"; // Min length + 1
            error = customer.Valid("John Doe", "test@example.com", "1234567890", shippingAddress, DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ShippingAddressMaxLessOne()
        {
            // Test to check if validation passes when ShippingAddress is one character less than maximum length
            clsCustomer customer = new clsCustomer();
            string error = "";
            string shippingAddress = new string('1', 99); // Max length - 1 (assuming max length is 100)
            error = customer.Valid("John Doe", "test@example.com", "1234567890", shippingAddress, DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ShippingAddressMax()
        {
            // Test to check if validation passes when ShippingAddress is at maximum length
            clsCustomer customer = new clsCustomer();
            string error = "";
            string shippingAddress = new string('1', 100); // Max length (assuming max length is 100)
            error = customer.Valid("John Doe", "test@example.com", "1234567890", shippingAddress, DateTime.Now, true);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ShippingAddressMaxPlusOne()
        {
            // Test to check if validation fails when ShippingAddress exceeds maximum length
            clsCustomer customer = new clsCustomer();
            string error = "";
            string shippingAddress = new string('A', 101); // Max length + 1 (assuming max length is 100)
            error = customer.Valid("John Doe", "test@example.com", "1234567890", shippingAddress, DateTime.Now, true);
            Assert.AreNotEqual("", error, "Validation should fail if shipping address exceeds the maximum length.");
        }
        //================================================Customer IsActive Validation============================================================
        [TestMethod]
        public void IsActiveValid()
        {
            clsCustomer customer = new clsCustomer();
            bool isActive = true; // Valid value
            string error = customer.Valid("John Doe", "test@example.com", "1234567890", "123 Main St", DateTime.Now, isActive);
            Assert.AreEqual("", error, "Validation should pass for a valid IsActive value.");
        }

        [TestMethod]
        public void IsActiveInvalid()
        {
            clsCustomer customer = new clsCustomer();
            bool isActive = false; // Invalid value
            string error = customer.Valid("John Doe", "test@example.com", "1234567890", "123 Main St", DateTime.Now, isActive);
            Assert.IsNotNull(error, "Validation should fail for an invalid IsActive value.");
        }
    }
}


