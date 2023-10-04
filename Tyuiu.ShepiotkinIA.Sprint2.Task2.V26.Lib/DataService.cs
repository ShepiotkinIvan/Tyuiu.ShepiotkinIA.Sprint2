using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShepiotkinIA.Sprint2.Task2.V26.Lib
{
    public class DataService : ISprint2Task2V26
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;

            if ((x >= 3) && (x <= 5) && (y >= 3) && (y <= 7))
            {
                res = true;
            }
            

            if ((x >= 6) && (x <= 8) && (y >= 5) && (y <= 11))
            {
                res = true;
            }
            

            if ((x >= 9) && (x <= 13) && (y >= 6) && (y <= 8))
            {
                res = true;
            }
            

            if ((x >= 9) && (x <= 10) && (y >= 3) && (y <= 5))
            {
                res = true;
            }


            if ((x >= 9) && (x <= 10) && (y >= 11) && (y <= 13))
            {
                res = true;
            }


            if ((x >= 11) && (x <= 12) && (y >= 11) && (y <= 12))
            {
                res = true;
            }


            if ((x >= 7) && (x <= 8) && (y == 12))
            {
                res = true;
            }


            if ((x >= 3) && (x <= 5) && (y == 11))
            {
                res = true;
            }


            if ((x == 9) && (y >= 9) && (y <= 10))
            {
                res = true;
            }


            if ((x >= 11) && (x <= 12) && (y == 3))
            {
                res = true;
            }


            return res;
        }
    }
}
