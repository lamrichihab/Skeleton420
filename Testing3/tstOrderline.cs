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
    }
}
