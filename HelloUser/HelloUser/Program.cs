using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            Console.WriteLine("Qual o seu nome ?");
            nome = Console.ReadLine();
            Console.Write("Seja bem-vindo(a) ");
            Console.Write(nome);

            Console.ReadLine();
        }
    }
}
