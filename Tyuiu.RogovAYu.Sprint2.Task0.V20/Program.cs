using System;
using Tyuiu.RogovAYu.Sprint2.Task0.V20.Lib;

namespace Tyuiu.RogovAYu.Sprint2.Task0.V20
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            bool[] result;

            Console.Title = "Task:2.0.v20| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие: Написать программу из операций сравнений (==, !=, <, >, <=, >= *");
            Console.WriteLine("*  последовательность операций не должна нарушаться) и арифметических     *");
            Console.WriteLine("* выражений, которая вернет логическую последовательность(массив):        *");
            Console.WriteLine("* (True,False,True,False,True,False), при x = 1075, y = 275               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("* x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("* y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.GetCompareOperations(x,y);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
