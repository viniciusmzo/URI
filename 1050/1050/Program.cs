using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1050
{
    class Program
    {
        static void Main(string[] args)
        {
            int ddd;

            ddd = int.Parse(Console.ReadLine());

            switch (ddd)
            {
                case 11:
                    Console.WriteLine("Sao Paulo");
                    break;
                case 19:
                    Console.WriteLine("Campinas");
                    break;
                case 21:
                    Console.WriteLine("Rio de Janeiro");
                    break;
                case 27:
                    Console.WriteLine("Vitoria");
                    break;
                case 31:
                    Console.WriteLine("Belo Horizonte");
                    break;
                case 32:
                    Console.WriteLine("Juiz de Fora");
                    break;
                case 61:
                    Console.WriteLine("Brasilia");
                    break;
                case 71:
                    Console.WriteLine("Salvador");
                    break;
                default:
                    Console.WriteLine("DDD nao cadastrado");
                    break;
            }

            Console.ReadKey();
        }
    }
}
