using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

//ЗАДАНИЕ
//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один раз в выражении)
//и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться),
//а также арифметических выражений, которая вернет логическую последовательность(массив):
//(True, False, True, True, True, False), при a = 135, b = 123, c = 455, d = 321

namespace Tyuiu.ShepiotkinIA.Sprint2.Task1.V17.Lib
{
    public class DataService : ISprint2Task1V17
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a - 13 > b) | (c - 135 < d);
            res[1] = (a - 13 > b) & (c - 135 < d);
            res[2] = (a - 13 > b) || (c - 135 < d);
            res[3] = (a > b) && (c - 135 < d);
            res[4] = !(!res[0]);
            res[5] = (a - 13 > b) ^ (c < d);

            return res;
        }
    }
}
