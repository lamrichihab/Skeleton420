using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_StaffDataEntry : Page
{
    Int32 EmployeeId;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the staff to be processed
        EmployeeId = Convert.ToInt32(Session["EmployeeId"]);
        if (!IsPostBack)
        {
            // if this is not a new record
            if (EmployeeId != -1)
            {
                // display the current data for the record
                DisplayStaff();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsStaff
        clsStaff AllStaff = new clsStaff();

        // Convert and capture data, handling any necessary type conversions
        int EmployeeId;
        if (!int.TryParse(txtEmployeeID.Text, out EmployeeId))
        {
            ShowError("Invalid Employee ID format. Please enter a valid integer value.");
            return;
        }
        AllStaff.EmployeeId = EmployeeId;

        string fullName = txtFullName.Text;
        string contactPhone = txtContactPhone.Text;
        string contactEmail = txtContactEmail.Text;
        string role = txtRole.Text;
        string department = txtDepartment.Text;
        string Error = "";
        // Validate the data
        Error = AllStaff.Valid(fullName, contactEmail, contactPhone, department, role);
        if (Error=="")
        {
            // Set the data
            AllStaff.EmployeeId= EmployeeId;
            AllStaff.FullName = fullName;
            AllStaff.ContactPhone = contactPhone;
            AllStaff.ContactEmail = contactEmail;
            AllStaff.Role = role;
            AllStaff.Department = department;
            AllStaff.IsActive = chkIsActive.Checked;
            // create a new instance of the staff collection
            clsStaffCollection StaffList = new clsStaffCollection();
            // if this is a new record, add the data
            if (EmployeeId == -1)
            {
                // set the ThisStaff property
                StaffList.ThisStaff = AllStaff;
                // add the new record
                StaffList.Add();
            }
            else
            {
                // find the record to update
                StaffList.ThisStaff.Find(EmployeeId);
                // set the ThisStaff property
                StaffList.ThisStaff = AllStaff;
                // update the record
                StaffList.Update();
            }
        }
        else
        {
            lblError.Text = Error;
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

    protected void BtnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of the staff class
        clsStaff AStaff = new clsStaff();

        // Create a variable to store the primary key
        Int32 EmployeeId;

        // Create a variable to store the result of the find operation
        Boolean Found = false;

        // Get the primary key entered by the user
        EmployeeId = Convert.ToInt32(txtEmployeeID.Text);

        // Find the record
        Found = AStaff.Find(EmployeeId);

        // If found, display the values of the properties in the form
        if (Found == true)
        {
            txtFullName.Text = AStaff.FullName;
            txtRole.Text = AStaff.Role;
            txtContactPhone.Text = AStaff.ContactPhone;
            txtContactEmail.Text = AStaff.ContactEmail;
            txtDepartment.Text = AStaff.Department;
            chkIsActive.Checked = AStaff.IsActive;
        }

    }
    void DisplayStaff()
    {
        // create an instance of the staff collection
        clsStaffCollection StaffBook = new clsStaffCollection();
        // find the record to update
        StaffBook.ThisStaff.Find(EmployeeId);

        // display the data for the record
        txtEmployeeID.Text = StaffBook.ThisStaff.EmployeeId.ToString();
        txtFullName.Text = StaffBook.ThisStaff.FullName.ToString();
        txtRole.Text = StaffBook.ThisStaff.Role.ToString();
        txtContactPhone.Text = StaffBook.ThisStaff.ContactPhone.ToString();
        txtContactEmail.Text = StaffBook.ThisStaff.ContactEmail.ToString();
        txtDepartment.Text = StaffBook.ThisStaff.Department.ToString();
        chkIsActive.Checked = StaffBook.ThisStaff.IsActive;
    }

}