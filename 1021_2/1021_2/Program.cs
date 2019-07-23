using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1021_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var cedulasMoedas = new[] { 100, 50, 20, 10, 5, 2, 1, 0.50, 0.25, 0.10, 0.05, 0.01 };
            cedulasMoedas.ToList().ForEach(x =>
            {
                valor = Math.Round(valor, 2);
                var quantidade = Math.Truncate(valor / x);
                valor -= (quantidade * x);
                if (x == 100)
                    Console.WriteLine("NOTAS:");
                else if (x == 1)
                    Console.WriteLine("MOEDAS:");

                Console.WriteLine($"{quantidade} {(x > 1 ? "nota(s)" : "moeda(s)")} de R$ {x:N2}");
            });
        }
    }
}
