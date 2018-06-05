using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_1_1
{
    class Program
    {             
        static void Nomber(int nomber)
        {
            char[] arrayNomber = nomber.ToString().ToCharArray();
            for (int i = 0; i < arrayNomber.Length; i++)
            { Console.WriteLine(arrayNomber[i]); }
        }

        static void Main(string[] args)
        {           
            Nomber(12345);
            Console.ReadLine();
        } 
    }
}
