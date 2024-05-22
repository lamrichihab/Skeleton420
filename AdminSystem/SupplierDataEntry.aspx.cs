using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;  

public partial class _1_SupplierDataEntry : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsSupplier
        clsSupplier AllSupplier = new clsSupplier();

        // Convert and capture data, handling any necessary type conversions
        int supplierID;
        if (!int.TryParse(txtSupplierID.Text, out supplierID))
        {
            ShowError("Invalid Supplier ID format. Please enter a valid integer value.");
            return;
        }
        AllSupplier.SupplierID = supplierID;

        string supplierName = txtSupplierName.Text;
        string suppliercontactName = txtContactName.Text;
        string suppliercontactPhone = txtContactPhone.Text;
        string suppliercontactEmail = txtContactEmail.Text;
        string supplierAddress = txtAddress.Text;

        // Validate the data
        string Error = AllSupplier.Valid(supplierName, suppliercontactName, suppliercontactEmail, suppliercontactPhone, supplierAddress);
        if (Error == "")
        {
            // Set the data
            AllSupplier.SupplierName = supplierName;
            AllSupplier.ContactName = suppliercontactName;
            AllSupplier.ContactPhone = suppliercontactPhone;
            AllSupplier.ContactEmail = suppliercontactEmail;
            AllSupplier.SupplierAddress = supplierAddress;

            // Store in session
            Session["SupplierData"] = AllSupplier;

            // Navigate to the viewer page
            Response.Redirect("SupplierViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }    


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // Clear the form
        txtSupplierID.Text = "";
        txtSupplierName.Text = "";
        txtContactName.Text = "";
        txtContactPhone.Text = "";
        txtContactEmail.Text = "";
        txtAddress.Text = "";
        chkIsActive.Checked = false;
    }

    // Define the ShowError method
    private void ShowError(string message)
    {
        lblError.Visible = true;
        lblError.Text = message;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        // Create an instance of the supplier class
        clsSupplier ASupplier = new clsSupplier();

        // Create a variable to store the primary key
        Int32 SupplierId;

        // Create a variable to store the result of the find operation
        Boolean Found = false;

        // Get the primary key entered by the user
        SupplierId = Convert.ToInt32(txtSupplierID.Text);

        // Find the record
        Found = ASupplier.Find(SupplierId);

        // If found, display the values of the properties in the form
        if (Found == true)
        {
            txtSupplierName.Text = ASupplier.SupplierName;
            txtContactName.Text = ASupplier.ContactName;
            txtContactPhone.Text = ASupplier.ContactPhone;
            txtContactEmail.Text = ASupplier.ContactEmail;
            txtAddress.Text = ASupplier.SupplierAddress;
            chkIsActive.Checked = ASupplier.IsActive;
        }
    }
}
