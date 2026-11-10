using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ReneDS.Sprint4.Task6.V10.Lib
{
    public class DataService : ISprint4Task6V10
    {
        public string[] Calculate(string[] array)
        {
            string[] res = Array.FindAll(array, item => item.Length < 7);

            return res;
        }
    }
}
