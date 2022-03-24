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

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            // store -1 into the session object to indicate this is a new record
            Session["FurnitureId"] = -1;
            // redirect to the data entry page
            Response.Redirect("AFurniture.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            // var to store the primary key value of the record to be deleted
            Int32 FurnitureId;
            // if a record has been seleted from the list
            if (lstFurniture.SelectedIndex != -1)
            {
                // get the primary key value of the record to be deleted
                FurnitureId = Convert.ToInt32(lstFurniture.SelectedValue);
                // store the data in the session object
                Session["FurnitureId"] = FurnitureId;
                // redirect to the delete page
                Response.Redirect("FurnitureDelete.aspx");
            }
            // if no record ha been selected
            else
            {
                // display an error
                lblError.Text = "Please select a record to delete from the list";
            }
        }
    }
}