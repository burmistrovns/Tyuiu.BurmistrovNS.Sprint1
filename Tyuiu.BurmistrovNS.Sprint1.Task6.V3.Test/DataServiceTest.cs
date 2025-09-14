using System.Globalization;
using Tyuiu.BurmistrovNS.Sprint1.Task6.V3.Lib;

namespace Tyuiu.BurmistrovNS.Sprint1.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Сегодня солнечный день";
            DataService ds = new DataService();
            string res = ds.LastLetterWord(strTest);
            string wait = "яйь";
            Assert.AreEqual(wait, res);

        }
    }
}
