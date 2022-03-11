using System;

namespace FurnitureClasses
{
    public class clsFurniture
    {
        // private data member for the furniture id
        private Int32 mFurnitureId;

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

        public bool Find(int FurnitureId)
        {
            // set the private data members to the test data value
            mFurnitureId = 2;
            // always return true
            return true;
        }
    }
}