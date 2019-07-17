using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, raio, area;
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            n = 3.14159;
            area = Math.Pow(raio, 2) * n;


            Console.Write("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
