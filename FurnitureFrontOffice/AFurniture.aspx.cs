using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FurnitureClasses;

namespace FurnitureFrontOffice
{
    public partial class findFurniture : System.Web.UI.Page
    {
        // error message
        String error = "Item does not exist";

        protected void Page_Load(object sender, EventArgs e)
        {
            // hide lblError
            lblError.Visible = false;
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            // create an instance of the address class
            clsFurniture AFurniture = new clsFurniture();
            // variable to store the primary key
            Int32 FurnitureId;
            // variable to store the result of the find operation
            Boolean Found = false;
            // get the primary key entered by the user
            FurnitureId = Convert.ToInt32(txtFrnitureId.Text);
            // find the record
            Found = AFurniture.Find(FurnitureId);
            // if found
            if (Found == true)
            {
                // display the values of the properties in the form
                txtCategory.Text = AFurniture.Category;
                txtName.Text = AFurniture.Name;
                txtWoodType.Text = AFurniture.WoodType;
                txtColour.Text = AFurniture.Colour;
                txtSize.Text = AFurniture.Size.ToString();
                txtStockNo.Text = AFurniture.StockNo.ToString();
                txtPrice.Text = AFurniture.Price.ToString();
            }
            // if not found
            else
            {
                // put the error message in the form
                lblError.Text = error;
                // show lblError
                lblError.Visible = true;
                // clear the form
                txtCategory.Text = "";
                txtName.Text = "";
                txtWoodType.Text = "";
                txtColour.Text = "";
                txtSize.Text = "";
                txtStockNo.Text = "";
                txtPrice.Text = "";
            }
        }
    }
}