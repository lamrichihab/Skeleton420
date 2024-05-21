using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

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
        //================================================Add Method OK======================================================
        [TestMethod]
        public void AddMethodOK()
        {
            // Arrange
            clsCustomerCollection allCustomers = new clsCustomerCollection();
            clsCustomer testItem = new clsCustomer();
            int primaryKey = 0;
            testItem.CustomerID = 1;
            testItem.FullName = "John Doe";
            testItem.EmailAddress = "johndoe@example.com";
            testItem.PhoneNumber = "123-456-7890";
            testItem.ShippingAddress = "123 Main St, Springfield";
            testItem.AccountCreationDate = new DateTime(2022, 1, 1);
            testItem.IsActive = true;

            // Act
            allCustomers.ThisCustomer = testItem;
            primaryKey = testItem.CustomerID;
            allCustomers.ThisCustomer.Find(primaryKey);

            // Assert
            Assert.AreEqual(allCustomers.ThisCustomer, testItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;

            // Set initial properties
            TestItem.FullName = "John Doe";
            TestItem.ShippingAddress = "123 Main St, Springfield";
            TestItem.AccountCreationDate = new DateTime(2024, 02, 05);
            TestItem.EmailAddress = "johndoe@example.com";
            TestItem.PhoneNumber = "123-456-7890";
            TestItem.IsActive = true;
            AllCustomers.ThisCustomer = TestItem;

            // Add the record and store the primary key
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey; // Assign the obtained primary key to TestItem

            // Update properties
            TestItem.FullName = "Jane Smith";
            TestItem.ShippingAddress = "456 Oak St, Riverdale, USA";
            TestItem.EmailAddress = "jane.smith@example.com";
            TestItem.PhoneNumber = "987-654-3210";
            TestItem.IsActive = false;
            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();

            // Retrieve the updated record and check
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer.FullName, "Jane Smith");
            Assert.AreEqual(AllCustomers.ThisCustomer.ShippingAddress, "456 Oak St, Riverdale, USA");
            Assert.AreEqual(AllCustomers.ThisCustomer.EmailAddress, "jane.smith@example.com");
            Assert.AreEqual(AllCustomers.ThisCustomer.PhoneNumber, "987-654-3210");
            Assert.AreEqual(AllCustomers.ThisCustomer.IsActive, false);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;

            // Set initial properties
            TestItem.FullName = "John Doe";
            TestItem.ShippingAddress = "123 Main St, Springfield";
            TestItem.AccountCreationDate = new DateTime(2022, 1, 1);
            TestItem.EmailAddress = "johndoe@example.com";
            TestItem.PhoneNumber = "123-456-7890";
            TestItem.IsActive = true;
            AllCustomers.ThisCustomer = TestItem;

            // Add the record and store the primary key
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey; // Assign the obtained primary key to TestItem

            // Ensure the record exists
            AllCustomers.ThisCustomer.Find(PrimaryKey);

            // Delete the record
            AllCustomers.Delete();

            // Verify the record no longer exists
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByFullNameMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByFullName("XXXXX XXXX");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }
        [TestMethod]
        public void ReportByFullNameDataFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            Boolean OK = true;
            FilteredCustomers.ReportByFullName("John Doe");
            if (FilteredCustomers.Count == 2)
            {
                if (FilteredCustomers.CustomerList[0].CustomerID != 1)
                {
                    OK = false;
                }
                if (FilteredCustomers.CustomerList[0].CustomerID != 54)
                {
                    OK = false;
                }
                else
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }
        }
    }
}
