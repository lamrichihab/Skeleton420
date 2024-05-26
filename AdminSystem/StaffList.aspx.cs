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
            // Update the list box
            DisplayStaff();
        }
    }
    void DisplayStaff()
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
}
   