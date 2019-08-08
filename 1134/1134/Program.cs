using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc, a = 0, g = 0, d = 0;

            opc = int.Parse(Console.ReadLine());

            do
            {
                if (opc == 4) break;
                else if (opc == 1) { a++; }
                else if (opc == 2) { g++; }
                else if (opc == 3) { d++; }

                opc = int.Parse(Console.ReadLine());
            } while (opc != null);

                Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + a);
            Console.WriteLine("Gasolina: " + g);
            Console.WriteLine("Diesel: " + d);

            Console.ReadKey();
        }
    }
}
