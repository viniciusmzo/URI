using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo, kmMedia;
            double consumo;

            tempo = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            kmMedia = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumo = (tempo * kmMedia) / 12.0;

            Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
