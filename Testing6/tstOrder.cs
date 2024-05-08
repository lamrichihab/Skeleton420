using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        
        }
        [TestMethod]
        public void OrderIdPropertyOK()
        {
            // Create an instance of the class we want to test
            clsOrder AnOrder = new clsOrder();

            // Create some test data to assign to the property
            int testData = 1;

            // Assign the test data to the property
            AnOrder.OrderId = testData;

            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderId, testData);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            // Create an instance of the class we want to test
            clsOrder AnOrder = new clsOrder();

            // Create some test data to assign to the property
            int testData = 1;

            // Assign the test data to the property
            AnOrder.CustomerId = testData;

            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerId, testData);
        }

        [TestMethod]
        public void EmployeeIdPropertyOK()
        {
            // Create an instance of the class we want to test
            clsOrder AnOrder = new clsOrder();

            // Create some test data to assign to the property
            int testData = 1;

            // Assign the test data to the property
            AnOrder.EmployeeId = testData;

            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.EmployeeId, testData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            // Create an instance of the class we want to test
            clsOrder AnOrder = new clsOrder();

            // Create some test data to assign to the property
            DateTime testData = DateTime.Now; // You can change this to a specific date/time

            // Assign the test data to the property
            AnOrder.OrderDate = testData;

            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, testData);
        }

        [TestMethod]
        public void RequiredDatePropertyOK()
        {
            // Create an instance of the class we want to test
            clsOrder AnOrder = new clsOrder();

            // Create some test data to assign to the property
            DateTime testData = DateTime.Now.AddDays(7); // Assuming required date is 7 days from now

            // Assign the test data to the property
            AnOrder.RequiredDate = testData;

            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.RequiredDate, testData);
        }

        [TestMethod]
        public void ShippedPropertyOK()
        {
            // Create an instance of the class we want to test
            clsOrder AnOrder = new clsOrder();

            // Create some test data to assign to the property
            bool testData = true; // Assuming order is shipped

            // Assign the test data to the property
            AnOrder.Shipped = testData;

            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.Shipped, testData);
        }

    }
}
