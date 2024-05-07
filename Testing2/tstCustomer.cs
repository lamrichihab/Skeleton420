using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInstantiationOfCustomer()
        {
            // Act: Instantiate a new Customer object
            var customer = new Customer(); // Replace with the actual Customer class name

            // Assert: Check if the object is not null
            Assert.IsNotNull(customer, "The Customer object should be instantiated successfully.");
        }
    }
}
