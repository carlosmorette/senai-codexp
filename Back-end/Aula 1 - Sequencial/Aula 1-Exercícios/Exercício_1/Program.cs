using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo ao Exercício 1");

            string nomeUser;
            int num;
            int conta;

            Console.Write("Qual o seu nome? ");
            nomeUser = Console.ReadLine();

            Console.Write("Ok " + nomeUser +", digite um número inteiros: ");
            num = int.Parse(Console.ReadLine());

            conta = num * 3;

            Console.WriteLine(nomeUser + "o triplo do seu número é: " + conta);
        }
    }
}
