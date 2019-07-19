using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int km;
            double litros;

            km = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            litros = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double autonomia = km / litros;

            Console.WriteLine(autonomia.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
            Console.ReadKey();
        }
    }
}
