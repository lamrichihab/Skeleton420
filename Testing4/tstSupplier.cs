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
            supplier.Address = testData;

            // Assert
            Assert.AreEqual(supplier.Address, testData);
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
        }
    }
}

