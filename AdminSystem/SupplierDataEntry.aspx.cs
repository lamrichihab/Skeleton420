using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;  

public partial class _1_SupplierDataEntry : Page
{
    Int32 SupplierID;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the staff to be processed
        SupplierID = Convert.ToInt32(Session["SupplierId"]);
        if (!IsPostBack)
        {
            // if this is not a new record
            if (SupplierID != -1)
            {
                // display the current data for the record
                DisplaySupplier();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsSupplier
        clsSupplier AllSupplier = new clsSupplier();


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
            AllSupplier.SupplierID = SupplierID;
            AllSupplier.SupplierName = supplierName;
            AllSupplier.ContactName = suppliercontactName;
            AllSupplier.ContactPhone = suppliercontactPhone;
            AllSupplier.ContactEmail = suppliercontactEmail;
            AllSupplier.SupplierAddress = supplierAddress;

            // Store in session
            Session["SupplierData"] = AllSupplier;

            // Debug message to confirm session storage
            lblError.Text = "Supplier data stored in session.";

            // create a new instance of the staff collection
            clsSupplierCollection SupplierList = new clsSupplierCollection();
            // if this is a new record, add the data
            if (SupplierID == -1)
            {
                // set the ThisStaff property
                SupplierList.ThisSupplier = AllSupplier;
                // add the new record
                SupplierList.Add();
            }
            else
            {
                // find the record to update
                SupplierList.ThisSupplier.Find(SupplierID);
                // set the ThisStaff property
                SupplierList.ThisSupplier = AllSupplier;
                // update the record
                SupplierList.Update();
            }
            SupplierList.ThisSupplier = AllSupplier;
            SupplierList.Add();
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

    protected void Find_Click(object sender, EventArgs e)
    {
        
            // Create an instance of the supplier class
            clsSupplier ASupplier = new clsSupplier();

            // Variable to store the primary key
            Int32 SupplierId;

            // Variable to store the result of the find operation
            Boolean Found = false;

            if (txtSupplierID.Text != "")
            {
                // Get the primary key entered by the user
                SupplierId = Convert.ToInt32(txtSupplierID.Text);
                // Find the record
                Found = ASupplier.Find(SupplierId);
            }

            // If found, display the values of the properties in the form
            if (Found == true)
            {
                lblError.Text = "";
                txtSupplierName.Text = ASupplier.SupplierName;
                txtContactName.Text = ASupplier.ContactName;
                txtContactPhone.Text = ASupplier.ContactPhone;
                txtContactEmail.Text = ASupplier.ContactEmail;
                txtAddress.Text = ASupplier.SupplierAddress;
                chkIsActive.Checked = ASupplier.IsActive;
            }
            else
            {
                // Clear the fields
                txtSupplierName.Text = "";
                txtContactName.Text = "";
                txtContactPhone.Text = "";
                txtContactEmail.Text = "";
                txtAddress.Text = "";
                chkIsActive.Checked = false;
                // Display error message
                lblError.Text = "This ID does not exist";
                lblError.Visible = true;
            }
    }
    void DisplaySupplier()
    {
        clsSupplierCollection SupplierList = new clsSupplierCollection();
        bool found = SupplierList.ThisSupplier.Find(SupplierID);

        if (found)
        {
            txtSupplierID.Text = SupplierList.ThisSupplier.SupplierID.ToString();
            txtSupplierName.Text = SupplierList.ThisSupplier.SupplierName.ToString();
            txtContactName.Text = SupplierList.ThisSupplier.ContactName.ToString();
            txtContactPhone.Text = SupplierList.ThisSupplier.ContactPhone.ToString();
            txtContactEmail.Text = SupplierList.ThisSupplier.ContactEmail.ToString();
            txtAddress.Text = SupplierList.ThisSupplier.SupplierAddress.ToString();
            chkIsActive.Checked = SupplierList.ThisSupplier.IsActive;
        }
        else
        {
            // Handle the case where the supplier is not found
            lblError.Text = "Supplier not found.";
            lblError.Visible = true;
        }
    }
}
