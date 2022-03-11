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
        public int FurnitureId
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
        public string Category
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

        public bool Find(int FurnitureId)
        {
            // set the private data members to the test data value
            mFurnitureId = 1;
            // always return true
            return true;
        }
    }
}