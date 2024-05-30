using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 SupplierID;
    protected void Page_Load(object sender, EventArgs e)
    {
        SupplierID = Convert.ToInt32(Session["SupplierID"]);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        SupplierBook.ThisSupplier.Find(SupplierID);
        SupplierBook.Delete();
        Response.Redirect("SupplierList.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierList.aspx");
    }
}