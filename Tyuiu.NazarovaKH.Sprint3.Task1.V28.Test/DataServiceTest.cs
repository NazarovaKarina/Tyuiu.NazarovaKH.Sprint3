using Tyuiu.NazarovaKH.Sprint3.Task1.V28.Lib;

namespace Tyuiu.NazarovaKH.Sprint3.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 0.5;
            int startValue = 1;
            int stopValue = 18;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 0.814;

            Assert.AreEqual(wait, res);
        }
    }
}