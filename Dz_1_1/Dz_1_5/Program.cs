using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dz_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1;
            double number2;
            Program p = new Program();
            Console.Write("Введите 2 числа. \n1 число = ");
            string str1 = Console.ReadLine();
            Console.Write("2 число = ");
            string str2 = Console.ReadLine();

            if (!String.IsNullOrEmpty(str1) && !String.IsNullOrEmpty(str2))
            {
                foreach (var check in str1 + str2)
                {
                    if (Convert.ToString(Char.GetUnicodeCategory(check)) != "DecimalDigitNumber")
                    {
                        Console.WriteLine("Неверный формат числа!");
                        break;
                    }
                    else
                    {
                        double.TryParse(str1, out number1);
                        double.TryParse(str2, out number2);
                        if (number1 > number2)
                        {
                            Console.WriteLine("{0} больше {1}", number1, number2);
                        }
                        else
                        {
                            if (number1 < number2)
                            {
                                Console.WriteLine("{0} меньше {1}", number1, number2);
                            }
                            else
                            {
                                Console.WriteLine("Числа равны.", number1, number2);
                            }
                        }
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Не введено число!");
            }

            Console.ReadLine();
        }
    }
}
