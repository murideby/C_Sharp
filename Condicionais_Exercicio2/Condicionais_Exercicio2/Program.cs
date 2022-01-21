using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais_Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num1;
            int Num2;
            int Num3;

            Console.WriteLine("Digite o primeiro número:");
            Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            Num2 = int.Parse(Console.ReadLine());   
            Console.WriteLine("Digite o terceiro número:");
            Num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("====================================");
            Console.WriteLine("Resultado: ");

            if (Num1 > Num2 & Num1 > Num3)
            {
                Console.WriteLine("O primeiro número é o MAIOR");
            }
            else if (Num2 > Num1 & Num2 > Num3)
            {
                Console.WriteLine("O segundo número é o MAIOR");
            }
            else if (Num3 > Num1 & Num3 > Num2)
            {
                Console.WriteLine("O terceiro número é o MAIOR");
            }
            else if (Num1 == Num2 & Num2 == Num3 & Num1 == Num3)
            {
                Console.WriteLine("Todos os números são IGUAIS");
            }
            else
            {
                Console.WriteLine("Ocorreu um erro, tente novamente");
            }
            Console.ReadLine();
        }
    }
}
