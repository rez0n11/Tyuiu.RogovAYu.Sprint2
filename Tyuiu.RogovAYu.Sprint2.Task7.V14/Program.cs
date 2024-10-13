using System;
using Tyuiu.RogovAYu.Sprint2.Task7.V14.Lib;

namespace Tyuiu.RogovAYu.Sprint2.Task7.V14
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            bool result;

            Console.Title = "Task:2.7.v14| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #7                                                               *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:вычислить, находится ли точка с координатами XY в заштрихованной*\n" +
                              "*                                                                области. *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("* x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("* y = ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.CheckDotInShadedArea(x,y);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* bool = {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
