using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1075
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10000; i++)
            {
                if (i % n == 2)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
