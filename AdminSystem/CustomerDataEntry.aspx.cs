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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the first name
        AnCustomer.FirstName = txtFirstName.Text;
        //capture the last name
        AnCustomer.LastName = txtLastName.Text;
        //capture the mail
        AnCustomer.Email = txtEmail.Text;
        //capture the street
        AnCustomer.Street = txtStreet.Text;
        //capture the flat
        AnCustomer.Flat = txtFlat.Text;
        //capture the city
        AnCustomer.City = txtCity.Text;
        //capture the postcode
        AnCustomer.Postcode = txtPostcode.Text;
        //capture the Country
        AnCustomer.Country = txtCountry.Text;
        //store the customer in the current session 
        Session["AnCustomer"] = AnCustomer;
        //navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }
}