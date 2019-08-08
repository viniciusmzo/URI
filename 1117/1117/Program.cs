using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1117
{
    class Program
    {
        static void Main(string[] args)
        {
            int notavalida = 0;
            double nota, media = 0.0;

            while (notavalida < 2)
            {
                nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (nota >= 0.0 && nota <= 10.0)
                {
                    media += nota;
                    notavalida++;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            }
            Console.WriteLine("media = " + (media /2).ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();

        }
    }
}
