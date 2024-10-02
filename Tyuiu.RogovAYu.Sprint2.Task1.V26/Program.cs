using System;
using Tyuiu.RogovAYu.Sprint2.Task1.V26.Lib;

namespace Tyuiu.RogovAYu.Sprint2.Task1.V26
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            bool[] result;

            Console.Title = "Task:2.1.v26| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                 *");
            Console.WriteLine("* Задание #1                                                                *");
            Console.WriteLine("* Вариант #26                                                               *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                            *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Условие:Написать программу из операций сравнений (==, !=, <, >, <=, >=,   *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в выражении)*");
            Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^, последовательность операций не *");
            Console.WriteLine("* должна нарушаться), а также арифметических выражений, которая вернет      *");
            Console.WriteLine("* логическую последовательность(массив): (True,True,True, False,True,False) *");
            Console.WriteLine("*   при a = 654, b = 671, c = 874, d = 137                                  *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Исходные данные:                                                          *");
            Console.Write("* a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("* b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("* c = ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("* d = ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*****************************************************************************");

            { //code
                result = ds.GetLogicOperations(a,b,c,d);
            }
            Console.WriteLine("* Результат:                                                                *");
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("*****************************************************************************");
            Console.ReadKey();
        }
    }
}
