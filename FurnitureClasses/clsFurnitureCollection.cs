using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureClasses
{
    public class clsFurnitureCollection
    {
        // private data member for the list
        List<clsFurniture> mFurnitureList = new List<clsFurniture>();

        // public property for the furniture list
        public List<clsFurniture> FurnitureList
        {
            get
            {
                // return the private data
                return mFurnitureList;
            }
            set
            {
                // set the private data
                mFurnitureList = value;
            }
        }
        public int Count
        {
            get
            {
                // return the count of the list
                return mFurnitureList.Count;
            }
            set
            {
            }
        }
        public clsFurniture ThisFurniture { get; set; }
    }
}
