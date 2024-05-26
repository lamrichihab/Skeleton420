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
        private DateTime mArrivedOn;
        private int mQuantityInStock;
        private Boolean mAvailable;
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
        public DateTime ArrivedOn
        {
            get { return mArrivedOn; }
            set { ArrivedOn = value; }
        }

        // QuantityInStock property
        public int QuantityInStock
        {
            get { return mQuantityInStock; }
            set { mQuantityInStock = value; }
        }

        // Available property
        public Boolean Available
        {
            get { return mAvailable; }
            set { mAvailable = value; }
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
                mArrivedOn = Convert.ToDateTime(DB.DataTable.Rows[0]["ArrivedOn"]);
                mQuantityInStock = Convert.ToInt32(DB.DataTable.Rows[0]["QuantityInStock"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
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
        public string Valid(string productName, string arrivedOn, string quantityInStock, string size, string supplierId)
        {
            // Variable to store the error message
            string error = "";

            //================================================ Product Name Validation ================================================
            if (string.IsNullOrWhiteSpace(productName))
            {
                error += "Product name is required.";
            }
            else if (productName.Length > 50) // Assuming maximum length is 50 characters
            {
                error += "Product name cannot exceed 50 characters.";
            }

            //================================================ arrivedOn Validation ================================================
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //create an instance of DateTime (DateComp) to compare with DateTemp in the if statements
            DateTime DateNow = DateTime.Now.Date;
            try
            {
                //copy the arrivedOn value to the DateTemp variable
                DateTemp = Convert.ToDateTime(arrivedOn);

                if (DateTemp < DateNow)//compare the dates
                {
                    //record the error
                    error = error + "The date cannot be in the past";
                }

                if (DateTemp > DateNow)
                {
                    //record the error
                    error = error + "The date cannot be in the future";
                }
            }
            catch
            {
                error = error + "The date was not a valid date";
            }

            //================================================ Quantity In Stock Validation ================================================
            //create temporary variable to store the int values
            int QuantityTemp;
            if (QuantityInStock == 0 )
            {
                error = error + "Quantity cannot be left blank";
            }
            else
            {
                try
                {
                    QuantityTemp = Convert.ToInt32(QuantityInStock);

                    if (QuantityTemp < 0)
                    {
                        error = error + "The quantity cannot be less than 0";
                    }

                    if (QuantityTemp > 200)
                    {
                        error = error + "The quantity cannot be greater than 200";
                    }


                }
                catch
                {
                    error = error + "The quantity was not valid";
                }
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
            if (string.IsNullOrWhiteSpace(supplierId))
            {
                error += "Supplier ID  is required. ";
            }

            // Return any error messages, or an empty string if there are no errors
            return error;
        }
    }
}