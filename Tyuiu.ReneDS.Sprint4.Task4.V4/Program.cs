using System;
using Tyuiu.ReneDS.Sprint4.Task4.V4.Lib;

namespace Tyuiu.ReneDS.Sprint4.Task4.V4
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Ренье Д. С. | АСОиУБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                             *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Ренье Дмитрий Сергеевич | АСОиУБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Ввести матрицу 5 на 5 со значениями от 3 до 9.                          *");
            Console.WriteLine("* Заменить чётные элементы матрицы на 1.                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[5, 5];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int value;
                    Console.Write($"Строка {i + 1}, столбец {j + 1}: ");

                    while (!int.TryParse(Console.ReadLine(), out value) ||
                        value < 3 || value > 9)
                    {
                        Console.Write("Введите целое число от 3 до 9: ");
                    }

                    matrix[i, j] = value;
                }
            }

            int[,] res = ds.Calculate(matrix);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    Console.Write("{0,3}", res[i, j]);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}