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
        try
        {
            // Create a new instance of clsSupplier
            ClassLibrary.clsSupplier newSupplier = new ClassLibrary.clsSupplier();

            // Convert and capture data, handling any necessary type conversions
            newSupplier.SupplierID = int.Parse(txtSupplierID.Text); // Converting string to integer
            newSupplier.SupplierName = txtSupplierName.Text;
            newSupplier.ContactName = txtContactName.Text;
            newSupplier.ContactPhone = txtContactPhone.Text;
            newSupplier.ContactEmail = txtContactEmail.Text;
            newSupplier.Address = txtAddress.Text;
            newSupplier.IsActive = chkIsActive.Checked;

            // Store in session
            Session["SupplierData"] = newSupplier;

            // Navigate to the viewer page
            Response.Redirect("SupplierViewer.aspx");
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
}
