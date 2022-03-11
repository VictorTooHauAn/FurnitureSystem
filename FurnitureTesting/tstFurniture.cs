using FurnitureClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FurnitureTesting
{
    [TestClass]
    public class tstFurniture
    {
        [TestMethod]
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
    }
}
