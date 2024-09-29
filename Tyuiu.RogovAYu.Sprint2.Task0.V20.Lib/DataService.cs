using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.RogovAYu.Sprint2.Task0.V20.Lib
{
    public class DataService : ISprint2Task0V20
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            object [] array = new object[1];
            array = [x == y, x != y, x<y, x> y, x <= y, x >= y];
            return [false,true,false,true,false,true];
        }
    }
}
