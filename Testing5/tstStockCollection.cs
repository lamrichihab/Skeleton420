using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace TestingStockCollection
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance
            clsStockCollection AllStock = new clsStockCollection();
            //test to see if it exists
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create instance
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list objects
            List<clsStock2> TestList = new List<clsStock2>();
            //Add an item to the list
            //create item of the test data
            clsStock2 TestItem = new clsStock2();
            //set its properties
            TestItem.ArrivedOn = DateTime.Now;
            TestItem.ProductID = 1;
            TestItem.ProductName = "TestName";
            TestItem.Available = true;
            TestItem.Size = "XL";
            TestItem.QuantityInStock = 10;
            TestItem.SupplierID = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.StockList, TestList);
        }


        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance 
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock2 TestStock = new clsStock2();
            //set the properties of the test object
            TestStock.ArrivedOn = DateTime.Now;
            TestStock.ProductID = 1;
            TestStock.ProductName = "TestName";
            TestStock.Available = true;
            TestStock.Size = "XL";
            TestStock.QuantityInStock = 10;
            TestStock.SupplierID = 1;
            //assign the data to the property
            AllStock.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class
            clsStockCollection AllStock = new clsStockCollection();
            //create test data
            //needs to be a list of objects
            List<clsStock2> TestList = new List<clsStock2>();
            //create the item of the test data
            clsStock2 TestItem = new clsStock2();
            //set its properties
            TestItem.ArrivedOn = DateTime.Now;
            TestItem.ProductID = 1;
            TestItem.ProductName = "TestName";
            TestItem.Available = true;
            TestItem.Size = "XL";
            TestItem.QuantityInStock = 10;
            TestItem.SupplierID = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create instance
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock2 TestItem = new clsStock2();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductID = 1;
            TestItem.ArrivedOn = new DateTime(2024, 1, 15);
            TestItem.ProductName = "T-Shirt";
            TestItem.Available = true;
            TestItem.Size = "M";
            TestItem.QuantityInStock = 100;
            TestItem.SupplierID = 1;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //set the primary key to the test data
            TestItem.ProductID = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create instance
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock2 TestItem = new clsStock2();
            //variable t store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductID = 1;
            TestItem.ArrivedOn = new DateTime(2024, 1, 15);
            TestItem.ProductName = "T-Shirt";
            TestItem.Available = true;
            TestItem.Size = "M";
            TestItem.QuantityInStock = 100;
            TestItem.SupplierID = 1;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //set the primary key of the test data
            TestItem.ProductID = PrimaryKey;
            //modify the test record
            TestItem.ProductName = "NewName456";
            TestItem.QuantityInStock = 0;
            TestItem.Available = false;
            //set the record based on the new test data
            AllStock.ThisStock = TestItem;
            //update the record
            AllStock.Update();
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see if ThisStock matches the test data
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create instance
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock2 TestItem = new clsStock2();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductID = 1;
            TestItem.ArrivedOn = new DateTime(2024, 1, 15);
            TestItem.ProductName = "T-Shirt";
            TestItem.Available = true;
            TestItem.Size = "M";
            TestItem.QuantityInStock = 100;
            TestItem.SupplierID = 1;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //set the primary key of the test data
            TestItem.ProductID = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //delete the record
            AllStock.Delete();
            //now find the record
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByProductNameMethodOK()
        {
            //create instance
            clsStockCollection AllStock = new clsStockCollection();
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a blank string (should return all records)
            FilteredStock.ReportByProductName("");
            //test to see that the two values are teh same
            Assert.AreEqual(AllStock.Count, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByProductNameNoneFound()
        {
            //create instance
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a itemname that doesnt exist
            FilteredStock.ReportByProductName("ProductNameDoesNotExist");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByProductNameTestDataFound()
        {
            //create instance of filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a item name that doesnt exist
            FilteredStock.ReportByProductName("T-Shirt");
            //check that the correct number of records are found
            if (FilteredStock.Count == 1)
            {
                //check to see that the first record is 1
                if (FilteredStock.StockList[0].ProductID != 1)
                {
                    OK = false;
                }
                //check to see that the first record is 19
                if (FilteredStock.StockList[0].ProductID != 19)
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
