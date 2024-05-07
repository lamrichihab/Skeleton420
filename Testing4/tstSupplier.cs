using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOk()
        {
            // Create an instance of the supplier class we want to test
            clsSupplier supplier = new clsSupplier();

            // Test to see that it exists
            Assert.IsNotNull(supplier);
        }
    }
}
