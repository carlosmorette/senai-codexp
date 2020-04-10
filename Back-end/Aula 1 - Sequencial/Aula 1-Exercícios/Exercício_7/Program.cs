using System;

namespace Exercício_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo ao Exercício 7");

            float preco= 4.30f, conta;
            int passageiros;

            Console.Write("Digite a quantidade de passageiros dentro do ônibus: ");
            passageiros = int.Parse(Console.ReadLine());

            conta = passageiros * preco;

            Console.WriteLine($"Você faturou R${conta}");
        }
    }
}
