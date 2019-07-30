using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1042
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vet = Console.ReadLine().Split(' ');
            List<int> listaOrdenada = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                listaOrdenada.Add(int.Parse(vet[i]));
            }

            listaOrdenada.Sort();
            foreach (int num in listaOrdenada)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(vet[i]);
            }

                Console.ReadKey();

        }
    }
}
