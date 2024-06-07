using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // If this is the first time the page is displayed
        if (IsPostBack == false)
        {
            if (Session["UserName"] != null)
            {
                lblUserName.Text = "Logged in as: " + Session["UserName"].ToString();
            }
            else
            {
                // Redirect to login page if no user is logged in
                Response.Redirect("StockLogin.aspx");
            }
            // Update the list box
            DisplaySuppliers();
        }
    }

    void DisplaySuppliers()
    {
        // Create an instance of the Supplier collection
        clsSupplierCollection SupplierCollection = new clsSupplierCollection();
        // Set the data source to list of suppliers in the collection
        lstSupplierList.DataSource = SupplierCollection.SupplierList;
        // Set the name of the primary key
        lstSupplierList.DataValueField = "SupplierID";
        // Set the data field to display
        lstSupplierList.DataTextField = "SupplierName";
        // Bind the data to the list
        lstSupplierList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["SupplierID"] = -1;
        Response.Redirect("SupplierDataEntry.aspx");
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        // Create an instance of the supplier collection object
        clsSupplierCollection ASupplier = new clsSupplierCollection();
        // Retrieve the value of the supplier name from the presentation layer
        ASupplier.ReportByContactName(txtFilter.Text);
        // Set the data source to the list of suppliers in the collection
        lstSupplierList.DataSource = ASupplier.SupplierList;
        // Set the name of the primary key
        lstSupplierList.DataValueField = "SupplierID";
        // Set the name of the field to display
        lstSupplierList.DataTextField = "ContactName";
        // Bind the data to the list
        lstSupplierList.DataBind();
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be edited
        int SupplierID;
        // if a record has been selected from the list
        if (lstSupplierList.SelectedIndex != -1)
        {
            // get the primary key value of the record to edit
            SupplierID = Convert.ToInt32(lstSupplierList.SelectedValue);
            // store the data in the session object
            Session["SupplierID"] = SupplierID;
            // redirect to the edit page
            Response.Redirect("SupplierDataEntry.aspx");
        }
        else
        {
            // if no record has been selected
            lblError.Text = "Please select a record from the list to edit.";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be deleted
        Int32 SupplierID;
        // if a record has been selected from the list
        if (lstSupplierList.SelectedIndex != -1)
        {
            // get the primary key value of the record to delete
            SupplierID = Convert.ToInt32(lstSupplierList.SelectedValue);
            // store the data in the session object
            Session["SupplierID"] = SupplierID;
            // redirect to the delete confirmation page
            Response.Redirect("SupplierConfirmDelete.aspx");
        }
        else
        {
            // if no record has been selected
            lblError.Text = "Please select a record from the list to delete.";
        }
    }


    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
    // Create an instance of the supplier collection object
    clsSupplierCollection ASupplier = new clsSupplierCollection();
    // Set an empty string to clear the filter
    ASupplier.ReportByContactName("");
    // Clear any existing filter to tidy up the interface
    txtFilter.Text = "";
    // Set the data source to the list of suppliers in the collection
    lstSupplierList.DataSource = ASupplier.SupplierList;
    // Set the name of the primary key
    lstSupplierList.DataValueField = "SupplierID";
    // Set the name of the field to display
    lstSupplierList.DataTextField = "ContactName";
    // Bind the data to the list
    lstSupplierList.DataBind();
    }
}