using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibrary // Adjust to your project's namespace
{
    public class clsStock2
    {
        //================================================== Private Data Members ==================================================
        private int mProductID;
        private string mProductName;
        private string mCategory;
        private int mQuantityInStock;
        private string mColor;
        private string mSize;
        private int mSupplierID;

        //================================================== Public Properties ==================================================

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

        //================================================== Find Method ==================================================
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

        //================================================== Validation Method ==================================================
        public string Valid(string productName, string category, int quantityInStock, string color, string size, int supplierId)
        {
            // Variable to store the error message
            string error = "";

            //================================================ Product Name Validation ================================================
            if (string.IsNullOrWhiteSpace(productName))
            {
                error += "Product name is required. ";
            }
            else if (productName.Length > 50) // Assuming maximum length is 50 characters
            {
                error += "Product name cannot exceed 50 characters. ";
            }

            //================================================ Category Validation ================================================
            if (string.IsNullOrWhiteSpace(category))
            {
                error += "Category is required. ";
            }
            else if (category.Length > 30) // Assuming maximum length is 30 characters
            {
                error += "Category cannot exceed 30 characters. ";
            }

            //================================================ Quantity In Stock Validation ================================================
            if (quantityInStock < 0)
            {
                error += "Quantity in stock cannot be negative. ";
            }

            //================================================ Color Validation ================================================
            if (string.IsNullOrWhiteSpace(color))
            {
                error += "Color is required. ";
            }
            else if (color.Length > 20) // Assuming maximum length is 20 characters
            {
                error += "Color cannot exceed 20 characters. ";
            }

            //================================================ Size Validation ================================================
            if (string.IsNullOrWhiteSpace(size))
            {
                error += "Size is required. ";
            }
            else if (size.Length > 10) // Assuming maximum length is 10 characters
            {
                error += "Size cannot exceed 10 characters. ";
            }

            //================================================ Supplier ID Validation ================================================
            if (supplierId <= 0)
            {
                error += "Supplier ID must be a positive number. ";
            }

            // Return any error messages, or an empty string if there are no errors
            return error;
        }
    }
}