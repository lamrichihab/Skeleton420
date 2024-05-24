using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            if (CustomerID != -1)
            {
                DisplayCustomer();
            }

        }
    }
    protected void chkCustomerActive_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        // Capture the customer full name
        string FullName = txtFullName.Text;
        // Capture the customer Account Creation Date
        string AccountCreationDateString = txtAccountCreationDate.Text;
        // Capture the customer address
        string ShippingAddress = txtShippingAddress.Text;
        // Capture the customer phone number
        string PhoneNumber = txtPhoneNumber.Text;
        // Capture the customer email
        string emailAddress = txtEmailAddress.Text;
        // Capture the customer active status
        bool IsActive = chkIsActive.Checked;
        // Parse the AccountCreationDate
        DateTime AccountCreationDate;
        bool DateValid = DateTime.TryParse(AccountCreationDateString, out AccountCreationDate);

        if (!DateValid)
        {
            // Display error if the date is not valid
            lblError.Text = "The account creation date is not a valid date.";
            return;
        }
        // Variable to store any error message
        string Error = "";
        // Validate the data
        Error = ACustomer.Valid(FullName, PhoneNumber, emailAddress, ShippingAddress, AccountCreationDate, IsActive);
        if (Error == "")
        {
            ACustomer.CustomerID = CustomerID;
            // Capture the customer full name
            ACustomer.FullName = FullName;
            // Capture the customer Account Creation Date
            ACustomer.AccountCreationDate = Convert.ToDateTime (AccountCreationDate);
            // Capture the customer phone number
            ACustomer.PhoneNumber = PhoneNumber;
            // Capture the customer address
            ACustomer.ShippingAddress = ShippingAddress;
            // Capture the customer email
            ACustomer.EmailAddress = emailAddress;
            // Capture the customer active status
            ACustomer.IsActive = IsActive;
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            if (CustomerID == -1)
            {
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(CustomerID);
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Update();
            }
            CustomerList.ThisCustomer = ACustomer;
            CustomerList.Add();
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            // Display the error message
            lblError.Text = Error;
        }
    }
    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Customer class
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = ACustomer.Find(CustomerID);
        //if found
        if (Found == true)
        {
            //display the value of the properties in the form
            lblError.Text = "";
            txtFullName.Text = ACustomer.FullName;
            txtAccountCreationDate.Text = ACustomer.AccountCreationDate.ToString("yyyy-MM-dd");
            txtShippingAddress.Text = ACustomer.ShippingAddress;
            txtPhoneNumber.Text = ACustomer.PhoneNumber;
            txtEmailAddress.Text = ACustomer.EmailAddress;
            chkIsActive.Checked = ACustomer.IsActive;
        }
        else
        {
            txtFullName.Text = "";
            txtAccountCreationDate.Text = "";
            txtShippingAddress.Text = "";
            txtAccountCreationDate.Text = "";
            txtEmailAddress.Text = "";
            lblError.Text = "Error: This Id doesn't exist!";
            lblError.Visible = true;
        }
    }
     protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
    void DisplayCustomer()
    {
        clsCustomerCollection CustomerList = new clsCustomerCollection();
        bool found = CustomerList.ThisCustomer.Find(CustomerID);

        if (found)
        {
            txtCustomerID.Text = CustomerList.ThisCustomer.CustomerID.ToString();
            txtFullName.Text = CustomerList.ThisCustomer.FullName.ToString();
            txtShippingAddress.Text = CustomerList.ThisCustomer.ShippingAddress.ToString();
            txtPhoneNumber.Text = CustomerList.ThisCustomer.PhoneNumber.ToString();
            txtEmailAddress.Text = CustomerList.ThisCustomer.EmailAddress.ToString();
            txtAccountCreationDate.Text = CustomerList.ThisCustomer.AccountCreationDate.ToString("yyyy-MM-dd");
            chkIsActive.Checked = CustomerList.ThisCustomer.IsActive;
        }
        else
        {
            // Handle the case where the customer is not found
            lblError.Text = "Customer not found.";
            lblError.Visible = true;
        }
    }
    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");

    }
}
