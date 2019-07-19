using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int km, tempo;

            km = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            tempo = km * 2;

            Console.WriteLine(tempo.ToString("F0", CultureInfo.InvariantCulture) + " minutos");
            Console.ReadKey();

        }
    }
}
