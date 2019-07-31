using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, res;
            
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    res = (int)Math.Pow(i, 2);
                    Console.WriteLine(i.ToString() + "^2 = " + res.ToString());
                }
            }

            Console.ReadKey();
        }
    }
}
