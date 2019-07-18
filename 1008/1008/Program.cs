using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFuncionario, horasTrabalhadas;
            double valorHora;

            
            numFuncionario = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            horasTrabalhadas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
          
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            valorHora = valorHora * horasTrabalhadas;

            Console.WriteLine("NUMBER = " + numFuncionario);
            Console.WriteLine("SALARY = U$ " + valorHora.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();

        }
    }
}
