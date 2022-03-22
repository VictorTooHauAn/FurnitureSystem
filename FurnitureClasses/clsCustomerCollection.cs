﻿using System.Collections.Generic;

namespace FurnitureClasses
{
    public class clsCustomerCollection
    {
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