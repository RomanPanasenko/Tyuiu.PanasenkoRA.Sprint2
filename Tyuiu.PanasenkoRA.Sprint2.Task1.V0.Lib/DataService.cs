using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
// (True, False, True, False, True, False), при a = 325, b = 325, c = 242, d = 324, |, &, ||, &&, !, ^
namespace Tyuiu.PanasenkoRA.Sprint2.Task1.V0.Lib
{
    public class DataService : ISprint2Task1V24
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a == b) | (a < c);
            res[1] = (c > d) & (b >= c);
            res[2] = (a <= d) || (b >= a);
            res[3] = (a != b) && (c < d);
            res[4] = !(!res[0]);
            res[5] = (a == b) ^ (a > d);
            return res;
        }
    }
}
