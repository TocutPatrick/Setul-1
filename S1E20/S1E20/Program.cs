using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1E20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rezultatul fractiei");
            float a, b, c,s;
            Console.Write("a="); 
            a = float.Parse(Console.ReadLine());
            Console.Write("b=");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine(a/b);

            Console.ReadKey();
        }
    }
}
