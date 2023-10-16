using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PanasenkoRA.Sprint2.Task4.V0.Lib
{
    public class DataService : ISprint2Task4V26
    {
        public double Calculate(double x, double y)
        {
            double z = (x - 2) < (y / 2) ? Math.Pow((10 + (2 / Math.Pow(x, 2))), y) : (Math.Pow(x, 2) - (1 / y));
            return Math.Round(z, 3);
        }
    }
}
