using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitsNet;

namespace Dz_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число в метрах = ");
            string str = Console.ReadLine();
            Double.TryParse(str, out double length);
            Length meter = Length.FromMeters(length);
            double kilometers = meter.Kilometers;
            Console.WriteLine("В километрах = {0}км.", kilometers);
            Console.ReadLine();
        }
    }
}
