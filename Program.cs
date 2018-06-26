using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_1_1
{
    class Program
    {             
        static void Main(string[] args)
        {
            int number = 12345;
            for (int i = 10000; i >= 1; i /= 10)
            {
                int outputNumber = number / i;
                number -= outputNumber * i;
                Console.WriteLine(outputNumber);
            }
            Console.ReadLine();
        } 
    }
}
