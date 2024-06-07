using ClassLibrary;
using System;
using System.Data.SqlClient;
using System.Web.UI;

public partial class _1_SupplierViewer : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Display supplier information on page load
            supplierInfoDiv.InnerHtml = GetSupplierInfo();
        }
    }

    // This function retrieves supplier data from the session
    public string GetSupplierInfo()
    {
        // Retrieve supplier data from the session
        clsSupplier supplier = Session["SupplierData"] as clsSupplier;

        if (supplier == null)
        {
            return "No supplier data found."; // Return a message if no data is found
        }


        // Create a formatted string with supplier information
        string supplierInfo = "Supplier ID: " + supplier.SupplierID + "<br>" +
                              "Supplier Name: " + supplier.SupplierName + "<br>" +
                              "Contact Name: " + supplier.ContactName + "<br>" +
                              "Contact Phone: " + supplier.ContactPhone + "<br>" +
                              "Contact Email: " + supplier.ContactEmail + "<br>" +
                              "Address: " + supplier.SupplierAddress + "<br>" +
                              "Is Active: " + (supplier.IsActive ? "Yes" : "No") + "<br>";

        return supplierInfo; // Return the formatted string
    }
}
