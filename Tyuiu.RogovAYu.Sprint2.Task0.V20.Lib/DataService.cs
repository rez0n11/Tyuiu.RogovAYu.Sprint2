using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.RogovAYu.Sprint2.Task0.V20.Lib
{
    public class DataService 
    {
        public object[] GetCompareOperations(int x, int y)
        {
            return [x == y, x != y, x < y, x > y, x <= y, x >= y];
        }
    }
}
