using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShepiotkinIA.Sprint2.Task5.V7.Lib;

namespace Tyuiu.ShepiotkinIA.Sprint2.Task5.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер месяца: ");
            int n = Convert.ToInt32(Console.ReadLine());

            String res;

            if ((n < 1) || (n > 12))
            {
                res = "Введенно неверное значение!";
            }
            else
            {
                res = "Это месяц: " + ds.FindMonthName(1999, n);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();

        }
    }
}
