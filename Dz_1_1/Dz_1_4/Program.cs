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

        static void Cout(string labNomber, string group, string name)
        {
            int count = 0;

            if (labNomber.Length > name.Length)
            {
                if (labNomber.Length > group.Length)
                { count = labNomber.Length; }
                else
                { count = group.Length; }
            }
            else
            {
                if (name.Length > group.Length)
                { count = name.Length; }
                else
                { count = group.Length; }
            }
            Star();
            Console.Write("\n* {0}", labNomber);
            Space(labNomber.Length);
            Console.Write("*\n* {0}", group);
            Space(group.Length);
            Console.Write("*\n* {0}", name);
            Space(name.Length);
            Console.WriteLine("*");
            Star();



            void Star()
            {
                for (int i = 0; i < count + 3; i++)
                { Console.Write("*"); }
            }
            void Space(int n)
            {
                for (int i = 0; i < count - n; i++)
                { Console.Write(" "); }
            }
        }
    }
}
