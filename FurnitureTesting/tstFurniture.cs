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
    }
}
