using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioFixo, comissao;

            nome = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comissao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioFixo = salarioFixo + (comissao * 0.15);
            Console.WriteLine("TOTAL = R$ " + salarioFixo.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
