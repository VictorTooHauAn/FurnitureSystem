using Microsoft.VisualStudio.TestTools.UnitTesting;
using FurnitureClasses;
using System;
using System.Collections.Generic;

namespace FurnitureTesting
{
    [TestClass]
    public class tstFurnitureCollection
    {
        [TestMethod]
        public void InstanceOK() {
            // create an instance of clsFurnitureCollection
            clsFurnitureCollection AllFurniture = new clsFurnitureCollection();
            // test to see if it exists
            Assert.IsNotNull(AllFurniture);
        }

        [TestMethod]
        public void FurnitureListOK()
        {
            // create an instance of the class we want to create
            clsFurnitureCollection AllFurniture = new clsFurnitureCollection();
            // create some test data to assign the property
            // in this case the data needs to be a list of objects
            List<clsFurniture> TestList = new List<clsFurniture>();
            // add an item to the list
            // create the item of test data
            clsFurniture TestItem = new clsFurniture();
            // set its properties
            TestItem.Category = "Lounge";
            TestItem.Name = "chair";
            TestItem.WoodType = "birchwood";
            TestItem.Colour = "red";
            TestItem.Size = 43.40;
            TestItem.StockNo = 53;
            TestItem.Price = 83.32;
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllFurniture.FurnitureList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllFurniture.FurnitureList, TestList);
        }

        [TestMethod]
        public void ThisFurniturePropertyOk()
        {
            // create an instance of clsFurnitureCollection
            clsFurnitureCollection AllFurniture = new clsFurnitureCollection();
            // create some test data to assign to the property
            clsFurniture TestFurniture = new clsFurniture();
            // set the properties of the test object
            TestFurniture.Category = "Lounge";
            TestFurniture.Name = "chair";
            TestFurniture.WoodType = "birchwood";
            TestFurniture.Colour = "red";
            TestFurniture.Size = 43.40;
            TestFurniture.StockNo = 53;
            TestFurniture.Price = 83.32;
            // assign the data to the property
            AllFurniture.ThisFurniture = TestFurniture;
            // test to see that the two values are the same
            Assert.AreEqual(AllFurniture.ThisFurniture, TestFurniture);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            // create an instance of clsFurnitureCollection
            clsFurnitureCollection AllFurniture = new clsFurnitureCollection();
            // create some test data to assign to the property
            // in this case the data needs to be a list of objects
            List<clsFurniture> TestList = new List<clsFurniture>();
            // add an item to the list
            // create the item of test data
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
            // add the item to the property
            TestList.Add(TestItem);
            // assign the data to the property
            AllFurniture.FurnitureList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllFurniture.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsFurnitureCollection AllFurniture = new clsFurnitureCollection();
            // create the item of test data
            clsFurniture TestItem = new clsFurniture();
            // var to store the primaery key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.FurnitureId = 2;
            TestItem.Category = "Lounge";
            TestItem.Name = "chair";
            TestItem.WoodType = "birchwood";
            TestItem.Colour = "red";
            TestItem.Size = 43.40;
            TestItem.StockNo = 53;
            TestItem.Price = 83.32;
            // set ThisFurniture to the test data
            AllFurniture.ThisFurniture = TestItem;
            // add the record
            PrimaryKey = AllFurniture.Add();
            // set the primary key of the test data
            TestItem.FurnitureId = PrimaryKey;
            // find the record
            AllFurniture.ThisFurniture.Find(PrimaryKey);
            // test to see that the two values are the same
            Assert.AreEqual(AllFurniture.ThisFurniture, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // create an instance of the class we want to create
            clsFurnitureCollection AllFurniture = new clsFurnitureCollection();
            // create the item of test data
            clsFurniture TestItem = new clsFurniture();
            // var to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            //TestItem.FurnitureId = 2;
            TestItem.Category = "Lounge";
            TestItem.Name = "chair";
            TestItem.WoodType = "birchwood";
            TestItem.Colour = "red";
            TestItem.Size = 43.40;
            TestItem.StockNo = 53;
            TestItem.Price = 83.32;
            // set ThisFurniture to the test data
            AllFurniture.ThisFurniture = TestItem;
            // add the record
            PrimaryKey = AllFurniture.Add();
            // set the primary key of the test data
            TestItem.FurnitureId = PrimaryKey;
            // find the record
            AllFurniture.ThisFurniture.Find(PrimaryKey);
            // delete the record
            AllFurniture.Delete();
            // now find the record
            Boolean Found = AllFurniture.ThisFurniture.Find(PrimaryKey);
            // test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            // create an instance of the class want to create
            clsFurnitureCollection AllFurniture = new clsFurnitureCollection();
            // create the item of test data
            clsFurniture TestItem = new clsFurniture();
            // var to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.Category = "Lounge";
            TestItem.Name = "chair";
            TestItem.WoodType = "birchwood";
            TestItem.Colour = "red";
            TestItem.Size = 43.40;
            TestItem.StockNo = 53;
            TestItem.Price = 83.32;
            // set ThisFurniture to the test data
            AllFurniture.ThisFurniture = TestItem;
            // add the record
            PrimaryKey = AllFurniture.Add();
            // set the primary key of the test data
            TestItem.Category = "Kitchen";
            TestItem.Name = "table";
            TestItem.WoodType = "cider";
            TestItem.Colour = "white";
            TestItem.Size = 32.43;
            TestItem.StockNo = 32;
            TestItem.Price = 21.76;
            // set the record based on the new test data
            AllFurniture.ThisFurniture = TestItem;
            // update the record
            AllFurniture.Update();
            // find the record
            AllFurniture.ThisFurniture.Find(PrimaryKey);
            // test to see ThisFurniture matches the test data
            Assert.AreEqual(AllFurniture.ThisFurniture, TestItem);
        }

        [TestMethod]
        public void ReportByCategory()
        {
            // create an instance of the class containing unfiltered results
            clsFurnitureCollection AllFurniture = new clsFurnitureCollection();
            // create an instance of the filtered data
            clsFurnitureCollection FilteredFurintures = new clsFurnitureCollection();
            // apply a blank string (should return all records)
            FilteredFurintures.ReportByCategory("");
            // test to see that the two values are the same
            Assert.AreEqual(AllFurniture.Count, FilteredFurintures.Count);
        }

        [TestMethod]
        public void ReportByCategoryNoneFound()
        {
            // create the instance of the filtered data
            clsFurnitureCollection FilteredCategories = new clsFurnitureCollection();
            // apply a category that doesn't exist
            FilteredCategories.ReportByCategory("xxx xxx");
            // test to see that there are no records
            Assert.AreEqual(0, FilteredCategories.Count);
        }

        [TestMethod]
        public void ReportByCategoryTestDataFound()
        {
            // create an instance of the filtered data
            clsFurnitureCollection FilteredCategories = new clsFurnitureCollection();
            // var to store outcome
            Boolean OK = true;
            // apply a category that doesn't exist
            FilteredCategories.ReportByCategory("yyy yy");
            // check that the coorect number of records are found
            if (FilteredCategories.Count == 2)
            {
                // check that the first record is ID 36
                if (FilteredCategories.FurnitureList[0].FurnitureId != 36)
                {
                    OK = false;
                }
                // check that the first record is ID 37
                if (FilteredCategories.FurnitureList[1].FurnitureId != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            // test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
