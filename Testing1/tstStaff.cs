using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class TstStaff
    {
        [TestMethod]
        public void InstanceOk()
        {
            // Create an instance of the staff class we want to test
            clsStaff Staff = new clsStaff();

            // Test to see that it exists
            Assert.IsNotNull(Staff);
        }
    }
}
