using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new istsance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //get the data from the session object
        AnOrder = (clsOrder)Session["AnOrder"];
        //display this entry
        Response.Write(AnOrder.OrderId);
        Response.Write(AnOrder.CustomerId);
        Response.Write(AnOrder.EmployeeId);
        Response.Write(AnOrder.OrderDate);
        Response.Write(AnOrder.RequiredDate);
        Response.Write(AnOrder.Shipped);
    }
}