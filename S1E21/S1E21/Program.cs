using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace S1E21
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 0; int min = 1; int max = 1024;  int p;  string response;
          
            while(max - min > 1)
            {
                p = (min + max) / 2;

                Console.WriteLine($"Numarul este mai mare sau egal ca si {p}?");
                response = Console.ReadLine();

                if(response == "da")
                {
                    min = p;
                }
                else
                {
                    max = p-1;
                }

                n = p;

            }
                
                Console.WriteLine($"Numarul tau este {n}");
                

            Console.ReadKey();
        }
    }
}
