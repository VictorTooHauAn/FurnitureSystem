using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FurnitureClasses;

namespace FurnitureFrontOffice
{
    public partial class PaymentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                // uodate teh list box
                DisplayPayments();
            }
        }

        void DisplayPayments()
        {
            // create an instance of the furniture collection
            clsFurnitureCollection Furniture = new clsFurnitureCollection();
            // set the data source to the list of furniture in the collection
            ListBox1.DataSource = Furniture.FurnitureList;
            // set the name of the primary key
            ListBox1.DataValueField = "PaymentID";
            // set the data field to display
            ListBox1.DataTextField = "CustomerUserID";
            // bind the data to the list
            ListBox1.DataBind();
        }

    }
}