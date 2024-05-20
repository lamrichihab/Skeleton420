using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstOrderline
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderlines AnOrderlines = new clsOrderlines();
            Assert.IsNotNull(AnOrderlines);
        }
        [TestMethod]
        public void ProductIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderlines AnOrderlines = new clsOrderlines();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderlines.ProductId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderlines.ProductId, TestData);
        }
        [TestMethod]
        public void OrderIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderlines AnOrderlines = new clsOrderlines();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderlines.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderlines.OrderId, TestData);
        }
        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderlines AnOrderlines = new clsOrderlines();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderlines.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderlines.Quantity, TestData);
        }
        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderlines AnOrderlines = new clsOrderlines();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderlines.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderlines.Price, TestData);
        }
        [TestMethod]
        public void LocationPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderlines AnOrderlines = new clsOrderlines();
            //create some test data to assign to the property
            string TestData = "Some Street";
            //assign the data to the property
            AnOrderlines.Location = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderlines.Location, TestData);
        }
        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderlines AnOrderlines = new clsOrderlines();
            //create some test data to assign to the property
            string TestData = "Some Street";
            //assign the data to the property
            AnOrderlines.OrderStatus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderlines.OrderStatus, TestData);
        }
        public void FindMethodOK()
        {
            // Create an instance of the class we want to test
            clsOrderlines AnOrderlines = new clsOrderlines();

            // Create a Boolean variable to store the results of the validation
            bool found = false;

            // Create some test data to use with the method
            int ProductId = 12; // Assuming an order with ID 12 exists

            // Invoke the method
            found = AnOrderlines.Find(ProductId);

            // Test to see if the result is true
            Assert.IsTrue(found);
        }
        [TestMethod]
        public void TestProdcutIdFound()
        {
            // Create an instance of the class we want to test
            clsOrderlines AnOrderlines = new clsOrderlines();

            // Create a Boolean variable to store the result of the search
            bool found = false;

            // Create a Boolean variable to record if the data is OK (assume it is)
            bool ok = true;

            // Create some test data to use with the method
            int ProductId = 12; // Assuming Order with ID 12 exists

            // Invoke the method
            found = AnOrderlines.Find(ProductId);

            // Check the  ID
            if (AnOrderlines.ProductId != 12)
            {
                ok = false;
            }

            // Test to see that the result is correct
            Assert.IsTrue(ok);
        }
        [TestMethod]
        public void TestOrderIdFound()
        {
            // Create an instance of the class we want to create
            clsOrderlines AnOrderlines = new clsOrderlines();
            // Create a Boolean variable to store the result of the search
            bool found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            bool ok = true;
            // Create some test data to use with the method
            int ProductId = 12;
            // Invoke the method
            found = AnOrderlines.Find(ProductId);
            // Check the  property
            if (AnOrderlines.OrderId != 12)
            {
                ok = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            // Create an instance of the class we want to create
            clsOrderlines AnOrderlines = new clsOrderlines();
            // Create a Boolean variable to store the result of the search
            bool found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            bool ok = true;
            // Create some test data to use with the method
            int ProductId = 12;
            // Invoke the method
            found = AnOrderlines.Find(ProductId);
            // Check the  property
            if (AnOrderlines.Quantity != 12)
            {
                ok = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            // Create an instance of the class we want to create
            clsOrderlines AnOrderlines = new clsOrderlines();
            // Create a Boolean variable to store the result of the search
            bool found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            bool ok = true;
            // Create some test data to use with the method
            int ProductId = 12;
            // Invoke the method
            found = AnOrderlines.Find(ProductId);
            // Check the property
            if (AnOrderlines.Price != 12)
            {
                ok = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestLocationFound()
        {
            // Create an instance of the class we want to create
            clsOrderlines AnOrderlines = new clsOrderlines();
            // Create a Boolean variable to store the result of the search
            bool found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            bool ok = true;
            // Create some test data to use with the method
            int ProductId = 12;
            // Invoke the method
            found = AnOrderlines.Find(ProductId);
            // Check the ContactEmail property
            if (AnOrderlines.Location != "Test Location")
            {
                ok = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(ok);
        }



        [TestMethod]
        public void TestOrderStatusFound()
        {
            // Create an instance of the class we want to create
            clsOrderlines AnOrderlines = new clsOrderlines();
            // Create a Boolean variable to store the result of the search
            bool found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            bool ok = true;
            // Create some test data to use with the method
            int ProductId = 12;
            // Invoke the method
            found = AnOrderlines.Find(ProductId);
            // Check the IsActive property
            if (AnOrderlines.OrderStatus != "Test OrderStatus")
            {
                ok = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(ok);
        }
    }
}




