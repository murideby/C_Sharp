using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais_Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int urgencia;

            Console.WriteLine("Descreva sua solicitação!");
            Console.ReadLine();
            Console.WriteLine("Em uma escala de 0 a 10 informe o nível de urgência!");
            urgencia = int.Parse(Console.ReadLine());

            if (urgencia > 0 & urgencia <= 3)
            {
                Console.WriteLine("Sua urgência foi recebida e é de nível: BAIXO");
            }
            else if (urgencia > 3 & urgencia <= 6)
            {
                Console.WriteLine("Sua urgência foi recebida e é de nível: MÉDIO");
            }
            else if (urgencia > 6 & urgencia <=9)
            {
                Console.WriteLine("Sua urgência foi recebida e é de nível: ALTO");
            }
            else
            {
                Console.WriteLine("Sua urgência foi recebida e é de nível: GRAVE");
            }
            Console.ReadLine();
        }
    }
}
