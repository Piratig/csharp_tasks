using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cout("Лабораторная работа #1 ", "Выполнил: ст. гр. ЗИ-123 ", "Харьковский Игорь Сергеевич ");
            Console.ReadLine();
        }

        static void Cout(string labNumber, string group, string name)
        {
            int count = (labNumber.Length > name.Length) ? (labNumber.Length > group.Length) ? labNumber.Length : group.Length : (name.Length > group.Length) ? name.Length : group.Length;
            
            Star(count);
            Console.Write("\n* {0}", labNumber, count);
            Space(labNumber.Length, count);
            Console.Write("*\n* {0}", group);
            Space(group.Length, count);
            Console.Write("*\n* {0}", name);
            Space(name.Length, count);
            Console.WriteLine("*");
            Star(count);
        }



        static void Star(int count)
        {
            for (int i = 0; i < count + 3; i++)
            { Console.Write("*"); }
        }

        static void Space(int n, int count)
        {
            for (int i = 0; i < count - n; i++)
            { Console.Write(" "); }
        }

    }
}