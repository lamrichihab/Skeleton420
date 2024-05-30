using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            Assert.IsNotNull(AllSupplier);
        }
        [TestMethod]
        public void SupplierListOK()
        {
            // Arrange
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            List<clsSupplier> testList = new List<clsSupplier>();
            clsSupplier testItem = new clsSupplier();
            testItem.SupplierID = 1;
            testItem.SupplierName = "Fashion Supplier Inc.";
            testItem.ContactName = "John Smith";
            testItem.ContactEmail = "john.smith@fashionsupplier.com";
            testItem.ContactPhone = "1234567890";
            testItem.SupplierAddress = "123 Fashion Ave, Cityville, USA";
            testItem.IsActive = true;
            testList.Add(testItem);

            // Act
            AllSuppliers.SupplierList = testList;

            // Assert
            Assert.AreEqual(AllSuppliers.SupplierList, testList);
        }
        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            // Arrange
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier testSupplier = new clsSupplier();
            testSupplier.SupplierID = 1;
            testSupplier.SupplierName = "Fashion Supplier Inc.";
            testSupplier.ContactName = "John Smith";
            testSupplier.ContactEmail = "john.smith@fashionsupplier.com";
            testSupplier.ContactPhone = "1234567890";
            testSupplier.SupplierAddress = "123 Fashion Ave, Cityville, USA";
            testSupplier.IsActive = true;

            // Act
            AllSuppliers.ThisSupplier = testSupplier;

            // Assert
            Assert.AreEqual(AllSuppliers.ThisSupplier, testSupplier);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            // Arrange
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            List<clsSupplier> testList = new List<clsSupplier>();
            clsSupplier testItem = new clsSupplier();
            testItem.SupplierID = 1;
            testItem.SupplierName = "Fashion Supplier Inc.";
            testItem.ContactName = "John Smith";
            testItem.ContactEmail = "john.smith@fashionsupplier.com";
            testItem.ContactPhone = "1234567890";
            testItem.SupplierAddress = "123 Fashion Ave, Cityville, USA";
            testItem.IsActive = true;
            testList.Add(testItem);

            // Act
            AllSuppliers.SupplierList = testList;

            // Assert
            Assert.AreEqual(AllSuppliers.Count, testList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            // Arrange
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier testItem = new clsSupplier();
            Int32 primaryKey = 0;
            testItem.SupplierID = 1;
            testItem.SupplierName = "Fashion Supplier Inc.";
            testItem.ContactName = "John Smith";
            testItem.ContactEmail = "john.smith@fashionsupplier.com";
            testItem.ContactPhone = "1234567890";
            testItem.SupplierAddress = "123 Fashion Ave, Cityville, USA";
            testItem.IsActive = true;

            // Act
            AllSuppliers.ThisSupplier = testItem;
            primaryKey = AllSuppliers.Add();
            testItem.SupplierID = primaryKey;
            AllSuppliers.ThisSupplier.Find(primaryKey);

            // Assert
            Assert.AreEqual(AllSuppliers.ThisSupplier, testItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            // Arrange
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier testItem = new clsSupplier();
            Int32 primaryKey = 0;

            // Set initial properties
            testItem.SupplierID = 1;
            testItem.SupplierName = "Fashion Supplier Inc.";
            testItem.ContactName = "John Smith";
            testItem.ContactEmail = "john.smith@fashionsupplier.com";
            testItem.ContactPhone = "1234567890";
            testItem.SupplierAddress = "123 Fashion Ave, Cityville, USA";
            testItem.IsActive = true;
            AllSuppliers.ThisSupplier = testItem;

            // Add the record and store the primary key
            primaryKey = AllSuppliers.Add();
            testItem.SupplierID = primaryKey;

            // Update properties
            testItem.SupplierID = primaryKey;
            testItem.SupplierName = "Updated Supplier Inc.";
            testItem.ContactName = "Jane Doe";
            testItem.ContactEmail = "jane.doe@updatedsupplier.com";
            testItem.ContactPhone = "0987654321";
            testItem.SupplierAddress = "456 Updated St, Newcity, USA";
            testItem.IsActive = false;
            AllSuppliers.ThisSupplier = testItem;
            AllSuppliers.Update();

            // Retrieve the updated record and check
            AllSuppliers.ThisSupplier.Find(primaryKey);
            Assert.AreEqual(AllSuppliers.ThisSupplier, testItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            // Arrange
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier testItem = new clsSupplier();
            Int32 primaryKey = 0;

            // Set initial properties
            testItem.SupplierID = 1;
            testItem.SupplierName = "Fashion Supplier Inc.";
            testItem.ContactName = "John Smith";
            testItem.ContactEmail = "john.smith@fashionsupplier.com";
            testItem.ContactPhone = "1234567890";
            testItem.SupplierAddress = "123 Fashion Ave, Cityville, USA";
            testItem.IsActive = true;
            AllSuppliers.ThisSupplier = testItem;

            // Add the record and store the primary key
            primaryKey = AllSuppliers.Add();
            testItem.SupplierID = primaryKey;

            // Ensure the record exists
            AllSuppliers.ThisSupplier.Find(primaryKey);

            // Delete the record
            AllSuppliers.Delete();

            // Verify the record no longer exists
            Boolean found = AllSuppliers.ThisSupplier.Find(primaryKey);
            Assert.IsFalse(found);
        }
        [TestMethod]
        public void ReportByContactNameMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            FilteredSuppliers.ReportByContactName("Nonexistent Supplier");
            Assert.AreEqual(0, FilteredSuppliers.Count);
        }
        [TestMethod]
        public void ReportBySupplierNameDataFound()
        {
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            Boolean ok = true;
            FilteredSuppliers.ReportByContactName("Michael Brown");
            if (FilteredSuppliers.Count == 2)
            {
                if (FilteredSuppliers.SupplierList[0].SupplierID != 3)
                {
                    ok = false;
                }
                if (FilteredSuppliers.SupplierList[1].SupplierID != 15)
                {
                    ok = false;
                }
            }
            else
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }
    }
}
