using FurnitureClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FurnitureTesting
{
    [TestClass]
    public class tstFurniture
    {

        // good test data
        // create some test data to pass to the method
        string Category = "Desk";
        string Name = "i-desk 123";
        string WoodType = "Maple";
        string Colour = "Red";
        double Size = 14.2;
        double StockNo = 20;
        double Price = 23.99;


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
        // test to check that the find furnitur id method works
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
        // test to check that the find category method works
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
            if (aFurniture.Category != "Living room")
            {
                OK = false;
            }
            // test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        // test to check that the find name method works
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
            if (aFurniture.Name != "2-legged table")
            {
                OK = false;
            }
            // test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        // test to check that the find wood type method works
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
            if (aFurniture.WoodType != "Oak")
            {
                OK = false;
            }
            // test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        // test to check that the find colour method works
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
            if (aFurniture.Colour != "Brown")
            {
                OK = false;
            }
            // test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        // test to check that the find size method works
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
            if (aFurniture.Size != 3)
            {
                OK = false;
            }
            // test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        // test to check that the find amount in stock method works
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
            if (aFurniture.StockNo != 5)
            {
                OK = false;
            }
            // test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        // test to check that the find price method works
        public void PriceFound()
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
            if (aFurniture.Price != 13)
            {
                OK = false;
            }
            // test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        // validation test
        public void ValideMethodOK()
        {
            // create an instance of the class we want to create
            clsFurniture AFurniture = new clsFurniture();
            // string variable to store any error message
            String Error = "";
            // invoke the method
            Error = AFurniture.Valid(Category, Name, WoodType, Colour, Size, StockNo, Price);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        // validation test for category min less one
        public void CategoryMinLessOne()
        {
            // create an instance of the class we want to create
            clsFurniture AFurniture = new clsFurniture();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Category = ""; // should trigger an error
            // invoke the method
            Error = AFurniture.Valid(Category, Name, WoodType, Colour, Size, StockNo, Price);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        // validation test for category min
        public void CategoryMin()
        {
            // create an instance of the class we want to create
            clsFurniture AFurniture = new clsFurniture();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Category = "k"; // should should be ok
            // invoke the method
            Error = AFurniture.Valid(Category, Name, WoodType, Colour, Size, StockNo, Price);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        // validation test for category min plus one
        public void CategoryMinPlusOne()
        {
            // create an instance of the class we want to create
            clsFurniture AFurniture = new clsFurniture();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Category = "ko"; // should should be ok
            // invoke the method
            Error = AFurniture.Valid(Category, Name, WoodType, Colour, Size, StockNo, Price);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        // validation test for category max less one
        public void CategoryMaxLessOne()
        {
            // create an instance of the class we want to create
            clsFurniture AFurniture = new clsFurniture();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Category = "ko"; // should should be ok
            // add characters to the variable
            Category = Category.PadRight(14, 'o');
            // invoke the method
            Error = AFurniture.Valid(Category, Name, WoodType, Colour, Size, StockNo, Price);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        // validation test for category max
        public void CategoryMax()
        {
            // create an instance of the class we want to create
            clsFurniture AFurniture = new clsFurniture();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Category = "ko"; // should be ok
            // add characters to the variable
            Category = Category.PadRight(15, 'o');
            // invoke the method
            Error = AFurniture.Valid(Category, Name, WoodType, Colour, Size, StockNo, Price);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        // validation test for category mid
        public void CategoryMid()
        {
            // create an instance of the class we want to create
            clsFurniture AFurniture = new clsFurniture();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Category = "ko"; // should be ok
            // add characters to the variable
            Category = Category.PadRight(7, 'o');
            // invoke the method
            Error = AFurniture.Valid(Category, Name, WoodType, Colour, Size, StockNo, Price);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        // validation test for category max plus one
        public void CategoryMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsFurniture AFurniture = new clsFurniture();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Category = "ko";
            // add characters till it reaches the 14
            Category = Category.PadRight(16, 'o');
            // invoke the method
            Error = AFurniture.Valid(Category, Name, WoodType, Colour, Size, StockNo, Price);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        // validation test for category extreme max
        public void CategoryExtremeMax()
        {
            // create an instance of the class we want to create
            clsFurniture AFurniture = new clsFurniture();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Category = "ko";
            // add characters till it reaches the 14
            Category = Category.PadRight(100, 'o');
            // invoke the method
            Error = AFurniture.Valid(Category, Name, WoodType, Colour, Size, StockNo, Price);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        // validation test for name min less one
        public void NameMinLessOne()
        {
            // create an instance of the class we want to create
            clsFurniture AFurniture = new clsFurniture();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Name = "";
            // invoke the method
            Error = AFurniture.Valid(Category, Name, WoodType, Colour, Size, StockNo, Price);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        // validation test for name min less one
        public void NameMin()
        {
            // create an instance of the class we want to create
            clsFurniture AFurniture = new clsFurniture();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Name = "n"; // should should be ok
            // invoke the method
            Error = AFurniture.Valid(Category, Name, WoodType, Colour, Size, StockNo, Price);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        // validation test for name min plus one
        public void NameMinPlusOne()
        {
            // create an instance of the class we want to create
            clsFurniture AFurniture = new clsFurniture();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Name = "no"; // should should be ok
            // invoke the method
            Error = AFurniture.Valid(Category, Name, WoodType, Colour, Size, StockNo, Price);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        // validation test for name max less one
        public void NameMaxLessOne()
        {
            // create an instance of the class we want to create
            clsFurniture AFurniture = new clsFurniture();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Name = ""; // should should be ok
            // add characters to the variable
            Name = Name.PadRight(14, 'p');
            // invoke the method
            Error = AFurniture.Valid(Category, Name, WoodType, Colour, Size, StockNo, Price);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        // validation test for name max
        public void NameMax()
        {
            // create an instance of the class we want to create
            clsFurniture AFurniture = new clsFurniture();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Name = ""; // should be ok
            // add characters to the variable
            Name = Name.PadRight(15, 'p');
            // invoke the method
            Error = AFurniture.Valid(Category, Name, WoodType, Colour, Size, StockNo, Price);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        // validation test for name mid
        public void NameMid()
        {
            // create an instance of the class we want to create
            clsFurniture AFurniture = new clsFurniture();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Name = "";
            // add characters to the variable
            Name = Name.PadRight(7, 'p');
            // invoke the method
            Error = AFurniture.Valid(Category, Name, WoodType, Colour, Size, StockNo, Price);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        // validation test for name max plus one
        public void NameMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsFurniture AFurniture = new clsFurniture();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Name = "";
            // add characters till it reaches the 14
            Name = Name.PadRight(16, 'p');
            // invoke the method
            Error = AFurniture.Valid(Category, Name, WoodType, Colour, Size, StockNo, Price);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        // validation test for name extreme max
        public void NameExtremeMax()
        {
            // create an instance of the class we want to create
            clsFurniture AFurniture = new clsFurniture();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Name = "";
            // add characters till it reaches the 14
            Name = Name.PadRight(100, 'p');
            // invoke the method
            Error = AFurniture.Valid(Category, Name, WoodType, Colour, Size, StockNo, Price);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        // validation test for wood type min less one
        public void WoodTypeMinLessOne()
        {
            // create an instance of the class we want to create
            clsFurniture AFurniture = new clsFurniture();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string WoodType = ""; // should trigger an error
            // invoke the method
            Error = AFurniture.Valid(Category, Name, WoodType, Colour, Size, StockNo, Price);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        // validation test for wood type min
        public void WoodTypeMin()
        {
            // create an instance of the class we want to create
            clsFurniture AFurniture = new clsFurniture();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string WoodType = "s";
            // invoke the method
            Error = AFurniture.Valid(Category, Name, WoodType, Colour, Size, StockNo, Price);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        // validation test for wood type min plus one
        public void WoodTypeMinPLusOne()
        {
            // create an instance of the class we want to create
            clsFurniture AFurniture = new clsFurniture();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string WoodType = "so"; // should should be ok
            // invoke the method
            Error = AFurniture.Valid(Category, Name, WoodType, Colour, Size, StockNo, Price);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        // validation test for wood type max less one
        public void WoodTypeMaxLessOne()
        {
            // create an instance of the class we want to create
            clsFurniture AFurniture = new clsFurniture();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string WoodType = ""; // should should be ok
            // add characters to the variable
            WoodType = WoodType.PadRight(14, 's');
            // invoke the method
            Error = AFurniture.Valid(Category, Name, WoodType, Colour, Size, StockNo, Price);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        // validation test for wood type max less one
        public void WoodTypeMax()
        {
            // create an instance of the class we want to create
            clsFurniture AFurniture = new clsFurniture();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Category = ""; // should should be ok
            // add characters to the variable
            Category = Category.PadRight(15, 's');
            // invoke the method
            Error = AFurniture.Valid(Category, Name, WoodType, Colour, Size, StockNo, Price);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        // validation test for wood type mid
        public void WoodTypeMid()
        {
            // create an instance of the class we want to create
            clsFurniture AFurniture = new clsFurniture();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string Category = ""; // should be ok
            // add characters to the variable
            Category = Category.PadRight(7, 's');
            // invoke the method
            Error = AFurniture.Valid(Category, Name, WoodType, Colour, Size, StockNo, Price);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
