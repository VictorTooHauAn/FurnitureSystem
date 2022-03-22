﻿using System;
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
            // var for the index
            Int32 Index = 0;
            // var to store the record count
            Int32 RecordCount = 0;
            // object for data connection
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblFurniture_SelectAll");
            // get the count of records
            RecordCount = DB.Count;
            // while there are records to process
            while (Index < RecordCount)
            {
                // create a blank furniture
                clsFurniture AFurniture = new clsFurniture();
                // read in the fields from the current record
                AFurniture.FurnitureId = Convert.ToInt32(DB.DataTable.Rows[Index]["FurnitureID"]);
                AFurniture.Category = Convert.ToString(DB.DataTable.Rows[Index]["Category"]);
                AFurniture.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AFurniture.WoodType = Convert.ToString(DB.DataTable.Rows[Index]["WoodType"]);
                AFurniture.Colour = Convert.ToString(DB.DataTable.Rows[Index]["Colour"]);
                AFurniture.Size = Convert.ToDouble(DB.DataTable.Rows[Index]["Size"]);
                AFurniture.StockNo = Convert.ToInt32(DB.DataTable.Rows[Index]["SrockNo"]);
                AFurniture.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                // add the record to the private data member
                mFurnitureList.Add(AFurniture);
                // points at the next record
                Index++;
            }
        }
    }
}
