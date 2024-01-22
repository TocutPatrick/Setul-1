using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1E16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se vor afisa 5 numere in ordine crescatoare");
            int n1, n2, n3, n4, n5;

            Console.Write("n1=");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("n2=");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("n3=");
            n3 = int.Parse(Console.ReadLine());

            Console.Write("n4=");
            n4 = int.Parse(Console.ReadLine());

            Console.Write("n5=");
            n5 = int.Parse(Console.ReadLine());

            int h = 0;

            if(n1 > n2)
            {
                h = n2;
                n2 = n1;
                n1 = h;
            }

            if (n2 > n3)
            {
                h = n3;
                n3 = n2;
                n2 = h;
            }

            if (n3 > n4)
            {
                h = n4;
                n4 = n3;
                n3 = h;
            }

            if (n4 > n5)
            {
                h = n5;
                n5 = n4;
                n4 = h;
            }

            if (n1 > n2)
            {
                h = n2;
                n2 = n1;
                n1 = h;
            }

            if (n2 > n3)
            {
                h = n3;
                n3 = n2;
                n2 = h;
            }

            if (n3 > n4)
            {
                h = n4;
                n4 = n3;
                n3 = h;
            }

            if (n1 > n2)
            {
                h = n2;
                n2 = n1;
                n1 = h;
            }

            if (n2 > n3)
            {
                h = n3;
                n3 = n2;
                n2 = h;
            }

            if (n1 > n2)
            {
                h = n2;
                n2 = n1;
                n1 = h;
            }




            Console.WriteLine($"{n1}, {n2}, {n3}, {n4}, {n5}" );

            Console.ReadKey();

        }

        

         



        
    }
}

