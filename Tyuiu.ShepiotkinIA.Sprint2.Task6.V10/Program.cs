using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShepiotkinIA.Sprint2.Task6.V10.Lib;

namespace Tyuiu.ShepiotkinIA.Sprint2.Task6.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string res;
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine("Введите день: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите год: ");
            int g = Convert.ToInt32(Console.ReadLine());

            if (((m < 1) || (m > 12)) || ((n < 1) || (n > 31)) || ((g < 1)))
            {
                res = "Введены не верные значени";

            }
            else
            {
                res = "Предыдущая дата:" + ds.FindDateOfPreviousDay(g, m, n);
            }

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
