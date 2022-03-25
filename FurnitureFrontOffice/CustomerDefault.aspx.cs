using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FurnitureFrontOffice
{
    public partial class CustomerDefault : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayCustomer();
            }

            void DisplayCustomer()
            {
                //create an instance of the Country Collection
                FurnitureClasses.clsCustomerCollection Customers = new FurnitureClasses.clsCustomerCollection();
                //set the data source to the list of counties in the collection
                lstCustomer.DataSource = Customers.CustomerList;
                //set the name of the primaru key
                lstCustomer.DataValueField = "CustomerUserID";
                //set the data field to display
                lstCustomer.DataTextField = "FirstName";
                //blind the data to the list
                lstCustomer.DataBind();
            }
        }

        protected void btnAdd_Click1(object sender, EventArgs e)
        {
            //store -1 into the seesion object to indicate this is a new rcord
            Session["CustomerUserId"] = -1;
            //redirect to the data entry page
            Response.Redirect("ACustomerAdd.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be delete
            string CustomerUserID;
            //if a record has been selected from the list
            if (lstCustomer.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                CustomerUserID = Convert.ToString(lstCustomer.SelectedValue);
                //store the data in the session object
                Session["CustomerUserID"] = CustomerUserID;
                //redirect to the delete page
                Response.Redirect("ACustomerDelete.aspx");
            }
            else //if no record has been selected
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            string CustomerUserID;
            //if a record has been selected from the list
            if (lstCustomer.SelectedIndex != -1)
            {
                //get the primary key value of the record to edit
                CustomerUserID = Convert.ToString(lstCustomer.SelectedValue);
                //store the data in the session object
                Session["CustomerUserID"] = CustomerUserID;
                //redirect to the edit page
                Response.Redirect("ACustomerUpdate.aspx");
            }
            else //if no record has been selected
            {
                //diaplay eroor
                lblError.Text = "Please select a record to delete from the list";
            }
        }
    }
}