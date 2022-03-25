using System;

namespace FurnitureClasses
{
    public class clsFurniture
    {
        // private data member for the furniture id
        private Int32 mFurnitureId;
        // privat data member for category
        private String mCategory;
        // private data member for name
        private String mName;
        // private data member for wood type
        private String mWoodType;
        // private data member for colour
        private String mColour;
        // private data member for size
        private Double mSize;
        // private data member for number in stock
        private Int32 mStockNo;
        // private data member for price
        private Double mPrice;

        // furniture id public data member
        public Int32 FurnitureId
        {
            get
            {
                // this line of sends data out of the property
                return mFurnitureId;
            }
            set
            {
                // this line of code allows data into the property
                mFurnitureId = value;
            }
        }

        // Category public data member
        public String Category
        {
            get
            {
                // this line of code sends data out of the property
                return mCategory;
            }
            set
            {
                // this line of code allows data into the property
                mCategory = value;
            }
        }

        // name public data member
        public String Name
        {
            get
            {
                // this line of code sends data out of the property
                return mName;
            }
            set
            {
                // this line of code allows data into the property
                mName = value;
            }
        }

        // Wood type public data member
        public string WoodType
        {
            get
            {
                // this line of code sends data out of the property
                return mWoodType;
            }
            set
            {
                // this line of code allows data into the property
                mWoodType = value;
            }
        }

        // Colour public data member
        public string Colour
        {
            get
            {
                // this line of code sends data out of the property
                return mColour;
            }
            set
            {
                // this line of code allows data into the property
                mColour = value;
            }
        }

        // Size public data member
        public Double Size
        {
            get
            {
                // this line of code sends data out of the property
                return mSize;
            }
            set
            {
                // this line of code allows data into the property
                mSize = value;
            }
        }

        // Number of stock public data member
        public Int32 StockNo
        {
            get
            {
                // this line of code sends data out of the property
                return mStockNo;
            }
            set
            {
                // this line of code allows data into the property
                mStockNo = value;
            }
        }

        // Price public data member
        public Double Price
        {
            get
            {
                // this line of code sends data out of the property
                return mPrice;
            }
            set
            {
                // this line of code allows data into the property
                mPrice = value;
            }
        }

        // public method to find a furniture id
        public bool Find(int FurnitureId)
        {
            // create a instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the furniture id to search for
            DB.AddParameter("@FurnitureId", FurnitureId);
            // execute the stored procedure
            DB.Execute("sproc_tblFurniture_FilterByFurnitureId");
            // if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                // copy the data from the database to the private data members
                mFurnitureId = Convert.ToInt32(DB.DataTable.Rows[0]["FurnitureID"]);
                mCategory = Convert.ToString(DB.DataTable.Rows[0]["Category"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mWoodType = Convert.ToString(DB.DataTable.Rows[0]["WoodType"]);
                mColour = Convert.ToString(DB.DataTable.Rows[0]["Colour"]);
                mSize = Convert.ToDouble(DB.DataTable.Rows[0]["Size"]);
                mStockNo = Convert.ToInt32(DB.DataTable.Rows[0]["StockNo"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                // return that everything worked OK
                return true;
            }
            // if no record was found
            else
            {
                // return false indicating a problem
                return false;
            }
        }

        // function for the public validation method
        public string Valid(string category,
                            string name,
                            string woodType,
                            string colour,
                            double size,
                            int stockNo,
                            double price)
        {
            // create a string variable to store the error
            String Error = "";
            // if the Category is blank
            if (category.Length == 0)
            {
                // record the error
                Error = Error + "The category may not be blank: ";
            }
            // if the category is greater than 15 characters
            if (category.Length > 15)
            {
                // record the error
                Error = Error + "The category must be less than 15 characters";
            }
            // if name is blank
            if (name.Length == 0)
            {
                // record the error
                Error = Error + "The name may not be blank";
            }
            // if the name is greater than 15 characters
            if (name.Length > 15)
            {
                // record the error
                Error = Error + "The name may not be less than 15 characters";
            }
            // if the wood type is blank
            if (woodType.Length == 0)
            {
                // record the error
                Error = Error + "The wood type may not be blank";
            }
            // if the wood type is greater than 15
            if (woodType.Length > 15)
            {
                // record the error
                Error = Error + "The wood type may not be less than 15 characters";
            }
            // if the colour is blank
            if (colour.Length == 0)
            {
                // record the error
                Error = Error + "The colour may not be blank";
            }
            // if the colour is greater than 15
            if (colour.Length > 15)
            {
                // record the error
                Error = Error + "The colour may not be less than 15 characters";
            }
            // if size is invalid data
            if (Convert.ToString(size).Length == 0)
            {
                // record the error
                Error = Error + "The size must be a figure";
            }
            // if the size is less than 0
            if (size < 0)
            {
                // record the error
                Error = Error + "The size may not be less than 0";
            }
            // if the size is greater than 
            if (size > 50)
            {
                // record the error
                Error = Error + "The size may not be greater than 50";
            }
            // if the stock no is less than 1
            if (stockNo < 1)
            {
                // record the error
                Error = Error + "The stock nunmber may not be less than 1";
            }
            // if the stock no is greater than 200
            if (stockNo > 200)
            {
                // record the error
                Error = Error + "The stock number may not be gretaer than 200";
            }
            // if the stock no is less than 0
            if (price < 0)
            {
                // record the error
                Error = Error + "The price may not be less than 0";
            }
            // if the stock no is greater than 3000001.00
            if (price > 3000000.00)
            {
                // record the error
                Error = Error + "The price may not be greater than 3,000,000";
            }

            // return any error message
            return Error;
        }
    }
}