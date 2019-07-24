using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor >= 0.00 && valor <= 25.00)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            if (valor > 25.00 && valor <= 50.00)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            if (valor > 50.00 && valor <= 75.00)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            if (valor > 75.00 && valor <= 100.00)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            if(valor < 0.00 || valor > 100.00) { Console.WriteLine("Fora de intervalo"); }

            Console.ReadKey();
        }
    }
}
