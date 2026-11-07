using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BelovolovVS.Sprint4.Task5.V12.Lib;

namespace Tyuiu.BelovolovVS.Sprint4.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { -6,  2, -3,  0,  4 },
                { -1, -5,  3, -2,  1 },
                {  4, -4,  0, -6,  2 },
                { -3,  1, -1,  3, -2 },
                {  0, -5,  4, -4, -3 } };

            int res = ds.Calculate(mas2);
            int wait = 13; 

            Assert.AreEqual(wait, res);
        }
    }
}