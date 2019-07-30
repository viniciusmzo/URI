using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1041
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            string[] vet = Console.ReadLine().Split(' ');

            x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y = double.Parse(vet[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.00)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.00)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.00 && y > 0.00)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.00 && y > 0.00)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.00 && y < 0.00)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }


            Console.ReadKey();


        }
    }
}
