using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInstantiationOfStock()
        {
            // Act: Instantiate a new Stock object
            var stock = new Stock(); // Ensure the Stock class exists and has a default constructor

            // Assert: Check if the Stock object is successfully instantiated
            Assert.IsNotNull(stock, "The Stock object should be instantiated successfully.");
        }
    }
}
