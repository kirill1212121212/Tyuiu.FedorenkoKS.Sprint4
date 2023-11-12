using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FedorenkoKS.Sprint4.Task5.V22.Lib;
namespace Tyuiu.FedorenkoKS.Sprint4.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5];
            Random random = new Random();

            int res = ds.Calculate(mas2);
            int wait = 25;

            Assert.AreEqual(wait, res);
        }
    }
}