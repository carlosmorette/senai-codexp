using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Exercício 2");
            
            float merc;
            float perc;
            float conta;

            Console.Write("Digite o valor de uma mercadoria: ");
            merc = float.Parse (Console.ReadLine());

            Console.Write("Digite uma porcentagem de acréscimo: ");
            perc = float.Parse (Console.ReadLine());

            conta = (merc*perc/100) + merc;

            Console.WriteLine($"Sua mercadoria de R${merc} ficou por R${conta}");
        }
    }
}
