using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1113
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            List<string> resultado = new List<string>();

            do {
                
                string[] vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

                if (x < y)
                {
                   resultado.Add("Crescente");
                }
                else if (x > y)
                {
                    resultado.Add("Decrescente");
                }

            } while (x != y);

            foreach (string res in resultado)
            {
                Console.WriteLine(res);
            }
            Console.ReadKey();
        }
    }
}
