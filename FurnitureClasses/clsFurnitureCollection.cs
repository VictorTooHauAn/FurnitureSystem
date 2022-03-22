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

        // constructor for the class
        public clsFurnitureCollection()
        {
            // create the items of test data
            clsFurniture TestItem = new clsFurniture();
            // set its properties
            TestItem.FurnitureId = 1;
            TestItem.Category = "Lounge";
            TestItem.Name = "chair";
            TestItem.WoodType = "birchwood";
            TestItem.Colour = "red";
            TestItem.Size = 43.40;
            TestItem.StockNo = 53;
            TestItem.Price = 83.32;
            // add the item to the test list
            mFurnitureList.Add(TestItem);
            // re initialise the object for some new data
            TestItem = new clsFurniture();
            // st its properties
            TestItem.FurnitureId = 2;
            TestItem.Category = "kitchen";
            TestItem.Name = "table";
            TestItem.WoodType = "cider";
            TestItem.Colour = "white";
            TestItem.Size = 30;
            TestItem.StockNo = 94;
            TestItem.Price = 94.99;
            // add the item to the test list
            mFurnitureList.Add(TestItem);
        }
    }
}
