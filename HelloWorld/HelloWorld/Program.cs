using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Int - -156 como 32334
            //Float - -15.6 como 232.132
            //Bool - true ou false
            //String - "texto"
            //Char - 'a'

            int segundaGuerraMundial = 1942;
            string cor_favorita = "Preto";
            float velocidadeF1 = 120.05f;
            bool segundaGuerraMundialAconteceu = true;

            //Exibir uma mensagem no console
            Console.WriteLine(segundaGuerraMundial);
            Console.WriteLine(cor_favorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(segundaGuerraMundialAconteceu);

            velocidadeF1 = 348.29f;
            cor_favorita = "roxo";

            Console.WriteLine(velocidadeF1);
            Console.WriteLine(cor_favorita);

            Console.ReadLine();
        }
    }
}
