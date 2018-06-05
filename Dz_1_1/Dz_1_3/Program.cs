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
            double meter = int.Parse(Console.ReadLine());
            meter /= 1000;
            Console.WriteLine("В киллометрах = {0}.", meter);
            Console.ReadLine();
        }
    }
}
