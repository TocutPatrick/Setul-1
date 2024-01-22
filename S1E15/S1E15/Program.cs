using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1E15
{
    internal class Program
    {
        static void Main(string[] args)
        { int n1, n2, n3;

            Console.WriteLine("Afisati 3 numere in ordine crescatoare");

            Console.Write("n1=");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("n2=");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("n3=");
            n3 = int.Parse(Console.ReadLine());

            int min = n1;
            int max = n3;

            if (n1 > n2)
            {
                min = n2;
                if (n3 < n2)
                {
                    min = n3;
                }
            }
            else
            {
                if (n1 > n3)
                {
                    min = n3;
                }
            }

            if (n3 < n2)
            {
                max = n2;
                if (n2 < n1)
                {
                    max = n1;
                }
            }
            else
            {
                if (n1 > n3)
                {
                    max = n1;
                }
            }

            Console.WriteLine($"{min}, {n1 + n2 + n3 - min - max}, {max}");
            Console.ReadKey();

        }
    }
}
