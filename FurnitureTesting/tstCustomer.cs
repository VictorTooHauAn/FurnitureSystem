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
            string TestData = "P123";
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

        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of class
            clsCustomer ACustomer = new clsCustomer();
            //Bollean varaible to store the results of the validation
            Boolean Found = false;
            //Create some test data to use 
            string CustomerUserID = "P123";
            //invoker the method
            Found = ACustomer.Find(CustomerUserID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestCustomerUserIDFound()
        {
            //Create an instance of class
            clsCustomer ACustomer = new clsCustomer();
            //Bollean varaible to store the results of the validation
            Boolean Found = false;
            //boolean varaible to record if data is ok(assume it is)
            Boolean OK = true;
            //create some test data to use
            string CustomerUserID = "P123";
            //invoker the method
            Found = ACustomer.Find(CustomerUserID);
            //check the address no
            if (ACustomer.CustomerUserID != "P123")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //Create an instance of class
            clsCustomer ACustomer = new clsCustomer();
            //Bollean varaible to store the results of the validation
            Boolean Found = false;
            //boolean varaible to record if data is ok(assume it is)
            Boolean OK = true;
            //create some test data to use
            string CustomerUserID = "P123";
            //invoker the method
            Found = ACustomer.Find(CustomerUserID);
            //check the address no
            if (ACustomer.Address != "Test Address")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            //Create an instance of class
            clsCustomer ACustomer = new clsCustomer();
            //Bollean varaible to store the results of the validation
            Boolean Found = false;
            //boolean varaible to record if data is ok(assume it is)
            Boolean OK = true;
            //create some test data to use
            string CustomerUserID = "P123";
            //invoker the method
            Found = ACustomer.Find(CustomerUserID);
            //check the address no
            if (ACustomer.Firstname != "Test First Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            //Create an instance of class
            clsCustomer ACustomer = new clsCustomer();
            //Bollean varaible to store the results of the validation
            Boolean Found = false;
            //boolean varaible to record if data is ok(assume it is)
            Boolean OK = true;
            //create some test data to use
            string CustomerUserID = "P123";
            //invoker the method
            Found = ACustomer.Find(CustomerUserID);
            //check the address no
            if (ACustomer.Lastname != "Test Last Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //Create an instance of class
            clsCustomer ACustomer = new clsCustomer();
            //Bollean varaible to store the results of the validation
            Boolean Found = false;
            //boolean varaible to record if data is ok(assume it is)
            Boolean OK = true;
            //create some test data to use
            string CustomerUserID = "P123";
            //invoker the method
            Found = ACustomer.Find(CustomerUserID);
            //check the address no
            if (ACustomer.Email != "Test Email")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAdded()
        {
            //Create an instance of class
            clsCustomer ACustomer = new clsCustomer();
            //Bollean varaible to store the results of the validation
            Boolean Found = false;
            //boolean varaible to record if data is ok(assume it is)
            Boolean OK = true;
            //create some test data to use
            string CustomerUserID = "P123";
            //invoker the method
            Found = ACustomer.Find(CustomerUserID);
            //check the address no
            if (ACustomer.DateAdded != Convert.ToDateTime("20/4/2000"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhone()
        {
            //Create an instance of class
            clsCustomer ACustomer = new clsCustomer();
            //Bollean varaible to store the results of the validation
            Boolean Found = false;
            //boolean varaible to record if data is ok(assume it is)
            Boolean OK = true;
            //create some test data to use
            string CustomerUserID = "P123";
            //invoker the method
            Found = ACustomer.Find(CustomerUserID);
            //check the address no
            if (ACustomer.Phone != "Test Phone")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}


