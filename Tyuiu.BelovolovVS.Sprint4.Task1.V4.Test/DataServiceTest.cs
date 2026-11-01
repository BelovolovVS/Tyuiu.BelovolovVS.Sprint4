using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BelovolovVS.Sprint4.Task1.V4.Lib;

namespace Tyuiu.BelovolovVS.Sprint4.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 2, 5, 3, 4, 7, 8, 8, 3, 9 };
            int wait = 2835;

            int res = ds.Calculate(numsArray);

            Assert.AreEqual(wait, res);
        }
    }
}