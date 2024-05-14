using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing6
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void SupplierInstanceOK()
        {
            // Arrange
            clsSupplier supplier = new clsSupplier();

            // Act - Nothing to act upon, just creating an instance

            // Assert
            Assert.IsNotNull(supplier);
        }

        [TestMethod]
        public void SupplierIDPropertyOK()
        {
            // Arrange
            clsSupplier supplier = new clsSupplier();
            int testData = 1;

            // Act
            supplier.SupplierID = testData;

            // Assert
            Assert.AreEqual(supplier.SupplierID, testData);
        }

        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            // Arrange
            clsSupplier supplier = new clsSupplier();
            string testData = "ABC Clothing";

            // Act
            supplier.SupplierName = testData;

            // Assert
            Assert.AreEqual(supplier.SupplierName, testData);
        }

        [TestMethod]
        public void SupplierContactNamePropertyOK()
        {
            // Arrange
            clsSupplier supplier = new clsSupplier();
            string testData = "John Smith";

            // Act
            supplier.ContactName = testData;

            // Assert
            Assert.AreEqual(supplier.ContactName, testData);
        }

        [TestMethod]
        public void SupplierContactPhonePropertyOK()
        {
            // Arrange
            clsSupplier supplier = new clsSupplier();
            string testData = "1234567890";

            // Act
            supplier.ContactPhone = testData;

            // Assert
            Assert.AreEqual(supplier.ContactPhone, testData);
        }

        [TestMethod]
        public void SupplierContactEmailPropertyOK()
        {
            // Arrange
            clsSupplier supplier = new clsSupplier();
            string testData = "supplier@example.com";

            // Act
            supplier.ContactEmail = testData;

            // Assert
            Assert.AreEqual(supplier.ContactEmail, testData);
        }

        [TestMethod]
        public void SupplierAddressPropertyOK()
        {
            // Arrange
            clsSupplier supplier = new clsSupplier();
            string testData = "123 Main St";

            // Act
            supplier.SupplierAddress = testData;

            // Assert
            Assert.AreEqual(supplier.SupplierAddress, testData);
        }

        [TestMethod]
        public void SupplierIsActivePropertyOK()
        {
            // Arrange
            clsSupplier supplier = new clsSupplier();
            bool testData = true;

            // Act
            supplier.IsActive = testData;

            // Assert
            Assert.AreEqual(supplier.IsActive, testData);
        } // Find method test
        [TestMethod]
        public void FindMethodOK()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // Create a Boolean variable to store the results of the validation
            bool Found = false;
            // Create some test data to use with the method
            int SupplierID = 1;
            // Invoke the method
            Found = supplier.Find(SupplierID);
            // Test to see if the result is true
            Assert.IsTrue(Found);
        }
        // Property data tests
        [TestMethod]
        public void TestSupplierIDFound()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // Create a Boolean variable to store the result of the search
            bool Found = false;
            // Create a Boolean variable to record if the data is OK (assume it is)
            bool OK = true;
            // Create some test data to use with the method
            int SupplierID = 1;
            // Invoke the method
            Found = supplier.Find(SupplierID);
            // Check the SupplierID property
            if (supplier.SupplierID != 1)
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierNameFound()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // Create a Boolean variable to store the result of the search
            bool Found = false;
            // Create a Boolean variable to record if the data is OK (assume it is)
            bool OK = true;
            // Create some test data to use with the method
            int SupplierID = 1;
            // Invoke the method
            Found = supplier.Find(SupplierID);
            // Check the SupplierName property
            if (supplier.SupplierName != "Fashion Supplier Inc.")
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestContactNameFound()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // Create a Boolean variable to store the result of the search
            bool Found = false;
            // Create a Boolean variable to record if the data is OK (assume it is)
            bool OK = true;
            // Create some test data to use with the method
            int SupplierID = 1;
            // Invoke the method
            Found = supplier.Find(SupplierID);
            // Check the ContactName property
            if (supplier.ContactName != "John Smith")
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestContactEmailFound()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // Create a Boolean variable to store the result of the search
            bool Found = false;
            // Create a Boolean variable to record if the data is OK (assume it is)
            bool OK = true;
            // Create some test data to use with the method
            int SupplierID = 1;
            // Invoke the method
            Found = supplier.Find(SupplierID);
            // Check the ContactEmail property
            if (supplier.ContactEmail != "john.smith@fashionsupplier.com")
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestContactPhoneFound()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // Create a Boolean variable to store the result of the search
            bool Found = false;
            // Create a Boolean variable to record if the data is OK (assume it is)
            bool OK = true;
            // Create some test data to use with the method
            int SupplierID = 1;
            // Invoke the method
            Found = supplier.Find(SupplierID);
            // Check the ContactPhone property
            if (supplier.ContactPhone != "555-777-8888")
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierAddressFound()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // Create a Boolean variable to store the result of the search
            bool Found = false;
            // Create a Boolean variable to record if the data is OK (assume it is)
            bool OK = true;
            // Create some test data to use with the method
            int SupplierID = 1;
            // Invoke the method
            Found = supplier.Find(SupplierID);
            // Check the SupplierAddress property
            if (supplier.SupplierAddress != "123 Fashion Ave, Cityville, USA")
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsActiveFound()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // Create a Boolean variable to store the result of the search
            bool Found = false;
            // Create a Boolean variable to record if the data is OK (assume it is)
            bool OK = true;
            // Create some test data to use with the method
            int SupplierID = 1;
            // Invoke the method
            Found = supplier.Find(SupplierID);
            // Check the IsActive property
            if (supplier.IsActive != true)
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}

