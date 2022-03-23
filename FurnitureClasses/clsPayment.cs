using System;


namespace FurnitureClasses
{
    public class clsPayment
    {
        //private data maember for the Customer User Name property
        private string mPaymentID;
        private string mCustomerUserID;
        private string mEmailAddress;
        private decimal mAmount;
        private DateTime mDateOfPayment;
        private string mTypeOfPayment;
        public string PaymentID
        {
            get
            {
                //this line of code sends data out of the property
                return mPaymentID;
            }

            set
            {
                //this line of code allows data into the property
                mPaymentID = value;
            }
        }
        public string CustomerUserID
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerUserID;
            }

            set
            {
                //this line of code allows data into the property
                mCustomerUserID = value;
            }
        }
        public string EmailAddress
        {
            get
            {
                //this line of code sends data out of the property
                return mEmailAddress;
            }

            set
            {
                //this line of code allows data into the property
                mEmailAddress = value;
            }
        }
        public decimal Amount
        {
            get
            {
                //this line of code sends data out of the property
                return mAmount;
            }

            set
            {
                //this line of code allows data into the property
                mAmount = value;
            }
        }
        public DateTime DateOfPayment
        {
            get
            {
                //this line of code sends data out of the property
                return mDateOfPayment;
            }

            set
            {
                //this line of code allows data into the property
                mDateOfPayment = value;
            }
        }
        
        public string TypeOfPayment
        {
            get
            {
                //this line of code sends data out of the property
                return mTypeOfPayment;
            }

            set
            {
                //this line of code allows data into the property
                mTypeOfPayment = value;
            }
        }

        public bool Find(string PaymentID)
        {
            // create a instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the furniture id to search for
            DB.AddParameter("@PaymentID", PaymentID);
            // execute the stored procedure
            DB.Execute("sproc_Payment_FilterByPaymentID");
            // if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                // copy the data from the database to the private data members
                mPaymentID = Convert.ToString(DB.DataTable.Rows[0]["PaymentID"]);
                mCustomerUserID = Convert.ToString(DB.DataTable.Rows[0]["CustomerUserID"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mAmount = Convert.ToDecimal(DB.DataTable.Rows[0]["Amount"]);
                mDateOfPayment = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfPayment"]);
                mTypeOfPayment = Convert.ToString(DB.DataTable.Rows[0]["TypeOfPayment"]);
                // return that everything worked OK
                return true;
            }
            // if no record was found
            else
            {
                // return false indicating a problems
                return false;
            }
        }

    }
}