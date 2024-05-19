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
            clsCustomer newCustomer = new clsCustomer();

            // Convert and capture data, handling any necessary type conversions
            newCustomer.CustomerID = int.Parse(txtCustomerID.Text); // Converting string to integer
            newCustomer.FullName = txtFullName.Text;

            // Validate email format (very basic check)
            string emailAddress = txtEmailAddress.Text.Trim(); // Trim to remove leading and trailing whitespaces
            if (string.IsNullOrEmpty(emailAddress) || !IsValidEmail(emailAddress))
            {
                ShowError("Invalid email address.");
                return;
            }

            newCustomer.EmailAddress = emailAddress;
            newCustomer.PhoneNumber = txtPhoneNumber.Text;
            newCustomer.ShippingAddress = txtShippingAddress.Text;
            newCustomer.AccountCreationDate = DateTime.Parse(txtAccountCreationDate.Text); // Converting string to DateTime
            newCustomer.IsActive = chkIsActive.Checked;

            // Validate the data
            string error = newCustomer.Valid(newCustomer.FullName, newCustomer.EmailAddress, newCustomer.PhoneNumber, newCustomer.ShippingAddress, newCustomer.AccountCreationDate, newCustomer.IsActive);
            if (string.IsNullOrEmpty(error))
            {
                // Store in session
                Session["CustomerData"] = newCustomer;

                // Navigate to the viewer page
                Response.Redirect("CustomerViewer.aspx");
            }
            else
            {
                // Display the error message
                ShowError(error);
            }
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
        txtCustomerID.Text = "";
        txtFullName.Text = "";
        txtEmailAddress.Text = "";
        txtPhoneNumber.Text = "";
        txtShippingAddress.Text = "";
        txtAccountCreationDate.Text = "";
        chkIsActive.Checked = false;
    }

    // Validate email address format
    private bool IsValidEmail(string email)
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }

    // Define the ShowError method
    private void ShowError(string message)
    {
        lblError.Visible = true;
        lblError.Text = message;
    }

    protected void btnFind_Click(Object sender, EventArgs e)
    {
        // Create an instance of the customer class
        clsCustomer ACustomer = new clsCustomer();

        // Create a variable to store the customer ID
        Int32 CustomerID;

        // Create a variable to store the result of the find operation
        Boolean Found = false;

        // Get the customer ID entered by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);

        // Find the record
        Found = ACustomer.Find(CustomerID);

        // If found
        if (Found == true)
        {
            // Display values of properties in form
            txtFullName.Text = ACustomer.FullName;
            txtEmailAddress.Text = ACustomer.EmailAddress;
            txtPhoneNumber.Text = ACustomer.PhoneNumber;
            txtShippingAddress.Text = ACustomer.ShippingAddress;
            txtAccountCreationDate.Text = ACustomer.AccountCreationDate.ToString("yyyy-MM-dd");
            chkIsActive.Checked = ACustomer.IsActive;
        }
    }
}
