using System;

namespace FurnitureClasses
{
    public class clsCustomer
    {
        //private data maember for the Customer User Name property
        private string mCustomerUserID;
        private string mAddress;
        private string mFirstName;
        private string mLastName;
        private string mEmail;
        private DateTime mDataAdded;
        private string mPhone;
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
                return mFirstName;
            }

            set
            {
                //this line of code allows data into the property
                mFirstName = value;
            }
        }
        public string Lastname
        {
            get
            {
                //this line of code sends data out of the property
                return mLastName;
            }

            set
            {
                //this line of code allows data into the property
                mLastName = value;
            }
        }
        public string Email
        {
            get
            {
                //this line of code sends data out of the property
                return mEmail;
            }

            set
            {
                //this line of code allows data into the property
                mEmail = value;
            }
        }
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of the property
                return mDataAdded;
            }

            set
            {
                //this line of code allows data into the property
                mDataAdded = value;
            }
        }
        public string Phone
        {
            get
            {
                //this line of code sends data out of the property
                return mPhone;
            }

            set
            {
                //this line of code allows data into the property
                mPhone = value;
            }
        }

        public bool Find(string customerUserID)
        {
            //set the private data members to the test data value
            mCustomerUserID = "P123";
            mAddress = "Test Address";
            mFirstName = "Test First Name";
            mLastName = "Test Last Name";
            mEmail = "Test Email";
            mDataAdded = Convert.ToDateTime("20/4/2000");
            mPhone = "Test Phone";
            //always return true
            return true;
        }
    }
}