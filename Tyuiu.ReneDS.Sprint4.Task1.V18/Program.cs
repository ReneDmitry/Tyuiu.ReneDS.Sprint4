using System;
using Tyuiu.ReneDS.Sprint4.Task1.V18.Lib;

namespace Tyuiu.ReneDS.Sprint4.Task1.V18
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Ренье Д. С. | АСОиУБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Ренье Дмитрий Сергеевич | АСОиУБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Ввести с клавиатуры 16 целых чисел от 3 до 9.                           *");
            Console.WriteLine("* Найти сумму нечётных элементов массива.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[16];

            for (int i = 0; i < array.Length; i++)
            {
                int value;

                Console.Write("Введите элемент №" + (i + 1) + ": ");

                while (!int.TryParse(Console.ReadLine(), out value) ||
                    value < 3 || value > 9)
                {
                    Console.Write("Введите целое число от 3 до 9: ");
                }

                array[i] = value;
            }

            Console.WriteLine("Массив: " + string.Join(", ", array));

            int res;
            res = ds.Calculate(array);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма нечётных элементов = " + res);

            Console.ReadKey();
        }
    }
}