using Tyuiu.ReneDS.Sprint4.Task3.V2.Lib;

namespace Tyuiu.ReneDS.Sprint4.Task3.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5]
            {
                { 4, 3, 2, 8, 7 },
                { 4, 6, 5, 5, 7 },
                { 3, 8, 8, 3, 5 },
                { 5, 7, 5, 4, 4 },
                { 8, 8, 3, 7, 6 }
            };

            int res = ds.Calculate(mas2);
            int wait = 8;

            Assert.AreEqual(wait, res);
        }
    }
}
