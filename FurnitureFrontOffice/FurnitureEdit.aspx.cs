using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FurnitureClasses;

namespace FurnitureFrontOffice
{
    public partial class FurnitureEdit : System.Web.UI.Page
    {
        // variabel to store the primary key with  page level scope
        Int32 FurnitureId;

        // event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            // get the number of the furniture to be processed
            FurnitureId = Convert.ToInt32(Session["FurnitureId"]);
            if (IsPostBack == false)
            {
                // populate the list of furniture
                DisplayFurniture();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("FurnitureHome.aspx");
        }

        // event handler for the edit button
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            // update the record
            Update();
            Response.Redirect("FurnitureHome.aspx");
        }

        // function for updating records
        void Update()
        {
            // create an instance of the new furniture
            clsFurnitureCollection Furnitures = new clsFurnitureCollection();
            // validate the data on the web form
            String Error = Furnitures.ThisFurniture.Valid(txtCategory.Text, txtName.Text, txtWoodType.Text, txtColour.Text, Convert.ToDouble(txtSize.Text), Convert.ToInt32(txtStockNo.Text), Convert.ToDouble(txtPrice.Text));
            // if the data is OK then ad it to the object
            if (Error == "")
            {
                // find the recoprd to update
                Furnitures.ThisFurniture.Find(FurnitureId);
                // get the data entered by the user
                Furnitures.ThisFurniture.Category = txtCategory.Text;
                Furnitures.ThisFurniture.Name = txtName.Text;
                Furnitures.ThisFurniture.WoodType = txtWoodType.Text;
                Furnitures.ThisFurniture.Colour = txtColour.Text;
                Furnitures.ThisFurniture.Size = Convert.ToDouble(txtSize.Text);
                Furnitures.ThisFurniture.StockNo = Convert.ToInt32(txtStockNo.Text);
                Furnitures.ThisFurniture.Price = Convert.ToDouble(txtPrice.Text);
                // update the record
                Furnitures.Update();
                // all done so redirect back to main page
                Response.Redirect("FurnitureList.aspx");
            }
            else
            {
                // report an error
                LabelError.Text = "There were problems with the data entered " + Error;
            }
        }

        void DisplayFurniture()
        {
            // create an instance of the furniture
            clsFurnitureCollection Furnitures = new clsFurnitureCollection();
            // find the record to update
            Furnitures.ThisFurniture.Find(FurnitureId);
            // display the data for this record
            txtCategory.Text = Furnitures.ThisFurniture.Category;
            txtName.Text = Furnitures.ThisFurniture.Name;
            txtWoodType.Text = Furnitures.ThisFurniture.WoodType;
            txtColour.Text = Furnitures.ThisFurniture.Colour;
            txtSize.Text = Furnitures.ThisFurniture.Size.ToString();
            txtStockNo.Text = Furnitures.ThisFurniture.StockNo.ToString();
            txtPrice.Text = Furnitures.ThisFurniture.Price.ToString();
        }
    }
}