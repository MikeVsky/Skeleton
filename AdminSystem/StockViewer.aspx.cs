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
        //Create a new instance of clsStock
        clsStock AStockUnit = new clsStock();
        //Get data from the session object
        AStockUnit = (clsStock) Session["AStockUnit"];
        //display the sneaker description for this entry
        Response.Write(AStockUnit.SneakerSize);
    }
}