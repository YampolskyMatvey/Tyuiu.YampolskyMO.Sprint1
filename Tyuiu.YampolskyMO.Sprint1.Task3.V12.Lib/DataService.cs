using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.YampolskyMO.Sprint1.Task3.V12.Lib
{
    public class DataService : ISprint1Task3V12
    {
        public double TriangleArea(double x, double y)
        {
            return Math.Round((x * y) / 2.0, 3);
        }
    }
}