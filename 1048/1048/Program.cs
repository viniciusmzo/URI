using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, reajuste, percentual;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            reajuste = salario;

            if (salario <= 400.00)
            {
                percentual = 0.15;
                salario += (salario * percentual);
                reajuste = salario - reajuste;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + (percentual * 100) + " %");
            }
            else if (salario <= 800.00)
            {
                percentual = 0.12;
                salario += (salario * percentual);
                reajuste = salario - reajuste;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + (percentual * 100) + " %");
            }
            else if (salario <= 1200.00)
            {
                percentual = 0.10;
                salario += (salario * percentual);
                reajuste = salario - reajuste;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + (percentual * 100) + " %");
            }
            else if (salario <= 2000.00)
            {
                percentual = 0.07;
                salario += (salario * percentual);
                reajuste = salario - reajuste;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + (percentual * 100) + " %");
            }
            else if (salario > 2000.00 )
            {
                percentual = 0.04;
                salario += (salario * percentual);
                reajuste = salario - reajuste;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + (percentual * 100) + " %");
            }

            Console.ReadKey();
        }
    }
}
