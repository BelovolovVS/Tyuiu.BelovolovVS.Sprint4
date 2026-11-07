using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BelovolovVS.Sprint4.Task2.V3.Lib;

namespace Tyuiu.BelovolovVS.Sprint4.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 3, 4, 5, 6, 7, 2, 3, 4, 5, 6, 7 };
            int wait = 24;

            int res = ds.Calculate(numsArray);

            Assert.AreEqual(wait, res);
        }
    }
}