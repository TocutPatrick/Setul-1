using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1E13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y1, y2;
            int n = 0;

            Console.Write("y1=");
            y1 = int.Parse(Console.ReadLine());

            Console.Write("y2=");
            y2 = int.Parse(Console.ReadLine());

            int p = y1;

            while ( y1 <= y2 )
            {
                if ((y1%4 == 0) && (y1%100 != 0) || (y1%400 == 0))
                {
                    n++;
                    y1++;
                }
                else y1++;
               
            }
            Console.WriteLine($"Intre {p} si {y2} sunt {n} an bisecti");
            Console.ReadKey();
        }
    }
}
