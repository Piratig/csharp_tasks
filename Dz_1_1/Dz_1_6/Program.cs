using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Condition(5, 3, 5);
            Console.ReadLine();
        }

        static void Condition(int a, int b, int c)
        {
            if (a == c || a == b || b == c)
            {
                a += 5;
                b += 5;
                c += 5;
                Console.WriteLine("a = {0}, b =  {1}, c =  {2}", a, b, c);
            }
            else
            { Console.WriteLine("Равных нет."); }
        }
    }
}
