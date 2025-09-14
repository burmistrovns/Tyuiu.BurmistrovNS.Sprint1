using Tyuiu.BurmistrovNS.Sprint1.Task5.V3.Lib;

namespace Tyuiu.BurmistrovNS.Sprint1.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var k = 12345678;
            double res = ds.Calculate(k);

            int result = Convert.ToInt32(res);

            int wait = 6;

            Assert.AreEqual(wait, result);

            




        }
    }
}
