using ClassLibrary;
using System;
using System.Web.UI;

public partial class _1_StaffViewer : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Display staff information on page load
            staffInfoDiv.InnerHtml = GetStaffInfo();
        }
    }

    // This function retrieves staff data from the session
    public string GetStaffInfo()
    {
        // Retrieve staff data from the session
        clsStaff staff = Session["StaffData"] as clsStaff;

        if (staff == null)
        {
            return "No staff data found."; // Return a message if no data is found
        }

        // Create a formatted string with staff information
        string staffInfo = "Employee ID: " + staff.EmployeeId + "<br>" +
                           "Full Name: " + staff.FullName + "<br>" +
                           "Contact Phone: " + staff.ContactPhone + "<br>" +
                           "Contact Email: " + staff.ContactEmail + "<br>" +
                           "Role: " + staff.Role + "<br>" +
                           "Department: " + staff.Department + "<br>" +
                           "Is Active: " + (staff.IsActive ? "Yes" : "No") + "<br>";

        return staffInfo; // Return the formatted string
    }
}
