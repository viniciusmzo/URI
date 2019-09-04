using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1155
{
    class Program
    {
        static void Main(string[] args)
        {
            double cont = 1.00;
            double soma = 0.00;

            for (int i = 1; i <= 100; i++)
            {
                soma += (1 / cont);
                cont++;
            }

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
