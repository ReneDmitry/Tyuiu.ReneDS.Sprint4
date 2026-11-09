using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ReneDS.Sprint4.Task3.V2.Lib
{
    public class DataService : ISprint4Task3V2
    {
        public int Calculate(int[,] matrix)
        {
            int res = matrix[0, 0];

            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[0, j] > res)
                {
                    res = matrix[0, j];
                }
            }

            return res;
        }
    }
}
