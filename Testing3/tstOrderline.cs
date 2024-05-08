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
    }
}


