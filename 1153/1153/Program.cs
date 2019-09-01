using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1153
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, fatorial;

            n = int.Parse(Console.ReadLine());
            fatorial = n;
            for (int i = 1; i < n; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine(fatorial);

            Console.ReadKey();
        }
    }
}
