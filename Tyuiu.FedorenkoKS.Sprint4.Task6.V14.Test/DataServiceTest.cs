using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FedorenkoKS.Sprint4.Task6.V14.Lib;

namespace Tyuiu.FedorenkoKS.Sprint4.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var month = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль" };
            string[] res = ds.Calculate(month);
            string[] wait = { "Январь", "Февраль", "Март", "Апрель", "Июнь", "Июль" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}