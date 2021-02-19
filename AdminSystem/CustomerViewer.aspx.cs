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
        clsCustomer ACustomer = new clsCustomer();
        //get the data from session object
        ACustomer = (clsCustomer)Session["ACustomer"];
        //display the customer first name for this entry
        Response.Write(ACustomer.FirstName);
        //display the customer last name for this entry
        Response.Write(ACustomer.LastName);
        //display the customer email for this entry
         Response.Write(ACustomer.Email);
        //display the customer Street for this entry
        Response.Write(ACustomer.Street);
        //display the customer flat for this entry
        Response.Write(ACustomer.Flat);
        //display the customer city for this entry
        Response.Write(ACustomer.City);
        //display the customer postcode for this entry
        Response.Write(ACustomer.Postcode);
        //display the customer country for this entry
        Response.Write(ACustomer.Country);
    }
}