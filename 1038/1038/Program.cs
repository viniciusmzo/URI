using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int codProduto, qtdProduto;
            double total;
            string[] vet = Console.ReadLine().Split(' ');

            codProduto = int.Parse(vet[0]);
            qtdProduto = int.Parse(vet[1]);

            if (codProduto == 1)
            {
                total = qtdProduto * 4.00;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }

            if (codProduto == 2)
            {
                total = qtdProduto * 4.50;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }

            if (codProduto == 3)
            {
                total = qtdProduto * 5.00;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }

            if (codProduto == 4)
            {
                total = qtdProduto * 2.00;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }

            if (codProduto == 5)
            {
                total = qtdProduto * 1.50;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();
        }
    }
}
