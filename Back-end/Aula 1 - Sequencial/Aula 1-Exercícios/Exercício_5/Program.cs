using System;

namespace Exercício_5
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Bem Vindo ao Exercício 5");

            string nomeVend;
            double salario,op;
            int vendas;
        
            Console.Write("Diga seu nome: ");
            nomeVend = Console.ReadLine();

            Console.Write("Digite seu salário: ");
            salario = double.Parse(Console.ReadLine());

            Console.Write("Digite o total de vendas feitas no mês: ");
            vendas = int.Parse(Console.ReadLine());

            op = salario + (vendas * 0.010);

            Console.WriteLine($"Seu nome é: {nomeVend}");
            Console.WriteLine($"Seu salário fixo é: {salario}");
            Console.WriteLine($"Seu salário com comissão é: {op}");
        }
    }
}
