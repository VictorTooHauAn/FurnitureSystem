using System;
using System.Collections.Generic;

namespace FurnitureClasses
{
    public class clsCustomerCollection
    {
        //constructor for the class
        public clsCustomerCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_Customer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //white there are records to process
            while (Index < RecordCount)
            {
                //create a blank Customer
                clsCustomer Acustomer = new clsCustomer();
                //read in the fields from the current record
                Acustomer.CustomerUserID = Convert.ToString(DB.DataTable.Rows[Index]["CustomerUserID"]);
                Acustomer.Firstname = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                Acustomer.Lastname = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                Acustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                Acustomer.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                Acustomer.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                Acustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                //add the record to the private data mamber
                mCustomerList.Add(Acustomer);
                //point at the next record
                Index++;
            }         
        }
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        public List<clsCustomer> CustomerList 
        { get
            {
                //return the privare data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            } 
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsCustomer ThisCustomer { get; set; }

      
    }
}