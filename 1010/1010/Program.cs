using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int codPeca, numPecas;
            double valorPeca, total;

            string[] vet = Console.ReadLine().Split(' ');

            codPeca = int.Parse(vet[0], CultureInfo.InvariantCulture);
            numPecas = int.Parse(vet[1], CultureInfo.InstalledUICulture);
            valorPeca = double.Parse(vet[2], CultureInfo.InvariantCulture);
            total = 0;
            total = numPecas * valorPeca;

            string[] vet2 = Console.ReadLine().Split(' ');

            codPeca = int.Parse(vet2[0], CultureInfo.InvariantCulture);
            numPecas = int.Parse(vet2[1], CultureInfo.InstalledUICulture);
            valorPeca = double.Parse(vet2[2], CultureInfo.InvariantCulture);
            total = total + (numPecas * valorPeca);


            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
