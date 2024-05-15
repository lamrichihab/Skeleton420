using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// File: clsStock.cs
namespace ClassLibrary // Adjust to your project's namespace
{
    public class clsStock2
    {
        // Private data members for the properties
        private int mProductID;
        private string mProductName;
        private string mCategory;
        private int mQuantityInStock;
        private string mColor;
        private string mSize;
        private int mSupplierID;

        // ProductID property
        public int ProductID
        {
            get { return mProductID; }
            set { mProductID = value; }
        }

        // ProductName property
        public string ProductName
        {
            get { return mProductName; }
            set { mProductName = value; }
        }

        // Category property
        public string Category
        {
            get { return mCategory; }
            set { mCategory = value; }
        }

        // QuantityInStock property
        public int QuantityInStock
        {
            get { return mQuantityInStock; }
            set { mQuantityInStock = value; }
        }

        // Color property
        public string Color
        {
            get { return mColor; }
            set { mColor = value; }
        }

        // Size property
        public string Size
        {
            get { return mSize; }
            set { mSize = value; }
        }

        // SupplierID property
        public int SupplierID
        {
            get { return mSupplierID; }
            set { mSupplierID = value; }
        }

        // Find method
        public bool Find(int ProductID)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the product ID to search for
            DB.AddParameter("@ProductID", ProductID);
            // Execute the stored procedure or query to retrieve data
            DB.Execute("sproc_tblStock_FilterByProductID");

            // If one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                // Copy the data from the database to the private data members
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mCategory = Convert.ToString(DB.DataTable.Rows[0]["Category"]);
                mQuantityInStock = Convert.ToInt32(DB.DataTable.Rows[0]["QuantityInStock"]);
                mColor = Convert.ToString(DB.DataTable.Rows[0]["Color"]);
                mSize = Convert.ToString(DB.DataTable.Rows[0]["Size"]);
                mSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);

                // Return that everything worked OK
                return true;
            }
            // If no record was found
            else
            {
                // Return false indicating there is a problem
                return false;
            }
        }
    }
}
