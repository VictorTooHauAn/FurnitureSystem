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
        private string mEmailAddress;
        private DateTime mDataAdded;
        private string mPhoneNumber;
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
        public string PhoneNumber
        {
            get
            {
                //this line of code sends data out of the property
                return mPhoneNumber;
            }

            set
            {
                //this line of code allows data into the property
                mPhoneNumber = value;
            }
        }

        public bool Find(string CustomerUserID)
        {
            // create a instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the furniture id to search for
            DB.AddParameter("@CustomerUserID", CustomerUserID);
            // execute the stored procedure
            DB.Execute("sproc_Customer_FilterByCustomerUserID");
            // if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                // copy the data from the database to the private data members
                mCustomerUserID = Convert.ToString(DB.DataTable.Rows[0]["CustomerUserID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mDataAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
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