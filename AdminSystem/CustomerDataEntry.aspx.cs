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
            if (!newCustomer.EmailAddress.Contains("@"))
            {
                ShowError("Invalid email address.");
                return;
            }

            newCustomer.EmailAddress = txtEmailAddress.Text;
            newCustomer.PhoneNumber = txtPhoneNumber.Text;
            newCustomer.ShippingAddress = txtShippingAddress.Text;
            newCustomer.AccountCreationDate = DateTime.Parse(txtAccountCreationDate.Text); // Converting string to DateTime
            newCustomer.IsActive = chkIsActive.Checked;

            // Store in session
            Session["CustomerData"] = newCustomer;

            // Navigate to the viewer page
            Response.Redirect("CustomerViewer.aspx");
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

    private void ShowError(string message)
    {
        lblError.Visible = true;
        lblError.Text = message;
    }
}
