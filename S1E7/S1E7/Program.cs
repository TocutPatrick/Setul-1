using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1E7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vom inversa valorile lui a si b");

            int a, b, x;

            x = 0;

            Console.Write("a=");
            a = int.Parse(Console.ReadLine());

            Console.Write("b=");
            b = int.Parse(Console.ReadLine());

            x = a;
            a = b;
            b = x;

            Console.WriteLine($"a egal cu {a} si b egal cu {b}");

            Console.ReadKey();

        }
    }
}
