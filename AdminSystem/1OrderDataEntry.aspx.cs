using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new istance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture infomation
        AnOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
        AnOrder.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        AnOrder.EmployeeId = Convert.ToInt32(txtEmployeeId.Text);
        AnOrder.OrderDate = Convert.ToDateTime(DateTime.Now);
        AnOrder.RequiredDate = Convert.ToDateTime(DateTime.Now);
        AnOrder.Shipped = chkShipped.Checked;
        //store the ID in the session object
        Session["AnOrder"] = AnOrder;
        
    
        //Navigate to the view page
        Response.Redirect("1OrderViewer.aspx");
    }
}