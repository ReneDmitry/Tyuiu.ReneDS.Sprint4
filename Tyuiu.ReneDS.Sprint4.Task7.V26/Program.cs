using System;
using Tyuiu.ReneDS.Sprint4.Task7.V26.Lib;

namespace Tyuiu.ReneDS.Sprint4.Task7.V26
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Ренье Д. С. | АСОиУБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Преобразование строки в матрицу                                    *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Ренье Дмитрий Сергеевич | АСОиУБ-26-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Преобразовать строку из цифр в матрицу 5 на 3.                            *");
            Console.WriteLine("* Найти произведение чётных элементов матрицы.                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int n = 5;
            int m = 3;
            string value = "351268459614723";

            Console.WriteLine("Исходная строка: " + value);
            Console.WriteLine("Размер матрицы: " + n + " на " + m);

            int res = ds.Calculate(n, m, value);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Матрица:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,3}", value[i * m + j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine("Произведение чётных элементов = " + res);

            Console.ReadKey();
        }
    }
}
