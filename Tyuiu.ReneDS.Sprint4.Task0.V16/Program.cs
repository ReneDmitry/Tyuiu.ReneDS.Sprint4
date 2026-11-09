using System;
using Tyuiu.ReneDS.Sprint4.Task0.V16.Lib;

namespace Tyuiu.ReneDS.Sprint4.Task0.V16
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Ренье Д. С. | АСОиУБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Ренье Дмитрий Сергеевич | АСОиУБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан целочисленный массив из 10 элементов со значениями от 0 до 9.       *");
            Console.WriteLine("* Найти произведение чётных элементов массива.                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };

            Console.WriteLine("Массив: " + string.Join(", ", array));

            int res;
            res = ds.GetMultEvenArrEl(array);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение чётных элементов = " + res);

            Console.ReadKey();
        }
    }
}
