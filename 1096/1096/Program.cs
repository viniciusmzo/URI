using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1096
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] resI = new int[5] { 1, 3, 5, 7, 9};

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("I=" + resI[i] + " J=" + 7);
                Console.WriteLine("I=" + resI[i] + " J=" + 6);
                Console.WriteLine("I=" + resI[i] + " J=" + 5);
            }

            Console.ReadKey();
        }
    }
}
