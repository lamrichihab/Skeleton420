using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary; // Adjust this to the correct namespace for clsStock2

namespace Testing6
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the clsStock2 class
            clsStock2 AStock = new clsStock2();
            Assert.IsNotNull(AStock, "The clsStock2 instance should not be null.");
        }

        [TestMethod]
        public void ProductIDPropertyOK()
        {
            // Test the ProductID property
            clsStock2 AStock = new clsStock2();
            int TestData = 1;  // Test value for ProductID
            AStock.ProductID = TestData;
            Assert.AreEqual(TestData, AStock.ProductID, "ProductID should match the assigned value.");
        }

        [TestMethod]
        public void ProductNamePropertyOK()
        {
            clsStock2 AStock = new clsStock2();
            string TestData = "Sample Product";
            AStock.ProductName = TestData;
            Assert.AreEqual(TestData, AStock.ProductName, "ProductName should match the assigned value.");
        }

        [TestMethod]
        public void CategoryPropertyOK()
        {
            clsStock2 AStock = new clsStock2();
            string TestData = "Electronics";
            AStock.Category = TestData;
            Assert.AreEqual(TestData, AStock.Category, "Category should match the assigned value.");
        }

        [TestMethod]
        public void QuantityInStockPropertyOK()
        {
            clsStock2 AStock = new clsStock2();
            int TestData = 100;
            AStock.QuantityInStock = TestData;
            Assert.AreEqual(TestData, AStock.QuantityInStock, "QuantityInStock should match the assigned value.");
        }

        [TestMethod]
        public void ColorPropertyOK()
        {
            clsStock2 AStock = new clsStock2();
            string TestData = "Red";
            AStock.Color = TestData;
            Assert.AreEqual(TestData, AStock.Color, "Color should match the assigned value.");
        }

        [TestMethod]
        public void SizePropertyOK()
        {
            clsStock2 AStock = new clsStock2();
            string TestData = "Medium";
            AStock.Size = TestData;
            Assert.AreEqual(TestData, AStock.Size, "Size should match the assigned value.");
        }

        [TestMethod]
        public void SupplierIDPropertyOK()
        {
            clsStock2 AStock = new clsStock2();
            int TestData = 5;
            AStock.SupplierID = TestData;
            Assert.AreEqual(TestData, AStock.SupplierID, "SupplierID should match the assigned value.");
        }
    }
}
