using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_StaffDataEntry : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        try
        {
            clsStaff newStaff = new clsStaff();

            // Convert and capture data, handling any necessary type conversions
            newStaff.EmployeeID = int.Parse(txtEmployeeID.Text); // Converting string to integer
            newStaff.FullName = txtFullName.Text;
            newStaff.Role = txtRole.Text;
            newStaff.ContactPhone = txtContactPhone.Text;
            newStaff.ContactEmail = txtContactEmail.Text;
            newStaff.Department = txtDepartment.Text;
            newStaff.IsActive = chkIsActive.Checked;

            // Store in session
            Session["StaffData"] = newStaff;

            // Navigate to the viewer page
            Response.Redirect("StaffViewer.aspx");
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
        txtEmployeeID.Text = "";
        txtFullName.Text = "";
        txtRole.Text = "";
        txtContactPhone.Text = "";
        txtContactEmail.Text = "";
        txtDepartment.Text = "";
        chkIsActive.Checked = false;
    }

    // Define the ShowError method
    private void ShowError(string message)
    {
        lblError.Visible = true;
        lblError.Text = message;
    }
}