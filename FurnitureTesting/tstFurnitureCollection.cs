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
        public void CountPropertyOK()
        {
            // create an instance of clsFurnitureCollection
            clsFurnitureCollection AllFurniture = new clsFurnitureCollection();
            // create some test data to assign to the property
            Int32 SomeCount = 0;
            // assign the data to the property
            AllFurniture.Count = SomeCount;
            // test to see that the two values are the same
            Assert.AreEqual(AllFurniture.Count, SomeCount);
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
        public void TwoRecordsPresent()
        {
            // create an instance of clsFurnitureCollection
            clsFurnitureCollection AllFurniture = new clsFurnitureCollection();
            // test to see that the two values are the same
            Assert.AreEqual(AllFurniture.Count, 2);
        }
    }
}
