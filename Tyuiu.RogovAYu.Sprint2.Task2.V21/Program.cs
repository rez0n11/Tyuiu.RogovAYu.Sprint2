using System;
using Tyuiu.RogovAYu.Sprint2.Task2.V21.Lib;

namespace Tyuiu.RogovAYu.Sprint2.Task2.V21
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            bool result;

            Console.Title = "Task:..v| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:    Написать программу на, которая запрашивает целые значения с *");
            Console.WriteLine("*          клавиатуры и вычисляет находится ли точка с координатами X,Y в *\n" +
                              "* заштрихованной области.                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("* x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("* y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.CheckDotInShadedArea(x,y);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* ({x},{y}) c A == {result}");
            Console.WriteLine("***************************************************************************");
            int i=0, j = 0;
            while (i < 15)
            {
                while (j < 15)
                {
                    if (ds.CheckDotInShadedArea(j, i))
                    {
                        Console.Write("1");
                    }

                    else { Console.Write("."); };
                    ++j;
                }
                Console.Write('\n');++i;j = 0;
            }

            Console.ReadKey();
        }
    }
}
