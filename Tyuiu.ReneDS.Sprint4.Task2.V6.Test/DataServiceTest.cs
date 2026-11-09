using Tyuiu.ReneDS.Sprint4.Task2.V6.Lib;

namespace Tyuiu.ReneDS.Sprint4.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 2, 3, 4, 5, 6, 7, 8, 2, 3, 4, 5, 6, 7, 8, 2 };

            int res = ds.Calculate(array);
            int wait = 11025;

            Assert.AreEqual(wait, res);
        }
    }
}
