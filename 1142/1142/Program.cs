using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            num = int.Parse(Console.ReadLine());
            num *= 4;

            for (int i = 1; i <= num; i++)
            {
                if (i % 4 != 0)
                {
                    Console.Write(i + " ");
                }
                else if (i % 4 == 0)
                {
                    Console.WriteLine("PUM");
                }
            }
            Console.ReadKey();
        }
    }
}
