using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void ActivePropertOK(){

            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data
            Boolean TestData = true;
            //Assign the data to the property
            AnCustomer.Active = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(AnCustomer.Active, TestData);
    }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnCustomer.DateAdded = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(AnCustomer.DateAdded, TestData);
        }


        [TestMethod]
        public void FirstNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
           string TestData = "John";
            //assign the data to the property
            AnCustomer.FirstName = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(AnCustomer.FirstName, TestData);
        }

        [TestMethod]
        public void LastNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Smith";
            //assign the data to the property
            AnCustomer.LastName = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(AnCustomer.LastName, TestData);
        }

        [TestMethod]
        public void EmailOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "John@gmail.com";
            //assign the data to the property
            AnCustomer.Email = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(AnCustomer.Email, TestData);
        }

        [TestMethod]
        public void StreetOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Northampton Street";
            //assign the data to the property
            AnCustomer.Street = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(AnCustomer.Street, TestData);
        }

        [TestMethod]
        public void FlatOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "4A";
            //assign the data to the property
            AnCustomer.Flat = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(AnCustomer.Flat, TestData);
        }

        [TestMethod]
        public void CityOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            AnCustomer.City = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(AnCustomer.City, TestData);
        }
        [TestMethod]
        public void PostcodeOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "LE15RT";
            //assign the data to the property
            AnCustomer.Postcode = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(AnCustomer.Postcode, TestData);
        }
        [TestMethod]
        public void CountryOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "United Kingdom";
            //assign the data to the property
            AnCustomer.Country = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(AnCustomer.Country, TestData);
        }
    }
}

    


