using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FurnitureClasses;

namespace FurnitureFrontOffice
{
    public partial class ACustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //Create an instance of class
            clsCustomer ACustomer = new clsCustomer();
            //capture the First Name
            string FirstName = txtFirstName.Text;
            string LastName = txtLastName.Text;
            string Address = txtAddress.Text;
            string EmailAddress = txtEmailAddress.Text;
            string PhoneNumber = txtPhoneNumber.Text;
            string DateOfBirth = txtDateOfBirth.Text;
            //variable to store any error messages
            string Error = "";
            //validate the data
            Error = ACustomer.Valid(FirstName, LastName, Address, EmailAddress, PhoneNumber, DateOfBirth);
            if (Error == "")
            {
                //capture the FirstName
                ACustomer.Firstname = FirstName;
                ACustomer.Lastname = LastName;
                ACustomer.Address = Address;
                ACustomer.EmailAddress = EmailAddress;
                ACustomer.PhoneNumber = PhoneNumber;
                ACustomer.DateAdded = Convert.ToDateTime(DateOfBirth);         
                //store the Customer ID in the session Object
                Session["ACustomer"] = ACustomer;
                //redirect to the viewer page
                Response.Redirect("CustomerViewer.aspx");
            }
            else
            {
                //display the error message
                lblError.Text = Error;
            }
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            //Create an instance of class
            clsCustomer ACustomer = new clsCustomer();
            //Variable to store the primary key
            string CustomerUserID;
            //Variable to store the result of the find operation
            Boolean Found = false;
            //get the primary key entered by the user
            CustomerUserID = Convert.ToString(txtCustomerUserID.Text);
            //find the record
            Found = ACustomer.Find(CustomerUserID);
            //if found
            if (Found == true)
            {
                //display the values of properties
                txtAddress.Text = ACustomer.Address;
                txtDateOfBirth.Text = ACustomer.DateAdded.ToString();
                txtEmailAddress.Text = ACustomer.EmailAddress;
                txtFirstName.Text = ACustomer.Firstname;
                txtLastName.Text = ACustomer.Lastname;
                txtPhoneNumber.Text = ACustomer.PhoneNumber;
            }
        }
    }
}