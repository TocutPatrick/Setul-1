using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1E18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Descompunerea in factori primi al numarului n");
            int n; int x = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)       
            {
                
                x = 0;
                while( n % i == 0)
                {
                   
                        n = n / i;
                        x++;

                }

                if ( x != 0 )
                    Console.Write($"{i}^{x}x");

            }

            Console.ReadKey();
        }
    }
}
