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
        [TestMethod]
        public void FindMethodOK()
        {
            // Create an instance of the class we want to test
            clsOrder AnOrder = new clsOrder();

            // Create a Boolean variable to store the results of the validation
            bool found = false;

            // Create some test data to use with the method
            int OrderId = 12; // Assuming an order with ID 12 exists

            // Invoke the method
            found = AnOrder.Find(OrderId);

            // Test to see if the result is true
            Assert.IsTrue(found);
        }
        [TestMethod]
        public void TestOrderIdFound()
        {
            // Create an instance of the class we want to test
            clsOrder AnOrder = new clsOrder();

            // Create a Boolean variable to store the result of the search
            bool found = false;

            // Create a Boolean variable to record if the data is OK (assume it is)
            bool ok = true;

            // Create some test data to use with the method
            int OrderId = 12; // Assuming Order with ID 12 exists

            // Invoke the method
            found = AnOrder.Find(OrderId);

            // Check the  ID
            if (AnOrder.OrderId != 12)
            {
                ok = false;
            }

            // Test to see that the result is correct
            Assert.IsTrue(ok);
        }
        [TestMethod]
        public void TestCustomerIdFound()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Create a Boolean variable to store the result of the search
            bool found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            bool ok = true;
            // Create some test data to use with the method
            int OrderId = 12;
            // Invoke the method
            found = AnOrder.Find(OrderId);
            // Check the  property
            if (AnOrder.OrderId != 12)
            {
                ok = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestEmployeeId()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Create a Boolean variable to store the result of the search
            bool found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            bool ok = true;
            // Create some test data to use with the method
            int OrderId = 12;
            // Invoke the method
            found = AnOrder.Find(OrderId);
            // Check the  property
            if (AnOrder.EmployeeId != 12)
            {
                ok = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Create a Boolean variable to store the result of the search
            bool found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            bool ok = true;
            // Create some test data to use with the method
            int OrderId = 12;
            // Invoke the method
            found = AnOrder.Find(OrderId);
            // Check the property
            if (AnOrder.OrderDate != Convert.ToDateTime("14/05/2024"))
            {
                ok = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestRequirdDateFound()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Create a Boolean variable to store the result of the search
            bool found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            bool ok = true;
            // Create some test data to use with the method
            int OrderId = 12;
            // Invoke the method
            found = AnOrder.Find(OrderId);
            // Check the ContactEmail property
            if (AnOrder.RequiredDate != Convert.ToDateTime("24/05/2024"))
            {
                ok = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(ok);
        }



        [TestMethod]
        public void TestShippedFound()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Create a Boolean variable to store the result of the search
            bool found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            bool ok = true;
            // Create some test data to use with the method
            int OrderId = 12;
            // Invoke the method
            found = AnOrder.Find(OrderId);
            // Check the IsActive property
            if (AnOrder.Shipped != true)
            {
                ok = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(ok);
        }
    }
}
