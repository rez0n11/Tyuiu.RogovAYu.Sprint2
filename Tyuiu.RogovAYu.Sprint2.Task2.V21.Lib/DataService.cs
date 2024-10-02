using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.RogovAYu.Sprint2.Task2.V21.Lib
{
    public class DataService : ISprint2Task2V21
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((x == 3 && y >= 3 && y <= 7) || (x >= 4 && x <= 6 && y >= 6 && y <= 9) ||
                (x >= 6 && x <= 9 && y >= 5 && y <= 7) || (x >= 10 && x <= 12 && y >= 3 && y <= 11) ||
                (x >=9  && x <=10  && y >=11  && y <=12 ) || (x ==9 && (y ==3 ||y == 4)) || (x == 13 && (y == 6 || y == 7||y==8)))
            {  return true; }
            else { return false; }
        }
    }
}
