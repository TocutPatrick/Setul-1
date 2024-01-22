using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1E9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se vor afisa toti divizorii numarului n");

            int n;

            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write("Divizorii lui n sunt:");

            for (int i = 1; i <= n; i++) 
            {
                if (n % i == 0)
              
                    Console.Write($"{i} ");
               
            }

            Console.ReadKey();
        }
    }
}
