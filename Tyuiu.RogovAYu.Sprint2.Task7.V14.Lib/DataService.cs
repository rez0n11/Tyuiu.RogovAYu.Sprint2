﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.RogovAYu.Sprint2.Task7.V14.Lib
{
    public class DataService : ISprint2Task7V14
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            
            if (x*x+y*y<=1 && (x>0 ||y>=x ) ) { return true; }
            else { return false; }
        }
    }
}
