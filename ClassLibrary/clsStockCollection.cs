using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsStockCollection
    {
        //constructor for the class
        public clsStockCollection()
        {
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);

        }

        //private data member for the list
        List<clsStock2> mStockList = new List<clsStock2>();
        //private data member for thisStock
        clsStock2 mThisStock = new clsStock2();


        public List<clsStock2> StockList
        {
            get
            {
                //return private data member
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mStockList.Count;
            }
            set
            {
                //to be done later
            }
        }
        //public property for ThisStock
        public clsStock2 ThisStock
        {
            get
            {
                //return private data member
                return mThisStock;
            }
            set
            {
                //set the private data
                mThisStock = value;
            }
        }

        public int Add()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductName", mThisStock.ProductName);
            DB.AddParameter("@QuantityInStock", mThisStock.QuantityInStock);
            DB.AddParameter("@Size", mThisStock.Size);
            DB.AddParameter("@Available", mThisStock.Available);
            DB.AddParameter("@ArrivedOn", mThisStock.ArrivedOn);
            DB.AddParameter("@SupplierID", mThisStock.SupplierID);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisStock
            //connect to db
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored proc
            DB.AddParameter("@ProductID", mThisStock.ProductID);
            DB.AddParameter("@ProductName", mThisStock.ProductName);
            DB.AddParameter("@QuantityInStock", mThisStock.QuantityInStock);
            DB.AddParameter("@Size", mThisStock.Size);
            DB.AddParameter("@Available", mThisStock.Available);
            DB.AddParameter("@ArrivedOn", mThisStock.ArrivedOn);
            DB.AddParameter("@SupplierID", mThisStock.SupplierID);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStock
            //connect to db
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the sproc
            DB.AddParameter("@ProductID", mThisStock.ProductID);
            //execute sproc
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportByProductName(string ProductName)
        {
            //filters the records based on a full or partial ProductName
            //connect to db
            clsDataConnection DB = new clsDataConnection();
            //send the item name param to db
            DB.AddParameter("@ProductName", ProductName);
            //execute the sproc
            DB.Execute("sproc_tblStock_FilterByProductName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter db
            //variable for index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStockList = new List<clsStock2>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address object 
                clsStock2 StockItem = new clsStock2();
                //read in the fields from the current record
                StockItem.ArrivedOn = Convert.ToDateTime(DB.DataTable.Rows[Index]["ArrivedOn"]);
                StockItem.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                StockItem.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                StockItem.Size = Convert.ToString(DB.DataTable.Rows[Index]["Size"]);
                StockItem.QuantityInStock = Convert.ToInt32(DB.DataTable.Rows[Index]["QuantityInStock"]);
                StockItem.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                StockItem.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);
                //add the record to the private data memeber list
                mStockList.Add(StockItem);
                //next record
                Index++;

            }
        }
    }
}