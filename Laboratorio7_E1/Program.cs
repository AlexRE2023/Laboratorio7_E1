using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7_E1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor de n: ");
            int n = int.Parse(Console.ReadLine());
            double i = 1;

            while (i <= n)
            {
                double resultado = (16 - i) / (3 * i); i++;
                Console.WriteLine("Resultado: " + resultado);
              
            }
            Console.ReadKey();
        }
    }
}
