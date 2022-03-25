using System;
using System.Collections.Generic;

namespace FurnitureClasses
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();
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
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }

        public string Add()
        {
            //adds a new record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerUserID", mThisCustomer.CustomerUserID);
            DB.AddParameter("@FirstName", mThisCustomer.Firstname);
            DB.AddParameter("@LastName", mThisCustomer.Lastname);
            DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateAdded);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            return Convert.ToString(DB.Execute("sproc_Customer_Insert"));
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramerters for the stored procedure
            DB.AddParameter("@CustomerUserID", mThisCustomer.CustomerUserID);
            //execute the stored procedure
            DB.Execute("sproc_Customer_Delete");
        }

        //public void Update()
        //{
        //    //update an existing record based on the values of ThisCustomer
        //    //connect to the database
        //    clsDataConnection DB = new clsDataConnection();
        //    //set the parameters for the stored procedure
        //    DB.AddParameter("@CustomerUserID", mThisCustomer.CustomerUserID);
        //    DB.AddParameter("@FirstName", mThisCustomer.Firstname);
        //    DB.AddParameter("@LastName", mThisCustomer.Lastname);
        //    DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
        //    DB.AddParameter("@DateOfBirth", mThisCustomer.DateAdded);
        //    DB.AddParameter("@Address", mThisCustomer.Address);
        //    DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
        //    //execute the stored procedure
        //    DB.Execute("sproc_Customer_Update");
        //}

        void PopulateArray(clsDataConnection DB)
        {
            //populated the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
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
    }
}