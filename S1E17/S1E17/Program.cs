using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1E17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cel mai mare divizor comun si cel mai mic multiplu comun");

            int a, b; int d = 0;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());

            Console.Write("b=");
            b = int.Parse(Console.ReadLine());

            int x = a; int y = b;

            while (x != y)
            {
                if (x < y)
                    y = y - x;
                else
                    x = x - y;

                d = x;
            }

            int m = a * b / d;



            Console.WriteLine($"Cel mai mare divizor comun este {d}");
            Console.WriteLine($"Cel mai mic multiplu comun este {m}");
            Console.ReadKey();
        }
    }
}
