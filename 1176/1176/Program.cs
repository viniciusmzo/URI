using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1176
{
    class Program
    {
        static void Main(string[] args)
        {

            UInt64 n, aux;
            UInt64[] soma;
            
            soma = new UInt64[61];

            for (UInt64 i = 0; i <= 60; i++)
            {
                if (i == 0)
                {
                    soma[i] = 0;
                }
                else if (i == 1)
                {
                    soma[i] = 1;
                }
                else if (i > 1)
                {
                    soma[i] = soma[(i - 2)] + soma[(i - 1)];
                }

            }


            n = UInt64.Parse(Console.ReadLine());
        
            for (UInt64 i = 0; i < n; i++)
            {
                aux = UInt64.Parse(Console.ReadLine());
                Console.WriteLine("Fib(" + aux + ") = " + soma[aux]);
            }
                Console.ReadKey();


        }
    }
}
