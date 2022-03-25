using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FurnitureClasses;

namespace FurnitureFrontOffice
{
    public partial class ACustomerUpdate : System.Web.UI.Page
    {
        string CustomerUserID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the address to be processed
            CustomerUserID = Convert.ToString(Session["CustomerUserID"]);
            if (IsPostBack == false)
            {
                //populate the list of conties
                //DisplayCustomer();
                if (CustomerUserID != "")
                {
                    DisplayCustomer();
                }
            }
        }

        //function for updateing records
        void Update()
        {
            //create an instance of the address book
            clsCustomerCollection CustomerBook = new clsCustomerCollection();
            //validate the data on the web form
            string Error = CustomerBook.ThisCustomer.Valid(txtAddress.Text, txtDateOfBirth.Text, txtEmailAddress.Text, txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //find the record to update
                CustomerBook.ThisCustomer.Find(CustomerUserID);
                //get the data entered by the user
                CustomerBook.ThisCustomer.Address = txtAddress.Text;
                CustomerBook.ThisCustomer.DateAdded = Convert.ToDateTime(txtDateOfBirth.Text);
                CustomerBook.ThisCustomer.EmailAddress = txtEmailAddress.Text;
                CustomerBook.ThisCustomer.Firstname = txtFirstName.Text;
                CustomerBook.ThisCustomer.Lastname = txtLastName.Text;
                CustomerBook.ThisCustomer.PhoneNumber = txtPhoneNumber.Text;
                //update the record
                //CustomerBook.Update();
                //all done
                Response.Redirect("CustomerDefault.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered" + Error;
            }


        }

        void DisplayCustomer()
        {
            //create an instance of the address book
            clsCustomerCollection CustomerBook = new clsCustomerCollection();
            //find the record to update
            CustomerBook.ThisCustomer.Find(CustomerUserID);
            //display the data for the record
            txtAddress.Text = CustomerBook.ThisCustomer.Address;
            txtDateOfBirth.Text = CustomerBook.ThisCustomer.DateAdded.ToString();
            txtEmailAddress.Text = CustomerBook.ThisCustomer.EmailAddress;
            txtFirstName.Text = CustomerBook.ThisCustomer.Firstname;
            txtLastName.Text = CustomerBook.ThisCustomer.Lastname;
            txtPhoneNumber.Text = CustomerBook.ThisCustomer.PhoneNumber;
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (CustomerUserID == "")
            {
                //add the new record
                //Add();
            }
            else
            {
                //update
                Update();
            }
            Response.Redirect("CustomerDefault.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerDefault.aspx");
        }
    }
}