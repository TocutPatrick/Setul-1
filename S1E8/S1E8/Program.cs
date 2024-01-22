using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1E8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schimbarea de valori fara a treia variabila");

            int x, y;

            Console.Write("x=");
            x = int.Parse(Console.ReadLine());

            Console.Write("y=");
            y = int.Parse(Console.ReadLine());

            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine($"x este egal cu {x} si y este egal cu {y}");

            Console.ReadKey();
        }
    }
}
