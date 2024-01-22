using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1E11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inversul lui n");
            int n; int p = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            while  ( n > 0 )
            {
                p = n%10;
                n = n/10;
                Console.Write(p);
            }

            Console.ReadKey();
        }
    }
}
