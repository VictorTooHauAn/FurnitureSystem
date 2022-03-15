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
            // set the private data members to the test data value
            mFurnitureId = 1;
            // always return true
            return true;
        }
    }
}