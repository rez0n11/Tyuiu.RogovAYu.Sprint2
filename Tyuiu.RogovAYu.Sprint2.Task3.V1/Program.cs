using System;
using Tyuiu.RogovAYu.Sprint2.Task3.V1.Lib;

namespace Tyuiu.RogovAYu.Sprint2.Task3.V1
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            double result;

            Console.Title = "Task:2.3.v1| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:       Написать программу, которая вычисляет требуемое значение *\n" +
                              "* функции Y с использованием вложенных оператор if-else, где пользователь *\n" +
                              "* вводит значение переменной X с клавиатуры.                              *\n" +
                              "* Округлить полученное значение до трех знаков после запятой;             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("* x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.Calculate(x);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* y(x) = {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
