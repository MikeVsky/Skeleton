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
        clsCustomer ACustomer = new clsCustomer();
        //capture the first name
        ACustomer.FirstName = txtFirstName.Text;
        //capture the last name
        ACustomer.LastName = txtLastName.Text;
        //capture the mail
        ACustomer.Email = txtEmail.Text;
        //capture the street
        ACustomer.Street = txtStreet.Text;
        //capture the flat
        ACustomer.Flat = txtFlat.Text;
        //capture the city
        ACustomer.City = txtCity.Text;
        //capture the postcode
        ACustomer.Postcode = txtPostcode.Text;
        //capture the Country
        ACustomer.Country = txtCountry.Text;

        //store the customer in the current session 
        Session["ACustomer"] = ACustomer;
        //navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key enterned by the user
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //find the record
        Found = ACustomer.Find(CustomerId);
        //if found
        if (Found == true)
        {
            txtFirstName.Text = ACustomer.FirstName;
            txtLastName.Text = ACustomer.LastName;
            txtEmail.Text = ACustomer.Email;
            txtStreet.Text = ACustomer.Street;
            txtFlat.Text = ACustomer.Flat;
            txtCity.Text = ACustomer.City;
            txtPostcode.Text = ACustomer.Postcode;
            txtCountry.Text = ACustomer.Country;
            txtDateAdded.Text = ACustomer.DateAdded.ToString();


        }
    }
}