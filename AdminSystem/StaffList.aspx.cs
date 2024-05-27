﻿using System;
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
}
   