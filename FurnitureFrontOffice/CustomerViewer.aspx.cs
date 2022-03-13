using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FurnitureClasses;

namespace FurnitureFrontOffice
{
    public partial class CustomerViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Create an instance of class
            clsCustomer ACustomer = new clsCustomer();
            //get the data from the session object
            ACustomer = (clsCustomer)Session["ACustomer"];
            //display the house number for this entry
            Response.Write(ACustomer.CustomerUserID);
        }
    }
}