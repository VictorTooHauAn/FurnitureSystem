using FurnitureClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace FurnitureTesting
    {
        [TestClass]
        public class tstPaymentollection
        {
            [TestMethod]
            public void InstanceOK()
            {
                //create an instance of the class we want to create
                clsPaymentCollection AllPayment = new clsPaymentCollection();
                //test to see that it exists
                Assert.IsNotNull(AllPayment);
            }

            [TestMethod]
            public void PaymentListOK()
            {
                //create an instance of the class we want to create
                clsPaymentCollection AllPayment = new clsPaymentCollection();
                //create some test data to asssign to the property
                //in this case the data needs to be a list of object
                List<clsPayment> TestList = new List<clsPayment>();
                //add an item to the list
                //create the item of test data
                clsPayment TestItem = new clsPayment();
                //set its properties
                TestItem.PaymentID = "1";
                TestItem.CustomerUserID = "6842";
                TestItem.EmailAddress = "lucy@yahoo.com";
                TestItem.Amount = 20;
                TestItem.DateOfPayment = DateTime.Now.Date;
                TestItem.TypeOfPayment = "cash";
            //add the item to the test list
            TestList.Add(TestItem);
            //asign the data to the property
            AllPayment.PaymentList = TestList;
                //test to see that the two values are the same
                Assert.AreEqual(AllPayment.PaymentList, TestList);
            }


        //[TestMethod]
        //public void AddMethodOK()
        //{
        //    //create an instance of the class we want to create
        //    clsPaymentCollection AllPayment = new clsPaymentCollection();
        //    //create the item of test data
        //    clsPayment TestItem = new clsPayment();
        //    //var to store the primary key
        //    string PrimaryKey = "";
        //    //set its properties
        //    TestItem.PaymentID = "1";
        //    TestItem.CustomerUserID = "6842";
        //    TestItem.EmailAddress = "lucy@yahoo.com";
        //    TestItem.Amount = 20;
        //    TestItem.DateOfPayment = DateTime.Now.Date;
        //    TestItem.TypeOfPayment = "cash";
        //    //set ThisCustomer to the test data
        //    AllPayment.ThisPayment = TestItem;
        //    //add the record
        //    PrimaryKey = AllPayment.Add();
        //    //set the primary key of the test data
        //    TestItem.PaymentID = PrimaryKey;
        //    //find the record
        //    AllPayment.ThisPayment.Find(PrimaryKey);
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllPayment.ThisPayment, TestItem);
        //}



        [TestMethod]
            public void ThisPaymentPropertyOK()
            {
                //create an instance of the class we want to create
                clsPaymentCollection AllPayment = new clsPaymentCollection();
                //create some test data to asssign to the property
                clsPayment TestPayment = new clsPayment();
            TestPayment.PaymentID = "1";
            TestPayment.CustomerUserID = "6842";
            TestPayment.EmailAddress = "lucy@yahoo.com";
            TestPayment.Amount = 20;
            TestPayment.DateOfPayment = DateTime.Now.Date;
            TestPayment.TypeOfPayment = "debit";
           
            //asign the data to the property
             AllPayment.ThisPayment = TestPayment;
                //test to see that the two values are the same
                Assert.AreEqual(AllPayment.ThisPayment, TestPayment);
            }


            [TestMethod]
            public void ListAndCountOK()
            {
                //create an instance of the class we want to create
                clsPaymentCollection AllPayment = new clsPaymentCollection();
                //create some test data to asssign to the property
                //in this case the data needs to be a list of objects
                List<clsPayment> TestList = new List<clsPayment>();
                //add an item to the list
                //create the item of test data
                clsPayment TestItem = new clsPayment();
            //set its properties
            TestItem.PaymentID = "1";
            TestItem.CustomerUserID = "6842";
            TestItem.EmailAddress = "lucy@yahoo.com";
            TestItem.Amount = 20;
            TestItem.DateOfPayment = DateTime.Now.Date;
            TestItem.TypeOfPayment = "cash";
            //add the item to the test list
            TestList.Add(TestItem);
                //asign the data to the property
                AllPayment.PaymentList = TestList;
                //test to see that the two values are the same
                Assert.AreEqual(AllPayment.Count, TestList.Count);
            }

           
        }
    }

