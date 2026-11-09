using Tyuiu.ReneDS.Sprint4.Task0.V16.Lib;

namespace Tyuiu.ReneDS.Sprint4.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };

            int res = ds.GetMultEvenArrEl(array);
            int wait = 3072;

            Assert.AreEqual(wait, res);
        }
    }
}
