using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1E19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vom determina daca numarul este format doar din doua cifre distincte");
            int n; int p = 0; int e = 0; int k = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                p = n;

                while( p / 10 != 0)
                {
                    p = p / 10;

                    if( n%10 == p%10)
                    {
                        e++;
                        break;
                    }
                }
                k++;
                n = n / 10;

            }

            if (k - e == 2)
                Console.WriteLine("Numarul este format din doar 2 cifre distincte");
            else
                Console.WriteLine("Numarul nu este format din doar doua cifre distincte");
            
            
            
            
            
            
            
            
            Console.ReadKey();
        }
    }
}
