using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FurnitureClasses;

namespace FurnitureFrontOffice
{
    public partial class ACustomerAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //function for adding new records
        void Add()
        {
            //create an instance of the address book
            clsCustomerCollection CustomerBook = new clsCustomerCollection();
            //validate the data on the web form
            string Error = CustomerBook.ThisCustomer.Valid(txtFirstName.Text, txtLastName.Text, txtEmailAddress.Text, txtDateOfBirth.Text, txtAddress.Text, txtPhoneNumber.Text);
            //if the data is OKthen add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                CustomerBook.ThisCustomer.CustomerUserID = txtCustomerUserID.Text;
                CustomerBook.ThisCustomer.Firstname = txtFirstName.Text;
                CustomerBook.ThisCustomer.Lastname = txtLastName.Text;
                CustomerBook.ThisCustomer.EmailAddress = txtEmailAddress.Text;
                CustomerBook.ThisCustomer.DateAdded = Convert.ToDateTime(txtDateOfBirth.Text);
                CustomerBook.ThisCustomer.Address = txtAddress.Text;
                CustomerBook.ThisCustomer.PhoneNumber = txtPhoneNumber.Text;
                //add the record
                CustomerBook.Add();
                //all done so redirect to the main page
                Response.Redirect("Default.aspx");
            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //add the new record
            Add();
            //all done so redirect back to the main page
            Response.Redirect("CustomerDefault.aspx");
        }
    }
}