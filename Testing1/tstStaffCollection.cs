using ClassLibrary;
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
    }
}

