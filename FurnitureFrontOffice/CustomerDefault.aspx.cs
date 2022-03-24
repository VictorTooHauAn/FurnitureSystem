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

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the seesion object to indicate this is a new rcord
            Session["CustomerUserId"] = -1;
            //redirect to the data entry page
            Response.Redirect("ACustomer.aspx");
        }
    }
}