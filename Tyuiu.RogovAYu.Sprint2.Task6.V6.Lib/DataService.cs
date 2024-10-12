using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.RogovAYu.Sprint2.Task6.V6
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int m, int n)
        {
            string a="", b = "";
            switch (m)
            {
                case 1: { a = " пик"; break; }
                case 2: { a = ""; break; }
                case 3: { a = " бубен"; break; }
                case 4: { a = " червей"; break; }
            }
            switch (n)
            {
                case 6: { b = "шестерка";break; }
                case 7: { b = "семерка"; break; }
                case 8: { b = "восьмерка"; break; }
                case 9: { b = "девятка"; break; }
                case 10: { b = "десятка"; break; }
                case 11: { b = "валет"; break; }
                case 12: { b = "дама"; break; }
                case 13: { b = "король"; break; }
                case 14: { b = "туз"; break; }
            }
            return (a + b);
        }
    }
}
