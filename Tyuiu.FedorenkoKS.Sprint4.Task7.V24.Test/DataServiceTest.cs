using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FedorenkoKS.Sprint4.Task7.V24.Lib;

namespace Tyuiu.FedorenkoKS.Sprint4.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int n = 5;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "651827384219648";

            double res = ds.Calculate(n, m, str);
            double wait = 1179648;

            Assert.AreEqual(wait, res);
        }
    }
}