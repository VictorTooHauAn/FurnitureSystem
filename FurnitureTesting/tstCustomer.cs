using FurnitureClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FurnitureTesting
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass to the method
        string FirstName = "Lucis";
        string LastName = "Lucy";
        string Address = "154,Leicester";
        string EmailAddress = "lucis@yahoo.com";
        string PhoneNumber = "+4478434543433";
        string DateOfBirth = DateTime.Now.Date.ToString();

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
            ACustomer.EmailAddress = TestData;
            //test to see that it exists
            Assert.AreEqual(ACustomer.EmailAddress, TestData);
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
            ACustomer.PhoneNumber = TestData;
            //test to see that it exists
            Assert.AreEqual(ACustomer.PhoneNumber, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of class
            clsCustomer ACustomer = new clsCustomer();
            //Bollean varaible to store the results of the validation
            Boolean Found = false;
            //Create some test data to use 
            string CustomerUserID = "123";
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
            string CustomerUserID = "123";
            //invoker the method
            Found = ACustomer.Find(CustomerUserID);
            //check the address no
            if (ACustomer.CustomerUserID != "123")
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
            string CustomerUserID = "123";
            //invoker the method
            Found = ACustomer.Find(CustomerUserID);
            //check the address no
            if (ACustomer.Address != "Code")
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
            string CustomerUserID = "123";
            //invoker the method
            Found = ACustomer.Find(CustomerUserID);
            //check the address no
            if (ACustomer.Firstname != "Victor")
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
            string CustomerUserID = "123";
            //invoker the method
            Found = ACustomer.Find(CustomerUserID);
            //check the address no
            if (ACustomer.Lastname != "Too")
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
            string CustomerUserID = "123";
            //invoker the method
            Found = ACustomer.Find(CustomerUserID);
            //check the address no
            if (ACustomer.EmailAddress != "victortoo@hotmail.com")
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
            string CustomerUserID = "123";
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
            string CustomerUserID = "123";
            //invoker the method
            Found = ACustomer.Find(CustomerUserID);
            //check the address no
            if (ACustomer.PhoneNumber != "+4412345678912")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        // validation test
        public void ValideMethodOK()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error message
            String Error = "";
            // invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Address, EmailAddress, PhoneNumber, DateOfBirth);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        // validation test
        public void FirstNameMinLessOne()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            // invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Address, EmailAddress, PhoneNumber, DateOfBirth);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        // validation test
        public void FirstNameMin()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "v";
            // invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Address, EmailAddress, PhoneNumber, DateOfBirth);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        // validation test
        public void FirstNameMinPlusOne()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "va";
            // invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Address, EmailAddress, PhoneNumber, DateOfBirth);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        // validation test
        public void FirstNameMaxLessOne()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "vvvvvvvvvvvvvv";
            // invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Address, EmailAddress, PhoneNumber, DateOfBirth);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        // validation test
        public void FirstNameMax()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "vvvvvvvvvvvvvvv";
            // invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Address, EmailAddress, PhoneNumber, DateOfBirth);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        // validation test
        public void FirstNameMid()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "vvvvvvv";
            // invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Address, EmailAddress, PhoneNumber, DateOfBirth);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        // validation test
        public void FirstNameMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "vvvvvvvvvvvvvvvv";
            // invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Address, EmailAddress, PhoneNumber, DateOfBirth);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        // validation test
        public void FirstNameExtremeMax()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 'v');
            // invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Address, EmailAddress, PhoneNumber, DateOfBirth);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        // validation test
        public void LastNameMinLessOne()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            // invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Address, EmailAddress, PhoneNumber, DateOfBirth);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        // validation test
        public void LastNameMin()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "a";
            // invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Address, EmailAddress, PhoneNumber, DateOfBirth);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        // validation test
        public void LastNameMinPlusOne()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "aa";
            // invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Address, EmailAddress, PhoneNumber, DateOfBirth);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        // validation test
        public void LastNameMaxLessOne()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "aaaaaaaaaaaaaa";
            // invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Address, EmailAddress, PhoneNumber, DateOfBirth);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        // validation test
        public void LastNameMax()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "aaaaaaaaaaaaaaa";
            // invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Address, EmailAddress, PhoneNumber, DateOfBirth);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        // validation test
        public void LastNameMid()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "aaaaaaaa";
            // invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Address, EmailAddress, PhoneNumber, DateOfBirth);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        // validation test
        public void LastNameMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "aaaaaaaaaaaaaaaa";
            // invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Address, EmailAddress, PhoneNumber, DateOfBirth);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        // validation test
        public void LastNameExtremeMax()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(500, 'a');
            // invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Address, EmailAddress, PhoneNumber, DateOfBirth);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}


