using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1118
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 1, notavalida = 0;
            double nota, media = 0.0;

            while (opc == 1)
            {
                if (opc == 2) break;
                else
                {
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
                    Console.WriteLine("media = " + (media / 2).ToString("F2", CultureInfo.InvariantCulture));
                    media = 0.0;
                    notavalida = 0;
                }
                
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                opc = int.Parse(Console.ReadLine());
                while (opc != 1 && opc != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    opc = int.Parse(Console.ReadLine());
                }

            }

            Console.ReadKey();


        }
    }
}
