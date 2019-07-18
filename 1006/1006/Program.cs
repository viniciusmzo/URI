using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, media;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (((nota1 * 2.0) + (nota2 * 3.0) + (nota3 * 5.0)) / 10);
            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
            Console.ReadKey();


        }
    }
}
