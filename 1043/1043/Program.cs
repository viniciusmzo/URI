using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double area, perimetro;
            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);


            //| b - c | < a < b + c
            //| a - c | < b < a + c
            //| a - b | < c < a + b

            if (a < b + c && b < a + c && c < a + b)
            {
                perimetro = a + b + c;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                area = ((a + b) * c) / 2.00;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();

        }
    }
}
