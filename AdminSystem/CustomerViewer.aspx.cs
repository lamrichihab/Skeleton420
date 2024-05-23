using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        ACustomer = (clsCustomer)Session["ACustomer"];
        Response.Write(ACustomer.CustomerID);
        Response.Write(ACustomer.ShippingAddress);
        Response.Write(ACustomer.FullName);
        Response.Write(ACustomer.PhoneNumber);
        Response.Write(ACustomer.EmailAddress);
        Response.Write(ACustomer.AccountCreationDate);
        Response.Write(ACustomer.IsActive);
    }
}

