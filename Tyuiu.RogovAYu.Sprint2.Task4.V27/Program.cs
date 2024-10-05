using System;
using Tyuiu.RogovAYu.Sprint2.Task4.V27.Lib;

namespace Tyuiu.RogovAYu.Sprint.Task.V
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            double result;

            Console.Title = "Task:..v| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие: z = x-10>y+2 ? x*((y+2)/(x-1))**x) : y*y-2/x                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("* x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("* y = ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.Calculate(x,y);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* z = {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
