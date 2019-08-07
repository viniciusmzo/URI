using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1098
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] resI = new double[11];
            int[] resJ = new int[11];
            double num = 0;
            double x = 1, y = 2, z = 3;

            for (int i = 0; i < 11; i++)
            {
                resI[i] = num;
                num += 0.2;
                Console.WriteLine("I=" + resI[i].ToString( CultureInfo.InvariantCulture) + " J=" + x.ToString( CultureInfo.InvariantCulture));
                Console.WriteLine("I=" + resI[i].ToString( CultureInfo.InvariantCulture) + " J=" + y.ToString( CultureInfo.InvariantCulture));
                Console.WriteLine("I=" + resI[i].ToString( CultureInfo.InvariantCulture) + " J=" + z.ToString( CultureInfo.InvariantCulture));
                x += 0.2;
                y += 0.2;
                z += 0.2;
            }

            Console.ReadKey();
        }
    }
}
