using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of class
        clsStock2 StockItem = new clsStock2();

        //get the data from the session object
        StockItem = (clsStock2)Session["StockItem"];

        //display the data from this entry
        Response.Write(StockItem.ProductName + " ");
        Response.Write(StockItem.ArrivedOn + " ");
        Response.Write(StockItem.QuantityInStock + " ");
        Response.Write(StockItem.Available + " ");
        Response.Write(StockItem.Size + " ");
        Response.Write(StockItem.SupplierID + " ");
    }
}
