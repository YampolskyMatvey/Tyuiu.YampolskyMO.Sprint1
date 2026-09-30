using System;
using Tyuiu.YampolskyMO.Sprint1.Task5.V4.Lib;

namespace Tyuiu.YampolskyMO.Sprint1.Task5.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Ямпольский М. О. | ИИПб-26-1";
            Console.WriteLine("***************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразования типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Ямпольский Матвей Олегович | ИИПб-26-1                        *");
            Console.WriteLine("***************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Идет k-я секунда суток. Определить, сколько полных часов (h) прошло     *");
            Console.WriteLine("* к этому моменту (например, h=3, если k=13257).                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************");

            int k;

            Console.WriteLine("Введите количество секунд (k):");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************");

            int res = ds.SecondsToHours(k);
            Console.WriteLine("Количество полных часов = " + res);

            Console.ReadKey();
        }
    }
}