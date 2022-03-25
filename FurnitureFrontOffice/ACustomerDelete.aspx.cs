using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FurnitureClasses;

namespace FurnitureFrontOffice
{
    public partial class ACustomerDelete : System.Web.UI.Page
    {
        //varto store the primary key value of the record to be deleted
        string CustomerUserID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the address to be deleted from the session object
            CustomerUserID = Convert.ToString(Session["CustomerUserID"]);
        }

        void DeleteCustomer()
        {
            //create a new insatance of the address book
            clsCustomerCollection CustomerBook = new clsCustomerCollection();
            //find the record to delete
            CustomerBook.ThisCustomer.Find(CustomerUserID);
            //delete the record
            CustomerBook.Delete();
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            //delete the record
            //DeleteCustomer();
            //redirect back to the main page
            Response.Redirect("CustomerDefault.aspx");
        }
    }
}