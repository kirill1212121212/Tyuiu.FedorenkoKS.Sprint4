using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FedorenkoKS.Sprint4.Task1.V14.Lib;

namespace Tyuiu.FedorenkoKS.Sprint4.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 1, 5, 3, 6, 5, 4, 8, 6, 8, 4, 2, 3, 1 };
            int res = ds.Calculate(numsArray);
            int wait = 18;
            Assert.AreEqual(wait, res);
        }
    }
}