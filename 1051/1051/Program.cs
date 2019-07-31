using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, imposto, aux, aux2, aux3;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (salario <= 3000.00)
            {
                aux = salario - 2000.00;
                aux = (aux * 0.08);
                imposto = aux;
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario <= 4500.00)
            {
                aux = salario - 2000.00;
                aux2 = aux - 1000.00;
                aux = aux - aux2;
                aux = (aux * 8) / 100;
                aux2 = (aux2 * 18) / 100;
                imposto = aux + aux2;
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario > 4500.00)
            {
                aux = salario - 2000.00;    
                aux2 = aux - 1000.00;   
                aux = aux - aux2;      
                aux3 = salario - 4500.00;
                aux2 = aux2 - aux3;
                imposto = aux * 0.08 + aux2 * 0.18 + aux3 * 0.28;
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();
        }
    }
}
