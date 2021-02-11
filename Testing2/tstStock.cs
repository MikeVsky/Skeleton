using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingStock
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOk()
        {
            //Create instance of class
            clsStock AStockUnit = new clsStock();
            //Test if instance exists
            Assert.IsNotNull(AStockUnit);
        }

        public void ActivePropertyOk()
        {
            //create an instance of the class we want to create
            clsStock AStockUnit = new clsStock();
            // create test data to assign to property
            Boolean TestData = true;
            //Assign data to property
            AStockUnit.Available = TestData;
            //Test to see if they are equal
            Assert.AreEqual(AStockUnit.Available, TestData);


       }
        public void SneakerDescriptionPropertyOk()
        {
            //Create instance of class
            clsStock AStockUnit = new clsStock();
            //create test data to assign property
            string TestData = "New Black Air Force 1's";
            //Assign data to property
            AStockUnit.SneakerDescription = TestData;
            //Test to see if values are equal
            Assert.AreEqual(AStockUnit.SneakerDescription, TestData);

        }
        
        public void SneakerColourPropertyOk()
        {
            //Create instance of class
            clsStock AStockUnit = new clsStock();
            //Create test data
            string TestData = "Red";
            //Assign test data to property
            AStockUnit.SneakerColour = TestData;
            //Test to see if two values are equal
            Assert.AreEqual(AStockUnit.SneakerColour, TestData);
        }

        public void SneakerSizePropertyOk()
        {
            //Create instance of class
            clsStock AStockUnit = new clsStock();
            //Create test data 
            int TestData = 9;
            //Assign test data to property
            AStockUnit.SneakerSize = TestData;
            //Test if values are equal
            Assert.AreEqual(AStockUnit.SneakerSize, TestData);
        }
 
        public void PricePropertyOk()
        {
            //Create an instance of class
            clsStock AStockUnit = new clsStock();
            //Create test data 
            double TestData = 149.99;
            //Assign data to property
            AStockUnit.Price = TestData;
            //Test if values are equal
            Assert.AreEqual(AStockUnit.Price, TestData);

        }
        public void SneakerIdPropertyOk()
        {
            //Create instance of a class
            clsStock AStockUnit = new clsStock();
            //Create testdata
            int TestData = 1;
            //Assign data to property
            AStockUnit.SneakerId = TestData;
            //Test if values are equal
            Assert.AreEqual(AStockUnit.SneakerId, TestData);
            
        }
    }
}
