using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.YampolskyMO.Sprint1.Task3.V12.Lib;

namespace Tyuiu.YampolskyMO.Sprint1.Task3.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Ямпольский М. О. | ИИПб-26-1";
            Console.WriteLine("***************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Ямпольский Матвей Олегович | ИИПб-26-1                        *");
            Console.WriteLine("***************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу для вычисления площади прямоугольного треугольника   *");
            Console.WriteLine("* по длинам двух катетов. Ответ округлите до 3 знаков после запятой.      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************");

            double x, y;

            Console.WriteLine("Введите длину первого катета:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину второго катета:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************");

            Console.WriteLine("Площадь прямоугольного треугольника = " + ds.TriangleArea(x, y));

            Console.ReadKey();
        }
    }
}