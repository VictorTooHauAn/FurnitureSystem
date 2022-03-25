using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FurnitureClasses;

namespace FurnitureFrontOffice
{
    public partial class Delete : System.Web.UI.Page
    {
        // var to store the primary key value of the record to be deleted
        Int32 FurnitureId;

        // event handler for load event
        protected void Page_Load(object sender, EventArgs e)
        {
            // get the number of the furniture to be deleted from the session object
            FurnitureId = Convert.ToInt32(Session["FurnitureId"]);
        }

        // function to delete the selected record
        void DeleteFurniture()
        {
            // create a new instance of the furniture
            clsFurnitureCollection Furniture = new clsFurnitureCollection();
            // find the record to delete
            Furniture.ThisFurniture.Find(FurnitureId);
            // delete the record
            Furniture.Delete();
        }

        // event handler for the yes button
        protected void btnYes_Click(object sender, EventArgs e)
        {
            // delete the record
            DeleteFurniture();
            // redirect back to the main page
            Response.Redirect("FurnitureHome.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("FurnitureList.aspx");
        }
    }
}