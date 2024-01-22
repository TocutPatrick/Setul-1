using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1E12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cate numere intregi divizibile cu n se afla in intervalul [a,b]");
            
            int a, b, n;
            int p = 0;

            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            while (a <= b)
            {
                if (a%n == 0)
                {
                    p ++;
                }

                a++;
            }

            Console.WriteLine($"{p} numere care se divid cu {n}");
            Console.ReadKey();

        }
    }
}
