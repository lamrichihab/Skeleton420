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
            // Arrange
            clsStock2 stock = new clsStock2();

            // Act - Nothing to act upon, just creating an instance

            // Assert
            Assert.IsNotNull(stock);
        }

        [TestMethod]
        public void StockProductIDPropertyOK()
        {
            // Arrange
            clsStock2 stock = new clsStock2();
            int testData = 1;

            // Act
            stock.ProductID = testData;

            // Assert
            Assert.AreEqual(stock.ProductID, testData);
        }

        [TestMethod]
        public void StockProductNamePropertyOK()
        {
            // Arrange
            clsStock2 stock = new clsStock2();
            string testData = "Sample Product";

            // Act
            stock.ProductName = testData;

            // Assert
            Assert.AreEqual(stock.ProductName, testData);
        }

        [TestMethod]
        public void StockCategoryPropertyOK()
        {
            // Arrange
            clsStock2 stock = new clsStock2();
            string testData = "Electronics";

            // Act
            stock.Category = testData;

            // Assert
            Assert.AreEqual(stock.Category, testData);
        }

        [TestMethod]
        public void StockQuantityInStockPropertyOK()
        {
            // Arrange
            clsStock2 stock = new clsStock2();
            int testData = 100;

            // Act
            stock.QuantityInStock = testData;

            // Assert
            Assert.AreEqual(stock.QuantityInStock, testData);
        }

        [TestMethod]
        public void StockColorPropertyOK()
        {
            // Arrange
            clsStock2 stock = new clsStock2();
            string testData = "Red";

            // Act
            stock.Color = testData;

            // Assert
            Assert.AreEqual(stock.Color, testData);
        }

        [TestMethod]
        public void StockSizePropertyOK()
        {
            // Arrange
            clsStock2 stock = new clsStock2();
            string testData = "Medium";

            // Act
            stock.Size = testData;

            // Assert
            Assert.AreEqual(stock.Size, testData);
        }

        [TestMethod]
        public void StockSupplierIDPropertyOK()
        {
            // Arrange
            clsStock2 stock = new clsStock2();
            int testData = 5;

            // Act
            stock.SupplierID = testData;

            // Assert
            Assert.AreEqual(stock.SupplierID, testData);
        }

        [TestMethod]
        public void StockFindMethodOK()
        {
            // Arrange
            clsStock2 stock = new clsStock2();

            // Create some test data to use with the method
            int productId = 1;

            // Invoke the method
            bool found = stock.Find(productId);

            // Test to see if the result is true
            Assert.IsTrue(found);
        }
    }
}
