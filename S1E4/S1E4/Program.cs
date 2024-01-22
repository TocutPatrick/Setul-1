using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1E4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vom determina daca un an este sau nu an bisect");

            int year;

            Console.Write("Scrieti anul: ");
            year = int.Parse(Console.ReadLine());

            if ( year%400 == 0 )
            {
                Console.WriteLine($"{year} este an bisect");
            }
            else { Console.WriteLine($"{year} nu e an bisect"); }

            Console.ReadKey();
        }
    }
}
