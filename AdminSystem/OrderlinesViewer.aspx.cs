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
        //create a new istsance of clsOrder
        clsOrderlines AnOrderlines = new clsOrderlines();
        //get the data from the session object
        AnOrderlines = (clsOrderlines)Session["AnOrderlines"];
        //display this entry
        Response.Write(AnOrderlines.ProductId);
        Response.Write(AnOrderlines.OrderId);
        Response.Write(AnOrderlines.Quantity);
        Response.Write(AnOrderlines.Price);
        Response.Write(AnOrderlines.Location);
        Response.Write(AnOrderlines.OrderStatus);

    }
}