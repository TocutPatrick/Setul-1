using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1E10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificam daca numarul n este prim");
            int n;
            int y = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)

                    y = y + 1;

            }

            if (y == 2)
                Console.WriteLine($"Numarul {n} este prim");
            else Console.WriteLine($"Numarul {n} nu este prim");

                    Console.ReadKey();

        }
    }
}
