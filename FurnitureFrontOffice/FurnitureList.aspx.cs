using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FurnitureClasses;

namespace FurnitureFrontOffice
{
    public partial class FurnitureList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                // uodate teh list box
                DisplayAddresses();
            }
        }

        void DisplayAddresses()
        {
            // create an instance of the furniture collection
            clsFurnitureCollection Furniture = new clsFurnitureCollection();
            // set the data source to the list of furniture in the collection
            lstFurniture.DataSource = Furniture.FurnitureList;
            // set the name of the primary key
            lstFurniture.DataValueField = "FurnitureId";
            // set the data field to display
            lstFurniture.DataTextField = "Name";
            // bind the data to the list
            lstFurniture.DataBind();
        }


    }
}