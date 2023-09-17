using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERC_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número 1: ");
            int factor1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el número 2: ");
            int factor2 = int.Parse(Console.ReadLine());
            int resultado = 0;
            for (int i = 0; i < factor1; i++)
            {
                resultado = resultado + factor2;
            }
            Console.WriteLine("El producto es: " + resultado + ".");
            Console.ReadKey();
        }
    }
}