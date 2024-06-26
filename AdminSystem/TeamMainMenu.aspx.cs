﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCustomer_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerLogin.aspx");
    }
    protected void btnStockData_Click(object sender, EventArgs e)
    {
        // Redirect to Add Stock page
        Response.Redirect("StockLogin.aspx");
    }

    protected void btnStaffData_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffLogin.aspx");
    }

    protected void btnSupplierData_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierLogin.aspx");
    }
}
