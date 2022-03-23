using FurnitureClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace FurnitureTesting
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomer);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to asssign to the property
            //in this case the data needs to be a list of object
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerUserID = "12345";
            TestItem.Firstname = "Peter";
            TestItem.Lastname = "Lee";
            TestItem.Address = "5, London";
            TestItem.EmailAddress = "peter@gmail.com";
            TestItem.PhoneNumber = "+4498765432123";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //asign the data to the property
            AllCustomer.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.CustomerList, TestList);
        }

        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    //create an instance of the class we want to create
        //    clsCustomerCollection AllCustomer = new clsCustomerCollection();
        //    //create some test data to assign to the property
        //    Int32 SomeCount = 2;
        //    //assign the data to the property
        //    AllCustomer.Count = SomeCount;
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllCustomer.Count,SomeCount);
        //}

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to asssign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.CustomerUserID = "12345";
            TestCustomer.Firstname = "Peter";
            TestCustomer.Lastname = "Lee";
            TestCustomer.Address = "5, London";
            TestCustomer.EmailAddress = "peter@gmail.com";
            TestCustomer.PhoneNumber = "+4498765432123";
            TestCustomer.DateAdded = DateTime.Now.Date;
            //asign the data to the property
            AllCustomer.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);
        }


        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to asssign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerUserID = "12345";
            TestItem.Firstname = "Peter";
            TestItem.Lastname = "Lee";
            TestItem.Address = "5, London";
            TestItem.EmailAddress = "peter@gmail.com";
            TestItem.PhoneNumber = "+4498765432123";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //asign the data to the property
            AllCustomer.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.Count, TestList.Count);
        }

        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    //create an instance of the class we want to create
        //    clsCustomerCollection AllCustomer = new clsCustomerCollection();
        //    //test to see that the two value are the same
        //    Assert.AreEqual(AllCustomer.Count, 2);
        //}
    }
}
