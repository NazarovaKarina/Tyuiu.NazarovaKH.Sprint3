using Tyuiu.NazarovaKH.Sprint3.Task3.V5.Lib;

namespace Tyuiu.NazarovaKH.Sprint3.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharInString()
        {
            DataService ds = new DataService();

            string value = "fifa al fall";
            char replaceable = 'a', replacement = '*';
            string res = ds.ReplaceCharInString(value, replaceable, replacement);

            Assert.AreEqual("fif* *l f*ll", res);
        }
    }
}