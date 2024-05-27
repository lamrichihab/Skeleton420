using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            // Check if the user is logged in
            if (Session["UserName"] != null)
            {
                lblUserName.Text = "Logged in as: " + Session["UserName"].ToString();
            }
            else
            {
                // Redirect to login page if no user is logged in
                Response.Redirect("StockLogin.aspx");
            }
            DisplayStock();

        }
    }
    void DisplayStock()
    {
        clsStockCollection AllStock= new clsStockCollection();
        lstStockList.DataSource = AllStock.StockList;
        lstStockList.DataValueField = "ProductID";
        lstStockList.DataTextField = "ProductName";
        lstStockList.DataBind();
    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ProductID"] = -1;
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 ProductId;
        if (lstStockList.SelectedIndex != -1)
        {
            ProductId = Convert.ToInt32(lstStockList.SelectedValue);
            Session["ProductID"] = ProductId;
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from list to edit";
        }

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 ProductID;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //het the primary key value of the record to edit
            ProductID = Convert.ToInt32(lstStockList.SelectedValue);
            //stroe the data in the session object
            Session["ProductID"] = ProductID;
            //redirect to delete page
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else//if no records has benn select.
        {

            lblError.Text = "Please select a record to delete from the list";
            lblError.Visible = true;
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportByProductName(txtFilter.Text);
        lstStockList.DataSource = Stock.StockList;
        lstStockList.DataValueField = "ProductID";
        lstStockList.DataTextField = "ProductName";
        lstStockList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportByProductName("");
        txtFilter.Text = "";
        Stock.ReportByProductName(txtFilter.Text);
        lstStockList.DataSource = Stock.StockList;
        lstStockList.DataValueField = "ProductID";
        lstStockList.DataTextField = "ProductName";
        lstStockList.DataBind();
    }
    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}