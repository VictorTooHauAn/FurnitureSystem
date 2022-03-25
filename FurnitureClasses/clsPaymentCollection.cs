using System;
using System.Collections.Generic;

namespace FurnitureClasses
{
    public class clsPaymentCollection
    {
        //private data member for the list
        List<clsPayment> mPaymentList = new List<clsPayment>();
        //private data member thisPayment
        clsPayment mThisPayment = new clsPayment();
        //constructor for the class
        public clsPaymentCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_Payment_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //white there are records to process
            while (Index < RecordCount)
            {
                //create a blank Customer
                clsPayment Apayment = new clsPayment();
                //read in the fields from the current record
                Apayment.PaymentID = Convert.ToString(DB.DataTable.Rows[Index]["PaymentID"]);
                Apayment.CustomerUserID = Convert.ToString(DB.DataTable.Rows[Index]["CustomerUserID"]);
                Apayment.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                Apayment.Amount = Convert.ToDecimal(DB.DataTable.Rows[Index]["Amount"]);
                Apayment.DateOfPayment = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfPayment"]);
                Apayment.TypeOfPayment = Convert.ToString(DB.DataTable.Rows[Index]["TypeOfPayment"]);
                //add the record to the private data mamber
                mPaymentList.Add(Apayment);
                //point at the next record
                Index++;
            }
        }

        public List<clsPayment> PaymentList
        {
            get
            {
                //return the privare data
                return mPaymentList;
            }
            set
            {
                //set the private data
                mPaymentList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mPaymentList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsPayment ThisPayment
        {
            get
            {
                //return the private data
                return mThisPayment;
            }
            set
            {
                //set the private data
                mThisPayment = value;
            }
        }

        public string Add()
        {
            //adds a new record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@PaymentID", mThisPayment.PaymentID);
            DB.AddParameter("@CustomerUserID", mThisPayment.CustomerUserID);
            DB.AddParameter("@EmailAddress", mThisPayment.EmailAddress);
            DB.AddParameter("@Amount", mThisPayment.Amount);
            DB.AddParameter("@DateOfPayment", mThisPayment.DateOfPayment);
            DB.AddParameter("@TypeOfPayment", mThisPayment.TypeOfPayment);
            return Convert.ToString(DB.Execute("sproc_Payment_Insert"));
        }
    }
}