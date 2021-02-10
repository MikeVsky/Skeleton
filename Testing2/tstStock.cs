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
    }
}
