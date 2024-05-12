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
        [TestMethod]
        public void FindMethodOK()
        {
            // Test the Find method
            clsStock2 AStock = new clsStock2();
            bool Found = false;
            int ProductID = 1;
            Found = AStock.Find(ProductID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestProductNameFound()
        {
            // Create an instance of the class we want to test
            clsStock2 AStock = new clsStock2();
            // Create a Boolean variable to store the result of the search
            bool Found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            // Create some test data to use with the method
            int ProductID = 1;
            // Invoke the method
            Found = AStock.Find(ProductID);
            // Check the ProductName property
            if (AStock.ProductName != "Sample Product")
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductIDFound()
        {
            clsStock2 AStock = new clsStock2();
            bool Found = false;
            bool OK = true;
            int ProductID = 1;
            Found = AStock.Find(ProductID);
            if (AStock.ProductID != ProductID)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCategoryFound()
        {
            clsStock2 AStock = new clsStock2();
            bool Found = false;
            bool OK = true;
            int ProductID = 1;
            Found = AStock.Find(ProductID);
            if (AStock.Category != "Electronics")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityInStockFound()
        {
            clsStock2 AStock = new clsStock2();
            bool Found = false;
            bool OK = true;
            int ProductID = 1;
            Found = AStock.Find(ProductID);
            if (AStock.QuantityInStock != 100)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestColorFound()
        {
            clsStock2 AStock = new clsStock2();
            bool Found = false;
            bool OK = true;
            int ProductID = 1;
            Found = AStock.Find(ProductID);
            if (AStock.Color != "Red")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSizeFound()
        {
            clsStock2 AStock = new clsStock2();
            bool Found = false;
            bool OK = true;
            int ProductID = 1;
            Found = AStock.Find(ProductID);
            if (AStock.Size != "Medium")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierIDFound()
        {
            clsStock2 AStock = new clsStock2();
            bool Found = false;
            bool OK = true;
            int ProductID = 1;
            Found = AStock.Find(ProductID);
            if (AStock.SupplierID != 5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
