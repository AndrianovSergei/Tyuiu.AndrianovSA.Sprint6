using Tyuiu.AndrianovSA.Sprint6.Task0.V27.Lib;

namespace Tyuiu.AndrianovSA.Sprint6.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(4);
            double wait = -6;
            Assert.AreEqual(wait, res);
        }
    }
}