using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_aritmeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroSoma = 20 + 20;
            int numeroSubtracao = 80 - 400;
            int numeroMultiplicacao = 10 * 90;
            int numeroDivisao = 6 / 2;
            float numeroDecimal = 5.0f / 2;
            int numeroSomaMult = (2 + 2) * 10;

            Console.WriteLine(numeroSoma);
            Console.WriteLine(numeroSubtracao); 
            Console.WriteLine(numeroMultiplicacao);
            Console.WriteLine(numeroDivisao);
            Console.WriteLine(numeroDecimal);
            Console.WriteLine(numeroSomaMult);

            Console.ReadLine();
        }
    }
}
