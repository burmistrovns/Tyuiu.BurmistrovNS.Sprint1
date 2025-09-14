using Tyuiu.BurmistrovNS.Sprint1.Task7.V5.Lib;

namespace Tyuiu.BurmistrovNS.Sprint1.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 10;
            double wait = -0.03801836167701159;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
