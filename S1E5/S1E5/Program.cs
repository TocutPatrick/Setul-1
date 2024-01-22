using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1E5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vom afisa a k-a cifra de la sfarsitul numarului");

            int numar, k, m, y;

            y = 0;
            

            Console.Write("Numarul=");
            numar = int.Parse(Console.ReadLine());

            m = numar;

            Console.Write("k=");
            k = int.Parse(Console.ReadLine());

            for (int i = 0; i < k; i++)
            {
                y = m % 10; 
                m = m / 10;

            }

            Console.WriteLine($"A {k}-a cifra a numarului {numar} este {y}");

            Console.ReadLine();


        }
    }
}
