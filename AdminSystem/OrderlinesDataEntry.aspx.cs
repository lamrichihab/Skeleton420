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
        clsOrderlines AnOrderlines = new clsOrderlines();
        //capture infomation
        AnOrderlines.ProductId = Convert.ToInt32(txtProductId.Text);
        AnOrderlines.OrderId = Convert.ToInt32(txtOrderId.Text);
        AnOrderlines.Quantity = Convert.ToInt32(txtQuantity.Text);
        AnOrderlines.Price = Convert.ToInt32(txtPrice.Text);
        AnOrderlines.Location = txtLocation.Text;
        AnOrderlines.OrderStatus = txtOrderStatus.Text;
        //store the ID in the session object
        Session["AnOrderlines"] = AnOrderlines;


        //Navigate to the view page
        Response.Redirect("OrderlinesViewer.aspx");
    }
}