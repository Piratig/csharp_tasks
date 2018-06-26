using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число в метрах = ");
            double.TryParse(Console.ReadLine(), out double kilometr);
            double meter = kilometr / 1000;
            Console.WriteLine("В километрах = {0}.", meter);
            Console.ReadLine();
        }
    }
}
