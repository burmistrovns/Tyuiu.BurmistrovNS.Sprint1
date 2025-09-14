﻿using Tyuiu.BurmistrovNS.Sprint1.Task4.V4.Lib;

namespace Tyuiu.BurmistrovNS.Sprint1.Task4.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
