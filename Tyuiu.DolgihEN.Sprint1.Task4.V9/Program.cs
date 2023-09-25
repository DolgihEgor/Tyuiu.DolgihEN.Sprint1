using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DolgihEN.Sprint1.Task4.V9.Lib;

namespace Tyuiu.DolgihEN.Sprint1.Task4.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Долгих Е.Н | ИИПБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Долгих Егор Николаевич | ИИПБ-23-2                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите значение y: ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Результат:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Результат: " + Math.Round(ds.Calculate(x, y),3));
            Console.ReadLine();
        }
    }
}
