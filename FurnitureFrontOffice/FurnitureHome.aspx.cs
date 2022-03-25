using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FurnitureFrontOffice
{
    public partial class FurnitureHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            Response.Redirect("AFurniture.aspx");
        }

        protected void btnAlter_Click(object sender, EventArgs e)
        {
            Response.Redirect("FurnitureList.aspx");
        }

        protected void btnDefault_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}