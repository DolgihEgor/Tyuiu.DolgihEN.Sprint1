using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DolgihEN.Sprint1.Task0.V12.Lib;

namespace Tyuiu.DolgihEN.Sprint1.Task0.V12
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
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Долгих Егор Николаевич | ИИПБ-23-2                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение (5*2 - 2) / 4 * 3       *");
            Console.WriteLine("* и печатает результат на экран                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("*(5*2 - 2) / 4 * 3                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Результат                                                                *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate());
            Console.ReadLine();
        }
    }
}
