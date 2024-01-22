using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1E6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determinam daca 3 laturi pot forma un triunghi");
            

            int l1, l2, l3;

            Console.Write("Latura 1=");
            l1 = int.Parse(Console.ReadLine());

            Console.Write("Latura 2=");
            l2 = int.Parse(Console.ReadLine());

            Console.Write("Latura 3=");
            l3 = int.Parse(Console.ReadLine());

            if (l1 > 0 && l2 > 0 && l3 > 0 && l1 + l2 > l3 && l1 + l3 > l2 && l2 + l3 > l1)
            {
                Console.WriteLine("Laturile pot forma un triunghi");
            }
            else Console.WriteLine("Laturile nu pot forma un triunghi");

            Console.ReadKey();
        }
    }
}
