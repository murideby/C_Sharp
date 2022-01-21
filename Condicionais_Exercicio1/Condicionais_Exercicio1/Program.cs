using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais_Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarando as Variáveis
            int Num1; //NÚMERO 1
            int Num2; //NÚMERO 2
            int Num3; //NÚMERO 3

            //Solicitando entrada do usuário
            Console.WriteLine("Digite o primeiro número:");
            Num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            Num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número:");
            Num3 = int.Parse(Console.ReadLine());

            //Espaçamento
            Console.WriteLine("=================================");
            //Exibir o resultado
            Console.WriteLine("Resultado: ");
            //Laços Codicionais
            if(Num1< Num2 & Num1 <Num3)
            {
                Console.WriteLine("O primeiro número é o MENOR!");
            }
            else if (Num2 < Num1 & Num2 < Num3)
            {
                Console.WriteLine("O segundo número é o MENOR!");
            }
            else if(Num3<Num1 & Num3<Num2)
            {
                Console.WriteLine("O terceiro número é o MENOR!");
            }
            else if(Num1==Num2 & Num2==Num3 & Num1==Num3)
            {
                Console.WriteLine("Todos os números são iguais!");
            }
            else
            {
                Console.WriteLine("Ocorreu um erro, tente novamente");
            };
            Console.ReadLine();







        }
    }
}
