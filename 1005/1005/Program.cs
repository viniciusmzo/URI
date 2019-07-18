using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (((nota1 * 3.5) + (nota2 * 7.5)) /11);
            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
            Console.ReadKey();

        }
    }
}
