using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PanasenkoRA.Sprint2.Task7.V0.Lib
{
    public class DataService : ISprint2Task7V6
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((((Math.Pow(x, 2) + Math.Pow(y, 2)) >= 1) && ((Math.Pow(x, 2) + Math.Pow(y, 2)) <= 2)) && ((((x >= 1) && (x <= 2)) || ((x <= -1) && (x >= -2))) && ((y >= 0) && (y <= 2))))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
