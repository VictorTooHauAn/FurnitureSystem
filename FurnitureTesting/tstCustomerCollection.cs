using FurnitureClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using FurnitureTesting;

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

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            string PrimaryKey = "";
            //set its properties
            TestItem.CustomerUserID = "13668";
            TestItem.Firstname = "Peter";
            TestItem.Lastname = "Lee";
            TestItem.Address = "5, London";
            TestItem.EmailAddress = "peter@gmail.com";
            TestItem.PhoneNumber = "+4498765432123";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisCustomer to the test data
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomer.Add();
            //set the primary key of the test data
            TestItem.CustomerUserID = PrimaryKey;
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }

        //[TestMethod]
        //public void DeleteMethodOK()
        //{
        //    //create an instance of the class we want to create
        //    clsCustomerCollection AllCustomer = new clsCustomerCollection();
        //    //create the item of test data
        //    clsCustomer TestItem = new clsCustomer();
        //    //var to store the primary key
        //    string PrimaryKey = "";
        //    //set its properties
        //    TestItem.CustomerUserID = "1574851";
        //    TestItem.Firstname = "Peter";
        //    TestItem.Lastname = "Lee";
        //    TestItem.Address = "5, London";
        //    TestItem.EmailAddress = "peter@gmail.com";
        //    TestItem.PhoneNumber = "+4498765432123";
        //    TestItem.DateAdded = DateTime.Now.Date;
        //    //set ThisCustomer to the test data
        //    AllCustomer.ThisCustomer = TestItem;
        //    //add the record
        //    PrimaryKey = AllCustomer.Add();
        //    //set the primary key of the test data
        //    TestItem.CustomerUserID = PrimaryKey;
        //    //find the record
        //    AllCustomer.ThisCustomer.Find(PrimaryKey);
        //    //delete the record
        //    AllCustomer.Delete();
        //    //now find the record
        //    Boolean Found = AllCustomer.ThisCustomer.Find(PrimaryKey);
        //    //test to see taht the record was not found
        //    Assert.IsFalse(Found);
        //}

        //[TestMethod]
        //public void UpdateMethodOK()
        //{
        //    //create an instance of the class we want to create
        //    clsCustomerCollection AllCustomer = new clsCustomerCollection();
        //    //create the item of test data
        //    clsCustomer TestItem = new clsCustomer();
        //    //var to store the primary key
        //    string PrimaryKey = "";
        //    //set its properties
        //    TestItem.Firstname = "Peter";
        //    TestItem.Lastname = "Lee";
        //    TestItem.Address = "5, London";
        //    TestItem.EmailAddress = "peter@gmail.com";
        //    TestItem.PhoneNumber = "+4498765432123";
        //    TestItem.DateAdded = DateTime.Now.Date;
        //    //set ThisCustomer to the test data
        //    AllCustomer.ThisCustomer = TestItem;
        //    //add the record
        //    PrimaryKey = AllCustomer.Add();
        //    //set the primary key of the test data
        //    TestItem.CustomerUserID = PrimaryKey;
        //    //modify the test data
        //    TestItem.Firstname = "Henry";
        //    TestItem.Lastname = "Petel";
        //    TestItem.Address = "30H, Highland";
        //    TestItem.EmailAddress = "henry@yahoo.com";
        //    TestItem.PhoneNumber = "+4412345678987";
        //    TestItem.DateAdded = DateTime.Now.Date;
        //    //set the record based on the new test data
        //    AllCustomer.ThisCustomer = TestItem;
        //    //update the record
        //    AllCustomer.Update();
        //    //find the record
        //    AllCustomer.ThisCustomer.Find(PrimaryKey);
        //    //test to see ThisAddress matches the test data
        //    Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        //}


        [TestMethod]
        public void ReportByFirstNameMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            //apply a blank string (should return all records)
            FilteredCustomer.ReportByFirstName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.Count, FilteredCustomer.Count);
        }

        [TestMethod]
        public void ReportByFirstNameNoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            //apply a post code that doesn't exist
            FilteredCustomer.ReportByFirstName("xxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomer.Count);
        }

        [TestMethod]
        public void ReportByFirstNameDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a post code that doesn't exist
            FilteredCustomer.ReportByFirstName("Alpfa");
            //check that the correct number of records are found
            if (FilteredCustomer.Count == 2)
            {
                //check that the first record CustomerID is 9999
                if (FilteredCustomer.CustomerList[0].CustomerUserID != "9998")
                {
                    OK = false;
                }
                //check that the first record is CustomerID is 9998
                if (FilteredCustomer.CustomerList[1].CustomerUserID != "9999")
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
