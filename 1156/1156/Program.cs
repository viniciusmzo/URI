using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1156
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b = 1, c, s = 0;

            for (a = 1; a <= 39; a += 2)
            {
                c = a / b;
                s += c;
                b *= 2;
            }


            Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
