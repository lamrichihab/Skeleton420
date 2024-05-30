using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

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
            DisplayStaffs();
        }
    }
    void DisplayStaffs()
    {
        // Create an instance of the Staff collection
        clsStaffCollection StaffCollection = new clsStaffCollection();
        // Set the data source to list of staff in the collection
        lstStaffList.DataSource = StaffCollection.StaffList;
        // Set the name of the primary key
        lstStaffList.DataValueField = "EmployeeId";
        // Set the data field to display
        lstStaffList.DataTextField = "FullName";
        // Bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["EmployeeId"] = -1;
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void BtnEdit_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be edited
        int EmployeeId ;
        // if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            // get the primary key value of the record to edit
            EmployeeId = Convert.ToInt32(lstStaffList.SelectedValue);
            // store the data in the session object
            Session["EmployeeId"] = EmployeeId ;
            // redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            // if no record has been selected
            lblError.Text = "Please select a record from the list to edit.";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be deleted
        Int32 EmployeeId;
        // if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            // get the primary key value of the record to delete
            EmployeeId = Convert.ToInt32(lstStaffList.SelectedValue);
            // store the data in the session object
            Session["EmployeeId"] = EmployeeId;
            // redirect to the delete confirmation page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else
        {
            // if no record has been selected
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        // Create an instance of the staff collection object
        clsStaffCollection AStaff = new clsStaffCollection();
        // Retrieve the value of the role from the presentation layer
        AStaff.ReportByDepartment(txtFilter.Text);
        // Set the data source to the list of staff in the collection
        lstStaffList.DataSource = AStaff.StaffList;
        // Set the name of the primary key
        lstStaffList.DataValueField = "EmployeeId";
        // Set the name of the field to display
        lstStaffList.DataTextField = "Department";
        // Bind the data to the list
        lstStaffList.DataBind();
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {   // Create an instance of the staff collection object
        clsStaffCollection AStaff = new clsStaffCollection();
        // Set an empty string to clear the filter
        AStaff.ReportByDepartment("");
        // Clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        // Set the data source to the list of staff in the collection
        lstStaffList.DataSource = AStaff.StaffList;
        // Set the name of the primary key
        lstStaffList.DataValueField = "EmployeeId";
        // Set the name of the field to display
        lstStaffList.DataTextField = "Department";
        // Bind the data to the list
        lstStaffList.DataBind();

    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}
   