using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;



namespace Testing6

{
    [TestClass]
    public class tstSupplier

    {
        //============================= Test Data =============================



        string supplierName = "Fashion Supplier Inc.";

        string supplierContactName = "John Smith";

        string supplierContactEmail = "john.smith@fashionsupplier.com";

        string supplierContactPhone = "1234567890";

        string supplierAddress = "123 Fashion St, Trendy City, TX 54321";

        //========================Supplier Instance and Properties======================================
        [TestMethod]
        public void SupplierInstanceOK()
        {
            clsSupplier Allsupplier = new clsSupplier();
            Assert.IsNotNull(Allsupplier);
        }

        [TestMethod]
        public void SupplierIDPropertyOK()
        {
            clsSupplier Allsupplier = new clsSupplier();
            int testData = 1;
            Allsupplier.SupplierID = testData;
            Assert.AreEqual(Allsupplier.SupplierID, testData);
        }

        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            clsSupplier Allsupplier = new clsSupplier();
            string testData = "ABC Clothing";
            Allsupplier.SupplierName = testData;
            Assert.AreEqual(Allsupplier.SupplierName, testData);
        }

        [TestMethod]
        public void SupplierContactNamePropertyOK()
        {
            clsSupplier Allsupplier = new clsSupplier();
            string testData = "John Smith";
            Allsupplier.ContactName = testData;
            Assert.AreEqual(Allsupplier.ContactName, testData);
        }



        [TestMethod]

        public void SupplierContactPhonePropertyOK()
        {
            clsSupplier Allsupplier = new clsSupplier();
            string testData = "1234567890";
            Allsupplier.ContactPhone = testData;
            Assert.AreEqual(Allsupplier.ContactPhone, testData);
        }


        [TestMethod]
        public void SupplierContactEmailPropertyOK()

        {

            clsSupplier Allsupplier = new clsSupplier();
            string testData = "supplier@example.com";
            Allsupplier.ContactEmail = testData;
            Assert.AreEqual(Allsupplier.ContactEmail, testData);

        }



        [TestMethod]

        public void SupplierAddressPropertyOK()

        {

            clsSupplier Allsupplier = new clsSupplier();
            string testData = "123 Main St";
            Allsupplier.SupplierAddress = testData;
            Assert.AreEqual(Allsupplier.SupplierAddress, testData);

        }



        [TestMethod]
        public void SupplierIsActivePropertyOK()

        {

            clsSupplier Allsupplier = new clsSupplier();
            bool testData = true;
            Allsupplier.IsActive = testData;
            Assert.AreEqual(Allsupplier.IsActive, testData);

        }



        //=============================== Find Method Tests =========================================



        [TestMethod]

        public void FindMethodOK()

        {

            clsSupplier Allsupplier = new clsSupplier();
            bool found = false;
            int supplierID = 1;
            found = Allsupplier.Find(supplierID);
            Assert.IsTrue(found);

        }



        [TestMethod]
        public void TestSupplierIsFound()
        { 

            clsSupplier Allsupplier = new clsSupplier();
            bool found = false;
            bool ok = true;
            int supplierID = 1;
            found = Allsupplier.Find(supplierID);
            if (Allsupplier.SupplierID != 1)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestSupplierNameFound()

        {

            clsSupplier Allsupplier = new clsSupplier();

            bool found = false;

            bool ok = true;

            int supplierID = 1;

            found = Allsupplier.Find(supplierID);

            if (Allsupplier.SupplierName != "Fashion Supplier Inc.")

            {

                ok = false;

            }

            Assert.IsTrue(ok);

        }



        [TestMethod]

        public void TestContactNameFound()

        {

            clsSupplier Allsupplier = new clsSupplier();

            bool found = false;

            bool ok = true;

            int supplierID = 1;

            found = Allsupplier.Find(supplierID);

            if (Allsupplier.ContactName != "John Smith")

            {

                ok = false;

            }

            Assert.IsTrue(ok);

        }



        [TestMethod]

        public void TestContactEmailFound()

        {

            clsSupplier Allsupplier = new clsSupplier();

            bool found = false;

            bool ok = true;

            int supplierID = 1;

            found = Allsupplier.Find(supplierID);

            if (Allsupplier.ContactEmail != "john.smith@fashionsupplier.com")

            {

                ok = false;

            }

            Assert.IsTrue(ok);

        }



        [TestMethod]

        public void TestContactPhoneFound()

        {

            clsSupplier Allsupplier = new clsSupplier();

            bool found = false;

            bool ok = true;

            int supplierID = 1;

            found = Allsupplier.Find(supplierID);

            if (Allsupplier.ContactPhone != "1234567890")

            {

                ok = false;

            }

            Assert.IsTrue(ok);

        }



        //=============================== Validation Method Tests =========================================



        [TestMethod]

        public void ValidMethodOK()

        {

            clsSupplier Allsupplier = new clsSupplier();

            string error = "";

            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);

            Assert.AreEqual(error, "");

        }



        [TestMethod]

        public void SupplierNameMinLessOne()

        {

            clsSupplier Allsupplier = new clsSupplier();

            string error = "";

            string supplierName = "";

            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);

            Assert.AreNotEqual(error, "");

        }



        [TestMethod]

        public void SupplierNameMin()

        {

            clsSupplier Allsupplier = new clsSupplier();

            string error = "";

            string supplierName = "a";

            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);

            Assert.AreEqual(error, "");

        }



        [TestMethod]

        public void SupplierNameMaxLessOne()

        {

            clsSupplier Allsupplier = new clsSupplier();

            string error = "";

            string supplierName = "";

            supplierName = supplierName.PadRight(49, 'a');

            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);

            Assert.AreEqual(error, "");

        }



        [TestMethod]

        public void SupplierNameMax()

        {

            clsSupplier Allsupplier = new clsSupplier();

            string error = "";

            string supplierName = "";

            supplierName = supplierName.PadRight(50,'a');

            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);

            Assert.AreEqual(error, "");

        }



        [TestMethod]

        public void SupplierNameMaxPlusOne()

        {

            clsSupplier Allsupplier = new clsSupplier();

            string error = "";

            string supplierName = "";

            supplierName = supplierName.PadRight(51, 'a');

            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);

            Assert.AreNotEqual(error, "");

        }

        [TestMethod]

        public void SupplierNameExtremMax()

        {

            clsSupplier Allsupplier = new clsSupplier();

            string error = "";

            string supplierName = "";

            supplierName = supplierName.PadRight(500, 'a');

            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);

            Assert.AreNotEqual(error, "");

        }


        [TestMethod]

        public void SupplierNameMid()

        {

            clsSupplier Allsupplier = new clsSupplier();

            string error = "";

            string supplierName = "";

            supplierName = supplierName.PadRight(25, 'a');

            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);

            Assert.AreEqual(error, "");

        }



        [TestMethod]

        public void ContactNameMinLessOne()

        {

            clsSupplier Allsupplier = new clsSupplier();

            string error = "";

            string supplierContactName = "";

            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);

            Assert.AreNotEqual(error, "");

        }



        [TestMethod]

        public void ContactNameMin()

        {

            clsSupplier Allsupplier = new clsSupplier();

            string error = "";

            string supplierContactName = "a";

            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);

            Assert.AreEqual(error, "");

        }



        [TestMethod]

        public void ContactNameMaxLessOne()

        {

            clsSupplier Allsupplier = new clsSupplier();

            string error = "";

            string supplierContactName = new string('a', 49);

            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);

            Assert.AreEqual(error, "");

        }



        [TestMethod]

        public void ContactNameMax()

        {

            clsSupplier Allsupplier = new clsSupplier();

            string error = "";

            string supplierContactName = "";

            supplierContactName = supplierContactName.PadRight(50, 'a');

            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);

            Assert.AreEqual(error, "");

        }



        [TestMethod]

        public void ContactNameMaxPlusOne()

        {

            clsSupplier Allsupplier = new clsSupplier();

            string error = "";

            string supplierContactName = new string('a', 51);

            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);

            Assert.AreNotEqual(error, "");

        }

        [TestMethod]

        public void ContactNameExtremeMax()

        {

            clsSupplier Allsupplier = new clsSupplier();

            string error = "";

            string supplierContactName = "";
            supplierContactName = supplierContactName.PadRight(500, 'a');

            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);

            Assert.AreNotEqual(error, "");

        }

        [TestMethod]

        public void ContactNameMid()

        {

            clsSupplier Allsupplier = new clsSupplier();

            string error = "";

            string suppliercontactName = new string('a', 25);

            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);

            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void ContactEmailMinLessOne()
        {
            clsSupplier Allsupplier = new clsSupplier();
            string error = "";
            string supplierContactEmail = "@gmail.com";
            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void ContactEmailMin()
        {
            clsSupplier Allsupplier = new clsSupplier();
            string error = "";
            string supplierContactEmail = "a@gmail.com";
            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void ContactEmailMinPlusOne()
        {
            clsSupplier Allsupplier = new clsSupplier();
            string error = "";
            string supplierContactEmail = "aa@gmail.com";
            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void ContactEmailMaxLessOne()
        {
            clsSupplier Allsupplier = new clsSupplier();
            string error = "";
            string supplierContactEmail = "";
            supplierContactEmail = supplierContactEmail.PadRight(49, 'a');
            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void ContactEmailMax()
        {
            clsSupplier Allsupplier = new clsSupplier();
            string error = "";
            string supplierContactEmail = "";
            supplierContactEmail = supplierContactEmail.PadRight(50, 'a');
            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void ContactEmailMaxPlusOne()
        {
            clsSupplier Allsupplier = new clsSupplier();
            string error = "";
            string supplierContactEmail = "";
            supplierContactEmail = supplierContactEmail.PadRight(51, 'a');
            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void ContactEmailExtremeMax()
        {
            clsSupplier Allsupplier = new clsSupplier();
            string error = "";
            string supplierContactEmail = "";
            supplierContactEmail = supplierContactEmail.PadRight(500, 'a');
            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void ContactEmailMid()
        {
            clsSupplier Allsupplier = new clsSupplier();
            string error = "";
            string supplierContactEmail = "";
            supplierContactEmail = supplierContactEmail.PadRight(25, 'a');
            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void ContactPhoneMinLessOne()
        {
            clsSupplier Allsupplier = new clsSupplier();
            string error = "";
            string supplierContactPhone = "1"; 
            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void ContactPhoneMin()
        {
            clsSupplier Allsupplier = new clsSupplier();
            string error = "";
            string supplierContactPhone = "123"; 
            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void ContactPhoneMinPlusOne()
        {
            clsSupplier Allsupplier = new clsSupplier();
            string error = "";
            string supplierContactPhone = "1234"; 
            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void ContactPhoneMid()
        {
            clsSupplier Allsupplier = new clsSupplier();
            string error = "";
            string supplierContactPhone = "";
            supplierContactPhone = supplierContactPhone.PadRight(9, 'a');
            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void ContactPhoneMaxLessOne()
        {
            clsSupplier Allsupplier = new clsSupplier();
            string error = "";
            string supplierContactPhone = "";
            supplierContactPhone = supplierContactPhone.PadRight(15, 'a');
            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void ContactPhoneMax()
        {
            clsSupplier Allsupplier = new clsSupplier();
            string error = "";
            string supplierContactPhone = "";
            supplierContactPhone = supplierContactPhone.PadRight(16, 'a');
            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void ContactPhoneMaxPlusOne()
        {
            clsSupplier Allsupplier = new clsSupplier();
            string error = "";
            string supplierContactPhone = "";
            supplierContactPhone = supplierContactPhone.PadRight(17, 'a');
            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void ContactPhoneExtremeMax()
        {
            clsSupplier Allsupplier = new clsSupplier();
            string error = "";
            string supplierContactPhone = "";
            supplierContactPhone = supplierContactPhone.PadRight(100, 'a');
            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);
            Assert.AreNotEqual("", error);
        }



        [TestMethod]

        public void SupplierAddressMinLessOne()

        {

            clsSupplier Allsupplier = new clsSupplier();

            string error = "";

            string supplierAddress = "";

            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);

            Assert.AreNotEqual(error, "");

        }



        [TestMethod]

        public void SupplierAddressMin()

        {

            clsSupplier Allsupplier = new clsSupplier();

            string error = "";

            string supplierAddress = "a";

            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);

            Assert.AreEqual(error, "");

        }



        [TestMethod]

        public void SupplierAddressMaxLessOne()

        {

            clsSupplier Allsupplier = new clsSupplier();

            string error = "";

            string supplierAddress = new string('a', 99);

            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);

            Assert.AreEqual(error, "");

        }



        [TestMethod]

        public void SupplierAddressMax()

        {

            clsSupplier Allsupplier = new clsSupplier();

            string error = "";

            string supplierAddress = new string('a', 100);

            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);

            Assert.AreEqual(error, "");

        }



        [TestMethod]

        public void SupplierAddressMaxPlusOne()

        {

            clsSupplier Allsupplier = new clsSupplier();

            string error = "";

            string supplierAddress = new string('a', 101);

            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);

            Assert.AreNotEqual(error, "");

        }



        [TestMethod]

        public void SupplierAddressMid()

        {

            clsSupplier Allsupplier = new clsSupplier();

            string error = "";

            string supplierAddress = new string('a', 50);

            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);

            Assert.AreEqual(error, "");

        }

        [TestMethod]

        public void SupplierAddressExtreme()

        {

            clsSupplier Allsupplier = new clsSupplier();

            string error = "";

            string supplierAddress = "";

            supplierAddress = supplierAddress.PadRight(500,'a');

            error = Allsupplier.Valid(supplierName, supplierContactName, supplierContactEmail, supplierContactPhone, supplierAddress);

            Assert.AreNotEqual(error, "");

        }





    }

}

