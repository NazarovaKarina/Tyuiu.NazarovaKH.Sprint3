using Tyuiu.NazarovaKH.Sprint3.Task6.V2.Lib;

namespace Tyuiu.NazarovaKH.Sprint3.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 12;
            int stopValue = 18;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 29;

            Assert.AreEqual(res, wait);
        }
    }
}