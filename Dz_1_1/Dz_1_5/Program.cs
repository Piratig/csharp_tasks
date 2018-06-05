using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double nomber1 = 0;
            double nomber2 = 0;
            Console.Write("Введите 2 часла. \n1 число = ");
            try
            {
                nomber1 = double.Parse(Console.ReadLine());
                Console.Write("2 число = ");
                nomber2 = double.Parse(Console.ReadLine());
            }
            catch
            { Console.WriteLine(""); }

            if (nomber1 > nomber2)
            { Console.WriteLine("{0} больше {1}", nomber1, nomber2 ); }
            else
            {
                if (nomber1 < nomber2)
                { Console.WriteLine("{0} меньше {1}", nomber1, nomber2); }
                else
                { Console.WriteLine("Числа равны.", nomber1, nomber2); }
            }
            Console.ReadLine();
        }
    }
}
