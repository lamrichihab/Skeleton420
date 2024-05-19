using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestingCustmerCollection
{
    [TestClass]
    public class tstCustmerCollection
    {
        //================================================Customer Instance============================================================
        [TestMethod]
        public void CustomerInstanceOK()
        {
            // Arrange
            clsCustomerCollection allCustomer = new clsCustomerCollection();

            // Act & Assert
            Assert.IsNotNull(allCustomer);
        }

        //================================================Customer List Property=======================================================
        [TestMethod]
        public void CustomerListOK()
        {
            //================================================Customer List Property=======================================================
            // Arrange
            clsCustomerCollection allCustomer = new clsCustomerCollection();
            List<clsCustomer> testList = new List<clsCustomer>();
            clsCustomer testItem = new clsCustomer();
            testItem.CustomerID = 1;
            testItem.FullName = "John Doe";
            testItem.EmailAddress = "johndoe@example.com";
            testItem.PhoneNumber = "123-456-7890";
            testItem.ShippingAddress = "123 Main St, Springfield";
            testItem.AccountCreationDate = new DateTime(2022, 1, 1);
            testItem.IsActive = true;
            testList.Add(testItem);

            // Act
            allCustomer.CustomerList = testList;

            // Assert
            Assert.AreEqual(allCustomer.CustomerList, testList);
        }

        //================================================This Customer Property======================================================
        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //================================================This Customer Property======================================================
            // Arrange
            clsCustomerCollection allCustomer = new clsCustomerCollection();
            clsCustomer testCustomer = new clsCustomer();
            testCustomer.CustomerID = 1;
            testCustomer.FullName = "John Doe";
            testCustomer.EmailAddress = "johndoe@example.com";
            testCustomer.PhoneNumber = "123-456-7890";
            testCustomer.ShippingAddress = "123 Main St, Springfield";
            testCustomer.AccountCreationDate = new DateTime(2022, 1, 1);
            testCustomer.IsActive = true;

            // Act
            allCustomer.ThisCustomer = testCustomer;

            // Assert
            Assert.AreEqual(allCustomer.ThisCustomer, testCustomer);
        }

        //================================================List And Count Property======================================================
        [TestMethod]
        public void ListAndCountOK()
        {
            //================================================List And Count Property======================================================
            // Arrange
            clsCustomerCollection allCustomer = new clsCustomerCollection();
            List<clsCustomer> testList = new List<clsCustomer>();
            clsCustomer testItem = new clsCustomer();
            testItem.CustomerID = 1;
            testItem.FullName = "John Doe";
            testItem.EmailAddress = "johndoe@example.com";
            testItem.PhoneNumber = "123-456-7890";
            testItem.ShippingAddress = "123 Main St, Springfield";
            testItem.AccountCreationDate = new DateTime(2022, 1, 1);
            testItem.IsActive = true;
            testList.Add(testItem);

            // Act
            allCustomer.CustomerList = testList;

            // Assert
            Assert.AreEqual(allCustomer.Count, testList.Count);
        }
    }
}
