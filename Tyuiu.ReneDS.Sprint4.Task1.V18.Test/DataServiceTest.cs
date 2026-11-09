using Tyuiu.ReneDS.Sprint4.Task1.V18.Lib;

namespace Tyuiu.ReneDS.Sprint4.Task1.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = { 7, 6, 9, 8, 9, 7, 4, 7, 8, 5, 6, 3, 9, 7, 9, 7 };

            int res = ds.Calculate(array);
            int wait = 79;

            Assert.AreEqual(wait, res);
        }
    }
}
