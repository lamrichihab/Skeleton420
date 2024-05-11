using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : Page
{
    // This function retrieves stock data from the session
    public string GetStockInfo()
    {
        // Retrieve stock data from the session
        clsStock2 stock = Session["StockData"] as clsStock2;

        if (stock == null)
        {
            return "No stock data found."; // Return a message if no data is found
        }

        // Create a formatted string with stock information
        string stockInfo = "Product ID: " + stock.ProductID + "<br>" +
                           "Product Name: " + stock.ProductName + "<br>" +
                           "Category: " + stock.Category + "<br>" +
                           "Quantity in Stock: " + stock.QuantityInStock + "<br>" +
                           "Color: " + stock.Color + "<br>" +
                           "Size: " + stock.Size + "<br>" +
                           "Supplier ID: " + stock.SupplierID + "<br>";

        return stockInfo; // Return the formatted string
    }
}
