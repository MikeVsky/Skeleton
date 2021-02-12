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
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //get the data from session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //display the customer first name for this entry
        Response.Write(AnCustomer.FirstName);
        //display the customer last name for this entry
        Response.Write(AnCustomer.LastName);
        //display the customer email for this entry
         Response.Write(AnCustomer.Email);
        //display the customer Street for this entry
        Response.Write(AnCustomer.Street);
        //display the customer flat for this entry
        Response.Write(AnCustomer.Flat);
        //display the customer city for this entry
        Response.Write(AnCustomer.City);
        //display the customer postcode for this entry
        Response.Write(AnCustomer.Postcode);
        //display the customer country for this entry
        Response.Write(AnCustomer.Country);
    }
}