using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static float number_one = 0;
        static float number_two = 0;
        static string modifier = "";
        static float result = 0;

        static void Main(string[] args)
        {
            
            start();


        }

        static void start()
        {
            Console.Write("kérem az első számot: ");
            number_one = Convert.ToInt32(Console.ReadLine());
            Console.Write("kérem a második számot: ");
            number_two = Convert.ToInt32(Console.ReadLine());
            Console.Write("kérem a művelet jelét: ");
            modifier = Console.ReadLine();

            if (modifier == "+")
            {
                addition();

            }
            else if (modifier == "-")
            {
                subtraction();
            }
            else if (modifier == "*")
            {
                multipication();
            }
            else if (modifier == "/")
            {
                divison();
            }
            else if (modifier == "%")
            {
                modular();
            }
            Console.WriteLine(result);
        }

        static void addition()
        {
            result = number_one + number_two;


        }

        

    }
}
}
