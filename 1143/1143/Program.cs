using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1143
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i + " " + (Math.Pow(i, 2)) + " " + (Math.Pow(i, 3)));
            }

            Console.ReadKey();
        }
    }
}
