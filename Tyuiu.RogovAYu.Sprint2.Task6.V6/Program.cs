using System;
using Tyuiu.RogovAYu.Sprint2.Task6.V6.Lib;

namespace Tyuiu.RogovAYu.Sprint2.Task6.V6
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            string result;

            Console.Title = "Task2.6.v6| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:По заданным номеру масти m и номеру достоинства карты k         *\n" +
                              "*            определить полное название карты                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("* x = ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("* y = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.FindCardNameAndValue(m,n);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
