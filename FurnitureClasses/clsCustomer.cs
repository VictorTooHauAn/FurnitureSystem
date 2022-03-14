using System;

namespace FurnitureClasses
{
    public class clsCustomer
    {
        //private data maember for the Customer User Name property
        private string mCustomerUserID;
        private string mAddress;
        private string mFirstName;
        public string Address
        {
            get
            {
                //this line of code sends data out of the property
                return mAddress;
            }

            set
            {
                //this line of code allows data into the property
                mAddress = value;
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
        public string Firstname
        {
            get
            {
                //this line of code sends data out of the property
                return mAddress;
            }

            set
            {
                //this line of code allows data into the property
                mAddress = value;
            }
        }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public DateTime DateAdded { get; set; }
        public string Phone { get; set; }

        public bool Find(string customerUserID)
        {
            //set the private data members to the test data value
            mCustomerUserID = "P123";
            mAddress = "Test Address";
            //always return true
            return true;
        }
    }
}