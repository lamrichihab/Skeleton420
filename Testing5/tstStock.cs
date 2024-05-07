using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary; // Adjust the namespace to where your clsStock class is located

namespace Testing6
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the class to test
            clsStock AStock = new clsStock();
            // Assert that the object is not null
            Assert.IsNotNull(AStock, "The clsStock instance should not be null.");
        }

        [TestMethod]
        public void ProductIDPropertyOK()
        {
            // Create an instance of clsStock
            clsStock AStock = new clsStock();
            // Test data for ProductID
            int TestData = 1;
            // Assign the test data to ProductID
            AStock.ProductID = TestData;
            // Verify that ProductID matches the test data
            Assert.AreEqual(TestData, AStock.ProductID, "ProductID should match the assigned value.");
        }

        [TestMethod]
        public void ProductNamePropertyOK()
        {
            // Test for ProductName property
            clsStock AStock = new clsStock();
            string TestData = "Sample Product";
            AStock.ProductName = TestData;
            Assert.AreEqual(TestData, AStock.ProductName, "ProductName should match the assigned value.");
        }

        [TestMethod]
        public void CategoryPropertyOK()
        {
            // Test for Category property
            clsStock AStock = new clsStock();
            string TestData = "Electronics";
            AStock.Category = TestData;
            Assert.AreEqual(TestData, AStock.Category, "Category should match the assigned value.");
        }

        [TestMethod]
        public void QuantityInStockPropertyOK()
        {
            // Test for Quantity in Stock property
            clsStock AStock = new clsStock();
            int TestData = 100;
            AStock.QuantityInStock = TestData;
            Assert.AreEqual(TestData, AStock.QuantityInStock, "QuantityInStock should match the assigned value.");
        }

        [TestMethod]
        public void ColorPropertyOK()
        {
            // Test for Color property
            clsStock AStock = new clsStock();
            string TestData = "Red";
            AStock.Color = TestData;
            Assert.AreEqual(TestData, AStock.Color, "Color should match the assigned value.");
        }

        [TestMethod]
        public void SizePropertyOK()
        {
            // Test for Size property
            clsStock AStock = new clsStock();
            string TestData = "Medium";
            AStock.Size = TestData;
            Assert.AreEqual(TestData, AStock.Size, "Size should match the assigned value.");
        }

        [TestMethod]
        public void SupplierIDPropertyOK()
        {
            // Test for SupplierID property
            clsStock AStock = new clsStock();
            int TestData = 5;
            AStock.SupplierID = TestData;
            Assert.AreEqual(TestData, AStock.SupplierID, "SupplierID should match the assigned value.");
        }
    }

        public int ProductID { get; internal set; }
        public string ProductName { get; internal set; }
        public string Category { get; internal set; }
        public int QuantityInStock { get; internal set; }
        public string Color { get; internal set; }
        public string Size { get; internal set; }
        public int SupplierID { get; internal set; }
    }
}
