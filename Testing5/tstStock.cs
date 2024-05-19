using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing6
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void StockInstanceOK()
        {
            // Test to check if an instance of clsStock2 can be created
            clsStock2 stock = new clsStock2();
            Assert.IsNotNull(stock);
        }

        //================================================Stock ProductID============================================================
        [TestMethod]
        public void StockProductIDPropertyOK()
        {
            // Test to check if ProductID property can be set and retrieved correctly
            clsStock2 stock = new clsStock2();
            int testData = 1;
            stock.ProductID = testData;
            Assert.AreEqual(testData, stock.ProductID);
        }

        //================================================Stock ProductName============================================================
        [TestMethod]
        public void StockProductNamePropertyOK()
        {
            // Test to check if ProductName property can be set and retrieved correctly
            clsStock2 stock = new clsStock2();
            string testData = "Sample Product";
            stock.ProductName = testData;
            Assert.AreEqual(testData, stock.ProductName);
        }

        //================================================Stock Category============================================================
        [TestMethod]
        public void StockCategoryPropertyOK()
        {
            // Test to check if Category property can be set and retrieved correctly
            clsStock2 stock = new clsStock2();
            string testData = "Electronics";
            stock.Category = testData;
            Assert.AreEqual(testData, stock.Category);
        }

        //================================================Stock QuantityInStock============================================================
        [TestMethod]
        public void StockQuantityInStockPropertyOK()
        {
            // Test to check if QuantityInStock property can be set and retrieved correctly
            clsStock2 stock = new clsStock2();
            int testData = 100;
            stock.QuantityInStock = testData;
            Assert.AreEqual(testData, stock.QuantityInStock);
        }

        //================================================Stock Color============================================================
        [TestMethod]
        public void StockColorPropertyOK()
        {
            // Test to check if Color property can be set and retrieved correctly
            clsStock2 stock = new clsStock2();
            string testData = "Red";
            stock.Color = testData;
            Assert.AreEqual(testData, stock.Color);
        }

        //================================================Stock Size============================================================
        [TestMethod]
        public void StockSizePropertyOK()
        {
            // Test to check if Size property can be set and retrieved correctly
            clsStock2 stock = new clsStock2();
            string testData = "Medium";
            stock.Size = testData;
            Assert.AreEqual(testData, stock.Size);
        }

        //================================================Stock SupplierID============================================================
        [TestMethod]
        public void StockSupplierIDPropertyOK()
        {
            // Test to check if SupplierID property can be set and retrieved correctly
            clsStock2 stock = new clsStock2();
            int testData = 5;
            stock.SupplierID = testData;
            Assert.AreEqual(testData, stock.SupplierID);
        }

        //================================================Stock Find Method============================================================
        [TestMethod]
        public void StockFindMethodOK()
        {
            // Test to check if the Find method can locate a product by ID
            clsStock2 stock = new clsStock2();
            int productId = 1;
            bool found = stock.Find(productId);
            Assert.IsTrue(found);
        }

        //================================================Stock ProductID Zero============================================================
        [TestMethod]
        public void StockProductIDZero()
        {
            // Test to check if ProductID can be set to zero
            clsStock2 stock = new clsStock2();
            int testData = 0;
            stock.ProductID = testData;
            Assert.AreEqual(testData, stock.ProductID);
        }
    }
}