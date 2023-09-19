using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DolgihEN.Sprint1.Task3.V18.Lib;

namespace Tyuiu.DolgihEN.Sprint1.Task3.V18
{
    //Написать программу, которая вычисляет, сколько квадратов со стороной C можно разместить внутри
    //
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Долгих Е.Н | ИИПБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Долгих Егор Николаевич | ИИПБ-23-2                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет, сколько квадратов                *");
            Console.WriteLine("* со стороной C можно разместить внутри прямоугольника                    *");
            Console.WriteLine("* с размерами A x B без наложений.                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a = 6;
            Console.WriteLine("Сторона A прямоугольника равна:" + a);
            int b = 12;
            Console.WriteLine("Сторона B прямоугольника равна:" + b);
            int c = 6;
            Console.WriteLine("Квадраты со строной с" + c);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Результат:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество квадратов в прямоугольнике =" + ds.HowManySquares(a, b, c));
            Console.ReadKey();
        }
    }
}
