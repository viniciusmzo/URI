using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio, final, tempo;
            string[] vet = Console.ReadLine().Split(' ');

            inicio = int.Parse(vet[0]);
            final = int.Parse(vet[1]);

            if (final <= inicio) { final += 24; }
            Console.WriteLine("O JOGO DUROU " + (final - inicio) +" HORA(S)");
            Console.ReadKey();
        }
    }
}
