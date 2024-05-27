using System;

public class clsStock2
{
    // Private data members
    private int mProductID;
    private string mProductName;
    private DateTime mArrivedOn;
    private int mQuantityInStock;
    private bool mAvailable;
    private string mSize;
    private int mSupplierID;

    // Public properties
    public int ProductID
    {
        get { return mProductID; }
        set { mProductID = value; }
    }

    public string ProductName
    {
        get { return mProductName; }
        set { mProductName = value; }
    }

    public DateTime ArrivedOn
    {
        get { return mArrivedOn; }
        set { mArrivedOn = value; }
    }

    public int QuantityInStock
    {
        get { return mQuantityInStock; }
        set { mQuantityInStock = value; }
    }

    public bool Available
    {
        get { return mAvailable; }
        set { mAvailable = value; }
    }

    public string Size
    {
        get { return mSize; }
        set { mSize = value; }
    }

    public int SupplierID
    {
        get { return mSupplierID; }
        set { mSupplierID = value; }
    }

    // Find method
    public bool Find(int ProductID)
    {
        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@ProductID", ProductID);
        DB.Execute("sproc_tblStock_FilterByProductID");

        if (DB.Count == 1)
        {
            mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
            mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
            mArrivedOn = Convert.ToDateTime(DB.DataTable.Rows[0]["ArrivedOn"]);
            mQuantityInStock = Convert.ToInt32(DB.DataTable.Rows[0]["QuantityInStock"]);
            mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
            mSize = Convert.ToString(DB.DataTable.Rows[0]["Size"]);
            mSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
            return true;
        }
        else
        {
            return false;
        }
    }

    // Validation method
    public string Valid(string productName, string arrivedOn, string quantityInStock, string size, string supplierID)
    {
        string error = "";

        // Product Name Validation
        if (string.IsNullOrWhiteSpace(productName))
        {
            error += "Product name is required. ";
        }
        else if (productName.Length > 70)
        {
            error += "Product name cannot exceed 70 characters. ";
        }

        // Arrived On Validation
        DateTime dateTemp;
        DateTime dateNow = DateTime.Now.Date;
        if (!DateTime.TryParse(arrivedOn, out dateTemp))
        {
            error += "The date was not a valid date. ";
        }
        else if (dateTemp > dateNow)
        {
            error += "The date cannot be in the future. ";
        }
        else
        {
            if (dateTemp < dateNow.AddYears(-10))
            {
                error += "The date cannot be less then 2014. ";
            }
        }
        // Quantity In Stock Validation
        int quantityTemp;
        if (string.IsNullOrWhiteSpace(quantityInStock))
        {
            error += "Quantity cannot be left blank. ";
        }
        else if (!int.TryParse(quantityInStock, out quantityTemp))
        {
            error += "The quantity was not valid. ";
        }
        else
        {
            if (quantityTemp < 0)
            {
                error += "The quantity cannot be less than 0. ";
            }
            if (quantityTemp > 1000)
            {
                error += "The quantity cannot be greater than 200. ";
            }
        }

        // Size Validation
        if (string.IsNullOrWhiteSpace(size))
        {
            error += "Size is required. ";
        }
        else if (size.Length > 10)
        {
            error += "Size cannot exceed 10 characters. ";
        }

        // Supplier ID Validation
        if (string.IsNullOrWhiteSpace(supplierID))
        {
            error += "Supplier ID is required. ";
        }

        return error;
    }
}
