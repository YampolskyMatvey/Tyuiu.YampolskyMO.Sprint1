using System;
using Tyuiu.YampolskyMO.Sprint1.Task7.V18.Lib;

namespace Tyuiu.YampolskyMO.Sprint1.Task7.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Ямпольский М. О. | ИИПб-26-1";
            Console.WriteLine("***************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов                           *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Ямпольский Матвей Олегович | ИИПб-26-1                        *");
            Console.WriteLine("***************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычислит математическое выражение по        *");
            Console.WriteLine("* исходным значениям X и Y. Ответ округлить до 3 знаков после запятой.    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************");

            double x, y;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************");

            double res = ds.Calculate(x, y);
            Console.WriteLine("Результат = " + res);

            Console.ReadKey();
        }
    }
}