using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PanasenkoRA.Sprint2.Task1.V0.Lib;

namespace Tyuiu.PanasenkoRA.Sprint2.Task1.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Панасенко Р. А. | ПКТб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы с C#                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #24                                                              *");
            Console.WriteLine("* Выполнил: Панаcенко Роман Анатольевич | ПКТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в выражени*");
            Console.WriteLine("* и) и логических операций (|, &, ||, &&, !, ^, последовательность        *");
            Console.WriteLine("* операций не должна нарушаться), а также арифметических выражений,       *");
            Console.WriteLine("* которая вернет логическую последовательность(массив):                   *");
            Console.WriteLine("* (True, False, True, False, True, False), при a = 325, b = 325, c = 242, *");
            Console.WriteLine("*  d = 324                                                                *");
            int a = 325;
            int b = 325;
            int c = 242;
            int d = 324;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
