using FurnitureClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FurnitureTesting
{
    [TestClass]
    public class tstPayment
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of class
            clsPayment Apayment = new clsPayment();
            //test to see that it exists
            Assert.IsNotNull(Apayment);
        }
        

        [TestMethod]
        public void PaymentIDPropertyOK()
        {
            //Create an instance of class
            clsPayment APayment = new clsPayment();
            //Create some test data to assign to the property
            string TestData = "123";
            //assign the data to the property
            APayment.PaymentID = TestData;
            //test to see that it exists
            Assert.AreEqual(APayment.PaymentID, TestData);
        }

        [TestMethod]
        public void CustomerUserIDPropertyOK()
        {
            //Create an instance of class
            clsPayment APayment = new clsPayment();
            //Create some test data to assign to the property
            string TestData = "1234";
            //assign the data to the property
            APayment.CustomerUserID = TestData;
            //test to see that it exists
            Assert.AreEqual(APayment.CustomerUserID, TestData);
        }

        [TestMethod]
        public void EmailAdressPropertyOK()
        {
            //Create an instance of class
            clsPayment APayment = new clsPayment();
            //Create some test data to assign to the property
            string TestData = "abc@gmail.com";
            //assign the data to the property
            APayment.EmailAddress = TestData;
            //test to see that it exists
            Assert.AreEqual(APayment.EmailAddress, TestData);
        }


        [TestMethod]
        public void AmountPropertyOK()
        {
            //Create an instance of class
            clsPayment APayment = new clsPayment();
            //Create some test data to assign to the property
            Decimal TestData = 20;
            //assign the data to the property
            APayment.Amount = TestData;
            //test to see that it exists
            Assert.AreEqual(APayment.Amount, TestData);
        }


        //[TestMethod]
        //public void AddressPropertyOK()
        //{
        //    //Create an instance of class
        //    clsCustomer ACustomer = new clsCustomer();
        //    //Create some test data to assign to the property
        //    string TestData = "23, London Street";
        //    //assign the data to the property
        //    ACustomer.Address = TestData;
        //    //test to see that it exists
        //    Assert.AreEqual(ACustomer.Address, TestData);
        //}

        [TestMethod]
        public void TypeOfPaymentPropertyOK()
        {
            //Create an instance of class
            clsPayment APayment = new clsPayment();
            //Create some test data to assign to the property
            string TestData = "Debit card";
            //assign the data to the property
            APayment.TypeOfPayment = TestData;
            //test to see that it exists
            Assert.AreEqual(APayment.TypeOfPayment, TestData);
        }


        [TestMethod]
        public void DateOfPaymentPropertyOK()
        {
            //Create an instance of class
            clsPayment APayment = new clsPayment();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            APayment.DateOfPayment = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(APayment.DateOfPayment, TestData);
        }



        [TestMethod]
        public void FindMethodpaymntOK()
        {
            //Create an instance of class
            clsPayment APayment = new clsPayment();
            //Bollean varaible to store the results of the validation
            Boolean Found = false;
            //Create some test data to use 
            string PaymentID = "1";
            //invoker the method
            Found = APayment.Find(PaymentID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestPaymentIDFound()
        {
            //Create an instance of class
            clsPayment APayment = new clsPayment();
            //Bollean varaible to store the results of the validation
            Boolean Found = false;
            //boolean varaible to record if data is ok(assume it is)
            Boolean OK = true;
            //create some test data to use
            string PaymentID = "1";
            //invoker the method
            Found = APayment.Find(PaymentID);
            //check the address no
            if (APayment.PaymentID != "1")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void EmailIDFound()
        {
            //Create an instance of class
            clsPayment APayment = new clsPayment();
            //Bollean varaible to store the results of the validation
            Boolean Found = false;
            //boolean varaible to record if data is ok(assume it is)
            Boolean OK = true;
            //create some test data to use
            string PayementID = "1";
            //invoker the method
            Found = APayment.Find(PayementID);
            //check the address no
            if (APayment.EmailAddress != "lucy@yahoo.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void customerUserIdFound()
        {
            //Create an instance of class
            clsPayment APayment = new clsPayment();
            //Bollean varaible to store the results of the validation
            Boolean Found = false;
            //boolean varaible to record if data is ok(assume it is)
            Boolean OK = true;
            //create some test data to use
            string PaymentID = "1";
            //invoker the method
            Found = APayment.Find(PaymentID);
            //check the address no
            if (APayment.CustomerUserID != "6842")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


    }
}


