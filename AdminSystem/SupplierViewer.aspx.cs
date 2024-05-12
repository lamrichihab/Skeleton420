using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_SupplierViewer : Page
{
    // This function retrieves supplier data from the session
    public string GetSupplierInfo()
    {
        // Retrieve supplier data from the session
        ClassLibrary.clsSupplier supplier = Session["SupplierData"] as ClassLibrary.clsSupplier;

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
                              "Address: " + supplier.Address + "<br>" +
                              "Is Active: " + (supplier.IsActive ? "Yes" : "No") + "<br>";

        return supplierInfo; // Return the formatted string
    }
}