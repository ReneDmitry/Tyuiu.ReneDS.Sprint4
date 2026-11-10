using Tyuiu.ReneDS.Sprint4.Task7.V26.Lib;

namespace Tyuiu.ReneDS.Sprint4.Task7.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCacl()
        {
            DataService ds = new DataService();

            int n = 5;
            int m = 3;
            string value = "351268459614723";

            int res = ds.Calculate(n, m, value);
            int wait = 18432;

            Assert.AreEqual(wait, res);
        }
    }
}
