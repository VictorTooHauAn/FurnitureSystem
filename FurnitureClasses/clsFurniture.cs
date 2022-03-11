using System;

namespace FurnitureClasses
{
    public class clsFurniture
    {
        // private data member for the furniture id
        private Int32 mFurnitureID;

        public int FurnitureId { get; set; }

        public bool Find(int furnitureId)
        {
            // always return true
            return true;
        }
    }
}