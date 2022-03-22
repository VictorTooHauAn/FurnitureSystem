using System;
using System.Collections.Generic;

namespace FurnitureClasses
{
    public class clsCustomerCollection
    {
        //constructor for the class
        public clsCustomerCollection()
        {
            //create the items of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerUserID = "12345";
            TestItem.Firstname = "Peter";
            TestItem.Lastname = "Lee";
            TestItem.Address = "5, London";
            TestItem.EmailAddress = "peter@gmail.com";
            TestItem.PhoneNumber = "+4498765432123";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            mCustomerList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerUserID = "54321";
            TestItem.Firstname = "Henry";
            TestItem.Lastname = "Jas";
            TestItem.Address = "53, Liverpool";
            TestItem.EmailAddress = "henry@gmail.com";
            TestItem.PhoneNumber = "+447123123123";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to thes test list
            mCustomerList.Add(TestItem);
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