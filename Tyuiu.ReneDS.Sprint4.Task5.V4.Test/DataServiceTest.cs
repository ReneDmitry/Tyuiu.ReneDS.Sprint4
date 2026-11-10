using Tyuiu.ReneDS.Sprint4.Task5.V4.Lib;

namespace Tyuiu.ReneDS.Sprint4.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5]
            {
                { -4,  0,  2,  5,  6 },
                {  1, -2,  0, -3,  4 },
                {  3,  2, -1,  0,  5 },
                {  0, -4,  6,  1, -2 },
                {  4,  0, -3,  2,  6 }
            };

            int res = ds.Calculate(mas2);
            int wait = 13;

            Assert.AreEqual(wait, res);
        }
    }
}
