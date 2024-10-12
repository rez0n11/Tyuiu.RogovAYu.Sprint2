using System;
using Tyuiu.RogovAYu.Sprint2.Task5.V2.Lib;

namespace Tyuiu.RogovAYu.Sprint2.Task5.V2
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            string result;

            Console.Title = "Task:..v| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие: По данному месяцу, определите в какую пору года попадает этот  *\n" +
                              "*            месяц (Зима, Лето, Весна, Осень).                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("* ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.FindMonthSeason(input);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
