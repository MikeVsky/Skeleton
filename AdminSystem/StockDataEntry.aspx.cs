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
        //Create a new instance of clsStock
        clsStock AStockUnit = new clsStock();
        //Capture Sneaker Description
        AStockUnit.SneakerSize =Convert.ToInt32(txtSneakerSize.Text);
        //Store the paticular Stock unit in session object
        Session["AStockUnit"] = AStockUnit;
        //Navigate to viewer page
        Response.Redirect("StockViewer.aspx");
    }
}