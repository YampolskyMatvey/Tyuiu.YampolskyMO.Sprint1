using System;
using Tyuiu.YampolskyMO.Sprint1.Task6.V9.Lib;

namespace Tyuiu.YampolskyMO.Sprint1.Task6.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Ямпольский М. О. | ИИПб-26-1";
            Console.WriteLine("***************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Ямпольский Матвей Олегович | ИИПб-26-1                        *");
            Console.WriteLine("***************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Пользователь вводит текст. Напечатать все слова, перенеся их последнюю  *");
            Console.WriteLine("* букву в начало.                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************");

            string str;

            Console.WriteLine("Введите текст:");
            str = Console.ReadLine();

            Console.WriteLine("***************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************");

            string res = ds.MoveLetterToStart(str);
            Console.WriteLine("Результат: " + res);

            Console.ReadKey();
        }
    }
}