using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 EmployeeId;
    protected void Page_Load(object sender, EventArgs e)
    {
        EmployeeId = Convert.ToInt32(Session["EmployeeId"]);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        clsStaffCollection StaffBook = new clsStaffCollection();
        StaffBook.ThisStaff.Find(EmployeeId);
        StaffBook.Delete();
        Response.Redirect("StaffList.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}