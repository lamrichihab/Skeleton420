﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Testing6;

namespace Testing1
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection Allstaff = new clsStaffCollection();
            Assert.IsNotNull(Allstaff);
        }
        [TestMethod]
        public void StaffListOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create some test data to assign to the property
            // in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            // add an item to the list
            // create the item of test data
            clsStaff TestItem = new clsStaff();
            // set its properties
            TestItem.EmployeeId = 12345;
            TestItem.FullName = "John Smith";
            TestItem.Department = "HR";
            TestItem.ContactPhone = "1234567890";
            TestItem.ContactEmail = "test@example.com";
            TestItem.Role = "Manager";
            TestItem.IsActive = true;
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllStaff.StaffList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            // set the properties of the test object
            TestStaff.EmployeeId = 1;
            TestStaff.FullName = "John Doe";
            TestStaff.Department = "HR";
            TestStaff.ContactPhone = "1234567890";
            TestStaff.ContactEmail = "john.doe@example.com";
            TestStaff.Role = "Manager";
            TestStaff.IsActive = true;
            // assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            // test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create some test data to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();
            // add an item to the list
            // create the item of test data
            clsStaff TestItem = new clsStaff();
            // set its properties
            TestItem.EmployeeId = 12345;
            TestItem.FullName = "John Smith";
            TestItem.Department = "HR";
            TestItem.ContactPhone = "1234567890";
            TestItem.ContactEmail = "test@example.com";
            TestItem.Role = "Manager";
            TestItem.IsActive = true;
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllStaff.StaffList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);

        }
        [TestMethod]
        public void AddMethodOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create the item of test data
            clsStaff TestItem = new clsStaff();
            // variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.EmployeeId = 12345;
            TestItem.FullName = "John Smith";
            TestItem.Department = "HR";
            TestItem.ContactPhone = "1234567890";
            TestItem.ContactEmail = "test@example.com";
            TestItem.Role = "Manager";
            TestItem.IsActive = true;
            // set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            // add the record
            PrimaryKey = AllStaff.Add();
            // set the primary key of the test data
            TestItem.EmployeeId = PrimaryKey;
            // find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            // test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create the item of test data
            clsStaff TestItem = new clsStaff();
            // variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.FullName = "John Smith";
            TestItem.Department = "HR";
            TestItem.ContactPhone = "1234567890";
            TestItem.ContactEmail = "test@example.com";
            TestItem.Role = "Manager";
            TestItem.IsActive = true;
            // set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            // add the record
            PrimaryKey = AllStaff.Add();
            // set the primary key of the test data
            TestItem.EmployeeId = PrimaryKey;
            // modify the test record
            TestItem.FullName = "John JR Smith";
            TestItem.Department = "Customer service";
            TestItem.ContactPhone = "0987654321";
            TestItem.ContactEmail = "example@test.com";
            TestItem.Role = "General Manager";
            TestItem.IsActive = false;
            // set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            // update the record
            AllStaff.Update();
            // find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            // test to see if ThisStaff matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
        [TestMethod]
        public void DeeleteMethodOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create the item of test data
            clsStaff TestItem = new clsStaff();
            // variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.FullName = "John Smith";
            TestItem.Department = "HR";
            TestItem.ContactPhone = "1234567890";
            TestItem.ContactEmail = "test@example.com";
            TestItem.Role = "Manager";
            TestItem.IsActive = true;
            // set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            // add the record
            PrimaryKey = AllStaff.Add();
            // set the primary key of the test data
            TestItem.EmployeeId = PrimaryKey;
            // find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            // delete the record
            AllStaff.Delete();
            // now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            // test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByDepartmentMethodOK()
        {
            // create an instance of the class containing unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            // apply a blank string (should return all records)
            FilteredStaff.ReportByDepartment("");
            // test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }
        [TestMethod]
        public void ReportByDepartmentNoneFound()
        {
            // create an instance of the class we want to create
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            // apply a Department that doesn't exist
            FilteredStaff.ReportByDepartment("xxx xxx");
            // test to see that there are no records
            Assert.AreEqual(0, FilteredStaff.Count);
        }
        [TestMethod]
        public void ReportByDepartmentTestDataFound()
        {
            // Create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            // Variable to store the outcome
            Boolean OK = true;
            // Apply a role that doesn't exist
            FilteredStaff.ReportByDepartment("Sales");
            // Check that the correct number of records are found
            if (FilteredStaff.Count == 2)
            {
                // Check to see that the first record is 4
                if (FilteredStaff.StaffList[0].EmployeeId != 4)
                {
                    OK = false;
                }
                // Check to see that the second record is 5
                if (FilteredStaff.StaffList[1].EmployeeId != 5)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            // Test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}

