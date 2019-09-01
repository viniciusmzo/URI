using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1180
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, menor, aux = 0;
            string[] dados;
            int[] vet;


            n = int.Parse(Console.ReadLine());
            vet = new int[n];
            dados = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                vet[i] = int.Parse(dados[i]);
            }

            menor = vet[0];

            for (int i = 0; i < n; i++)
            {
                if (menor >= vet[i])
                {
                    menor = vet[i];
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (menor == vet[i])
                {
                    aux = i;
                    break;
                }
                
            }

            Console.WriteLine("Menor valor: " + menor);
            Console.WriteLine("Posicao: " + aux);


            Console.ReadKey();
            
        }
    }
}
