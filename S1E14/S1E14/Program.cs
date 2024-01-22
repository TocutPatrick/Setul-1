using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1E14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inversul lui n");
            int n; int p = 0; int sum = 0; 
            
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            int h = n;

            while (n > 0)
            {
                p = n % 10;
                sum = (sum * 10) + p;
                n = n / 10;
                        
            }

            if (h == sum)
                Console.WriteLine($"Numarul {h} este palindrom");
            else
                Console.WriteLine($"Numarul {h} nu este palindrom");

            Console.ReadKey();

        }
    }
}
