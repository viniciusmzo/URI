using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1146
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            while (true)
            {
                num = int.Parse(Console.ReadLine());

                if (num == 0) break;
                else if (num > 0)
                {
                    Console.Write("1");
                    for (int i = 2; i <= num; i++)
                    {
                        Console.Write(" " + i);
                    }
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
