using FurnitureClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FurnitureTesting
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of class
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }
        [TestMethod]
        public void AddressPropertyOK()
        {
            //Create an instance of class
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property
            string TestData = "23, London Street";
            //assign the data to the property
            ACustomer.Address = TestData;
            //test to see that it exists
            Assert.AreEqual(ACustomer.Address, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //Create an instance of class
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property
            string TestData = "123";
            //assign the data to the property
            ACustomer.CustomerUserID = TestData;
            //test to see that it exists
            Assert.AreEqual(ACustomer.CustomerUserID, TestData);
        }


        [TestMethod]
        public void FirstnamePropertyOK()
        {
            //Create an instance of class
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property
            string TestData = "Victor";
            //assign the data to the property
            ACustomer.Firstname = TestData;
            //test to see that it exists
            Assert.AreEqual(ACustomer.Firstname, TestData);
        }

        [TestMethod]
        public void LastnamePropertyOK()
        {
            //Create an instance of class
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property
            string TestData = "Too";
            //assign the data to the property
            ACustomer.Lastname = TestData;
            //test to see that it exists
            Assert.AreEqual(ACustomer.Lastname, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //Create an instance of class
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property
            string TestData = "victortoo@gmail.com";
            //assign the data to the property
            ACustomer.Email = TestData;
            //test to see that it exists
            Assert.AreEqual(ACustomer.Email, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //Create an instance of class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateAdded, TestData);
        }


        [TestMethod]
        public void PhonePropertyOK()
        {
            //Create an instance of class
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property
            string TestData = "+445435423453";
            //assign the data to the property
            ACustomer.Phone = TestData;
            //test to see that it exists
            Assert.AreEqual(ACustomer.Phone, TestData);
        }
    }
}


