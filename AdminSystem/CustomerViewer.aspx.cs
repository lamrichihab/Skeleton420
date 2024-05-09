using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary; 
public partial class _1Viewer : Page
{
    // This function retrieves customer data from the session
    public string GetCustomerInfo()
    {
        // Retrieve customer data from the session
        clsCustomer customer = Session["CustomerData"] as clsCustomer;

        if (customer == null)
        {
            return "No customer data found."; // Return a message if no data is found
        }

        // Create a formatted string with customer information
        string customerInfo = "Customer ID: " + customer.CustomerID + "<br>" +
                              "Full Name: " + customer.FullName + "<br>" +
                              "Email Address: " + customer.EmailAddress + "<br>" +
                              "Phone Number: " + customer.PhoneNumber + "<br>" +
                              "Shipping Address: " + customer.ShippingAddress + "<br>" +
                              "Account Creation Date: " + customer.AccountCreationDate.ToShortDateString() + "<br>" +
                              "Is Active: " + (customer.IsActive ? "Yes" : "No") + "<br>";

        return customerInfo; // Return the formatted string
    }
}
