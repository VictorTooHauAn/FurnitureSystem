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

        //function for the public validation method
        public string Valid(string firstName, string lastName, string address, string emailAddress, string phoneNumber, string dateOfBirth)
        {
            //create a string variable to store the error
            string Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the FirstName is blank
            if (firstName.Length == 0)
            {
                //record the error
                Error = Error + "The First Name may not be blank : ";
            }
            //if the FirstName is greater than 15 characters
            if (firstName.Length > 15)
            {
                //record the error
                Error = Error + "The First Name must be less than 15 characters : ";
            }
            //if the LastName is blank
            if (lastName.Length == 0)
            {
                //record the error
                Error = Error + "The Last Name may not be blank : ";
            }
            //if the LastName is greater than 15 characters
            if (lastName.Length > 15)
            {
                //record the error
                Error = Error + "The Last Name must be less than 15 characters : ";
            }
            //if the Address is blank
            if (address.Length == 0)
            {
                //record the error
                Error = Error + "The Address may not be blank : ";
            }
            //if the Address is greater than 25 characters
            if (address.Length > 25)
            {
                //record the error
                Error = Error + "The Address must be less than 25 characters : ";
            }
            //if the EmailAddress is blank
            if (emailAddress.Length == 0)
            {
                //record the error
                Error = Error + "The Email Address may not be blank : ";
            }
            //if the EmailAddress is greater than 25 characters
            if (emailAddress.Length > 25)
            {
                //record the error
                Error = Error + "The Email Address must be less than 25 characters : ";
            }
            //if the PhoneNumber is blank
            if (phoneNumber.Length == 0)
            {
                //record the error
                Error = Error + "The Phone Number may not be blank : ";
            }
            //if the PhoneNumber is greater than 20 characters
            if (phoneNumber.Length > 20)
            {
                //record the error
                Error = Error + "The Phone Number must be less than 20 characters : ";
            }
            try
            {
                //copy the dateOfBirth value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateOfBirth);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the data is greater than today date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The data cannot be in the future";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The data was not a valid date";
            }
            //return any error message
            return Error;
        }

       


    }
}