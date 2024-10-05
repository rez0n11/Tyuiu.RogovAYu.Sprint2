using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.RogovAYu.Sprint2.Task4.V27.Lib
{
    public class DataService : ISprint2Task4V27
    {
        public double Calculate(double x, double y)
        {
            return x-10>y+2?Math.Round((x*Math.Pow((y+2)/(x-1),x)),3):y*y-2/x;
        }
    }
}
