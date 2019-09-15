using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1173
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            int x;

            x = int.Parse(Console.ReadLine());

            n[0] = x;

            Console.WriteLine("N[0] = " + n[0]);
            for (int i = 1; i < 10; i++)
            {
                n[i] = (n[i - 1] * 2);
                Console.WriteLine("N["+ i +"] = " + n[i]);
            }

            Console.ReadKey();
        }
    }
}
