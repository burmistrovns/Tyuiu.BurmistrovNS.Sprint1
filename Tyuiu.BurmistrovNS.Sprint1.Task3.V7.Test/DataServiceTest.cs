using Tyuiu.BurmistrovNS.Sprint1.Task3.V7.Lib;

namespace Tyuiu.BurmistrovNS.Sprint1.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 100;
            double wait = 106.67999999999999;
            var res = ds.VerstsToKilometers(x);
            Assert.AreEqual(wait, res);
        }
        

    }
}
