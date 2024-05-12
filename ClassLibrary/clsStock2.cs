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
            // Assume the method will return false
            bool Found = false;
            // Check if the Product ID is 1
            if (ProductID == 1)
            {
                // Set the properties
                mProductID = 1;
                mProductName = "Sample Product";
                mCategory = "Electronics";
                mQuantityInStock = 100;
                mColor = "Red";
                mSize = "Medium";
                mSupplierID = 5;
                // Indicate that the data was found
                Found = true;
            }
            // Return whether the data was found
            return Found;
        }
    }
}

