using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FurnitureClasses;

namespace FurnitureFrontOffice
{
    public partial class APayment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void btnFind_Click(object sender, EventArgs e)
        {
            // create an instance of the address class
            clsPayment APayment = new clsPayment();
            // variable to store the primary key
            string PaymentId;
            // variable to store the result of the find operation
            Boolean Found = false;
            // get the primary key entered by the user
            PaymentId = Convert.ToString(txtPaymentID.Text);
            // find the record
            Found = APayment.Find(PaymentId);
            //if found
            if (Found== true)
            {
                txtCustomerUserID.Text = APayment.CustomerUserID;
                txtEmailAddress.Text = APayment.EmailAddress;
                txtAmount.Text = APayment.Amount.ToString();
                txtDateOfPayment.Text = APayment.DateOfPayment.ToString();
                txtTypeOfPayment.Text = APayment.TypeOfPayment.ToString();
            }
        }

       
    }
}