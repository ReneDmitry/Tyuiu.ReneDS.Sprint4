using Tyuiu.ReneDS.Sprint4.Task6.V10.Lib;

namespace Tyuiu.ReneDS.Sprint4.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            string[] array =
            {
                "Театр", "Кино", "Музей", "Парк",
                "Зоопарк", "Концерт", "Выставка"
            };

            string[] res = ds.Calculate(array);
            string[] wait = { "Театр", "Кино", "Музей", "Парк" };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
