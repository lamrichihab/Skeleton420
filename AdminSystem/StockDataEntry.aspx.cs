using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.Expressions;
using ClassLibrary;
using Microsoft.SqlServer.Server;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        ProductID = Convert.ToInt32(Session["ProductID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (ProductID != -1)
            {
                //display the current data for the record
                DisplayStock();
            }
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }

    void DisplayStock()
    {
        //create instance
        clsStockCollection StockList = new clsStockCollection();
        //find the record to update
        StockList.ThisStock.Find(ProductID);
        //display the data for the record
        txtProductID.Text = StockList.ThisStock.ProductID.ToString();
        txtProductName.Text = StockList.ThisStock.ProductName.ToString();
        txtQuantityInStock.Text = StockList.ThisStock.QuantityInStock.ToString();
        txtSize.Text = StockList.ThisStock.Size.ToString();
        txtArrivedOn.Text = StockList.ThisStock.ArrivedOn.ToString("yyyy-MM-dd");
        chkAvailable.Checked = StockList.ThisStock.Available;
        txtSupplierID.Text = StockList.ThisStock.SupplierID.ToString ();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of class
        clsStock2 StockItem = new clsStock2();

        //capture the data using string variables to pass these into the valid method
        string ProductName = txtProductName.Text;
        string QuantityInStock = txtQuantityInStock.Text;
        string Size = txtSize.Text;
        string ArrivedOn = txtArrivedOn.Text;
        string SupplierID = txtSupplierID.Text;
        string Available = chkAvailable.Text;

        //variable to store error messages
        string Error = "";

        //validate the data by passing the above string vars
        //if valid is OK they will be stored as the intended data type
        Error = StockItem.Valid(ProductName, ArrivedOn, QuantityInStock, Size, SupplierID);
        if (Error == "")
        {
            //capture all the data
            StockItem.ProductName =Convert.ToString(ProductName) ;
            StockItem.ArrivedOn = Convert.ToDateTime(ArrivedOn);
            StockItem.QuantityInStock = Convert.ToInt32(QuantityInStock);
            StockItem.Size = Convert.ToString(Size);
            StockItem.SupplierID = Convert.ToInt32(SupplierID);
            StockItem.Available = chkAvailable.Checked;
            //create a new instance of the stock collection
            clsStockCollection StockList = new clsStockCollection();

            //if this is a new record i.e StockId = -1 then add the data
            if (ProductID == -1)
            {
                //set the ThisStock property
                StockList.ThisStock = StockItem;
                //add the new record
                StockList.Add();
            }
            //otherwise must update
            else
            {
                //find the record to udate
                StockList.ThisStock.Find(ProductID);
                //set the ThisStock property
                StockList.ThisStock = StockItem;
                //update the record
                StockList.Update();
            }
            //redirect back to the list page
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display an error message if the valid fails 
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of stock class
        clsStock2 StockItem = new clsStock2();
        //create a variable to store primary key
        Int32 StockId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary entered by the user
        StockId = Convert.ToInt32(txtProductID.Text);
        //find the record
        Found = StockItem.Find(StockId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in from
            txtProductID.Text = StockItem.ProductID.ToString();
            txtProductName.Text = StockItem.ProductName;
            txtQuantityInStock.Text = StockItem.QuantityInStock.ToString();
            txtSize.Text = StockItem.Size.ToString();
            txtArrivedOn.Text = StockItem.ArrivedOn.ToString();
            txtSupplierID.Text = StockItem.SupplierID.ToString();
            chkAvailable.Checked = StockItem.Available;
            lblError.Text = "";
        }
        else
        {
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtQuantityInStock.Text = "";
            txtSize.Text = "";
            txtArrivedOn.Text = "";
            txtSupplierID.Text = "";
            chkAvailable.Checked = false;
            lblError.Text = "Record Not Found";
        }

    }
    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");

    }
}