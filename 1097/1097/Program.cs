using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1097
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] resI = new int[5] { 1, 3, 5, 7, 9 };
            int[] resJ = new int[5] { 7, 9, 11, 13, 15 };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("I=" + resI[i] + " J=" + resJ[i]);
                Console.WriteLine("I=" + resI[i] + " J=" + (resJ[i] - 1));
                Console.WriteLine("I=" + resI[i] + " J=" + (resJ[i] - 2));
            }

            Console.ReadKey();
        }
    }
}
