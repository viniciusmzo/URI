using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1144
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i + " " + Math.Pow(i, 2) + " " + Math.Pow(i, 3));
                Console.WriteLine(i + " " + (Math.Pow(i, 2) + 1) + " " + (Math.Pow(i, 3) + 1));
                
            }

            Console.ReadKey();
        }
    }
}
