using System;
using System.Globalization;

namespace _1178
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numero;
            decimal[] resultado = new decimal[100];

            numero = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            resultado[0] = numero;

            for (int i = 1; i <= 99; i++) 
            {
                resultado[i] = resultado[(i - 1)] / 2;
            }

            Console.WriteLine("N[0] = " + resultado[0].ToString("F4", CultureInfo.InvariantCulture));
            for (int i = 1; i <= 99; i++) 
            {
                Console.WriteLine("N["+ i +"] = " + decimal.Round(resultado[i], 4, MidpointRounding.ToEven).ToString("F4", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();
        }
    }
}
