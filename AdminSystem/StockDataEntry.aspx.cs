using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        try
        {
            clsStock2 newStock = new clsStock2();

            // Convert and capture data, handling any necessary type conversions
            newStock.ProductID = int.Parse(txtProductID.Text); // Converting string to integer
            newStock.ProductName = txtProductName.Text;
            newStock.Category = txtCategory.Text;
            newStock.QuantityInStock = int.Parse(txtQuantityInStock.Text); // Converting string to integer
            newStock.Color = txtColor.Text;
            newStock.Size = txtSize.Text;
            newStock.SupplierID = int.Parse(txtSupplierID.Text); // Converting string to integer

            // Store in session
            Session["StockData"] = newStock;

            // Navigate to the viewer page
            Response.Redirect("StockViewer.aspx");
        }
        catch (FormatException)
        {
            ShowError("Invalid data format. Please check your input.");
        }
        catch (Exception ex)
        {
            ShowError("An unexpected error occurred: " + ex.Message);
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // Clear the form
        txtProductID.Text = "";
        txtProductName.Text = "";
        txtCategory.Text = "";
        txtQuantityInStock.Text = "";
        txtColor.Text = "";
        txtSize.Text = "";
        txtSupplierID.Text = "";
    }

    // Define the ShowError method
    private void ShowError(string message)
    {
        lblError.Visible = true;
        lblError.Text = message;
    }
}
