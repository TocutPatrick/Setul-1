using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1E2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a,b,c,delta,x1, x2;


            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b  = int.Parse(Console.ReadLine());
            Console.Write("c=");
            c = int.Parse(Console.ReadLine());

            delta = b * b - 4 * a * c;
            x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            x2 = (-b + Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"X1 este egal cu {x1}");
            Console.WriteLine($"X2 este egal cu {x2}");

            Console.ReadKey();



        }
    }
}
