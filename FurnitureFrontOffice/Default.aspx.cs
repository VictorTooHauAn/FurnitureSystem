﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FurnitureFrontOffice
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFurnitureSection_Click(object sender, EventArgs e)
        {
            Response.Redirect("FurnitureHome.aspx");
        }

        protected void btnCustomerSection_Click(object sender, EventArgs e)
        {
            Response.Redirect("ACustomer.aspx");
        }
    }
}