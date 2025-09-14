﻿using Tyuiu.BurmistrovNS.Sprint1.Task2.V11.Lib;

namespace Tyuiu.BurmistrovNS.Sprint1.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 30;
            var res = ds.ConvertHoursMinutesToSeconds(x, y);
            Assert.AreEqual(9000, res);


        }
    }
}
