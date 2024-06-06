using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;

namespace TestingStock
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void StockInstanceOK()
        {
            // Test to check if an instance of clsStock2 can be created
            clsStock2 stock = new clsStock2();
            Assert.IsNotNull(stock);
        }

        //================================================Stock ProductID============================================================
        [TestMethod]
        public void StockProductIDPropertyOK()
        {
            // Test to check if ProductID property can be set and retrieved correctly
            clsStock2 stock = new clsStock2();
            int testData = 1;
            stock.ProductID = testData;
            Assert.AreEqual(testData, stock.ProductID);
        }

        //================================================Stock ProductName============================================================
        [TestMethod]
        public void StockProductNamePropertyOK()
        {
            // Test to check if ProductName property can be set and retrieved correctly
            clsStock2 stock = new clsStock2();
            string testData = "Sample Product";
            stock.ProductName = testData;
            Assert.AreEqual(testData, stock.ProductName);
        }

        //================================================Available ============================================================
        [TestMethod]
        public void AvailablePropertyOK()
        {
            //create an instance of the class
            clsStock2 StockItem = new clsStock2();
            //create test data to assign to property
            Boolean TestData = true;
            //assign the data to the property
            StockItem.Available = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StockItem.Available, TestData);
        }

        //================================================Quantity In Stock============================================================
        [TestMethod]
        public void QuantityInStockPropertyOK()
        {
            // Test to check if QuantityInStock property can be set and retrieved correctly
            clsStock2 stock = new clsStock2();
            int testData = 100;
            stock.QuantityInStock = testData;
            Assert.AreEqual(testData, stock.QuantityInStock);
        }

        //================================================Arrived On============================================================
        [TestMethod]
        public void ArrivedOnPropertyOK()
        {
            //create an instance of the class
            clsStock2 Stock = new clsStock2();
            //create test data to assign to property
            DateTime TestData = new DateTime(2022, 1, 1);
            //assign the data to the property
            Stock.ArrivedOn = TestData;
            //test to see that the two values are the same
            Assert.AreEqual( TestData, Stock.ArrivedOn);
        }

    //================================================ Size============================================================
    [TestMethod]
        public void SizePropertyOK()
        {
            // Test to check if Size property can be set and retrieved correctly
            clsStock2 stock = new clsStock2();
            string testData = "Medium";
            stock.Size = testData;
            Assert.AreEqual(testData, stock.Size);
        }

        //================================================ SupplierID============================================================
        [TestMethod]
        public void SupplierIDPropertyOK()
        {
            // Test to check if SupplierID property can be set and retrieved correctly
            clsStock2 stock = new clsStock2();
            int testData = 5;
            stock.SupplierID = testData;
            Assert.AreEqual(testData, stock.SupplierID);
        }

        

        //================================================Stock ProductID Zero============================================================
        [TestMethod]
        public void StockProductIDZero()
        {
            // Test to check if ProductID can be set to zero
            clsStock2 stock = new clsStock2();
            int testData = 0;
            stock.ProductID = testData;
            Assert.AreEqual(testData, stock.ProductID);
        }
        //================================================ Find Method============================================================
        [TestMethod]
        public void productIDFindMethodOK()
        {
            // Test to check if the Find method can locate a product by ID
            clsStock2 stock = new clsStock2();
            int productID = 1;
            bool found = stock.Find(productID);
            Assert.IsTrue(found);
        }
        [TestMethod]
        public void TestStockIdFound()
        {
            //create an instance of the class
            clsStock2 StockItem = new clsStock2();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            Int32 ProductID = 4;
            //invoke the method
            Found = StockItem.Find(ProductID);
            //check the stockId
            if (StockItem.ProductID != 4)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestArrivedOnFound()
        {
            //create an instance of the class
            clsStock2 StockItem = new clsStock2();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            Int32 ProductID = 4;
            //invoke the method
            Found = StockItem.Find(ProductID);
            //check the arrived on property
            if (StockItem.ArrivedOn != Convert.ToDateTime("15/01/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductNameFound()
        {
            //create an instance of the class
            clsStock2 StockItem = new clsStock2();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            Int32 ProductID = 4;
            //invoke the method
            Found = StockItem.Find(ProductID);
            //check the item name property
            if (StockItem.ProductName != "Dress")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class
            clsStock2 StockItem = new clsStock2();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            Int32 ProductID = 4;
            //invoke the method
            Found = StockItem.Find(ProductID);
            //check the quantity property
            if (StockItem.QuantityInStock != 60)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSizeFound()
        {
            //create an instance of the class
            clsStock2 Stock = new clsStock2();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            Int32 ProductID = 4;
            //invoke the method
            Found = Stock.Find(ProductID);
            //check the price property
            if (Stock.Size != "S")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailableFound()
        {
            //create an instance of the class
            clsStock2 StockItem = new clsStock2();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            Int32 ProductID = 4;
            //invoke the method
            Found = StockItem.Find(ProductID);
            //check the available property
            if (StockItem.Available != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierIDFound()
        {
            //create an instance of the class
            clsStock2 StockItem = new clsStock2();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            Int32 ProductID = 4;
            //invoke the method
            Found = StockItem.Find(ProductID);
            //check the supplier id property
            if (StockItem.SupplierID != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        //================================================ Validation Method ============================================================

        //good test data
        string ProductName = "AA";
        string ArrivedOn = DateTime.Now.ToShortDateString();
        string QuantityInStock = "19";
        string Size = "XL";
        string SupplierID = "1";

        //================================================Product Name Validation============================================================

        [TestMethod]
        public void ProductNameMinLessOne()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            string ProductName = ""; //this should throw error
             //invoke method
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //if there is an error the strings wont match
        }

        [TestMethod]
        public void ProductNameMin()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            string ProductName = "a"; //this should pass
             //invoke method
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            string ProductName = "aa"; //this should be ok
             //invoke method
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxLessOne()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            string ProductName = "";
            ProductName = ProductName.PadRight(69, 'a'); //this should pass
             //invoke method
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMax()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            string ProductName = "";
            ProductName = ProductName.PadRight(70, 'a'); //this should pass
            //invoke method
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMid()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            string ProductName = "";
            ProductName = ProductName.PadRight(35, 'a'); //this should pass
             //invoke method
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            string ProductName = "";
            ProductName = ProductName.PadRight(71, 'a'); //this should fail
             //invoke method
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameExtremeMax()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            string ProductName = "";
            ProductName = ProductName.PadRight(500, 'a'); //this should fail
            //invoke method
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //================================================rrived On Validation============================================================

        [TestMethod]
        public void ArrivedOnExtremeMin()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //today's date minus 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string type
            string ArrivedOn = TestDate.ToString();
            //invoke the method
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ArrivedOnMinLessOne()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //today's date minus 1 day
            TestDate = TestDate.AddYears(-10).AddDays(-1); //should cause error
            //convert the date variable to a string type
            string ArrivedOn = TestDate.ToString();
            //invoke the method
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ArrivedOnMin()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //today's date minus 100 years
            TestDate = TestDate.AddYears(-10);
            //convert the date variable to a string type
            string ArrivedOn = TestDate.ToString();
            //invoke the method
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ArrivedOnMinPlusOne()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //today's date add 1 day
            TestDate = TestDate.AddDays(1); //should cause error
                                            //convert the date variable to a string type
            string ArrivedOn = TestDate.ToString();
            //invoke the method
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ArrivedOnMax()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string type
            string ArrivedOn = TestDate.ToString();
            //invoke the method
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ArrivedOnMaxPlusOne()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //today's date plus 1 day
            TestDate = TestDate.AddDays(1); //should cause error
                                            //convert the date variable to a string type
            string ArrivedOn = TestDate.ToString();
            //invoke the method
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ArrivedOnExtremeMax()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //today's date plus 100 years
            TestDate = TestDate.AddYears(100); //should cause error
            //convert the date variable to a string type
            string ArrivedOn = TestDate.ToString();
            //invoke the method
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //================================================Quantity In Stock Validation============================================================

        [TestMethod]
        public void QuantityInStockMinLessOne()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store error message
            String error = "";
            //create some test data to pass to the method
            string QuantityInStock = "-1"; //this should cause an error
            //invoke the method
            error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void QuantityInStockMin()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store error message
            String error = "";
            //create some test data to pass to the method
            string QuantityInStock = "0"; //this should pass
            //invoke the method
            error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void QuantityInStockMinPlusOne()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store error message
            String Error = "";
            //create some test data to pass to the method
            string QuantityInStock = "-1"; //this should pass
            //invoke the method
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityInStockMaxLessOne()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store error message
            String Error = "";
            //create some test data to pass to the method
            string QuantityInStock = "999"; //this should pass
            //invoke the method
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityInStockMax()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store error message
            String Error = "";
            //create some test data to pass to the method
            string QuantityInStock = "1000"; //this should pass
            //invoke the method
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityInStockMaxPlusOne()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store error message
            String Error = "";
            //create some test data to pass to the method
            string QuantityInStock = "1001"; //this should fail
            //invoke the method
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityInStockExtremeMax()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store error message
            String Error = "";
            //create some test data to pass to the method
            string QuantityInStock = "10000"; //this should fail
            //invoke the method
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //================================================Size Validation============================================================

        [TestMethod]
        public void SizeInvalidData()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store error message
            String Error = "";
            //create some test data to pass to the method
            string Size = "this is not a valid size"; //this should fail
            //invoke the method
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }      
        [TestMethod]
        public void sizeMin()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store error message
            String error = "";
            //create some test data to pass to the method
            Size = "a"; //this should pass
            //invoke the method
            error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void sizeMinPlusOne()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store error message
            String Error = "";
            //create some test data to pass to the method
            Size = Size.PadRight(2, 'a'); //this should pass
            //invoke the method
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void sizeMaxLessOne()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store error message
            String Error = "";
            //create some test data to pass to the method
            Size = Size.PadRight(9, 'a'); //this should fail //this should pass
            //invoke the method
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void sizeMax()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store error message
            String Error = "";
            //create some test data to pass to the method
            Size = Size.PadRight(10, 'a'); //this should fail
            //invoke the method
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void sizeMaxPlusOne()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store error message
            String Error = "";
            //create some test data to pass to the method
            Size = Size.PadRight(11, 'a'); //this should fail
            //invoke the method
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void sizeExtremeMax()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store error message
            String Error = "";
            //create some test data to pass to the method
            Size = Size.PadRight(500, 'a');
            //invoke the method
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //================================================Supplier ID Validation============================================================

        [TestMethod]
        public void SupplierIDInvalidData()
        {
            //create instance
            clsStock2 StockItem = new clsStock2();
            //string c=variable to store error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierID = ""; //this should fail
            //invoke the method
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierIDMin()
        {
            clsStock2 StockItem = new clsStock2();
            String Error = "";
            SupplierID = "1";
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIDMid()
        {
            clsStock2 StockItem = new clsStock2();
            String Error = "";
            SupplierID = "50";
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIDMax()
        {
            clsStock2 StockItem = new clsStock2();
            String Error = "";
            SupplierID = "99";
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierIDMINLessOne()
        {
            clsStock2 StockItem = new clsStock2();
            String Error = "";
            SupplierID = "-1";
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierIDMaxlESSONE()
        {
            clsStock2 StockItem = new clsStock2();
            String Error = "";
            SupplierID = "98";
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierIDMaxPLUSONE()
        {
            clsStock2 StockItem = new clsStock2();
            String Error = "";
            SupplierID = "100";
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierIDNonNumeric()
        {
            clsStock2 StockItem = new clsStock2();
            String Error = "";
            SupplierID = "abc";
            Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
            Assert.AreNotEqual(Error, "");
        }
    }
}