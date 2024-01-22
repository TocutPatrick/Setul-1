using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1E3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificam daca numarul n se divide cu k");

            int n, k;

            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());

            Console.Write("k= ");
            k = int.Parse(Console.ReadLine());

            if (n % k == 0)
            {
                Console.WriteLine("n de divide cu k");
            }
            else Console.WriteLine("n nu se divide cu k");

            Console.ReadKey();

        }
    }
}
