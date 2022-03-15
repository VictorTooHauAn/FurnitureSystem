using FurnitureClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FurnitureTesting
{
    [TestClass]
    public class tstFurniture
    {
        // test method to check if instance of class is null
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class
            clsFurniture afurniture = new clsFurniture();
            // test if an error message returned
            Assert.IsNotNull(afurniture);
        }

        // test method to check if category name is equal to test data
        [TestMethod]
        public void CategoryOK()
        {
            // create an instance of the class
            clsFurniture afurniture = new clsFurniture();
            // create some test data to test the method
            string TestData;
            TestData = "chair";
            afurniture.Category = TestData;
            Assert.AreEqual(TestData, afurniture.Category);
        }

        // test method to check if name is equal to test data
        [TestMethod]
        public void NameOK()
        {
            // create an instance of the class
            clsFurniture afurniture = new clsFurniture();
            // create some test data to test the method
            string TestData;
            TestData = "reclining chair 2000";
            afurniture.Name = TestData;
            Assert.AreEqual(TestData, afurniture.Name);
        }

        // test method to check if wood type is equal to test data
        [TestMethod]
        public void WoodTypeOK()
        {
            // create an instance of the class
            clsFurniture afurniture = new clsFurniture();
            // create some test data to test the method
            string TestData;
            TestData = "cinderwood";
            afurniture.WoodType = TestData;
            Assert.AreEqual(TestData, afurniture.WoodType);
        }

        // test method to check if colour is equal to test data
        [TestMethod]
        public void ColourOK()
        {
            // create an instance of the class
            clsFurniture afurniture = new clsFurniture();
            // create some test data to test the method
            string TestData;
            TestData = "Brown";
            afurniture.Colour = TestData;
            Assert.AreEqual(TestData, afurniture.Colour);
        }

        // test method to check if size is equal to test data
        [TestMethod]
        public void SizeOK()
        {
            // create an instance of the class
            clsFurniture afurniture = new clsFurniture();
            // create some test data to test the method
            Double TestData;
            TestData = 13.5;
            afurniture.Size = TestData;
            Assert.AreEqual(TestData, afurniture.Size);
        }

        // test method to check if stock number is equal to test data
        [TestMethod]
        public void StockNoOK()
        {
            // create an instance of the class
            clsFurniture afurniture = new clsFurniture();
            // create some test data to test the method
            Int32 TestData;
            TestData = 8;
            afurniture.StockNo = TestData;
            Assert.AreEqual(TestData, afurniture.StockNo);
        }

        // test method to check if price is equal to test data
        [TestMethod]
        public void PriceOK()
        {
            // create an instance of the class
            clsFurniture afurniture = new clsFurniture();
            // create some test data to test the method
            double Testdata;
            Testdata = 30.0;
            afurniture.Price = Testdata;
            Assert.AreEqual(Testdata, afurniture.Price);
        }


        [TestMethod]
        // test to check that the FindMethod() works
        public void FindMethodOk()
        {
            // create an instance of the class we want to create
            clsFurniture aFurniture = new clsFurniture();
            // boolean variable to store the results of the validation
            Boolean Found = false;
            // create some test data to use with the method
            Int32 FurnitureId = 1;
            // invoke the method
            Found = aFurniture.Find(FurnitureId);
            // test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        // test to check that the FurnitureIdFound() works
        public void FurnitureIdFound()
        {
            // create an instance of the class we want to create
            clsFurniture aFurniture = new clsFurniture();
            // boolean variable to store the results of the validation
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 FurnitureId = 1;
            // invoke the method
            Found = aFurniture.Find(FurnitureId);
            // check the furniture id
            if (aFurniture.FurnitureId != 1)
            {
                OK = false;
            }
            // test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        // test to check that the FurnitureIdFound() works
        public void CategoryFound()
        {
            // create an instance of the class we want to create
            clsFurniture aFurniture = new clsFurniture();
            // boolean variable to store the results of the validation
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 FurnitureId = 1;
            // invoke the method
            Found = aFurniture.Find(FurnitureId);
            // check the furniture id
            if (aFurniture.Category != "Premium wood")
            {
                OK = false;
            }
            // test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        // test to check that the FurnitureIdFound() works
        public void NameFound()
        {
            // create an instance of the class we want to create
            clsFurniture aFurniture = new clsFurniture();
            // boolean variable to store the results of the validation
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 FurnitureId = 1;
            // invoke the method
            Found = aFurniture.Find(FurnitureId);
            // check the furniture id
            if (aFurniture.Name != "chair T-50")
            {
                OK = false;
            }
            // test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        // test to check that the FurnitureIdFound() works
        public void WoodTypeFound()
        {
            // create an instance of the class we want to create
            clsFurniture aFurniture = new clsFurniture();
            // boolean variable to store the results of the validation
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 FurnitureId = 1;
            // invoke the method
            Found = aFurniture.Find(FurnitureId);
            // check the furniture id
            if (aFurniture.WoodType != "oak")
            {
                OK = false;
            }
            // test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        // test to check that the FurnitureIdFound() works
        public void ColourFound()
        {
            // create an instance of the class we want to create
            clsFurniture aFurniture = new clsFurniture();
            // boolean variable to store the results of the validation
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 FurnitureId = 1;
            // invoke the method
            Found = aFurniture.Find(FurnitureId);
            // check the furniture id
            if (aFurniture.Colour != "white")
            {
                OK = false;
            }
            // test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        // test to check that the FurnitureIdFound() works
        public void SizeFound()
        {
            // create an instance of the class we want to create
            clsFurniture aFurniture = new clsFurniture();
            // boolean variable to store the results of the validation
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 FurnitureId = 1;
            // invoke the method
            Found = aFurniture.Find(FurnitureId);
            // check the furniture id
            if (aFurniture.Size != 12)
            {
                OK = false;
            }
            // test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        // test to check that the FurnitureIdFound() works
        public void StockNoFound()
        {
            // create an instance of the class we want to create
            clsFurniture aFurniture = new clsFurniture();
            // boolean variable to store the results of the validation
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 FurnitureId = 1;
            // invoke the method
            Found = aFurniture.Find(FurnitureId);
            // check the furniture id
            if (aFurniture.StockNo != 7)
            {
                OK = false;
            }
            // test to see if the result is true
            Assert.IsTrue(OK);
        }
    }
}
