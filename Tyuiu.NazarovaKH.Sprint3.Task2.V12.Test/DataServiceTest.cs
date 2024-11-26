using Tyuiu.NazarovaKH.Sprint3.Task2.V12.Lib;

namespace Tyuiu.NazarovaKH.Sprint3.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 5;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 186.383;

            Assert.AreEqual(wait, res);
        }
    }
}